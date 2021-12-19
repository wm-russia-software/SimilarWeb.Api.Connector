using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Базовый объект метаданных ответа.
    /// </summary>
    public class BaseRequest
    {
        #region Свойства

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }


        #endregion
    }

}
