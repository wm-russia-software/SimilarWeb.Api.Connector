using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка по лучшим платным ключевым словам.
    /// </summary>
    public class TopPaidKeywordsItem
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
