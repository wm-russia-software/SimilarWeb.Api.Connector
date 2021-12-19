using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetAppDownloads. Содержит количество пользователей, загружающих приложение из Google Play / Apple App store за заданный период времени.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class AppDownloadsResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("downloads")]
        public List<DownloadDataListItem> Downloads { get; set; }

        #endregion
    }
}
