using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Цена за клик.
    /// </summary>
    public class CostPerClick
    {
        #region Свойства

        [JsonProperty("cpc")]
        public decimal Cpc { get; set; }

        #endregion
    }
}
