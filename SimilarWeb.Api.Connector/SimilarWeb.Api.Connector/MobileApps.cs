using SimilarWeb.Api.Connector.Models.MobileApps;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов MobileApps.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class MobileApps : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public MobileApps(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public MobileApps(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает заголовок, изображение, издателя, цену, основную категорию, идентификатор основной категории и рейтинг для запрошенного приложения.
        /// </summary>
        /// <param name="appDetailsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AppDetailsResponse GetAppDetails(AppDetailsParameters appDetailsParameters)
        {
            return Invoke<AppDetailsResponse>(appDetailsParameters);
        }

        /// <summary>
        /// Возвращает рейтинг в Apple App Store / Google Play Store для данного приложения.
        /// </summary>
        /// <param name="appRankParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AppRankResponse GetAppRank(AppRankParameters appRankParameters)
        {
            return Invoke<AppRankResponse>(appRankParameters);
        }

        /// <summary>
        /// Возвращает приложения, используемые той же аудиторией, что и запрошенное приложение.
        /// </summary>
        /// <param name="audienceInterestsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AudienceInterestsResponse GetAudienceInterests(AudienceInterestParameters audienceInterestsParameters)
        {
            return Invoke<AudienceInterestsResponse>(audienceInterestsParameters);
        }

        /// <summary>
        /// Возвращает список всех сайтов, связанных с данным мобильным приложением.
        /// </summary>
        /// <param name="relatedSitesParameters">Параметры запроса.</param>
        /// <returns></returns>
        public RelatedSitesResponse GetRelatedSites(RelatedSitesParameters relatedSitesParameters)
        {
            return Invoke<RelatedSitesResponse>(relatedSitesParameters);
        }

        /// <summary>
        /// Возвращает список всех мобильных приложений, связанных с запрошенным доменом.
        /// </summary>
        /// <param name="siteRelatedAppsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SiteRelatedAppsResponse GetSiteRelatedApps(SiteRelatedAppsParameters siteRelatedAppsParameters)
        {
            return Invoke<SiteRelatedAppsResponse>(siteRelatedAppsParameters);
        }

        /// <summary>
        /// Возвращает список лучших приложений для Android, отсортированных по рейтингу использования приложений SimilarWeb.
        /// </summary>
        /// <param name="topAndroidAppsUsageParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TopAndroidAppsUsageResponse GetTopAndroidAppsUsage(TopAndroidAppsUsageParameters topAndroidAppsUsageParameters)
        {
            return Invoke<TopAndroidAppsUsageResponse>(topAndroidAppsUsageParameters);
        }

        /// <summary>
        /// Возвращает список лучших приложений для iOS, отсортированный по рейтингу в App Store.
        /// </summary>
        /// <param name="topAppStoresParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TopAppStoresResponse GetTopAppStores(TopAppStoresParameters topAppStoresParameters)
        {
            return Invoke<TopAppStoresResponse>(topAppStoresParameters);
        }

        #endregion
    }
}
