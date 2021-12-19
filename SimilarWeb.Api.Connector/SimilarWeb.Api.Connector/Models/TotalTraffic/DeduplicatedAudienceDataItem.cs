using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Элемент списка не дублированных визитов.
    /// </summary>
    /// <seealso cref="BaseDataListItem" />
    public class DeduplicatedAudienceDataItem : BaseDataListItem
    {
        #region Свойства

        [JsonProperty("dedup_data")]
        public DeduplicatedAudienceDedupData DedupData { get; set; }

        #endregion
    }
}
