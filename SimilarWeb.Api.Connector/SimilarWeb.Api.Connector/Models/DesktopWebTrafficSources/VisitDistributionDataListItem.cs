using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Распределение платных и брендированных поисковых визитов. 
    /// </summary>
    public class VisitDistributionDataListItem
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
