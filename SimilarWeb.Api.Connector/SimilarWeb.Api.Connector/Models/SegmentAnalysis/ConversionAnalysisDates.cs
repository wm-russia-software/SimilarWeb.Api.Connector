using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Диапазон дат.
    /// </summary>
    public class ConversionAnalysisDates
    {
        #region Свойства

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        #endregion
    }
}
