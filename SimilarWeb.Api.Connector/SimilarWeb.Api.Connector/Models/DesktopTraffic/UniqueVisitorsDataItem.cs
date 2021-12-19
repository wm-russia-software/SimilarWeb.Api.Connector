using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Уникальные визитеры.
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class UniqueVisitorsDataItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("unique_visitors")]
        public decimal UniqueVisitors { get; set; }

        #endregion
    }
}
