using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Ответ на вызов метода GetLeadEnrichment. Содержит набор данных о домене для всего мира.
    /// </summary>
    /// <seealso cref="BaseSalesSolution" />
    public class LeadEnrichmentResponse : BaseSalesSolution
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("employee_range")]
        public string EmployeeRange { get; set; }

        [JsonProperty("estimated_revenue_in_usd")]
        public string EstimatedRevenueInUsd { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("headquarters")]
        public string Headquarters { get; set; }

        [JsonProperty("website_category")]
        public string WebsiteCategory { get; set; }

        [JsonProperty("pages_per_visit")]
        public List<DataValueItem> PagesPerVisit { get; set; }

        [JsonProperty("visits")]
        public List<DataValueItem> Visits { get; set; }

        [JsonProperty("mom_growth")]
        public List<DataValueItem> MomGrowth { get; set; }

        [JsonProperty("unique_visitors")]
        public List<DataValueItem> UniqueVisitors { get; set; }

        [JsonProperty("bounce_rate")]
        public List<DataValueItem> BounceRate { get; set; }

        [JsonProperty("average_visit_duration")]
        public List<DataValueItem> AverageVisitDuration { get; set; }

        [JsonProperty("mobile_desktop_share")]
        public List<MobileDesktopShare> MobileDesktopShare { get; set; }

        [JsonProperty("traffic_sources")]
        public List<TrafficSources> TrafficSources { get; set; }

        [JsonProperty("geography_share")]
        public List<GeographyShare> GeographyShare { get; set; }

        #endregion
    }
}
