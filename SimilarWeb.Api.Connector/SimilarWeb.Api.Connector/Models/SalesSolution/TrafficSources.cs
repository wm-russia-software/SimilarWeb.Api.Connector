using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Источники траффика.
    /// </summary>
    public class TrafficSources
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public List<TrafficSourcesValueItem> Value { get; set; }

        #endregion
    }
}
