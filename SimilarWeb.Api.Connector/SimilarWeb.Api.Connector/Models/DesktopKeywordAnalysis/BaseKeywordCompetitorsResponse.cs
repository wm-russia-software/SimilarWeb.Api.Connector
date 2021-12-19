using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Базовый класс ответа на вызов методов группы KeywordCompetitors.
    /// </summary>
    public abstract class BaseKeywordCompetitorsResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public KeywordCompetitorMeta Meta { get; set; }

        [JsonProperty("data")]
        public List<KeywordCompetitorsData> Data { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
