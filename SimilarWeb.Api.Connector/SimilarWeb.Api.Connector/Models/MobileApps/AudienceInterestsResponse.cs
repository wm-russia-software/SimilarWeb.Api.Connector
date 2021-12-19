using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetAudienceInterests. Содержит приложения, используемые той же аудиторией, что и запрошенное приложение.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class AudienceInterestsResponse : BaseResponseWithLastUpdate<AudienceInterestRequest>
    {
        #region Свойства

        [JsonProperty("also_used_apps")]
        public List<AlsoUsedApps> AlsoUsedApps { get; set; }

        #endregion
    }
}
