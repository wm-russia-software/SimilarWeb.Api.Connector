using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Базовый класс сегмента.
    /// </summary>
    public abstract class BaseSegment
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        #endregion
    }
}
