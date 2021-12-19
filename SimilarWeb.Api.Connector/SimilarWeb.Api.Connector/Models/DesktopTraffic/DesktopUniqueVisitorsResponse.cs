using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopUniqueVisitors. Содержит количество ежедневных или ежемесячных уникальных посетителей на веб-сайт.
    /// </summary>
    /// <seealso cref="BaseResponseWithDevice&lt;TRequest&gt;" />
    public class DesktopUniqueVisitorsResponse : BaseResponseWithDevice<RequestDesktopWithState>
    {
        #region Свойства

        [JsonProperty("unique_visitors")]
        public List<UniqueVisitorsDataItem> UniqueVisitors { get; set; }

        #endregion
    }
}
