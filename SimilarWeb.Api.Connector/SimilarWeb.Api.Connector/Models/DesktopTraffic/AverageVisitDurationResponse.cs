using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetAverageVisitDuration. Содержит среднюю продолжительность посещения в указанном домене (в секундах).
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class AverageVisitDurationResponse : BaseResponse<RequestDesktopWithState>
    {
        #region Свойства

        [JsonProperty("average_visit_duration")]
        public List<AverageVisitDataItem> AverageVisitDuration { get; set; }

        #endregion
    }
}
