using Ak.Framework.Core.Extensions;
using Ak.Framework.Core.Helpers;
using Newtonsoft.Json;
using RestSharp;
using SimilarWeb.Api.Connector.Converters;
using SimilarWeb.Api.Connector.Extensions;
using SimilarWeb.Api.Connector.Models.Common;
using SimilarWeb.Api.Connector.Models.Error;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Базовый обработчик API
    /// </summary>
    public abstract class BaseApiHandler
    {
        #region Переменные и константы

        /// <summary>
        /// Url для доступа к Api
        /// </summary>
        private const string DomainUrl = "https://api.similarweb.com";

        /// <summary>
        /// Таймаут между запросами
        /// </summary>
        protected const int DefaultRequestTimeout = 1000;

        #endregion

        #region Свойства

        /// <summary>
        /// Key для доступа к Api
        /// </summary>
        public string ApiKey { get; }

        /// <summary>
        /// Url для доступа к Api
        /// </summary>
        public string ApiUrl { get; }

        /// <summary>
        /// Таймаут между запросами
        /// </summary>
        public int RequestTimeout { get; set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        protected BaseApiHandler(string apiKey)
        {
            ApiKey = apiKey;
            ApiUrl = DomainUrl;
            RequestTimeout = DefaultRequestTimeout;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        protected BaseApiHandler(string apiKey, string apiUrl)
        {
            ApiKey = apiKey;
            ApiUrl = apiUrl;
            RequestTimeout = DefaultRequestTimeout;
        }

        #endregion

        #region Защищенные методы

        /// <summary>
        /// Ожидание
        /// </summary>
        protected void Wait()
        {
            Task.Delay(RequestTimeout).Wait();
        }

        #endregion

        #region Внутренние методы

        /// <summary>
        /// Выполняет метод API и возвращает результат указанного типа.
        /// </summary>
        /// <typeparam name="TResponse">Тип возвращаемого значения.</typeparam>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <param name="requestObject">Объект для отправки в теле запроса.</param>
        /// <param name="headerPairs">Пары элементов для заголовка.</param>
        /// <returns></returns>
        internal TResponse Invoke<TResponse>(BaseCommonParameters requestParameters, object requestObject = null, Dictionary<string, string> headerPairs = null)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, requestParameters.MethodPath);
            List<ParametersItem> parametersList = ParametersToList(requestParameters);
            url += $"?api_key={ApiKey}{(parametersList.Count == 0 ? string.Empty : "&")}";
            url += string.Join('&', parametersList.Select(x => $"{x.Name}={x.Value}"));
            RestClient restClient = new RestClient(url) { Timeout = -1 };

            // Для лучшей совместимости в классе-параметре указан родной для NET тип запроса, при запросе он преобразуется в тип запроса RestSharp через расширение.
            RestRequest restRequest = new RestRequest(requestParameters.HttpMethod.ToRestMethod());

            foreach (var headerPair in headerPairs ?? new Dictionary<string, string>())
                restRequest.AddHeader(headerPair.Key, headerPair.Value);

            // Встроенный сериалайзер RestSharp не умеет перечисления.
            if (requestObject != null)
                restRequest.AddParameter(System.Net.Mime.MediaTypeNames.Application.Json,
                    JsonConvert.SerializeObject(requestObject), ParameterType.RequestBody);

            IRestResponse restResponse = restClient.Execute(restRequest);
            Wait();

            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                if (typeof(TResponse) == typeof(HttpStatusCode))
                    return (TResponse)(object)restResponse.StatusCode;

                return JsonConvert.DeserializeObject<TResponse>(restResponse.Content, new DecimalJsonConverter(), new DecimalNullableJsonConverter());
            }

            string errorMessage;
            try
            {
                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(restResponse.Content);
                errorMessage = errorResponse?.Meta?.ErrorMessage;
            }
            catch
            {
                errorMessage = restResponse.Content;
            }

            HttpRequestException httpRequestException =
                new HttpRequestException($"Не удалось выполнить вызов API метода. Код ответа: {restResponse.StatusCode}, сообщение: '{errorMessage}'");
            httpRequestException.Data.Add("RequestParameters", requestParameters);
            throw httpRequestException;
        }

        #endregion

        #region Приватные методы

        /// <summary>
        /// Преобразование объекта с параметрами, через рефлексию, в список, для преобразования в строку, для url.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        private List<ParametersItem> ParametersToList(object requestParameters)
        {
            List<ParametersItem> returnParameters = new List<ParametersItem>();
            List<PropertyInfo> propertyInfos = requestParameters.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToList();

            propertyInfos
                .Where(x => x.GetValue(requestParameters) != null)
                .Where(x => x.CanWrite)
                .Where(x => ((ParameterName)x.GetCustomAttribute(typeof(ParameterName)))?.Name != null)
                .ForEach(propertyInfo => returnParameters.Add(new ParametersItem
                {
                    Name = ((ParameterName)propertyInfo.GetCustomAttribute(typeof(ParameterName)))?.Name,
                    Value = GetPropertyValue(propertyInfo, propertyInfo.GetValue(requestParameters))
                })
                );

            return returnParameters;
        }

        /// <summary>
        /// Получает строковое значение из элемента объекта параметров.
        /// </summary>
        /// <param name="propertyInfo">Информация о свойстве.</param>
        /// <param name="propertyValue">Значение свойства.</param>
        /// <returns>Строковое значение параметра.</returns>
        private string GetPropertyValue(PropertyInfo propertyInfo, object propertyValue)
        {
            string returnString = string.Empty;

            // Дата
            if (propertyInfo.PropertyType == typeof(DateTime))
                returnString = Convert.ToDateTime(propertyValue).ToString("yyyy-MM-dd");
            // Булевый
            if (propertyInfo.PropertyType == typeof(bool))
                returnString = Convert.ToBoolean(propertyValue).ToString().ToLower();

            //Элемент перечисления
            if (propertyInfo.PropertyType.BaseType == typeof(Enum))
                returnString = GetEnumAttributeName(propertyInfo, propertyValue?.ToString());

            // Списки
            if (IsIList(propertyValue))
                returnString = string.Join(',', GetEnumAttributeList(propertyValue));

            // В любых других случаях строка. 
            return string.IsNullOrEmpty(returnString)
                ? propertyValue?.ToString()
                : returnString;
        }

        /// <summary>
        /// Преобразование списка перечислений в список их атрибутов. 
        /// </summary>
        /// <param name="enumList">Список со значениями.</param>
        /// <returns></returns>
        private List<string> GetEnumAttributeList(object enumList)
        {
            List<string> returnList = new List<string>();

            if (enumList.GetType()
                    .GetInterfaces()
                    .FirstOrDefault(x => x == typeof(IList)) == null)
                return returnList;

            foreach (object enumListItem in (IList)enumList)
            {
                string itemName = string.Empty;

                //Для перечислений берется атрибут.
                if (enumListItem.GetType().BaseType == typeof(Enum))
                {
                    itemName = enumListItem.GetType()
                        .GetField(enumListItem.ToString() ?? string.Empty)?
                        .GetCustomAttribute<ParameterName>()?.Name;
                }

                // Для строк берется значение. 
                if (enumListItem is string)
                {
                    itemName = enumListItem.ToString();
                }

                returnList.Add(itemName);

            }

            return returnList;
        }

        /// <summary>
        /// Получает значение атрибута из свойства.
        /// </summary>
        /// <param name="propertyInfo">Свойство.</param>
        /// <param name="enumMemberName">Имя члена перечисления.</param>
        /// <returns></returns>
        private string GetEnumAttributeName(PropertyInfo propertyInfo, string enumMemberName)
        {
            FieldInfo fieldInfo = propertyInfo.PropertyType.GetField(enumMemberName);
            if (fieldInfo == null)
                return null;

            ParameterName enumMemberAttribute = fieldInfo.GetCustomAttribute<ParameterName>();

            return enumMemberAttribute?.Name;
        }

        /// <summary>
        /// Определяет реализует ли объект интерфейс списка.
        /// </summary>
        /// <param name="checkObject">Объект для проверки.</param>
        /// <returns>
        /// Если интерфейс поддерживается <c>true</c>, иначе <c>false</c>.
        /// </returns>
        private static bool IsIList(object checkObject)
        {
            /*return checkObject.GetType()
                .GetInterfaces()
                .FirstOrDefault(x => x == typeof(IList)) != null;*/
            return !checkObject.GetType()
                .GetInterfaces()
                .Where(x => x == typeof(IList))
                .IsEmpty();
        }

        #endregion

    }
}
