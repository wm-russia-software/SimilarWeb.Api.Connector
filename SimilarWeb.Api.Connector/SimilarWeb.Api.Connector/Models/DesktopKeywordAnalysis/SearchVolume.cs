using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Объем поиска.
    /// </summary>
    public class SearchVolume
    {
        #region Свойства

        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        #endregion
    }
}
