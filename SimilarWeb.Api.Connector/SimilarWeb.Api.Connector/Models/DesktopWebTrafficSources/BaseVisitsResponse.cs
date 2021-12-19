using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Базовый класс ответа с количеством визитов. 
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public abstract class BaseVisitsResponse : BaseResponse<RequestWithLimit>
    {
        #region Свойства

        [JsonProperty("visits")]
        public int Visits { get; set; }

        #endregion
    }
}
