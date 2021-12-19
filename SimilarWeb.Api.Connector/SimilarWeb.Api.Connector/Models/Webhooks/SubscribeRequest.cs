using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Запрос на подписку.
    /// </summary>
    public class SubscribeRequest
    {
        #region Свойства 

        /// <summary>
        /// Тип события.
        /// </summary>        
        [JsonProperty("web_hook_event_type"), JsonConverter(typeof(StringEnumConverter))]
        public WebHookEventType WebHookEventType { get; set; }

        /// <summary>
        /// Адрес для срабатывания триггера.
        /// </summary>        
        [JsonProperty("url")]
        public string Url { get; set; }

        #endregion
    }
}
