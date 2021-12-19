﻿using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Элемент списка поиска по ключевым словам.
    /// </summary>
    public class Search
    {
        #region Свойства

        [JsonProperty("search_term")]
        public string SearchTerm { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("visits")]
        public decimal? Visits { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        [JsonProperty("cpc")]
        public decimal Cpc { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        #endregion
    }
}
