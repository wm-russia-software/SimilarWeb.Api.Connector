using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Уникальные установоки.
    /// </summary>
    public class UniqueInstallsItem
    {
        #region Свойства 
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("unique_installs")]
        public decimal UniqueInstalls { get; set; }

        #endregion
    }
}
