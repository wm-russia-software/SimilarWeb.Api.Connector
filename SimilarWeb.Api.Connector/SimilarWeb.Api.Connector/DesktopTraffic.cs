using SimilarWeb.Api.Connector.Models.DesktopTraffic;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов DesktopTraffic.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class DesktopTraffic : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public DesktopTraffic(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public DesktopTraffic(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает среднюю продолжительность посещения в указанном домене (в секундах).
        /// </summary>
        /// <param name="averageVisitDurationParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AverageVisitDurationResponse GetAverageVisitDuration(AverageVisitDurationParameters averageVisitDurationParameters)
        {
            return Invoke<AverageVisitDurationResponse>(averageVisitDurationParameters);
        }

        /// <summary>
        /// Возвращает показатель отказов для указанного домена.
        /// </summary>
        /// <param name="bounceRateParameters">Параметры запроса.</param>
        /// <returns></returns>
        public BounceRateResponse GetBounceRate(BounceRateParameters bounceRateParameters)
        {
            return Invoke<BounceRateResponse>(bounceRateParameters);
        }

        /// <summary>
        /// Возвращает ежемесячный рейтинг страны в SimilarWeb для заданного домена.
        /// </summary>
        /// <param name="countryRankParameters">Параметры запроса.</param>
        /// <returns></returns>
        public CountryRankResponse GetCountryRank(CountryRankParameters countryRankParameters)
        {
            return Invoke<CountryRankResponse>(countryRankParameters);
        }

        /// <summary>
        /// Возвращает среднее количество просмотров страниц за посещение для данного домена.
        /// </summary>
        /// <param name="desktopPagesPerVisitParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopPagesPerVisitResponse GetDesktopPagesPerVisit(DesktopPagesPerVisitParameters desktopPagesPerVisitParameters)
        {
            return Invoke<DesktopPagesPerVisitResponse>(desktopPagesPerVisitParameters);
        }

        /// <summary>
        /// Возвращает количество ежедневных или ежемесячных уникальных посетителей на веб-сайт.
        /// </summary>
        /// <param name="desktopUniqueVisitorsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopUniqueVisitorsResponse GetDesktopUniqueVisitors(DesktopUniqueVisitorsParameters desktopUniqueVisitorsParameters)
        {
            return Invoke<DesktopUniqueVisitorsResponse>(desktopUniqueVisitorsParameters);
        }

        /// <summary>
        /// Возвращает приблизительное количество посещений для домена.
        /// </summary>
        /// <param name="desktopVisitsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopVisitsResponse GetDesktopVisits(DesktopVisitsParameters desktopVisitsParameters)
        {
            return Invoke<DesktopVisitsResponse>(desktopVisitsParameters);
        }

        /// <summary>
        /// Возвращает долю трафика настольных компьютеров с разбивкой по странам за выбранные даты (мин. 1 месяц). 
        /// </summary>
        /// <param name="geographyDistributionParameters">Параметры запроса.</param>
        /// <returns></returns>
        public GeographyDistributionResponse GetGeographyDistribution(GeographyDistributionParameters geographyDistributionParameters)
        {
            return Invoke<GeographyDistributionResponse>(geographyDistributionParameters);
        }

        /// <summary>
        /// Возвращает ежемесячный глобальный рейтинг SimilarWeb для заданного домена.
        /// </summary>
        /// <param name="globalRankParameters">Параметры запроса.</param>
        /// <returns></returns>
        public GlobalRankResponse GetGlobalRank(GlobalRankParameters globalRankParameters)
        {
            return Invoke<GlobalRankResponse>(globalRankParameters);
        }


        #endregion
    }
}
