using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Запрос из метаданных.
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public class AudienceOverlapRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("domains")]
        public string Domains { get; set; }

        #endregion
    }
}
