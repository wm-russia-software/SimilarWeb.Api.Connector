using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Данные о рейтинге в разрезе дат. 
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class GlobalRankData : BaseDataItem
    {
        #region Свойства

        [JsonProperty("global_rank")]
        public int GlobalRank { get; set; }

        #endregion
    }
}
