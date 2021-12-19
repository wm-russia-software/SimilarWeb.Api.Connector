using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetUniqueInstalls. Содержит количество уникальных установок запрошенного приложения.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class UniqueInstallsResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("unique_installs")]
        public List<UniqueInstallsItem> UniqueInstalls { get; set; }

        #endregion
    }
}
