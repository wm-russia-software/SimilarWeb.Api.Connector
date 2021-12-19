using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Метаданные ответа.
    /// </summary>
    public class Meta
    {
        #region Свойства

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion
    }

}
