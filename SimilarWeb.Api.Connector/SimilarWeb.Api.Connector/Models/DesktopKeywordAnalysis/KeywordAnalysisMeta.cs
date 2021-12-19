using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Метаданные из ответа вызова методов KeywordAnalysis.
    /// </summary>
    /// <seealso cref="BaseMeta&lt;TRequest&gt;" />
    public class KeywordAnalysisMeta : BaseMeta<KeywordAnalysisRequest>
    {
        #region Свойства

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        #endregion
    }
}
