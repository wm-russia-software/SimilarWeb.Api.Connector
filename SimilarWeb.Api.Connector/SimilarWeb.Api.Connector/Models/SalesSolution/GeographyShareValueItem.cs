using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Элемент списка с разделением по стране. 
    /// </summary>
    public class GeographyShareValueItem
    {
        #region Свойства

        [JsonProperty("country")]
        public int Country { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        #endregion
    }
}
