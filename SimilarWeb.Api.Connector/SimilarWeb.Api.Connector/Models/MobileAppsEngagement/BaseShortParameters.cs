using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Базовый класс короткого набора параметров. 
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public abstract class BaseShortParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Страна.
        /// </summary>        
        [ParameterName("country")]
        public string Country { get; set; }

        #endregion

    }
}
