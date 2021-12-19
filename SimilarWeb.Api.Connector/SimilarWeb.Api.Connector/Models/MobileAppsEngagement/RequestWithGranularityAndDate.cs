using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Запрос из метаданных с гранулярностью и датой.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithGranularityAndDate : BaseRequest
    {
        #region Свойства

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        #endregion
    }
}
