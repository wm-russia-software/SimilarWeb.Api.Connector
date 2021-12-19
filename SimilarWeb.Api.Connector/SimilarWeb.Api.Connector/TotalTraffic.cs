using SimilarWeb.Api.Connector.Models.TotalTraffic;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов TotalTraffic.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class TotalTraffic : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public TotalTraffic(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public TotalTraffic(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает среднюю продолжительность посещения указанного домена (в секундах).
        /// </summary>
        /// <param name="averageVisitDurationParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AverageVisitDurationResponse GetAverageVisitDuration(AverageVisitDurationParameters averageVisitDurationParameters)
        {
            return Invoke<AverageVisitDurationResponse>(averageVisitDurationParameters);
        }


        /// <summary>
        /// Возвращает показатель отказов для данного домена.
        /// </summary>
        /// <param name="bounceRateParameters">Параметры запроса.</param>
        /// <returns></returns>
        public BounceRateResponse GetBounceRate(BounceRateParameters bounceRateParameters)
        {
            return Invoke<BounceRateResponse>(bounceRateParameters);
        }

        /// <summary>
        /// Возвращает анализ количества людей, посещающих веб-сайт с разных устройств (с дедупликацией по устройствам).
        /// </summary>
        /// <param name="deduplicatedAudienceParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DeduplicatedAudienceResponse GetDeduplicatedAudience(DeduplicatedAudienceParameters deduplicatedAudienceParameters)
        {
            return Invoke<DeduplicatedAudienceResponse>(deduplicatedAudienceParameters);
        }

        /// <summary>
        /// Возвращает долю трафика для настольных компьютеров и мобильных устройств за выбранный период времени (минимум 1 месяц).
        /// </summary>
        /// <param name="desktopVsMobileSplitParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopVsMobileSplitResponse GetDesktopVsMobileSplit(DesktopVsMobileSplitParameters desktopVsMobileSplitParameters)
        {
            return Invoke<DesktopVsMobileSplitResponse>(desktopVsMobileSplitParameters);
        }

        /// <summary>
        /// Возвращает среднее количество просмотров страниц за посещение для данного домена.
        /// </summary>
        /// <param name="pagesPerVisitParameters">Параметры запроса.</param>
        /// <returns></returns>
        public PagesPerVisitResponse GetPagesPerVisit(PagesPerVisitParameters pagesPerVisitParameters)
        {
            return Invoke<PagesPerVisitResponse>(pagesPerVisitParameters);
        }

        /// <summary>
        /// Возвращает приблизительное количество посещений для домена.
        /// </summary>
        /// <param name="visitsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public VisitsResponse GetVisits(VisitsParameters visitsParameters)
        {
            return Invoke<VisitsResponse>(visitsParameters);
        }

        #endregion
    }
}
