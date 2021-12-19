using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Показатель отказов.
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class BounceRateDataItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        #endregion
    }
}
