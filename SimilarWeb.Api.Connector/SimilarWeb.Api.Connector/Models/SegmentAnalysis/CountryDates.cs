using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Диапазоны данных и дата их обновления.
    /// </summary>
    public class CountryDates
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("fresh_data")]
        public DateTime FreshData { get; set; }

        #endregion
    }
}
