using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetMonthlyActiveUsersAndroid. Содержит количество уникальных активных пользователей за месяц для приложений Android.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MonthlyActiveUsersAndroidResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("monthly_active_users")]
        public List<MonthlyActiveUsers> MonthlyActiveUsers { get; set; }

        #endregion 
    }
}
