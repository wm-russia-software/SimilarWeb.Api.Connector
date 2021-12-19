using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Элемент списка используемых технологий. 
    /// </summary>
    public class Technology
    {
        #region Свойства

        [JsonProperty("technology_name")]
        public string TechnologyName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sub_category")]
        public string SubCategory { get; set; }

        [JsonProperty("free_paid")]
        public string FreePaid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion
    }
}
