using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetTopAndroidAppsUsage. Содержит список лучших приложений для Android, отсортированных по рейтингу использования приложений SimilarWeb.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class TopAndroidAppsUsageResponse : BaseResponseWithLastUpdate<CategoryRequest>
    {
        #region Свойства

        [JsonProperty("top_apps")]
        public List<TopApps> TopApps { get; set; }

        #endregion
    }
}
