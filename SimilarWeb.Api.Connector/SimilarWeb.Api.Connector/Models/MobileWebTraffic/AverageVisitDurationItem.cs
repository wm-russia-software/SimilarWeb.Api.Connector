using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Элемент списка средней продолжительности визита. 
    /// </summary>
    public class AverageVisitDurationItem
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("average_visit_duration")]
        public decimal AverageVisitDuration { get; set; }

        #endregion
    }
}
