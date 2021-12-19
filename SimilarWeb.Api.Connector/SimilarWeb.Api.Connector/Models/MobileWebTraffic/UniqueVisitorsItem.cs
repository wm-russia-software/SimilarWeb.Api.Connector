using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Элемент списка уникальных визитеров.
    /// </summary>
    public class UniqueVisitorsItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("unique_visitors")]
        public decimal UniqueVisitors { get; set; }

        #endregion 
    }
}
