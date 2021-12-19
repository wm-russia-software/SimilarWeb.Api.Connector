using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Запрос из ответа на методы API возвращаюшие лимит. 
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
