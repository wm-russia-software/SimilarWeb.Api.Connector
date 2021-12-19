using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetVisits. Содержит приблизительное количество посещений для домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class VisitsResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("visits")]
        public List<VisitsDataListItem> Visits { get; set; }

        #endregion
    }
}
