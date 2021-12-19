using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Error
{
    /// <summary>
    /// Ответ с ошибкой сервиса.
    /// </summary>
    internal class ErrorResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        #endregion
    }
}
