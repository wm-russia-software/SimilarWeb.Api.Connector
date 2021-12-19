namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Параметры для вызова метода AppDownloads.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class AppDownloadsParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/app/{Vendor}/{Application}/engagement/downloads";

        /// <summary>
        /// Издатель приложения. 
        /// </summary>        
        public string Vendor { get; set; }

        /// <summary>
        /// Приложение.
        /// </summary>        
        public string Application { get; set; }

        #endregion
    }
}
