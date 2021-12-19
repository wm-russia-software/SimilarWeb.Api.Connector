using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Элемент списка с визитами на дату.
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
