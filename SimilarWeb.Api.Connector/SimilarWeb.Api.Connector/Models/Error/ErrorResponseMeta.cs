using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Error
{
    /// <summary>
    /// Метаданные ответа с ошибкой.
    /// </summary>
    public class Meta
    {
        #region Свойства

        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion
    }
}
