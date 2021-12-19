using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Запрос из метаданных. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class SimilarSitesRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
