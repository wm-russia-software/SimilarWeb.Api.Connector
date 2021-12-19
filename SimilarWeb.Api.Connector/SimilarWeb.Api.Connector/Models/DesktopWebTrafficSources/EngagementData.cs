using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Элемент списка данных из методов Engagement.
    /// </summary>
    public class EngagementData
    {
        #region Свойства

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("values")]
        public List<EngagementValue> Values { get; set; }

        #endregion
    }
}
