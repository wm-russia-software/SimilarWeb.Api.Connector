using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода DesktopAdNetworks.
    /// </summary>
    public class DesktopAdNetworksParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/traffic-sources/ad-networks";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Получение информации только для основного домена.
        /// </summary>
        [ParameterName("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        #endregion
    }
}
