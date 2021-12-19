using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebReferrals. Содержит мобильные ссылающиеся веб-сайты для данного домена и долю трафика на каждого реферера.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebReferralsResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("referrals")]
        public List<Referral> Referrals { get; set; }

        [JsonProperty("visits")]
        public int Visits { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
