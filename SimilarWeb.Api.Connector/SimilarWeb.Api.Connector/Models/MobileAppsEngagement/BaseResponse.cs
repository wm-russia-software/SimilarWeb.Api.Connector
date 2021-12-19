using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Базовый класс ответа на вызовы методов. 
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseResponse<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta<TRequest> Meta { get; set; }

        #endregion
    }
}

