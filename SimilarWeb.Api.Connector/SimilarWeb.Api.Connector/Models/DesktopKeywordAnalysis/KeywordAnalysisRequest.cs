using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Данные запроса из метаданных ответа на вызов метода KeywordAnalysis.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class KeywordAnalysisRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        #endregion
    }
}
