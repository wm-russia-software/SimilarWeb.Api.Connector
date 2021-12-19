
namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Параметры для вызова метода InstallPenetration.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class InstallPenetrationParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/app/{Vendor}/{Application}/engagement/current-installs";

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
