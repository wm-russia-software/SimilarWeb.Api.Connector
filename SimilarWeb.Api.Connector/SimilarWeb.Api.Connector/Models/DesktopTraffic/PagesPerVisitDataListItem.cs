using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Количество страниц на каждый визит. 
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class PagesPerVisitDataListItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("pages_per_visit")]
        public decimal PagesPerVisit { get; set; }

        #endregion
    }
}
