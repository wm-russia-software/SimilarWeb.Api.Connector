using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Элемент списка с данными по распределению платных и брендированных посещений на дату.
    /// </summary>
    public class DataItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("total_search_visits")]
        public decimal TotalSearchVisits { get; set; }

        [JsonProperty("visits_distribution")]
        public VisitsDistribution VisitsDistribution { get; set; }

        #endregion
    }
}
