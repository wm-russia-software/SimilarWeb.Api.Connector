using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Параметры для вызова метода TopAndroidAppsUsage.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class TopAndroidAppsUsageParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/appCategory/{Vendor}/UsageRank/top-apps";

        /// <summary>
        /// Издатель приложения. 
        /// </summary>        
        public string Vendor { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>        
        [ParameterName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Категория приложения.
        /// </summary>        
        [ParameterName("category")]
        public CategoryUppercase Category { get; set; }

        /// <summary>
        /// Режим лицензии приложения. 
        /// </summary>        
        [ParameterName("mode")]
        public Mode Mode { get; set; }

        /// <summary>
        /// Устройство.
        /// </summary>        
        [ParameterName("device")]
        public Device Device { get; set; }

        #endregion
    }
}
