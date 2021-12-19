using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Запрос из метаданных с гранулярностью и лимитом. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithGranularityAndLimit : BaseRequest
    {
        #region Свойства

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        #endregion
    }
}
