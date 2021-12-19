using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebAverageVisitDuration. Содержит среднюю продолжительность посещения мобильного веб-сайта в указанном домене (в секундах).
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebAverageVisitDurationResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("average_visit_duration")]
        public List<AverageVisitDurationItem> AverageVisitDuration { get; set; }

        #endregion
    }
}
