using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    #region Пречисления
    
    /// <summary>
    /// Метрики из ответа на вызов метода KeywordAnalysis.
    /// </summary>
    public enum KeywordAnalysisMetrics
    {
        [ParameterName("traffic")]
        Traffic,

        [ParameterName("organic-vs-paid")]
        OrganicVsPaid,

        [ParameterName("volume")]
        Volume,

        [ParameterName("cpc")]
        Cpc
    }

    #endregion
}
