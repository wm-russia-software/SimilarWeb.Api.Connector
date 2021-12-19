using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Error
{
    /// <summary>
    /// Даные запроса из метаданных ответа с ошибкой. 
    /// </summary>
    public class Request
    {
        #region Свойства

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("show_verified")]

        public bool ShowVerified { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        #endregion
    }
}
