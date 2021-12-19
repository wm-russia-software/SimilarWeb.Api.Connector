using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Запрос из метаданных с лимитом. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithLimit : BaseRequest
    {
        #region Свойства

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        #endregion
    }
}
