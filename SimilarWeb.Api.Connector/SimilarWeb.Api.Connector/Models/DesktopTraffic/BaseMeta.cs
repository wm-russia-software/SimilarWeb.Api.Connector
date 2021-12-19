using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Базовый класс с метаданными.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseMeta<TRequest> where TRequest : BaseRequest
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
