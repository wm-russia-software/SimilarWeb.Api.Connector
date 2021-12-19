using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetAverageVisitDuration. Содержит среднюю продолжительность посещения указанного домена (в секундах).
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class AverageVisitDurationResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("average_visit_duration")]
        public List<AverageVisitDataListItem> AverageVisitDuration { get; set; }

        #endregion
    }
}
