using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Элемент базового списка с визитами.
    /// </summary>
    /// <seealso cref="BaseDataListItem" />
    public class VisitsDataListItem : BaseDataListItem
    {
        #region Свойства

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        #endregion
    }
}
