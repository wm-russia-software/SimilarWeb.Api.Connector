using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Базовый тип запроса из метаданных.
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
