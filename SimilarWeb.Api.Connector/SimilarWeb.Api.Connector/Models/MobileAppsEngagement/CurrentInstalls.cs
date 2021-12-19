using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Текущее количество установок. 
    /// </summary>
    public class CurrentInstalls
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("installs")]
        public decimal Installs { get; set; }

        #endregion

    }

}