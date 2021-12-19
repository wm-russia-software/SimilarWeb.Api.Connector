using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Количество страниц на визит.
    /// </summary>
    public class PagesPerVisitItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("pages_per_visit")]
        public decimal PagesPerVisit { get; set; }

        #endregion
    }
}
