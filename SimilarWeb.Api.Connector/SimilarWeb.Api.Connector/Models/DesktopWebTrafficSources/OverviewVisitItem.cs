using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Приблизительный объем траффика с разбивкой по источникам.  
    /// </summary>
    public class OverviewVisitItem
    {
        #region Свойства

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("visits")]
        public List<OverviewVisit> Visits { get; set; }

        #endregion
    }
}
