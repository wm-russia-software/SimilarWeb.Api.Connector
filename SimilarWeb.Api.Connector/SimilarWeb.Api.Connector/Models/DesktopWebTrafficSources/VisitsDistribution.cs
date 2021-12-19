using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Детализация платных и брендированных поисковых визитов. 
    /// </summary>
    public class VisitsDistribution
    {
        #region Свойства

        [JsonProperty("branded_visits")]
        public decimal BrandedVisits { get; set; }

        [JsonProperty("non_branded_visits")]
        public decimal NonBrandedVisits { get; set; }

        [JsonProperty("organic_branded_visits")]
        public decimal OrganicBrandedVisits { get; set; }

        [JsonProperty("organic_non_branded_visits")]
        public decimal OrganicNonBrandedVisits { get; set; }

        [JsonProperty("paid_branded_visits")]
        public decimal PaidBrandedVisits { get; set; }

        [JsonProperty("paid_non_branded_visits")]
        public decimal PaidNonBrandedVisits { get; set; }

        #endregion
    }
}
