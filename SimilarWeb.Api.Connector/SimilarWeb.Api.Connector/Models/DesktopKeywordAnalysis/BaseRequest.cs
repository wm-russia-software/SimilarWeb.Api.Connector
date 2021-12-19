using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Базовый класс запроса из метаданных ответа на вызов методов из группы DesktopKeywordAnalysis.
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        #endregion
    }
}
