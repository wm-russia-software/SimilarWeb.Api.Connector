using SimilarWeb.Api.Connector.Models.WebsiteContent;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов WebsiteContent.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class WebsiteContent : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public WebsiteContent(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public WebsiteContent(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает список поддоменов и долю трафика на поддомен.
        /// </summary>
        /// <param name="subdomainsDesktopParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SubdomainsDesktopResponse GetSubdomainsDesktop(SubdomainsDesktopParameters subdomainsDesktopParameters)
        {
            return Invoke<SubdomainsDesktopResponse>(subdomainsDesktopParameters);
        }

        /// <summary>
        /// Возвращает список поддоменов и долю трафика на поддомен.
        /// </summary>
        /// <param name="subdomainsMobileWebParameters">Параметры запроса.</param>
        /// <returns></returns>
        public SubdomainsMobileWebResponse GetSubdomainsMobileWeb(SubdomainsMobileWebParameters subdomainsMobileWebParameters)
        {
            return Invoke<SubdomainsMobileWebResponse>(subdomainsMobileWebParameters);
        }

        #endregion
    }
}
