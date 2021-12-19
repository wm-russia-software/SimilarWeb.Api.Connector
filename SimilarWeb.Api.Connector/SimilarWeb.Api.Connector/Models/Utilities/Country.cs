using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Данные страны.
    /// </summary>
    public class Country
    {
        #region Свойства

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #endregion
    }
}
