using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Ответ на вызов метода GetListSegment. Содержит идентификаторы пользовательских сегментов, связанных с учетной записью, как определено на платформе Similarweb.
    /// </summary>
    public class ListSegmentsResponse
    {
        #region Свойства

        [JsonProperty("response")]
        public TrafficAndSegment Response { get; set; }

        #endregion
    }
}
