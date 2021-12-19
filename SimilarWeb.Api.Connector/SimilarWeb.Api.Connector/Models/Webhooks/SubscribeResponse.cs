using Newtonsoft.Json;
using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Ответ на запрос подписки. 
    /// </summary>
    public class SubscribeResponse
    {
        #region Свойства

        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        [JsonProperty("web_hook_event_type")]
        public WebHookEventType WebHookEventType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("last_update_date")]
        public DateTime LastUpdateDate { get; set; }

        #endregion        
    }
}
