using SimilarWeb.Api.Connector.Models.Common;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Параметры для вызов метода KeywordAnalysisOrganicCompetitors.
    /// </summary>
    /// <seealso cref="BaseParametersWithLimit" />
    public class KeywordAnalysisOrganicCompetitorsParameters : BaseParametersWithLimit
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/keywords/{Keyword}/analysis/organic-competitors";

        /// <summary>
        /// Ключевое слово.
        /// </summary>        
        public string Keyword { get; set; }

        /// <summary>
        /// Список метрик.
        /// </summary>        
        [ParameterName("metrics")]
        public List<KeywordAnalysisMetrics> Metrics { get; set; }

        #endregion
    }
}
