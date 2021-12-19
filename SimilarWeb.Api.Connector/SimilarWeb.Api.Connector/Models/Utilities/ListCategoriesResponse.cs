using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Ответ на вызов метода GetListCategories. Содержит список всех категорий сайтов SimilarWeb.
    /// </summary>
    public class ListCategoriesResponse
    {
        #region Свойства

        [JsonProperty("Arts_and_Entertainment")]
        public Dictionary<string, string> ArtsAndEntertainment { get; set; }

        [JsonProperty("Business_and_Consumer_Services")]
        public Dictionary<string, string> BusinessAndConsumerServices { get; set; }

        [JsonProperty("Community_and_Society")]
        public Dictionary<string, string> CommunityAndSociety { get; set; }

        [JsonProperty("Computers_Electronics_and_Technology")]
        public Dictionary<string, string> ComputersElectronicsAndTechnology { get; set; }

        [JsonProperty("E-commerce_and_Shopping")]
        public Dictionary<string, string> CommerceAndShopping { get; set; }

        [JsonProperty("Finance")]
        public Dictionary<string, string> Finance { get; set; }

        [JsonProperty("Food_and_Drink")]
        public Dictionary<string, string> FoodAndDrink { get; set; }

        [JsonProperty("Gambling")]
        public Dictionary<string, string> Gambling { get; set; }

        [JsonProperty("Games")]
        public Dictionary<string, string> Games { get; set; }

        [JsonProperty("Health")]
        public Dictionary<string, string> Health { get; set; }

        [JsonProperty("Heavy_Industry_and_Engineering")]
        public Dictionary<string, string> HeavyIndustryAndEngineering { get; set; }

        [JsonProperty("Hobbies_and_Leisure")]
        public Dictionary<string, string> HobbiesAndLeisure { get; set; }

        [JsonProperty("Home_and_Garden")]
        public Dictionary<string, string> HomeAndGarden { get; set; }

        [JsonProperty("Jobs_and_Career")]
        public Dictionary<string, string> JobsAndCareer { get; set; }

        [JsonProperty("Law_and_Government")]
        public Dictionary<string, string> LawAndGovernment { get; set; }

        [JsonProperty("Lifestyle")]
        public Dictionary<string, string> Lifestyle { get; set; }

        [JsonProperty("News_and_Media")]
        public Dictionary<string, string> NewsAndMedia { get; set; }

        [JsonProperty("Pets_and_Animals")]
        public Dictionary<string, string> PetsAndAnimals { get; set; }

        [JsonProperty("Reference_Materials")]
        public Dictionary<string, string> ReferenceMaterials { get; set; }

        [JsonProperty("Science_and_Education")]
        public Dictionary<string, string> ScienceAndEducation { get; set; }

        [JsonProperty("Sports")]
        public Dictionary<string, string> Sports { get; set; }

        [JsonProperty("Travel_and_Tourism")]
        public Dictionary<string, string> TravelAndTourism { get; set; }

        [JsonProperty("Vehicles")]
        public Dictionary<string, string> Vehicles { get; set; }

        [JsonProperty("Adult")]
        public Dictionary<string, string> Adult { get; set; }

        #endregion
    }
}
