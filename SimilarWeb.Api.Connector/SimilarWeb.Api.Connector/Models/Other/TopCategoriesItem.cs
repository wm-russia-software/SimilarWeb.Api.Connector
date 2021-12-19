using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка лучших категорий.
    /// </summary>
    public class TopCategoriesItem
    {
        #region Свойства

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("affinity")]
        public decimal Affinity { get; set; }

        #endregion
    }
}
