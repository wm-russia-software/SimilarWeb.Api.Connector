using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Параметры для вызова метода SiteRelatedApps.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class SiteRelatedAppsParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/related-apps/related-apps";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Магазин
        /// </summary>        
        [ParameterName("store")]
        public StoreUppercase Store { get; set; }

        #endregion
    }
}
