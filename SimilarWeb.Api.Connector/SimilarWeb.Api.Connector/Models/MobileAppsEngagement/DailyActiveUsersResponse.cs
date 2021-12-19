using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetDailyActiveUsers. Содержит количество уникальных ежедневных активных пользователей запрошенного приложения.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DailyActiveUsersResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("daily_active_users")]
        public List<DailyActiveUsersDataListItem> DailyActiveUsers { get; set; }

        #endregion
    }
}
