using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Базовый класс возвращаемый методами группы AudienceAnalysis.
    /// </summary>
    public abstract class BaseAudienceAnalysisResponse
    {
        #region Свойства

        [JsonProperty("meta")]
        public Meta<Request> Meta { get; set; }

        #endregion
    }
}
