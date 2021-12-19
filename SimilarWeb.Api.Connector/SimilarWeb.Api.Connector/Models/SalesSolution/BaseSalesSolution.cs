using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Базовый класс решений по продажам. 
    /// </summary>
    public abstract class BaseSalesSolution
    {
        #region Свойства

        [JsonProperty("global_rank")]
        public int GlobalRank { get; set; }

        [JsonProperty("category_rank")]
        public int CategoryRank { get; set; }

        #endregion
    }
}
