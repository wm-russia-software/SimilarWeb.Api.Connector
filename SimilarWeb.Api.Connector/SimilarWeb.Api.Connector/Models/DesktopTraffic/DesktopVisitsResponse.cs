using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopVisits. Содержит приблизительное количество посещений для домена.
    /// </summary>
    /// <seealso cref="BaseResponseWithDevice&lt;TRequest&gt;" />
    public class DesktopVisitsResponse : BaseResponseWithDevice<RequestDesktopWithState>
    {
        #region Свойства

        [JsonProperty("visits")]
        public List<VisitsDataItem> Visits { get; set; }

        #endregion
    }
}
