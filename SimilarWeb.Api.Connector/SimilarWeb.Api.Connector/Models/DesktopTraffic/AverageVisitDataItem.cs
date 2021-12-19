using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Средняя продолжительность визита.
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class AverageVisitDataItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("average_visit_duration")]
        public decimal AverageVisitDuration { get; set; }

        #endregion
    }
}
