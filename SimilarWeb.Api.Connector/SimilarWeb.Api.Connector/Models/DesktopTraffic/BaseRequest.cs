using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Базовый класс запроса из метаданных. 
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

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
