using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Параметры для вызова метода ListSegmentsConversionAnalysis.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class ListSegmentsConversionAnalysisParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/segment/conversion-analysis/describe";

        /// <summary>
        /// Возвращать только сегменты, связанные с учетной записью пользователя предоставленного ключа API или всем пользователями учетной записи.
        /// </summary>        
        [ParameterName("userOnlySegments")]
        public bool UserOnlySegments { get; set; }

        #endregion
    }
}
