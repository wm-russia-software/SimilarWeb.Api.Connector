using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода MobileWebTrafficSourcesOverview.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebTrafficSourcesOverviewParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/traffic-sources/mobile-overview-share";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Гранулярность по времени.
        /// </summary>        
        [ParameterName("granularity")]
        public Granularity Granularity { get; set; }

        #endregion
    }
}
