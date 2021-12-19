using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Соотношение органических и платных переходов. 
    /// </summary>
    public class OrganicVsPaid
    {
        #region Свойства

        [JsonProperty("organic")]
        public decimal Organic { get; set; }

        [JsonProperty("paid")]
        public decimal Paid { get; set; }

        #endregion
    }

}
