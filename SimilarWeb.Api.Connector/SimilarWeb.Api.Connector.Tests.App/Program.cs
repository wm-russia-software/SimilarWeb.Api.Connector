using Ak.Framework.Core.Extensions;
using Newtonsoft.Json;
using SimilarWeb.Api.Connector.Models.AudienceAnalysis;
using SimilarWeb.Api.Connector.Models.Common;
using SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis;
using SimilarWeb.Api.Connector.Models.DesktopTraffic;
using SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources;
using SimilarWeb.Api.Connector.Models.IndustryAnalysis;
using SimilarWeb.Api.Connector.Models.MobileApps;
using SimilarWeb.Api.Connector.Models.MobileAppsEngagement;
using SimilarWeb.Api.Connector.Models.MobileWebTraffic;
using SimilarWeb.Api.Connector.Models.MobileWebTrafficSources;
using SimilarWeb.Api.Connector.Models.Other;
using SimilarWeb.Api.Connector.Models.SalesSolution;
using SimilarWeb.Api.Connector.Models.SegmentAnalysis;
using SimilarWeb.Api.Connector.Models.TotalTraffic;
using SimilarWeb.Api.Connector.Models.Utilities;
using SimilarWeb.Api.Connector.Models.Webhooks;
using SimilarWeb.Api.Connector.Models.WebsiteContent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace SimilarWeb.Api.Connector.Tests.App
{
    /// <summary>
    /// Основной класс для тестирования.
    /// </summary>
    public static class Program
    {
        #region Свойства

        private static string CountryRu => "ru";
        private static string WebsiteBbc => "bbc.com";

        private static string WebsiteLenta => "lenta.ru";

        private static string CategoryOfArtAndEntMusic => "$Arts_and_Entertainment~Music";

        private static string VendorGoogle => "Google";

        private static string AppWhatsApp => "com.whatsapp";

        private static DateTime LastMonthStartDate => new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);

        private static DateTime LastMonthEndDate => new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 31);

        private static DateTime LastYearStartDate => new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month - 1, 1);

        private static DateTime LastYearEndDate => new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);



        #endregion

        #region Приватные методы

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        private static void Main()
        {
            try
            {
                Console.WriteLine("Test started");
                Console.WriteLine("AudienceAnalysis");
                Check_AudienceAnalysis();
                Console.WriteLine("IndustryAnalysis");
                Check_IndustryAnalysis();
                Console.WriteLine("DesktopKeywordAnalysis");
                Check_DesktopKeywordAnalysis();
                Console.WriteLine("DesktopTraffic");
                Check_DesktopTraffic();
                Console.WriteLine("DesktopTrafficSources");
                Check_DesktopTrafficSources();
                Console.WriteLine("MobileApps");
                Check_MobileApps();
                Console.WriteLine("MobileAppsEngagement");
                Check_MobileAppsEngagement();
                Console.WriteLine("MobileWebTraffic");
                Check_MobileWebTraffic();
                Console.WriteLine("MobileWebTrafficSources");
                Check_MobileWebTrafficSources();
                Console.WriteLine("Other");
                Check_Other();
                Console.WriteLine("SalesSolution");
                Check_SalesSolution();
                Console.WriteLine("SegmentAnalysis");
                Check_SegmentAnalysis();
                Console.WriteLine("TotalTraffic");
                Check_TotalTraffic();
                Console.WriteLine("Utilities");
                Check_Utilities();
                Console.WriteLine("WebsiteContent");
                Check_WebsiteContent();
                Console.WriteLine("Webhooks");
                Check_Webhooks();

            }
            catch (Exception ex)
            {
                LogEx(ex);
            }

            Console.WriteLine("Test finished");
            Console.ReadKey();
        }

        /// <summary>
        /// Проверка группы методов AudienceAnalysis.
        /// </summary>
        private static void Check_AudienceAnalysis()
        {
            AudienceAnalysis audienceAnalysis = new AudienceAnalysis(Settings.SimilarWebApiKey);

            AudienceInterestsParameters audienceInterestsParameters = new AudienceInterestsParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                MainDomainOnly = false,
                Website = WebsiteLenta
            };
            Models.AudienceAnalysis.AudienceInterestsResponse audienceInterestsResponse = audienceAnalysis.GetAudienceInterest(audienceInterestsParameters);
            Test(audienceInterestsResponse);

            AudienceOverlapParameters audienceOverlapParameters = new AudienceOverlapParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Domains = new List<string>
                {
                    "adidas.com",
                    "nike.com",
                    "footlocker.com"
                }
            };
            AudienceOverlapResponse audienceOverlapResponse = audienceAnalysis.GetAudienceOverlap(audienceOverlapParameters);
            Test(audienceOverlapResponse);

            DesktopDemographicsAgeParameters desktopDemographicsAgeParameters = new DesktopDemographicsAgeParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteLenta

            };
            DesktopDemographicsAgeResponse desktopDemographicsAgeResponse = audienceAnalysis.GetDesktopDemographicsAge(desktopDemographicsAgeParameters);
            Test(desktopDemographicsAgeResponse);

            DesktopDemographicsGenderParameters desktopDemographicsGenderParameters = new DesktopDemographicsGenderParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteLenta
            };
            DesktopDemographicsGenderResponse desktopDemographicsGenderResponse = audienceAnalysis.GetDesktopDemographicsGender(desktopDemographicsGenderParameters);
            Test(desktopDemographicsGenderResponse);

            MobileWebDemographicsAgeParameters mobileWebDemographicsAgeParameters = new MobileWebDemographicsAgeParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteLenta
            };
            MobileWebDemographicsAgeResponse mobileWebDemographicsAgeResponse = audienceAnalysis.GetMobileWebDemographicsAge(mobileWebDemographicsAgeParameters);
            Test(mobileWebDemographicsAgeResponse);

            MobileWebDemographicsGenderParameters mobileWebDemographicsGenderParameters = new MobileWebDemographicsGenderParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteLenta
            };
            MobileWebDemographicsGenderResponse mobileWebDemographicsGenderResponse = audienceAnalysis.GetMobileWebDemographicsGender(mobileWebDemographicsGenderParameters);
            Test(mobileWebDemographicsGenderResponse);

            NewVsReturningParameters newVsReturningParameters = new NewVsReturningParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteLenta
            };
            NewVsReturningResponse newVsReturningResponse = audienceAnalysis.GetNewVsReturning(newVsReturningParameters);
            Test(newVsReturningResponse);
        }

        private static void Check_IndustryAnalysis()
        {
            IndustryAnalysis industryAnalysis = new IndustryAnalysis(Settings.SimilarWebApiKey);

            TopSitesDesktopParameters topSitesDesktopParameters = new TopSitesDesktopParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = CategoryOfArtAndEntMusic
            };
            TopSitesDesktopResponse topSitesDesktopResponse = industryAnalysis.GetTopSitesDesktop(topSitesDesktopParameters);
            Test(topSitesDesktopResponse);

            TopSitesDesktopAndMobileParameters topSitesDesktopAndMobileParameters = new TopSitesDesktopAndMobileParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = CategoryOfArtAndEntMusic
            };
            TopSitesDesktopAndMobileResponse topSitesDesktopAndMobileResponse = industryAnalysis.GetTopSitesDesktopAndMobile(topSitesDesktopAndMobileParameters);
            Test(topSitesDesktopAndMobileResponse);

            TopSitesMobileParameters topSitesMobileParameters = new TopSitesMobileParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = CategoryOfArtAndEntMusic
            };
            TopSitesMobileResponse topSitesMobileResponse = industryAnalysis.GetTopSitesMobile(topSitesMobileParameters);
            Test(topSitesMobileResponse);
        }

        private static void Check_DesktopKeywordAnalysis()
        {
            DesktopKeywordAnalysis desktopKeywordAnalysis = new DesktopKeywordAnalysis(Settings.SimilarWebApiKey);

            KeywordAnalysisOrganicCompetitorsParameters keywordAnalysisOrganicCompetitorsParameters = new KeywordAnalysisOrganicCompetitorsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Keyword = "car",
                Limit = 100,
                Metrics = new List<KeywordAnalysisMetrics>
                {
                    KeywordAnalysisMetrics.Cpc,
                    KeywordAnalysisMetrics.OrganicVsPaid,
                    KeywordAnalysisMetrics.Traffic,
                    KeywordAnalysisMetrics.Volume
                }
            };
            KeywordAnalysisOrganicCompetitorsResponse keywordAnalysisOrganicCompetitorsResponse = desktopKeywordAnalysis.GetKeywordAnalysisOrganicCompetitors(keywordAnalysisOrganicCompetitorsParameters);
            Test(keywordAnalysisOrganicCompetitorsResponse);

            KeywordAnalysisPaidCompetitorsParameters keywordAnalysisPaidCompetitorsParameters = new KeywordAnalysisPaidCompetitorsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Keyword = "car",
                Limit = 100,
                Metrics = new List<KeywordAnalysisMetrics>
                {
                    KeywordAnalysisMetrics.Cpc,
                    KeywordAnalysisMetrics.OrganicVsPaid,
                    KeywordAnalysisMetrics.Traffic,
                    KeywordAnalysisMetrics.Volume
                }
            };
            KeywordAnalysisPaidCompetitorsResponse keywordAnalysisPaidCompetitorsResponse = desktopKeywordAnalysis.GetKeywordAnalysisPaidCompetitors(keywordAnalysisPaidCompetitorsParameters);
            Test(keywordAnalysisPaidCompetitorsResponse);

            KeywordCompetitorsOrganicParameters keywordCompetitorsOrganicParameters = new KeywordCompetitorsOrganicParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteBbc
            };
            KeywordCompetitorsOrganicResponse keywordCompetitorsOrganicResponse = desktopKeywordAnalysis.GetKeywordCompetitorsOrganic(keywordCompetitorsOrganicParameters);
            Test(keywordCompetitorsOrganicResponse);

            KeywordCompetitorsPaidParameters keywordCompetitorsPaidParameters = new KeywordCompetitorsPaidParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            KeywordCompetitorsPaidResponse keywordCompetitorsPaidResponse = desktopKeywordAnalysis.GetKeywordCompetitorsPaid(keywordCompetitorsPaidParameters);
            Test(keywordCompetitorsPaidResponse);
        }

        private static void Check_DesktopTraffic()
        {
            DesktopTraffic desktopTraffic = new DesktopTraffic(Settings.SimilarWebApiKey);

            Models.DesktopTraffic.AverageVisitDurationParameters averageVisitDurationParameters = new Models.DesktopTraffic.AverageVisitDurationParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            Models.DesktopTraffic.AverageVisitDurationResponse averageVisitDurationResponse = desktopTraffic.GetAverageVisitDuration(averageVisitDurationParameters);
            Test(averageVisitDurationResponse);

            Models.DesktopTraffic.BounceRateParameters bounceRateParameters = new Models.DesktopTraffic.BounceRateParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            Models.DesktopTraffic.BounceRateResponse bounceRateResponse = desktopTraffic.GetBounceRate(bounceRateParameters);
            Test(bounceRateResponse);

            CountryRankParameters countryRankParameters = new CountryRankParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            CountryRankResponse countryRankResponse = desktopTraffic.GetCountryRank(countryRankParameters);
            Test(countryRankResponse);

            DesktopPagesPerVisitParameters desktopPagesPerVisitParameters = new DesktopPagesPerVisitParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            DesktopPagesPerVisitResponse desktopPagesPerVisitResponse = desktopTraffic.GetDesktopPagesPerVisit(desktopPagesPerVisitParameters);
            Test(desktopPagesPerVisitResponse);

            DesktopUniqueVisitorsParameters desktopUniqueVisitorsParameters = new DesktopUniqueVisitorsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            DesktopUniqueVisitorsResponse desktopUniqueVisitorsResponse = desktopTraffic.GetDesktopUniqueVisitors(desktopUniqueVisitorsParameters);
            Test(desktopUniqueVisitorsResponse);

            DesktopVisitsParameters desktopVisitsParameters = new DesktopVisitsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            DesktopVisitsResponse desktopVisitsResponse = desktopTraffic.GetDesktopVisits(desktopVisitsParameters);
            Test(desktopVisitsResponse);

            GeographyDistributionParameters geographyDistributionParameters = new GeographyDistributionParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            GeographyDistributionResponse geographyDistributionResponse = desktopTraffic.GetGeographyDistribution(geographyDistributionParameters);
            Test(geographyDistributionResponse);

            GlobalRankParameters globalRankParameters = new GlobalRankParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            GlobalRankResponse globalRankResponse = desktopTraffic.GetGlobalRank(globalRankParameters);
            Test(globalRankResponse);
        }

        private static void Check_DesktopTrafficSources()
        {
            DesktopWebTrafficSources desktopWebTrafficSources = new DesktopWebTrafficSources(Settings.SimilarWebApiKey);

            DesktopAdNetworksParameters desktopAdNetworksParameters = new DesktopAdNetworksParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopAdNetworksResponse desktopAdNetworksResponse = desktopWebTrafficSources.GetDesktopAdNetworks(desktopAdNetworksParameters);
            Test(desktopAdNetworksResponse);

            DesktopBrandedKeywordsParameters desktopBrandedKeywordsParameters = new DesktopBrandedKeywordsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            DesktopBrandedKeywordsResponse desktopBrandedKeywordsResponse = desktopWebTrafficSources.GetDesktopBrandedKeywords(desktopBrandedKeywordsParameters);
            Test(desktopBrandedKeywordsResponse);

            DesktopDisplayPublishersParameters desktopDisplayPublishersParameters = new DesktopDisplayPublishersParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopDisplayPublishersResponse desktopDisplayPublishersResponse = desktopWebTrafficSources.GetDesktopDisplayPublishers(desktopDisplayPublishersParameters);
            Test(desktopDisplayPublishersResponse);

            // Выполняется почти минуту.
            DesktopNonBrandedKeywordsParameters desktopNonBrandedKeywordsParameters = new DesktopNonBrandedKeywordsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            DesktopNonBrandedKeywordsResponse desktopNonBrandedKeywordsResponse = desktopWebTrafficSources.GetDesktopNonBrandedKeywords(desktopNonBrandedKeywordsParameters);
            Test(desktopNonBrandedKeywordsResponse);

            DesktopOrganicOutgoingLinksParameters desktopOrganicOutgoingLinksParameters = new DesktopOrganicOutgoingLinksParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopOrganicOutgoingLinksResponse desktopOrganicOutgoingLinksResponse = desktopWebTrafficSources.GetDesktopOrganicOutgoingLinks(desktopOrganicOutgoingLinksParameters);
            Test(desktopOrganicOutgoingLinksResponse);

            DesktopOrganicSearchKeywordsParameters desktopOrganicSearchKeywordsParameters = new DesktopOrganicSearchKeywordsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            DesktopOrganicSearchKeywordsResponse desktopOrganicSearchKeywordsResponse = desktopWebTrafficSources.GetDesktopOrganicSearchKeywords(desktopOrganicSearchKeywordsParameters);
            Test(desktopOrganicSearchKeywordsResponse);

            DesktopOutgoingAdsAdNetworksParameters desktopOutgoingAdsAdNetworksParameters = new DesktopOutgoingAdsAdNetworksParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopOutgoingAdsAdNetworksResponse desktopOutgoingAdsAdNetworksResponse = desktopWebTrafficSources.GetDesktopOutgoingAdsAdNetworks(desktopOutgoingAdsAdNetworksParameters);
            Test(desktopOutgoingAdsAdNetworksResponse);

            DesktopOutgoingAdsAdvertisersParameters desktopOutgoingAdsAdvertisersParameters = new DesktopOutgoingAdsAdvertisersParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopOutgoingAdsAdvertisersResponse desktopOutgoingAdsAdvertisersResponse = desktopWebTrafficSources.GetDesktopOutgoingAdsAdvertisers(desktopOutgoingAdsAdvertisersParameters);
            Test(desktopOutgoingAdsAdvertisersResponse);

            DesktopPaidSearchKeywordsParameters desktopPaidSearchKeywordsParameters = new DesktopPaidSearchKeywordsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            DesktopPaidSearchKeywordsResponse desktopPaidSearchKeywordsResponse = desktopWebTrafficSources.GetDesktopPaidSearchKeywords(desktopPaidSearchKeywordsParameters);
            Test(desktopPaidSearchKeywordsResponse);

            DesktopPublishersPerAdNetworkParameters desktopPublishersPerAdNetworkParameters = new DesktopPublishersPerAdNetworkParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopPublishersPerAdNetworkResponse desktopPublishersPerAdNetworkResponse = desktopWebTrafficSources.GetDesktopPublishersPerAdNetwork(desktopPublishersPerAdNetworkParameters);
            Test(desktopPublishersPerAdNetworkResponse);

            DesktopQuestionsKeywordsParameters desktopQuestionsKeywordsParameters = new DesktopQuestionsKeywordsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            DesktopQuestionsKeywordsResponse desktopQuestionsKeywordsResponse = desktopWebTrafficSources.GetDesktopQuestionsKeywords(desktopQuestionsKeywordsParameters);
            Test(desktopQuestionsKeywordsResponse);

            DesktopReferralsParameters desktopReferralsParameters = new DesktopReferralsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopReferralsResponse desktopReferralsResponse = desktopWebTrafficSources.GetDesktopReferals(desktopReferralsParameters);
            Test(desktopReferralsResponse);

            DesktopSocialReferralsParameters desktopSocialReferralsParameters = new DesktopSocialReferralsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopSocialReferralsResponse desktopSocialReferralsResponse = desktopWebTrafficSources.GetDesktopSocialReferrals(desktopSocialReferralsParameters);
            Test(desktopSocialReferralsResponse);

            DesktopTrafficSourcesOverviewParameters desktopTrafficSourcesOverviewParameters = new DesktopTrafficSourcesOverviewParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopTrafficSourcesOverviewResponse desktopTrafficSourcesOverviewResponse = desktopWebTrafficSources.GetDesktopTrafficSourcesOverview(desktopTrafficSourcesOverviewParameters);
            Test(desktopTrafficSourcesOverviewResponse);

            DesktopTrafficSourcesParameters desktopTrafficSourcesParameters = new DesktopTrafficSourcesParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            DesktopTrafficSourcesResponse desktopTrafficSourcesResponse = desktopWebTrafficSources.GetDesktopTrafficSources(desktopTrafficSourcesParameters);
            Test(desktopTrafficSourcesResponse);

            EngagementMetricsAverageVisitDurationParameters engagementMetricsAverageVisitDurationParameters = new EngagementMetricsAverageVisitDurationParameters()
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            EngagementMetricsAverageVisitDurationResponse engagementMetricsAverageVisitDurationResponse = desktopWebTrafficSources.GetEngagementMetricsAverageVisitDuration(engagementMetricsAverageVisitDurationParameters);
            Test(engagementMetricsAverageVisitDurationResponse);

            EngagementMetricsBounceRateParameters engagementMetricsBounceRateParameters = new EngagementMetricsBounceRateParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            EngagementMetricsBounceRateResponse engagementMetricsBounceRateResponse = desktopWebTrafficSources.GetEngagementMetricsBounceRate(engagementMetricsBounceRateParameters);
            Test(engagementMetricsBounceRateResponse);

            EngagementMetricsPagesPerVisitParameters engagementMetricsPagesPerVisitParameters = new EngagementMetricsPagesPerVisitParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Website = WebsiteBbc
            };
            EngagementMetricsPagesPerVisitResponse engagementMetricsPagesPerVisitResponse = desktopWebTrafficSources.GetEngagementMetricsPagesPerVisit(engagementMetricsPagesPerVisitParameters);
            Test(engagementMetricsPagesPerVisitResponse);

            SearchVisitsDistributionDesktopParameters searchVisitsDistributionDesktopParameters = new SearchVisitsDistributionDesktopParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Limit = 100,
                Website = WebsiteBbc
            };
            SearchVisitsDistributionDesktopResponse searchVisitsDistributionDesktopResponse = desktopWebTrafficSources.GetSearchVisitsDistributionDesktop(searchVisitsDistributionDesktopParameters);
            Test(searchVisitsDistributionDesktopResponse);
        }

        private static void Check_MobileApps()
        {
            MobileApps mobileApps = new MobileApps(Settings.SimilarWebApiKey);

            AppDetailsParameters appDetailsParameters = new AppDetailsParameters
            {
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            AppDetailsResponse appDetailsResponse = mobileApps.GetAppDetails(appDetailsParameters);
            Test(appDetailsResponse);

            AppRankParameters appRankParameters = new AppRankParameters
            {
                Country = CountryRu,
                Category = Category.All,
                Mode = Mode.Free,
                Device = Device.AndroidPhone,
                Duration = 90,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            AppRankResponse appRankResponse = mobileApps.GetAppRank(appRankParameters);
            Test(appRankResponse);

            AudienceInterestParameters audienceInterestsParameters = new AudienceInterestParameters
            {
                Country = CountryRu,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            Models.MobileApps.AudienceInterestsResponse audienceInterestsResponse = mobileApps.GetAudienceInterests(audienceInterestsParameters);
            Test(audienceInterestsResponse);

            RelatedSitesParameters relatedSitesParameters = new RelatedSitesParameters
            {
                Country = CountryRu,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            RelatedSitesResponse relatedSitesResponse = mobileApps.GetRelatedSites(relatedSitesParameters);
            Test(relatedSitesResponse);

            SiteRelatedAppsParameters siteRelatedAppsParameters = new SiteRelatedAppsParameters
            {
                Store = StoreUppercase.Google,
                Website = WebsiteBbc
            };
            SiteRelatedAppsResponse siteRelatedAppsResponse = mobileApps.GetSiteRelatedApps(siteRelatedAppsParameters);
            Test(siteRelatedAppsResponse);

            TopAndroidAppsUsageParameters topAndroidAppsUsageParameters = new TopAndroidAppsUsageParameters
            {
                Country = CountryRu,
                Category = CategoryUppercase.All,
                Mode = Mode.Free,
                Device = Device.AndroidPhone,
                Vendor = VendorGoogle
            };
            TopAndroidAppsUsageResponse topAndroidAppsUsageResponse = mobileApps.GetTopAndroidAppsUsage(topAndroidAppsUsageParameters);
            Test(topAndroidAppsUsageResponse);

            TopAppStoresParameters topAppStoresParameters = new TopAppStoresParameters
            {
                Country = "us",
                Category = CategoryUppercase.All,
                Mode = Mode.TopPaidIPad,
                Device = Device.Ipad,
                Store = Store.Apple
            };
            TopAppStoresResponse topAppStoresResponse = mobileApps.GetTopAppStores(topAppStoresParameters);
            Test(topAppStoresResponse);
        }

        private static void Check_MobileAppsEngagement()
        {
            MobileAppsEngagement mobileAppsEngagement = new MobileAppsEngagement(Settings.SimilarWebApiKey);

            AppDemographicsAgeParameters appDemographicsAgeParameters = new AppDemographicsAgeParameters
            {
                Country = CountryRu,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            AppDemographicsAgeResponse appDemographicsAgeResponse = mobileAppsEngagement.GetAppDemographicsAge(appDemographicsAgeParameters);
            Test(appDemographicsAgeResponse);

            AppDemographicsGenderParameters appDemographicsGenderParameters = new AppDemographicsGenderParameters
            {
                Country = CountryRu,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            AppDemographicsGenderResponse appDemographicsGenderResponse = mobileAppsEngagement.GetAppDemographicsGender(appDemographicsGenderParameters);
            Test(appDemographicsGenderResponse);

            AppDownloadsParameters appDownloadsParameters = new AppDownloadsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Granularity = Granularity.Monthly,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            AppDownloadsResponse appDownloadsResponse = mobileAppsEngagement.GetAppDownloads(appDownloadsParameters);
            Test(appDownloadsResponse);

            DailyActiveUsersParameters dailyActiveUsersParameters = new DailyActiveUsersParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Granularity = Granularity.Monthly,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            DailyActiveUsersResponse dailyActiveUsersResponse = mobileAppsEngagement.GetDailyActiveUsers(dailyActiveUsersParameters);
            Test(dailyActiveUsersResponse);

            InstallPenetrationParameters installPenetrationParameters = new InstallPenetrationParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Granularity = Granularity.Monthly,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            InstallPenetrationResponse installPenetrationResponse = mobileAppsEngagement.GetInstallPenetration(installPenetrationParameters);
            Test(installPenetrationResponse);

            MonthlyActiveUsersAndroidParameters monthlyActiveUsersAndroidParameters = new MonthlyActiveUsersAndroidParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Granularity = Granularity.Monthly,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            MonthlyActiveUsersAndroidResponse monthlyActiveUsersAndroidResponse = mobileAppsEngagement.GetMonthlyActiveUsersAndroid(monthlyActiveUsersAndroidParameters);
            Test(monthlyActiveUsersAndroidResponse);

            MonthlyActiveUsersIOSParameters monthlyActiveUsersIOSParameters = new MonthlyActiveUsersIOSParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = "us",
                Granularity = Granularity.Monthly,
                Vendor = "Apple",
                Application = "310633997"
            };
            MonthlyActiveUsersIOSResponse monthlyActiveUsersIOSResponse = mobileAppsEngagement.GetMonthlyActiveUsersIOS(monthlyActiveUsersIOSParameters);
            Test(monthlyActiveUsersIOSResponse);

            UniqueInstallsParameters uniqueInstallsParameters = new UniqueInstallsParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Country = CountryRu,
                Granularity = Granularity.Monthly,
                Vendor = VendorGoogle,
                Application = AppWhatsApp
            };
            UniqueInstallsResponse uniqueInstallsResponse = mobileAppsEngagement.GetUniqueInstalls(uniqueInstallsParameters);
            Test(uniqueInstallsResponse);
        }

        private static void Check_MobileWebTraffic()
        {
            MobileWebTraffic mobileWebTraffic = new MobileWebTraffic(Settings.SimilarWebApiKey);

            MobileWebAverageVisitDurationParameters mobileWebAverageVisitDurationParameters = new MobileWebAverageVisitDurationParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebAverageVisitDurationResponse mobileWebAverageVisitDurationResponse = mobileWebTraffic.GetMobileWebAverageVisitDuration(mobileWebAverageVisitDurationParameters);
            Test(mobileWebAverageVisitDurationResponse);

            MobileWebBounceRateParameters mobileWebBounceRateParameters = new MobileWebBounceRateParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebBounceRateResponse mobileWebBounceRateResponse = mobileWebTraffic.GetMobileWebBounceRate(mobileWebBounceRateParameters);
            Test(mobileWebBounceRateResponse);

            MobileWebPagesPerVisitParameters mobileWebPagesPerVisitParameters = new MobileWebPagesPerVisitParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebPagesPerVisitResponse mobileWebPagesPerVisitResponse = mobileWebTraffic.GetMobileWebPagesPerVisit(mobileWebPagesPerVisitParameters);
            Test(mobileWebPagesPerVisitResponse);

            MobileWebUniqueVisitorsParameters mobileWebUniqueVisitorsParameters = new MobileWebUniqueVisitorsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebUniqueVisitorsResponse mobileWebUniqueVisitorsResponse = mobileWebTraffic.GetMobileWebUniqueVisitors(mobileWebUniqueVisitorsParameters);
            Test(mobileWebUniqueVisitorsResponse);

            MobileWebVisitsParameters mobileWebVisitsParameters = new MobileWebVisitsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebVisitsResponse mobileWebVisitsResponse = mobileWebTraffic.GetMobileWebVisits(mobileWebVisitsParameters);
            Test(mobileWebVisitsResponse);
        }

        private static void Check_MobileWebTrafficSources()
        {
            MobileWebTrafficSources mobileWebTrafficSources = new MobileWebTrafficSources(Settings.SimilarWebApiKey);

            MobileWebKeywordsParameters mobileWebKeywordsParameters = new MobileWebKeywordsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Limit = 100,
                Website = WebsiteBbc
            };
            MobileWebKeywordsResponse mobileWebKeywordsResponse = mobileWebTrafficSources.GetMobileWebKeywords(mobileWebKeywordsParameters);
            Test(mobileWebKeywordsResponse);

            MobileWebReferralsParameters mobileWebReferralsParameters = new MobileWebReferralsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebReferralsResponse mobileWebReferralsResponse = mobileWebTrafficSources.GetMobileWebReferrals(mobileWebReferralsParameters);
            Test(mobileWebReferralsResponse);

            MobileWebTrafficSourcesOverviewParameters mobileWebTrafficSourcesOverviewParameters = new MobileWebTrafficSourcesOverviewParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            MobileWebTrafficSourcesOverviewResponse mobileWebTrafficSourcesOverviewResponse = mobileWebTrafficSources.GetMobileWebTrafficSourcesOverview(mobileWebTrafficSourcesOverviewParameters);
            Test(mobileWebTrafficSourcesOverviewResponse);

            SearchVisitsDistributionMobileParameters searchVisitsDistributionMobileParameters = new SearchVisitsDistributionMobileParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            SearchVisitsDistributionMobileResponse searchVisitsDistributionMobileResponse = mobileWebTrafficSources.GetSearchVisitsDistributionMobile(searchVisitsDistributionMobileParameters);
            Test(searchVisitsDistributionMobileResponse);
        }

        private static void Check_Other()
        {
            Other other = new Other(Settings.SimilarWebApiKey);

            ApiLiteParameters apiLiteParameters = new ApiLiteParameters
            {
                Website = WebsiteBbc
            };
            ApiLiteResponse apiLiteResponse = other.GetApiLite(apiLiteParameters);
            Test(apiLiteResponse);

            CategoryRankParameters categoryRanksParameters = new CategoryRankParameters
            {
                Website = WebsiteBbc
            };
            CategoryRankResponse categoryRankResponse = other.GetCategoryRanks(categoryRanksParameters);
            Test(categoryRankResponse);

            SimilarSitesParameters similarSitesParameters = new SimilarSitesParameters
            {
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            SimilarSitesResponse similarSitesResponse = other.GetSimilarSites(similarSitesParameters);
            Test(similarSitesResponse);

            WebsiteDescriptionParameters websiteDescriptionParameters = new WebsiteDescriptionParameters
            {
                Website = WebsiteBbc
            };
            WebsiteDescriptionResponse websiteDescriptionResponse = other.GetWebsiteDescription(websiteDescriptionParameters);
            Test(websiteDescriptionResponse);
        }

        private static void Check_SalesSolution()
        {
            SalesSolution salesSolution = new SalesSolution(Settings.SimilarWebApiKey);

            LeadEnrichmentParameters leadEnrichmentParameters = new LeadEnrichmentParameters
            {
                Country = CountryRu,
                StartDate = LastMonthStartDate,
                EndDate = LastMonthEndDate,
                Website = WebsiteBbc
            };
            LeadEnrichmentResponse leadEnrichmentResponse = salesSolution.GetLeadEnrichment(leadEnrichmentParameters);
            Test(leadEnrichmentResponse);

            TechnographicsParameters technographicsParameters = new TechnographicsParameters
            {
                Website = WebsiteBbc
            };
            TechnographicsResponse technographicsResponse = salesSolution.GetTechnographics(technographicsParameters);
            Test(technographicsResponse);
        }

        private static void Check_SegmentAnalysis()
        {
            SegmentAnalysis segmentAnalysis = new SegmentAnalysis(Settings.SimilarWebApiKey);

            ListSegmentsParameters listSegmentParameters = new ListSegmentsParameters
            {

            };
            ListSegmentsResponse listSegmentResponse = segmentAnalysis.GetListSegment(listSegmentParameters);
            Test(listSegmentResponse);

            SegmentTrafficAndEngagementParameters segmentTrafficAndEngagementParameters = new SegmentTrafficAndEngagementParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Metrics = new List<SegmentTrafficAndEngagementMetrics>
                {
                    SegmentTrafficAndEngagementMetrics.Visits,
                    SegmentTrafficAndEngagementMetrics.Share,
                    SegmentTrafficAndEngagementMetrics.PagesPerVisit,
                    SegmentTrafficAndEngagementMetrics.PageViews,
                    SegmentTrafficAndEngagementMetrics.BounceRate,
                    SegmentTrafficAndEngagementMetrics.VisitDuration,
                    SegmentTrafficAndEngagementMetrics.UniqueVisitors
                },
                SegmentId = listSegmentResponse.Response.Segments[0].SegmentId // or "07008669-e042-42de-9d85-6f6474221559"
            };
            SegmentTrafficAndEngagementResponse segmentTrafficAndEngagementResponse = segmentAnalysis.GetSegmentTrafficAndEngagement(segmentTrafficAndEngagementParameters);
            Test(segmentTrafficAndEngagementResponse);

            ListSegmentsConversionAnalysisParameters listSegmentsConversionAnalysisParameters = new ListSegmentsConversionAnalysisParameters
            {

            };
            ListSegmentsConversionAnalysisResponse listSegmentsConversionAnalysisResponse = segmentAnalysis.GetListSegmentsConversionAnalysis(listSegmentsConversionAnalysisParameters);
            Test(listSegmentsConversionAnalysisResponse);

            ListSegmentsConversionAnalysisSegment ikeaItem = listSegmentsConversionAnalysisResponse.Response.Segments.First(x => x.Site == "ikea.com");
            ConversionAnalysisParameters conversionAnalysisParameters = new ConversionAnalysisParameters
            {
                Channel = "total",
                Country = ikeaItem?.AvailableCountries?.FirstOrDefault(x => x == "RU")?.ToLower(),
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Metrics = new List<ConversionAnalysisMetrics>
                {
                    ConversionAnalysisMetrics.Visits,
                    ConversionAnalysisMetrics.ConvertedVisits,
                    ConversionAnalysisMetrics.ConversionRate,
                    ConversionAnalysisMetrics.Stickiness
                },
                SegmentId = ikeaItem?.SegmentId
            };
            ConversionAnalysisResponse conversionAnalysisResponse = segmentAnalysis.GetConversionAnalysis(conversionAnalysisParameters);
            Test(conversionAnalysisResponse);
        }

        private static void Check_TotalTraffic()
        {
            TotalTraffic totalTraffic = new TotalTraffic(Settings.SimilarWebApiKey);

            Models.TotalTraffic.AverageVisitDurationParameters averageVisitDurationParameters = new Models.TotalTraffic.AverageVisitDurationParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            Models.TotalTraffic.AverageVisitDurationResponse averageVisitDurationResponse = totalTraffic.GetAverageVisitDuration(averageVisitDurationParameters);
            Test(averageVisitDurationResponse);

            Models.TotalTraffic.BounceRateParameters bounceRateParameters = new Models.TotalTraffic.BounceRateParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            Models.TotalTraffic.BounceRateResponse bounceRateResponse = totalTraffic.GetBounceRate(bounceRateParameters);
            Test(bounceRateResponse);

            DeduplicatedAudienceParameters deduplicatedAudienceParameters = new DeduplicatedAudienceParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            DeduplicatedAudienceResponse deduplicatedAudienceResponse = totalTraffic.GetDeduplicatedAudience(deduplicatedAudienceParameters);
            Test(deduplicatedAudienceResponse);

            DesktopVsMobileSplitParameters desktopVsMobileSplitParameters = new DesktopVsMobileSplitParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            DesktopVsMobileSplitResponse desktopVsMobileSplitResponse = totalTraffic.GetDesktopVsMobileSplit(desktopVsMobileSplitParameters);
            Test(desktopVsMobileSplitResponse);

            PagesPerVisitParameters pagesPerVisitParameters = new PagesPerVisitParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            PagesPerVisitResponse pagesPerVisitResponse = totalTraffic.GetPagesPerVisit(pagesPerVisitParameters);
            Test(pagesPerVisitResponse);

            VisitsParameters visitsParameters = new VisitsParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            VisitsResponse visitsResponse = totalTraffic.GetVisits(visitsParameters);
            Test(visitsResponse);
        }

        private static void Check_Utilities()
        {
            Utilities utilities = new Utilities(Settings.SimilarWebApiKey);
            CheckCapabilitiesParameters checkCapabilitiesParameters = new CheckCapabilitiesParameters
            {

            };
            CheckCapabilitiesResponse checkCapabilitiesResponse = utilities.GetCheckCapabilities(checkCapabilitiesParameters);
            Test(checkCapabilitiesResponse);

            ListCategoriesParameters listCategoriesParameters = new ListCategoriesParameters
            {

            };
            ListCategoriesResponse listCategoriesResponse = utilities.GetListCategories(listCategoriesParameters);
            Test(listCategoriesResponse);
        }

        private static void Check_WebsiteContent()
        {
            WebsiteContent websiteContent = new WebsiteContent(Settings.SimilarWebApiKey);

            SubdomainsDesktopParameters subdomainsDesktopParameters = new SubdomainsDesktopParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            SubdomainsDesktopResponse subdomainsDesktopResponse = websiteContent.GetSubdomainsDesktop(subdomainsDesktopParameters);
            Test(subdomainsDesktopResponse);

            SubdomainsMobileWebParameters subdomainsMobileWebParameters = new SubdomainsMobileWebParameters
            {
                Country = CountryRu,
                StartDate = LastYearStartDate,
                EndDate = LastYearEndDate,
                Website = WebsiteBbc
            };
            SubdomainsMobileWebResponse subdomainsMobileWebResponse = websiteContent.GetSubdomainsMobileWeb(subdomainsMobileWebParameters);
            Test(subdomainsMobileWebResponse);
        }

        private static void Check_Webhooks()
        {
            Webhooks webhooks = new Webhooks(Settings.SimilarWebApiKey);

            // Авторизация не проходит с ошибкой HTTP/1.1 406 Not Acceptable.         
            AuthorizeParameters authorizeParameters = new AuthorizeParameters
            {

            };
            HttpStatusCode httpStatusCode = webhooks.Authorize(authorizeParameters);
            Test(httpStatusCode);

            // На запрос, в любой конфигурации параметров, отвечает: "HTTP/1.1 400 Bad Request Unsupported Webhook event type" возможно метод еще не готов.
            SubscribeParameters subscribeParameters = new SubscribeParameters
            {

            };
            SubscribeRequest subscribeRequest = new SubscribeRequest
            {
                Url = WebsiteLenta,
                WebHookEventType = WebHookEventType.Monthly
            };
            SubscribeResponse subscribeResponse = webhooks.Subscribe(subscribeParameters, subscribeRequest);
            Test(subscribeResponse);

            // Выдает пустой список '[]', как после сериализации new object();
            GetListParameters getListParameters = new GetListParameters
            {

            };
            GetListResponse getListResponse = webhooks.GetList(getListParameters);
            Test(getListResponse);

            // Нет подписки для того чтобы отписаться.
            UnSubscribeParameters unSubscribeParameters = new UnSubscribeParameters
            {
                SubscriptionId = getListResponse.GetListDataListItems[0].SubscriptionId
            };
            httpStatusCode = webhooks.UnSubscribe(unSubscribeParameters);
            Test(httpStatusCode);
        }

        private static void LogEx(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Invoke parameters: {JsonConvert.SerializeObject(ex.Data["RequestParameters"], Formatting.Indented)}");
        }

        /// <summary>
        /// Тестирование полученного объекта.
        /// </summary>
        /// <param name="testObject">объект для тестирования.</param>
        private static void Test(object testObject)
        {
            if (testObject == null)
            {
                Console.WriteLine("Object is null.");
                return;
            }

            List<PropertyInfo> propertyInfos = testObject
                .GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToList();

            // Если объект список, и он пуст, пишем в консоль. 
            propertyInfos.Where(x => IsIList(x.GetValue(testObject)))
                .ForEach(x =>
                    {
                        if (x != null && ((IList)x.GetValue(testObject))?.Count == 0)
                        {
                            Console.WriteLine($"Object {testObject} has empty list {x}.");
                        }
                    }
                );
        }

        /// <summary>
        /// Определяет реализует ли объект интерфейс списка.
        /// </summary>
        /// <param name="checkObject">Объект для проверки.</param>
        private static bool IsIList(object checkObject)
        {
            return !checkObject.GetType()
                .GetInterfaces()
                .Where(x => x == typeof(IList))
                .IsEmpty();
        }

        #endregion
    }
}
