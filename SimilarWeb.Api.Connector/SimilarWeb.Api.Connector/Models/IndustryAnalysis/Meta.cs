using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.IndustryAnalysis
{
    /// <summary>
    /// Метаданные ответа. 
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public class Meta<TRequest> where TRequest : Request
    {
        #region Свойства

        [JsonProperty("request")]
        public TRequest Request { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        #endregion
    }
}
