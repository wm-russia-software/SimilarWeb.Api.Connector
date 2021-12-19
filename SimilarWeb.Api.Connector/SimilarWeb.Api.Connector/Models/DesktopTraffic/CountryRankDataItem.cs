using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Рейтинг по стране. 
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class CountryRankDataItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("country_rank")]
        public decimal CountryRank { get; set; }

        #endregion
    }
}
