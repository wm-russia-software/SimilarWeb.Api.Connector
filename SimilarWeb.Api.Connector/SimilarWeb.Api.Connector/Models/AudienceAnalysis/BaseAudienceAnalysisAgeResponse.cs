using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Базовый класс, возвращаемый методами использующими информацию о возрасте аудитории.
    /// </summary>
    /// <seealso cref="BaseAudienceAnalysisResponse" />
    public abstract class BaseAudienceAnalysisAgeResponse : BaseAudienceAnalysisResponse
    {
        #region Свойства

        [JsonProperty("age_18_to_24")]
        public decimal Age18To24 { get; set; }

        [JsonProperty("age_25_to_34")]
        public decimal Age25To34 { get; set; }

        [JsonProperty("age_35_to_44")]
        public decimal Age35To44 { get; set; }

        [JsonProperty("age_45_to_54")]
        public decimal Age45To54 { get; set; }

        [JsonProperty("age_55_to_64")]
        public decimal Age55To64 { get; set; }

        [JsonProperty("age_65_plus")]
        public decimal Age65Plus { get; set; }

        #endregion
    }
}
