using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка тэгов. 
    /// </summary>
    public class TagItem
    {
        #region Свойства

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("strength")]
        public decimal Strength { get; set; }

        #endregion
    }
}
