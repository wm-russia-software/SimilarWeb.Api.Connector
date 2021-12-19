using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Запрос из метаданных.
    /// </summary>
    public class Request
    {
        #region Свойства

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("metrics")]
        public List<string> Metrics { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        #endregion
    }
}
