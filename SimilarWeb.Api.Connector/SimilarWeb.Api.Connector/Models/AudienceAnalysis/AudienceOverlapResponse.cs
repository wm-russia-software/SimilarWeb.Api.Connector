using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Ответ на вызов метода GetAudienceOverlap. Содержит сравнение аудитории с конкурентами, для измерения размера рынка и уточнения в предпочтениях аудитории.
    /// </summary>
    public class AudienceOverlapResponse
    {
        #region Свойства 

        [JsonProperty("meta")]
        public Meta<AudienceOverlapRequest> Meta { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, decimal> Data { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        #endregion
    }
}
