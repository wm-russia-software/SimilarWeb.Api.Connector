using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Рейтинг приложения в ключевые моменты. 
    /// </summary>
    public class Rank
    {
        #region Свойства 
        
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        #endregion
    }
}
