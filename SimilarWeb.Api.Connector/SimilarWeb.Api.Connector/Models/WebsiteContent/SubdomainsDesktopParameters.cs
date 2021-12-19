namespace SimilarWeb.Api.Connector.Models.WebsiteContent
{
    /// <summary>
    /// Параметры для вызова метода SubdomainsDesktop.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class SubdomainsDesktopParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/website-content-subdomains/subdomains";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
