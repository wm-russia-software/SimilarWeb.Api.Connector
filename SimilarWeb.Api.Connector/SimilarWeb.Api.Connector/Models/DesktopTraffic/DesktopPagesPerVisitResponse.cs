using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopPagesPerVisit. Содержит среднее количество просмотров страниц за посещение для данного домена.
    /// </summary>
    /// <seealso cref="BaseResponseWithDevice&lt;TRequest&gt;" />
    public class DesktopPagesPerVisitResponse : BaseResponseWithDevice<RequestDesktopWithState>
    {
        #region Свойства

        [JsonProperty("pages_per_visit")]
        public List<PagesPerVisitDataListItem> PagesPerVisit { get; set; }

        #endregion
    }
}
