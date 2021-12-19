using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Запрос из ответа на методы API возвращаюшие гранулярность и лимит. 
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
