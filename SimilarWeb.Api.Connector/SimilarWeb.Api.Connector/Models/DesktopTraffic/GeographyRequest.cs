using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Запрос для метаданных ответа на вызов метода группы DesktopTraffic.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class GeographyRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
