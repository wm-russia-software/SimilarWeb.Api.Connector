using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Ответ на вызов метода GetApiLite. Содержит полный набор данных о веб-сайте.
    /// </summary>
    public class ApiLiteResponse
    {
        #region Свойства

        [JsonProperty("site_name")]
        public string SiteName { get; set; }

        [JsonProperty("is_site_verified")]
        public bool IsSiteVerified { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("large_screenshot")]
        public string LargeScreenshot { get; set; }

        [JsonProperty("reach_months")]
        public int ReachMonths { get; set; }

        [JsonProperty("data_months")]
        public int DataMonths { get; set; }

        [JsonProperty("global_rank")]
        public GlobalRankItem GlobalRank { get; set; }

        [JsonProperty("country_rank")]
        public CountryRankItem CountryRank { get; set; }

        [JsonProperty("category_rank")]
        public CategoryRankItem CategoryRank { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("estimated_monthly_visits")]
        public Dictionary<DateTime, long> EstimatedMonthlyVisits { get; set; }

        [JsonProperty("engagments")]
        public EngagmentsItem Engagments { get; set; }

        [JsonProperty("top_country_shares")]
        public List<TopCountrySharesItem> TopCountryShares { get; set; }

        [JsonProperty("total_countries")]
        public int TotalCountries { get; set; }

        [JsonProperty("traffic_sources")]
        public TrafficSourcesItem TrafficSources { get; set; }

        [JsonProperty("referrals_ratio")]
        public decimal ReferralsRatio { get; set; }

        [JsonProperty("top_referring")]
        public List<TopReferringItem> TopReferring { get; set; }

        [JsonProperty("total_referring")]
        public int TotalReferring { get; set; }

        [JsonProperty("top_destinations")]
        public List<TopDestinationsItem> TopDestinations { get; set; }

        [JsonProperty("total_destinations")]
        public int TotalDestinations { get; set; }

        [JsonProperty("search_ratio")]
        public decimal SearchRatio { get; set; }

        [JsonProperty("top_organic_keywords")]
        public List<TopOrganicKeywordsItem> TopOrganicKeywords { get; set; }

        [JsonProperty("top_paid_keywords")]
        public List<TopPaidKeywordsItem> TopPaidKeywords { get; set; }

        [JsonProperty("organic_keywords_rolling_unique_count")]
        public int OrganicKeywordsRollingUniqueCount { get; set; }

        [JsonProperty("paid_keywords_rolling_unique_count")]
        public int PaidKeywordsRollingUniqueCount { get; set; }

        [JsonProperty("organic_search_share")]
        public decimal OrganicSearchShare { get; set; }

        [JsonProperty("paid_search_share")]
        public decimal PaidSearchShare { get; set; }

        [JsonProperty("social_ratio")]
        public decimal SocialRatio { get; set; }

        [JsonProperty("top_social")]
        public List<TopSocialItem> TopSocial { get; set; }

        [JsonProperty("display_ads_ratio")]
        public decimal DisplayAdsRatio { get; set; }

        [JsonProperty("top_publishers")]
        public List<TopPublishersItem> TopPublishers { get; set; }

        [JsonProperty("top_ad_networks")]
        public List<TopAdNetworksItem> TopAdNetworks { get; set; }

        [JsonProperty("incoming_ads_rolling_unique_count")]
        public int IncomingAdsRollingUniqueCount { get; set; }

        [JsonProperty("also_visited_unique_count")]
        public int AlsoVisitedUniqueCount { get; set; }

        [JsonProperty("similar_sites")]
        public List<SimilarSitesItem> SimilarSites { get; set; }

        [JsonProperty("similar_sites_by_rank")]
        public List<SimilarSitesByRankItem> SimilarSitesByRank { get; set; }

        [JsonProperty("mobile_apps")]
        public Dictionary<string, MobileAppsItem> MobileApps { get; set; }

        [JsonProperty("daily_visits_min_date")]
        public DateTime DailyVisitsMinDate { get; set; }

        [JsonProperty("daily_visits_max_date")]
        public DateTime DailyVisitsMaxDate { get; set; }

        [JsonProperty("top_categories")]
        public List<TopCategoriesItem> TopCategories { get; set; }

        [JsonProperty("top_also_visited")]
        public List<string> TopAlsoVisited { get; set; }

        [JsonProperty("tags")]
        public List<TagItem> Tags { get; set; }

        #endregion
    }
}