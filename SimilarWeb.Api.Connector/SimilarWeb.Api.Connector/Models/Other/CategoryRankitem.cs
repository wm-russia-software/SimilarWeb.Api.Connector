using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка рейтинга в категории. 
    /// </summary>
    public class CategoryRankItem
    {
        #region Свойства

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("direction")]
        public int Direction { get; set; }

        #endregion
    }
}
