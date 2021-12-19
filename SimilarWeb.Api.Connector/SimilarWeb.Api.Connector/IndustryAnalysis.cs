using SimilarWeb.Api.Connector.Models.IndustryAnalysis;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов IndustryAnalysis.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class IndustryAnalysis : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public IndustryAnalysis(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public IndustryAnalysis(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает самые популярные сайты (на основе трафика настольных компьютеров) в заданной категории.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TopSitesDesktopResponse GetTopSitesDesktop(TopSitesDesktopParameters requestParameters)
        {
            return Invoke<TopSitesDesktopResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает самые популярные сайты (на основе трафика мобильного Интернета) в заданной категории.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TopSitesMobileResponse GetTopSitesMobile(TopSitesMobileParameters requestParameters)
        {
            return Invoke<TopSitesMobileResponse>(requestParameters);
        }

        /// <summary>
        /// Возвращает самые популярные сайты (на основе трафика настольных и мобильных устройств) в заданной категории.
        /// </summary>
        /// <param name="requestParameters">Параметры запроса.</param>
        /// <returns></returns>
        public TopSitesDesktopAndMobileResponse GetTopSitesDesktopAndMobile(TopSitesDesktopAndMobileParameters requestParameters)
        {
            return Invoke<TopSitesDesktopAndMobileResponse>(requestParameters);
        }

        #endregion
    }
}
