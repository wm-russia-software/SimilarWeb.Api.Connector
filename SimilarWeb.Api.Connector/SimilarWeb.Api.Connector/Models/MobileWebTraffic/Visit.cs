using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Количество визитов на дату.
    /// </summary>
    public class Visit
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        #endregion
    }
}
