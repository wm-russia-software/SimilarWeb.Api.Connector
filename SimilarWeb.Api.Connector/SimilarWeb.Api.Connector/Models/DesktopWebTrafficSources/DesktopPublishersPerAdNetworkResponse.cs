using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopPublishersPerAdNetwork. Содержит лучших издателей с разбивкой по рекламной сети для данного домена и их долю трафика.
    /// </summary>
    /// <seealso cref="BaseRankingResponse" />
    public class DesktopPublishersPerAdNetworkResponse : BaseRankingResponse
    {
        #region Свойства

        [JsonProperty("ad_networks")]
        public List<AdNetworksWithPublisher> AdNetworks { get; set; }

        #endregion
    }
}
