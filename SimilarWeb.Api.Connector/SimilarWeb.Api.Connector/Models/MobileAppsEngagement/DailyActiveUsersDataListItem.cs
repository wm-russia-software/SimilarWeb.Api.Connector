using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Элемент списка активных пользователей за день.
    /// </summary>
    public class DailyActiveUsersDataListItem
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
