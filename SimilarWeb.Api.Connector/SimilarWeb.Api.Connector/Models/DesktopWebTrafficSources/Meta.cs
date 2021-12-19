using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    ///  Базовый класс метаданных ответа на вызов метода группы DesktopWebTrafficSources.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public class Meta<TRequest> where TRequest : BaseRequest
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
