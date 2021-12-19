using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Данные по странам во временом разрезе.
    /// </summary>
    public class TrafficAndEngagement
    {
        #region Свойства

        [JsonProperty("countries")]
        public Dictionary<string, CountryDates> Countries { get; set; }

        #endregion
    }
}
