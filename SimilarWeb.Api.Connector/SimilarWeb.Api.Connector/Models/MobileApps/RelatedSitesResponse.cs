using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetRelatedSites. Содержит список всех сайтов, связанных с данным мобильным приложением.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class RelatedSitesResponse : BaseResponseWithLastUpdate<CategoryWithApIdRequest>
    {
        #region Свойства

        [JsonProperty("related_sites")]
        public List<string> RelatedSites { get; set; }

        #endregion
    }

}
