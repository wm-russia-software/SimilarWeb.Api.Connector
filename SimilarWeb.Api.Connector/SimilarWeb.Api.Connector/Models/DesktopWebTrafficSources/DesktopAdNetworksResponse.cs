using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopAdNetworks. Содержит ведущие рекламные сети, отправляющие трафик в указанный домен, а также долю трафика в каждой рекламной сети.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DesktopAdNetworksResponse : BaseResponse<RequestWithLimit>
    {
        #region Свойства

        [JsonProperty("ad_networks")]
        public List<AdNetworks> AdNetworks { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
