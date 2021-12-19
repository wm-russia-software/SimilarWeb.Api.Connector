using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Базовый класс ответа за вызовы методов. 
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    public class BaseResponse<TRequest> where TRequest : Request
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta<TRequest> Meta { get; set; }

        #endregion
    }
}
