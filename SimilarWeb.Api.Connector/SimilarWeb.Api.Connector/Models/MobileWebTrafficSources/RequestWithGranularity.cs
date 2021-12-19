using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Запрос из метаданных с гранулярностью. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithGranularity : BaseRequest
    {
        #region Свойства

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        #endregion
    }

}
