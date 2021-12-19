using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка по лучшим органическим ключевым словам. 
    /// </summary>
    public class TopOrganicKeywordsItem
    {
        #region Свойства

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        #endregion
    }
}
