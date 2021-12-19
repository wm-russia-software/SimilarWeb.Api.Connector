using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebUniqueVisitors. Содержит количество уникальных посетителей за день или месяц на веб-сайт в мобильной сети.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebUniqueVisitorsResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("unique_visitors")]
        public List<UniqueVisitorsItem> UniqueVisitors { get; set; }

        #endregion
    }
}
