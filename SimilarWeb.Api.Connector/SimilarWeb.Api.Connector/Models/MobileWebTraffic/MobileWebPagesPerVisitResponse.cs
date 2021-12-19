using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebPagesPerVisit. Содержит среднее количество просмотров страниц за посещение веб-сайта для данного домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebPagesPerVisitResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("pages_per_visit")]
        public List<PagesPerVisitItem> PagesPerVisit { get; set; }

        #endregion
    }
}
