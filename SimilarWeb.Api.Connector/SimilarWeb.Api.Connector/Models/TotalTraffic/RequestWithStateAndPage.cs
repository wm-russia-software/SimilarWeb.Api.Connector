using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Запрос из метаданных со штатом USA и страницей. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithStateAndPage : BaseRequest
    {
        #region Свойства

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("page")]
        public object Page { get; set; }

        #endregion
    }
}
