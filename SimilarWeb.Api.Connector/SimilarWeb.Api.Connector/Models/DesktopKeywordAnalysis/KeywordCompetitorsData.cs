using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Данные для списка данных из запроса KeywordCompetitors.
    /// </summary>
    public class KeywordCompetitorsData
    {
        #region Свойства

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        #endregion
    }
}
