using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopOutgoingAdsAdvertisers. Содержит долю трафика всех рекламодателей, получающих трафик из домена.
    /// </summary>
    /// <seealso cref="BaseVisitsResponse" />
    public class DesktopOutgoingAdsAdvertisersResponse : BaseVisitsResponse
    {
        #region Свойства

        [JsonProperty("advertisers")]
        public List<Advertiser> Advertisers { get; set; }

        #endregion
    }
}
