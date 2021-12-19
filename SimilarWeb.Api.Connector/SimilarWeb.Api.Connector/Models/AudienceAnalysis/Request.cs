using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Метаданные запроса из ответа на вызовов методов из группы AudienceAnalysis.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class Request : BaseRequest
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
