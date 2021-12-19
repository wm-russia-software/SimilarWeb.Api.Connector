using SimilarWeb.Api.Connector.Models.Webhooks;
using System.Collections.Generic;
using System.Net;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов Webhooks.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class Webhooks : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public Webhooks(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public Webhooks(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Позволяет подтвердить, что конечная точка была запущена из надежного источника (например, SimilarWeb).
        /// </summary>
        /// <param name="authorizeParameters">Параметры запроса.</param>
        /// <returns></returns>
        public HttpStatusCode Authorize(AuthorizeParameters authorizeParameters)
        {
            Dictionary<string, string> headerPairs = new Dictionary<string, string>
            {
                {"Content-Type", System.Net.Mime.MediaTypeNames.Application.Json },
                {"X-sw-authorization", authorizeParameters.XswAuthorization }
            };
            return Invoke<HttpStatusCode>(authorizeParameters, headerPairs: headerPairs);
        }

        /// <summary>
        /// Возвращает существующие подписки на Webhooks.
        /// </summary>
        /// <param name="getListParameters">Параметры запроса.</param>
        /// <returns></returns>
        public GetListResponse GetList(GetListParameters getListParameters)
        {
            return Invoke<GetListResponse>(getListParameters);
        }

        /// <summary>
        /// Подписка на определенный тип события Webhook. Разрешена одна подписка на каждый тип события. Длина URL для подписки ограничена 255 символами.
        /// </summary>
        /// <param name="subscribeParameters">Параметры запроса.</param>
        /// <param name="requestObject">Объект с набором параметров для тела запроса.</param>
        /// <returns></returns>
        public SubscribeResponse Subscribe(SubscribeParameters subscribeParameters, object requestObject)
        {
            return Invoke<SubscribeResponse>(subscribeParameters, requestObject);
        }

        /// <summary>
        /// Отменить подписку на конкретное событие Webhook по идентификатору подписки.
        /// </summary>
        /// <param name="unSubscribeParameters">Параметры запроса.</param>
        /// <returns></returns>
        public HttpStatusCode UnSubscribe(UnSubscribeParameters unSubscribeParameters)
        {
            return Invoke<HttpStatusCode>(unSubscribeParameters);
        }

        #endregion
    }
}
