using Newtonsoft.Json;
using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Элемент списка полученных подписок. 
    /// </summary>
    public class GetListDataListItem
    {
        #region Свойства

        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        [JsonProperty("web_hook_event_type")]
        public WebHookEventType WebHookEventType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("last_update_date")]
        public string LastUpdateDate { get; set; }

        #endregion
    }
}
