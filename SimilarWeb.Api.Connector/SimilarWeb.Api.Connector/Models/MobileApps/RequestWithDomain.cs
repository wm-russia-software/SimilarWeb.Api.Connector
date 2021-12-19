using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Запрос из метаданных с веб-сайтом.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class RequestWithDomain : BaseRequest
    {
        #region Свойства

        [JsonProperty("domain")]
        public string Domain { get; set; }

        #endregion
    }
}
