using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Глобальный рейтинг.
    /// </summary>
    public class GlobalRankItem
    {
        #region Свойства

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("direction")]
        public int Direction { get; set; }

        #endregion
    }
}
