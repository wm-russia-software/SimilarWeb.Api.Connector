using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopOutgoingAdsAdNetworks. Содержит долю трафика всех рекламных сетей, получающих трафик из домена.
    /// </summary>
    /// <seealso cref="BaseVisitsResponse" />
    public class DesktopOutgoingAdsAdNetworksResponse : BaseVisitsResponse
    {
        #region Свойства

        [JsonProperty("ad_networks")]
        public List<AdNetworks> AdNetworks { get; set; }

        #endregion
    }
}
