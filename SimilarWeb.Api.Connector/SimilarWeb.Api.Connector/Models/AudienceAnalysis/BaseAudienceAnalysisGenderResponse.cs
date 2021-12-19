using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Базовый класс, возвращаемый методами использующими информацию о поле аудитории.
    /// </summary>
    /// <seealso cref="BaseAudienceAnalysisResponse" />
    public abstract class BaseAudienceAnalysisGenderResponse : BaseAudienceAnalysisResponse
    {
        #region Свойства

        [JsonProperty("male")]
        public decimal Male { get; set; }

        [JsonProperty("female")]
        public decimal Female { get; set; }

        #endregion
    }
}
