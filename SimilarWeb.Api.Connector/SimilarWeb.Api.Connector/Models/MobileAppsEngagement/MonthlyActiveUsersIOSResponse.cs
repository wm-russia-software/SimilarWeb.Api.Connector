using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetMonthlyActiveUsersIOS. Содержит количество уникальных активных пользователей за месяц для приложений iOS.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MonthlyActiveUsersIOSResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("monthly_active_users")]
        public List<MonthlyActiveUsers> MonthlyActiveUsers { get; set; }

        #endregion 
    }
}
