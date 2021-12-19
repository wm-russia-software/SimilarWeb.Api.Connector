using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetSiteRelatedApps. Содержит список всех мобильных приложений, связанных с запрошенным доменом.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class SiteRelatedAppsResponse : BaseResponse<RequestWithDomain>
    {
        #region Свойства

        [JsonProperty("related_apps")]
        public List<RelatedApps> RelatedApps { get; set; }

        #endregion
    }
}
