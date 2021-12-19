using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Элемент списка правил сегментов.
    /// </summary>
    public class Rule
    {
        #region Свойства

        [JsonProperty("words")]
        public List<string> Words { get; set; }

        [JsonProperty("exact")]
        public List<string> Exact { get; set; }

        [JsonProperty("folders")]
        public List<string> Folders { get; set; }

        [JsonProperty("exact_url_s")]
        public List<string> ExactUrl { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        #endregion
    }
}
