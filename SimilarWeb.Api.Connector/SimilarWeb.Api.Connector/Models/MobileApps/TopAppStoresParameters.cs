using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Параметры для вызова метода TopAppStores.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class TopAppStoresParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/appCategory/rank/StoreRank/top-apps";

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
        /// Магазин.
        /// </summary>
        [ParameterName("store")]
        public Store Store { get; set; }

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
