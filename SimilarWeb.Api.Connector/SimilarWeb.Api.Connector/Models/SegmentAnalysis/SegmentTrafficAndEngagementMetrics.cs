using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    #region Перечисления    
    
    /// <summary>
    /// Перечисление метрик сегментов. 
    /// </summary>
    public enum SegmentTrafficAndEngagementMetrics
    {
        [ParameterName("visits")]
        Visits,

        [ParameterName("share")]
        Share,

        [ParameterName("pages-per-visit")]
        PagesPerVisit,

        [ParameterName("page-views")]
        PageViews,

        [ParameterName("bounce-rate")]
        BounceRate,

        [ParameterName("visit-duration")]
        VisitDuration,

        [ParameterName("unique-visitors")]
        UniqueVisitors
    }

    #endregion
}
