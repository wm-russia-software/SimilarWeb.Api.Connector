using Newtonsoft.Json;
using System;


namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Данные по траффику в разрезе даты. 
    /// </summary>
    public class OverviewVisit
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("organic")]
        public decimal Organic { get; set; }

        [JsonProperty("paid")]
        public decimal Paid { get; set; }

        #endregion
    }
}
