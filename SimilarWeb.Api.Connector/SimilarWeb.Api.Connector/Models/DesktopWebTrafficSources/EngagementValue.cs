using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Элемент списка данных со значением в разрезе даты. 
    /// </summary>
    public class EngagementValue
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        #endregion
    }
}
