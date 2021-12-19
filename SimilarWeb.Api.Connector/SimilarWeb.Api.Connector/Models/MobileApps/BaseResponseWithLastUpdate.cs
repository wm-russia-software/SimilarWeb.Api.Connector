using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Базовый тип ответа на вызов метода..
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseResponseWithLastUpdate<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("meta")]
        public MetaWithLastUpdate<TRequest> Meta { get; set; }

        #endregion
    }
}
