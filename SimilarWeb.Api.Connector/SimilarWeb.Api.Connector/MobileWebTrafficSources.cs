using SimilarWeb.Api.Connector.Models.MobileWebTrafficSources;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов MobileWebTrafficSources.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class MobileWebTrafficSources : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public MobileWebTrafficSources(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public MobileWebTrafficSources(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает ключевые слова для поиска для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL-адрес и позицию ключевого слова для посещений при поиске в мобильном Интернете.
        /// </summary>
        /// <param name="mobileWebKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebKeywordsResponse GetMobileWebKeywords(MobileWebKeywordsParameters mobileWebKeywordsParameters)
        {
            return Invoke<MobileWebKeywordsResponse>(mobileWebKeywordsParameters);
        }

        /// <summary>
        /// Возвращает мобильные ссылающиеся веб-сайты для данного домена и долю трафика на каждого реферера.
        /// </summary>
        /// <param name="mobileWebReferralsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebReferralsResponse GetMobileWebReferrals(MobileWebReferralsParameters mobileWebReferralsParameters)
        {
            return Invoke<MobileWebReferralsResponse>(mobileWebReferralsParameters);
        }

        /// <summary>
        /// Возвращает примерный объем мобильного веб-трафика с разбивкой по источникам.
        /// </summary>
        /// <param name="mobileWebTrafficSourcesOverviewParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MobileWebTrafficSourcesOverviewResponse GetMobileWebTrafficSourcesOverview(MobileWebTrafficSourcesOverviewParameters mobileWebTrafficSourcesOverviewParameters)
        {
            return Invoke<MobileWebTrafficSourcesOverviewResponse>(mobileWebTrafficSourcesOverviewParameters);
        }

        /// <summary>
        /// Возвращает распределение ежемесячных платных и брендированных поисковых посещений для мобильного веб-трафика.
        /// </summary>
        /// <param name="searchVisitsDistributionMobileParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SearchVisitsDistributionMobileResponse GetSearchVisitsDistributionMobile(SearchVisitsDistributionMobileParameters searchVisitsDistributionMobileParameters)
        {
            return Invoke<SearchVisitsDistributionMobileResponse>(searchVisitsDistributionMobileParameters);
        }

        #endregion
    }
}
