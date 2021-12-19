using SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов DesktopWebTrafficSources.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class DesktopWebTrafficSources : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public DesktopWebTrafficSources(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public DesktopWebTrafficSources(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает ведущие рекламные сети, отправляющие трафик в указанный домен, а также долю трафика в каждой рекламной сети.
        /// </summary>
        /// <param name="desktopAdNetworksParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopAdNetworksResponse GetDesktopAdNetworks(DesktopAdNetworksParameters desktopAdNetworksParameters)
        {
            return Invoke<DesktopAdNetworksResponse>(desktopAdNetworksParameters);
        }

        /// <summary>
        /// Возвращает брендированные ключевые слова для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL и позицию ключевого слова, а также количество посещений с брендом на компьютере.
        /// </summary>
        /// <param name="desktopBrandedKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopBrandedKeywordsResponse GetDesktopBrandedKeywords(DesktopBrandedKeywordsParameters desktopBrandedKeywordsParameters)
        {
            return Invoke<DesktopBrandedKeywordsResponse>(desktopBrandedKeywordsParameters);
        }

        /// <summary>
        /// Возвращает ведущих издателей, отправляющих трафик в данный домен, а также долю трафика на одного издателя и количество посещений медийной рекламы.
        /// </summary>
        /// <param name="desktopDisplayPublishersParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopDisplayPublishersResponse GetDesktopDisplayPublishers(DesktopDisplayPublishersParameters desktopDisplayPublishersParameters)
        {
            return Invoke<DesktopDisplayPublishersResponse>(desktopDisplayPublishersParameters);
        }

        /// <summary>
        /// Возвращает небрендовые ключевые слова для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL и позицию ключевого слова, а также количество небрендированных посещений на компьютере.
        /// </summary>
        /// <param name="desktopNonBrandedKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopNonBrandedKeywordsResponse GetDesktopNonBrandedKeywords(DesktopNonBrandedKeywordsParameters desktopNonBrandedKeywordsParameters)
        {
            return Invoke<DesktopNonBrandedKeywordsResponse>(desktopNonBrandedKeywordsParameters);
        }

        /// <summary>
        /// Возвращает долю трафика всех исходящих обычных ссылок для домена и количество исходящих посещений.
        /// </summary>
        /// <param name="desktopOrganicOutgoingLinksParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopOrganicOutgoingLinksResponse GetDesktopOrganicOutgoingLinks(DesktopOrganicOutgoingLinksParameters desktopOrganicOutgoingLinksParameters)
        {
            return Invoke<DesktopOrganicOutgoingLinksResponse>(desktopOrganicOutgoingLinksParameters);
        }

        /// <summary>
        /// Возвращает обычные ключевые слова для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL-адрес и позицию ключевого слова, а также количество обычных посещений на компьютере.
        /// </summary>
        /// <param name="desktopOrganicSearchKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopOrganicSearchKeywordsResponse GetDesktopOrganicSearchKeywords(DesktopOrganicSearchKeywordsParameters desktopOrganicSearchKeywordsParameters)
        {
            return Invoke<DesktopOrganicSearchKeywordsResponse>(desktopOrganicSearchKeywordsParameters);
        }

        /// <summary>
        /// Возвращает долю трафика всех рекламных сетей, получающих трафик из домена.
        /// </summary>
        /// <param name="desktopOutgoingAdsAdNetworksParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopOutgoingAdsAdNetworksResponse GetDesktopOutgoingAdsAdNetworks(DesktopOutgoingAdsAdNetworksParameters desktopOutgoingAdsAdNetworksParameters)
        {
            return Invoke<DesktopOutgoingAdsAdNetworksResponse>(desktopOutgoingAdsAdNetworksParameters);
        }

        /// <summary>
        /// Возвращает долю трафика всех рекламодателей, получающих трафик из домена.
        /// </summary>
        /// <param name="desktopOutgoingAdsAdvertisersParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopOutgoingAdsAdvertisersResponse GetDesktopOutgoingAdsAdvertisers(DesktopOutgoingAdsAdvertisersParameters desktopOutgoingAdsAdvertisersParameters)
        {
            return Invoke<DesktopOutgoingAdsAdvertisersResponse>(desktopOutgoingAdsAdvertisersParameters);
        }

        /// <summary>
        /// Возвращает оплачиваемые ключевые слова для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL-адрес и позицию ключевого слова, а также количество оплачиваемых посещений на компьютере.
        /// </summary>
        /// <param name="desktopPaidSearchKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopPaidSearchKeywordsResponse GetDesktopPaidSearchKeywords(DesktopPaidSearchKeywordsParameters desktopPaidSearchKeywordsParameters)
        {
            return Invoke<DesktopPaidSearchKeywordsResponse>(desktopPaidSearchKeywordsParameters);
        }

        /// <summary>
        /// Возвращает лучших издателей с разбивкой по рекламной сети для данного домена и их долю трафика.
        /// </summary>
        /// <param name="desktopPublishersPerAdNetworkParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopPublishersPerAdNetworkResponse GetDesktopPublishersPerAdNetwork(DesktopPublishersPerAdNetworkParameters desktopPublishersPerAdNetworkParameters)
        {
            return Invoke<DesktopPublishersPerAdNetworkResponse>(desktopPublishersPerAdNetworkParameters);
        }

        /// <summary>
        /// Возвращает ключевые слова с вопросами для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL и позицию ключевого слова, а также количество посещений с вопросами на компьютере.
        /// </summary>
        /// <param name="desktopQuestionsKeywordsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopQuestionsKeywordsResponse GetDesktopQuestionsKeywords(DesktopQuestionsKeywordsParameters desktopQuestionsKeywordsParameters)
        {
            return Invoke<DesktopQuestionsKeywordsResponse>(desktopQuestionsKeywordsParameters);
        }

        /// <summary>
        /// Возвращает ссылающиеся веб-сайты для данного домена, долю трафика на одного реферера и количество посещений реферала.
        /// </summary>
        /// <param name="desktopReferralsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopReferralsResponse GetDesktopReferals(DesktopReferralsParameters desktopReferralsParameters)
        {
            return Invoke<DesktopReferralsResponse>(desktopReferralsParameters);
        }

        /// <summary>
        /// Возвращает ведущие социальные сети, отправляющие трафик в данный домен, а также долю трафика в социальных сетях и количество посещений в социальных сетях.
        /// </summary>
        /// <param name="desktopSocialReferralsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopSocialReferralsResponse GetDesktopSocialReferrals(DesktopSocialReferralsParameters desktopSocialReferralsParameters)
        {
            return Invoke<DesktopSocialReferralsResponse>(desktopSocialReferralsParameters);
        }

        /// <summary>
        /// Возвращает примерный объем трафика с разбивкой по источникам.
        /// </summary>
        /// <param name="desktopTrafficSourcesOverviewParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopTrafficSourcesOverviewResponse GetDesktopTrafficSourcesOverview(DesktopTrafficSourcesOverviewParameters desktopTrafficSourcesOverviewParameters)
        {
            return Invoke<DesktopTrafficSourcesOverviewResponse>(desktopTrafficSourcesOverviewParameters);
        }

        /// <summary>
        /// Возвращает подробный обзор источников трафика с разбивкой по типу источника и доле трафика за выбранный период времени.
        /// </summary>
        /// <param name="desktopTrafficSourcesParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DesktopTrafficSourcesResponse GetDesktopTrafficSources(DesktopTrafficSourcesParameters desktopTrafficSourcesParameters)
        {
            return Invoke<DesktopTrafficSourcesResponse>(desktopTrafficSourcesParameters);
        }

        /// <summary>
        /// Возвращает примерную среднюю продолжительность посещения с разбивкой по источникам на компьютере.
        /// </summary>
        /// <param name="engagementMetricsAverageVisitDurationParameters">Параметры запроса.</param>
        /// <returns></returns>
        public EngagementMetricsAverageVisitDurationResponse GetEngagementMetricsAverageVisitDuration(EngagementMetricsAverageVisitDurationParameters engagementMetricsAverageVisitDurationParameters)
        {
            return Invoke<EngagementMetricsAverageVisitDurationResponse>(engagementMetricsAverageVisitDurationParameters);
        }

        /// <summary>
        /// Возвращает приблизительный показатель отказов по источникам.
        /// </summary>
        /// <param name="engagementMetricsBounceRateParameters">Параметры запроса.</param>
        /// <returns></returns>
        public EngagementMetricsBounceRateResponse GetEngagementMetricsBounceRate(EngagementMetricsBounceRateParameters engagementMetricsBounceRateParameters)
        {
            return Invoke<EngagementMetricsBounceRateResponse>(engagementMetricsBounceRateParameters);
        }

        /// <summary>
        /// Возвращает приблизительное количество страниц за посещение с разбивкой по источникам.
        /// </summary>
        /// <param name="engagementMetricsPagesPerVisitParameters">Параметры запроса.</param>
        /// <returns></returns>
        public EngagementMetricsPagesPerVisitResponse GetEngagementMetricsPagesPerVisit(EngagementMetricsPagesPerVisitParameters engagementMetricsPagesPerVisitParameters)
        {
            return Invoke<EngagementMetricsPagesPerVisitResponse>(engagementMetricsPagesPerVisitParameters);
        }

        /// <summary>
        /// Возвращает ежемесячное распределение платных и брендированных поисковых посещений для настольного трафика.
        /// </summary>
        /// <param name="searchVisitsDistributionDesktopParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SearchVisitsDistributionDesktopResponse GetSearchVisitsDistributionDesktop(SearchVisitsDistributionDesktopParameters searchVisitsDistributionDesktopParameters)
        {
            return Invoke<SearchVisitsDistributionDesktopResponse>(searchVisitsDistributionDesktopParameters);
        }

        #endregion
    }
}
