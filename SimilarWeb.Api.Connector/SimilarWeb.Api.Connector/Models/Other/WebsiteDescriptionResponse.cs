using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Ответ на вызов метода GetWebsiteDescription. Содержит мета-описание веб-сайта
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class WebsiteDescriptionResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion
    }
}
