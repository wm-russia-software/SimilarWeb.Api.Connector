using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopOrganicOutgoingLinks. Содержит долю трафика всех исходящих обычных ссылок для домена и количество исходящих посещений.
    /// </summary>
    /// <seealso cref="BaseRankingResponse" />
    public class DesktopOrganicOutgoingLinksResponse : BaseRankingResponse
    {
        #region Свойства

        [JsonProperty("referrals")]
        public List<Referral> Referrals { get; set; }

        #endregion
    }
}
