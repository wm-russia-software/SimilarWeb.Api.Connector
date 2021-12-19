using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    #region Перечисления
    
    /// <summary>
    /// Метрики аналитики по изменениям. 
    /// </summary>
    public enum ConversionAnalysisMetrics
    {
        [ParameterName("visits")]
        Visits,

        [ParameterName("converted-visits")]
        ConvertedVisits,

        [ParameterName("conversion-rate")]
        ConversionRate,

        [ParameterName("stickiness")]
        Stickiness
    }

    #endregion
}
