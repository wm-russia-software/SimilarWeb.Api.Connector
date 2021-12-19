using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    ///  Базовый класс запроса из метаданных.
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
