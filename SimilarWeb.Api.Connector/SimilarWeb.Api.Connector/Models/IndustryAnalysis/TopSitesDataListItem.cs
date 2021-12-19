using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.IndustryAnalysis
{
    /// <summary>
    /// Элемент списка с данными по рейтингу веб-сайта. 
    /// </summary>
    public class TopSitesDataListItem
    {
        #region Свойства

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        #endregion
    }

}
