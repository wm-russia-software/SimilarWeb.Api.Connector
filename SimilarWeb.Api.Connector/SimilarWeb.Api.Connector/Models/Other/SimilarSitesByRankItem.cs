using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка похожих сайтов по рейтингу.
    /// </summary>
    public class SimilarSitesByRankItem
    {
        #region Свойства

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("screenshot")]
        public string Screenshot { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        #endregion
    }
}
