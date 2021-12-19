using SimilarWeb.Api.Connector.Models.Common;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Параметры для вызова метода ConversionAnalysis.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class ConversionAnalysisParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/segment/{SegmentId}/conversion-analysis/query";

        /// <summary>
        /// Идентификатор сегмента. 
        /// </summary>        
        public string SegmentId { get; set; }

        /// <summary>
        /// Маркетинговый канал, по умолчанию "total".
        /// </summary>        
        [ParameterName("channel")]
        public string Channel { get; set; }
        
        /// <summary>
        /// Список показателей. 
        /// </summary>        
        [ParameterName("metrics")]
        public List<ConversionAnalysisMetrics> Metrics { get; set; }

        #endregion
    }
}
