using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Данные по рекламной сети c информацией об издателях. 
    /// </summary>
    /// <seealso cref="BaseAdNetworks" />
    public class AdNetworksWithPublisher : BaseAdNetworks
    {
        #region Свойства

        [JsonProperty("publishers")]
        public List<Publisher> Publishers { get; set; }

        #endregion
    }
}
