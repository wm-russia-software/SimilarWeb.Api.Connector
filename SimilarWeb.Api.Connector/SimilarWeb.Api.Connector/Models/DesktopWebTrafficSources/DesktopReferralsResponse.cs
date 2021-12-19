using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopReferrals. Содержит ссылающиеся веб-сайты для данного домена, долю трафика на одного реферера и количество посещений реферала.
    /// </summary>
    /// <seealso cref="BaseRankingResponse" />
    public class DesktopReferralsResponse : BaseRankingResponse
    {
        #region Свойства

        [JsonProperty("referrals")]
        public List<Referral> Referrals { get; set; }

        #endregion
    }
}
