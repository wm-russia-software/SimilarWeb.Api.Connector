using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Базовый класс ответа на вызов методов группы KeywordAnalysis.
    /// </summary>
    public abstract class BaseKeywordAnalysisResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public KeywordAnalysisMeta Meta { get; set; }

        [JsonProperty("traffic_breakdown")]
        public List<TrafficBreakdown> TrafficBreakdown { get; set; }

        [JsonProperty("search_volume")]
        public SearchVolume SearchVolume { get; set; }

        [JsonProperty("cost_per_click")]
        public CostPerClick CostPerClick { get; set; }

        [JsonProperty("organic_vs_paid")]
        public OrganicVsPaid OrganicVsPaid { get; set; }

        #endregion
    }
}
