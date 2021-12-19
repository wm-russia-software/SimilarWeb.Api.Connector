using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Базовый класс запроса из метаданных.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public abstract class BaseRequestDesktop : BaseRequest
    {
        #region Свойства

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
