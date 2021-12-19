using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Запрос из метаданных.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class NewVsReturningRequest : BaseRequest
    {
        #region Свойства 

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        #endregion
    }
}
