using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Элемент списка с используемыми приложениями той же аудиторией. 
    /// </summary>
    public class AlsoUsedApps
    {
        #region Свойства

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("affinity")]
        public decimal Affinity { get; set; }

        #endregion
    }
}
