using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebVisits. Содержит приблизительное количество посещений мобильного Интернета для домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebVisitsResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("visits")]
        public List<Visit> Visits { get; set; }

        #endregion
    }
}
