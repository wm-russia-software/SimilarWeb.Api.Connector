using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Ответ на вызов метода GetListSegmentConverionAnalysis. Содержит идентификаторы пользовательских сегментов, связанных с учетной записью, как определено на платформе Similarweb.
    /// </summary>
    public class ListSegmentsConversionAnalysisResponse
    {
        #region Свойства

        [JsonProperty("response")]
        public ConversionAndSegment Response { get; set; }

        #endregion
    }
}
