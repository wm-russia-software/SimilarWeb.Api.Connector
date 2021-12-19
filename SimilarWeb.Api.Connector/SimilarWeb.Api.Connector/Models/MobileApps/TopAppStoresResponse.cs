using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetTopAppStores. Содержит список лучших приложений для iOS, отсортированный по рейтингу в App Store.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class TopAppStoresResponse : BaseResponseWithLastUpdate<CategoryRequest>
    {
        #region Свойства

        [JsonProperty("top_apps")]
        public List<TopApps> TopApps { get; set; }

        #endregion
    }
}
