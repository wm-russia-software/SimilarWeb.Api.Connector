using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    ///  Элемент списка с показателями отказов.
    /// </summary>
    /// <seealso cref="BaseDataListItem" />
    public class BounceRateDataListItem : BaseDataListItem
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        #endregion
    }
}
