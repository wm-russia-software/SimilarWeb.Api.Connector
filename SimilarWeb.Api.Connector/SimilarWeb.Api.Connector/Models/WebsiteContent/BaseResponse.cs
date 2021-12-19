using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.WebsiteContent
{
    /// <summary>
    /// Базовый класс ответа на вызов методов.
    /// </summary>
    public abstract class BaseResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("subdomains")]
        public List<SubdomainDataListItem> Subdomains { get; set; }

        #endregion
    }
}
