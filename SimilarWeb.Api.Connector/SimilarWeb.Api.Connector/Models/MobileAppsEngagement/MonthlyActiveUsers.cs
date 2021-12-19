using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Активные пользователи в месяце.
    /// </summary>
    public class MonthlyActiveUsers
    {
        #region Свойства

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("active_users")]
        public decimal ActiveUsers { get; set; }

        #endregion
    }

}
