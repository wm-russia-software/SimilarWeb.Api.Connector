using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Данные запроса из метаданных ответа на вызов метода KeywordCompetitor.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class KeywordCompetitorRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
