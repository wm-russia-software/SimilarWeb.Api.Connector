using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopSocialReferrals. Содержит ведущие социальные сети, отправляющие трафик в данный домен, а также долю трафика в социальных сетях и количество посещений в социальных сетях.
    /// </summary>
    /// <seealso cref="BaseVisitsResponse" />
    public class DesktopSocialReferralsResponse : BaseVisitsResponse
    {
        #region Свойства

        [JsonProperty("social")]
        public List<Social> Social { get; set; }

        #endregion
    }
}
