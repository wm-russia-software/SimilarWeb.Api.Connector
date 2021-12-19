using SimilarWeb.Api.Connector.Models.MobileWebTraffic;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов MobileWebTraffic.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class MobileWebTraffic : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public MobileWebTraffic(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public MobileWebTraffic(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает среднюю продолжительность посещения мобильного веб-сайта в указанном домене (в секундах).
        /// </summary>
        /// <param name="mobileWebAverageVisitDurationParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebAverageVisitDurationResponse GetMobileWebAverageVisitDuration(MobileWebAverageVisitDurationParameters mobileWebAverageVisitDurationParameters)
        {
            return Invoke<MobileWebAverageVisitDurationResponse>(mobileWebAverageVisitDurationParameters);
        }

        /// <summary>
        /// Возвращает показатель отказов мобильного Интернета для данного домена.
        /// </summary>
        /// <param name="mobileWebBounceRateParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebBounceRateResponse GetMobileWebBounceRate(MobileWebBounceRateParameters mobileWebBounceRateParameters)
        {
            return Invoke<MobileWebBounceRateResponse>(mobileWebBounceRateParameters);
        }

        /// <summary>
        /// Возвращает среднее количество просмотров страниц за посещение веб-сайта для данного домена
        /// </summary>
        /// <param name="mobileWebPagesPerVisitParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebPagesPerVisitResponse GetMobileWebPagesPerVisit(MobileWebPagesPerVisitParameters mobileWebPagesPerVisitParameters)
        {
            return Invoke<MobileWebPagesPerVisitResponse>(mobileWebPagesPerVisitParameters);
        }

        /// <summary>
        /// Возвращает количество уникальных посетителей за день или месяц на веб-сайт в мобильной сети.
        /// </summary>
        /// <param name="mobileWebUniqueVisitorsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebUniqueVisitorsResponse GetMobileWebUniqueVisitors(MobileWebUniqueVisitorsParameters mobileWebUniqueVisitorsParameters)
        {
            return Invoke<MobileWebUniqueVisitorsResponse>(mobileWebUniqueVisitorsParameters);
        }

        /// <summary>
        /// Возвращает приблизительное количество посещений мобильного Интернета для домена.
        /// </summary>
        /// <param name="mobileWebVisitsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebVisitsResponse GetMobileWebVisits(MobileWebVisitsParameters mobileWebVisitsParameters)
        {
            return Invoke<MobileWebVisitsResponse>(mobileWebVisitsParameters);
        }

        #endregion
    }
}
