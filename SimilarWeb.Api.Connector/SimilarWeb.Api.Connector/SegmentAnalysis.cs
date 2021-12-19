using SimilarWeb.Api.Connector.Models.SegmentAnalysis;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов SegmentAnalysis.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class SegmentAnalysis : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public SegmentAnalysis(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public SegmentAnalysis(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает предварительно определенные сегменты (определенные в PRO).
        /// </summary>
        /// <param name="conversionAnalysisParameters">Параметры запроса.</param>
        /// <returns></returns>
        public ConversionAnalysisResponse GetConversionAnalysis(ConversionAnalysisParameters conversionAnalysisParameters)
        {
            return Invoke<ConversionAnalysisResponse>(conversionAnalysisParameters);
        }

        /// <summary>
        /// Возвращает идентификаторы пользовательских сегментов, связанных с вашей учетной записью, как определено на платформе SimilarWeb.
        /// </summary>
        /// <param name="listSegmentParameters">Параметры запроса.</param>
        /// <returns></returns>
        public ListSegmentsResponse GetListSegment(ListSegmentsParameters listSegmentParameters)
        {
            return Invoke<ListSegmentsResponse>(listSegmentParameters);
        }

        /// <summary>
        /// Возвращает пользовательские сегменты учетной записи (определенные в PRO).
        /// </summary>
        /// <param name="segmentTrafficAndEngagementParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SegmentTrafficAndEngagementResponse GetSegmentTrafficAndEngagement(SegmentTrafficAndEngagementParameters segmentTrafficAndEngagementParameters)
        {
            return Invoke<SegmentTrafficAndEngagementResponse>(segmentTrafficAndEngagementParameters);
        }

        /// <summary>
        /// Возвращает идентификаторы пользовательских сегментов, связанных с вашей учетной записью, как определено на платформе SimilarWeb.
        /// </summary>
        /// <param name="listSegmentsConversionAnalysisParameters">Параметры запроса.</param>
        /// <returns></returns>
        public ListSegmentsConversionAnalysisResponse GetListSegmentsConversionAnalysis(ListSegmentsConversionAnalysisParameters listSegmentsConversionAnalysisParameters)
        {
            return Invoke<ListSegmentsConversionAnalysisResponse>(listSegmentsConversionAnalysisParameters);
        }


        #endregion
    }
}
