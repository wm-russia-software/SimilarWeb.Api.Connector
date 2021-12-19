using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.WebsiteContent
{
    /// <summary>
    /// Запрос из метаданных.
    /// </summary>
    public class Request
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        #endregion
    }
}
