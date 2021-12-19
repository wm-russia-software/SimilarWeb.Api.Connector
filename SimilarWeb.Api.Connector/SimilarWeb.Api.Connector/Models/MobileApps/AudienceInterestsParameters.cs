using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Параметры для вызова метода AudienceInterest.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class AudienceInterestParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/app/{Vendor}/{Application}/audience-interests/also-used-apps";

        /// <summary>
        /// Издатель приложения. 
        /// </summary>        
        public string Vendor { get; set; }

        /// <summary>
        /// Приложение.
        /// </summary>        
        public string Application { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>        
        [ParameterName("country")]
        public string Country { get; set; }

        #endregion
    }
}
