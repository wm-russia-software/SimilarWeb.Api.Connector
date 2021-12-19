using SimilarWeb.Api.Connector.Models.Common;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Параметры для вызова метода SegmentTrafficAndEngagement.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class SegmentTrafficAndEngagementParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/segment/{SegmentId}/traffic-and-engagement/query";

        /// <summary>
        /// Идентификатор сегмента.
        /// </summary>        
        public string SegmentId { get; set; }

        /// <summary>
        /// Список показателей. 
        /// </summary>        
        [ParameterName("metrics")]
        public List<SegmentTrafficAndEngagementMetrics> Metrics { get; set; }

        #endregion
    }
}
