using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Элемент списка показателя отказов.
    /// </summary>
    public class BounceRateItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        #endregion
    }
}
