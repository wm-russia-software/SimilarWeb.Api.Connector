using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка рейтинга по странам.
    /// </summary>
    public class CountryRankItem
    {
        #region Свойства

        [JsonProperty("country")]
        public int Country { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("direction")]
        public int Direction { get; set; }

        #endregion
    }
}
