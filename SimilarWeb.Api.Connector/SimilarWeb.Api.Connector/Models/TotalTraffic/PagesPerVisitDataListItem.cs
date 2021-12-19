using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Элемент списка страниц за визит.
    /// </summary>
    /// <seealso cref="BaseDataListItem" />
    public class PagesPerVisitDataListItem : BaseDataListItem
    {
        #region Свойства

        [JsonProperty("pages_per_visit")]
        public decimal PagesPerVisit { get; set; }

        #endregion
    }
}
