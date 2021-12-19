using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    ///  Элемент списка среднего времени визита.
    /// </summary>
    /// <seealso cref="BaseDataListItem" />
    public class AverageVisitDataListItem : BaseDataListItem
    {
        #region Свойства

        [JsonProperty("average_visit_duration")]
        public decimal AverageVisitDuration { get; set; }

        #endregion
    }
}
