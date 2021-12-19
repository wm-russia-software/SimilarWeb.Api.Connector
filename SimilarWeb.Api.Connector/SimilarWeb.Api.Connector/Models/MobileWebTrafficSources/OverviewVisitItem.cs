using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Список типа источника и детализацией визитов. 
    /// </summary>
    public class OverviewVisitItem
    {
        #region Свойства

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("visits")]
        public List<Visit> Visits { get; set; }

        #endregion
    }
}
