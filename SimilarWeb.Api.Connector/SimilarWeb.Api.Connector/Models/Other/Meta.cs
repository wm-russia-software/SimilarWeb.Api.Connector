using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Метаданные ответа.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public class Meta<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("request")]
        public TRequest Request { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion
    }
}
