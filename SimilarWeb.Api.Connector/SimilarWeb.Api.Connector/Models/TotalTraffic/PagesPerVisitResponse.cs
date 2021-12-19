using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetPagesPerVisit. Содержит среднее количество просмотров страниц за посещение для данного домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class PagesPerVisitResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("pages_per_visit")]
        public List<PagesPerVisitDataListItem> PagesPerVisit { get; set; }

        #endregion
    }
}
