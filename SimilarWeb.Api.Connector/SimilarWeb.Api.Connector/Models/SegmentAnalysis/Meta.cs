using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
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

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        #endregion
    }
}
