using SimilarWeb.Api.Connector.Models.Other;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов Other.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class Other : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public Other(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public Other(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает полный набор данных о домене.
        /// </summary>
        /// <param name="apiLiteParameters">The API lite parameters.</param>
        /// <returns></returns>
        public ApiLiteResponse GetApiLite(ApiLiteParameters apiLiteParameters)
        {
            return Invoke<ApiLiteResponse>(apiLiteParameters);
        }

        /// <summary>
        /// Возвращает категорию данного домена и его глобальный рейтинг в данной категории.
        /// </summary>
        /// <param name="categoryRanksParameters">Параметры запроса.</param>
        /// <returns></returns>
        public CategoryRankResponse GetCategoryRanks(CategoryRankParameters categoryRanksParameters)
        {
            return Invoke<CategoryRankResponse>(categoryRanksParameters);
        }

        /// <summary>
        /// Возвращает 40 самых похожих веб-сайтов для данного домена и их оценку сходства.
        /// </summary>
        /// <param name="similarSitesParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SimilarSitesResponse GetSimilarSites(SimilarSitesParameters similarSitesParameters)
        {
            return Invoke<SimilarSitesResponse>(similarSitesParameters);
        }

        /// <summary>
        /// Возвращает мета-описание веб-сайта
        /// </summary>
        /// <param name="websiteDescriptionParameters">Параметры запроса.</param>
        /// <returns></returns>
        public WebsiteDescriptionResponse GetWebsiteDescription(WebsiteDescriptionParameters websiteDescriptionParameters)
        {
            return Invoke<WebsiteDescriptionResponse>(websiteDescriptionParameters);
        }

        #endregion
    }
}
