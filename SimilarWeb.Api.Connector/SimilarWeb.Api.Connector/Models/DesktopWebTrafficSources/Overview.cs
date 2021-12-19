using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Данные по источнику с разбивкой по типу источника и его доле. 
    /// </summary>
    public class Overview
    {
        #region Свойства

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        #endregion
    }
}
