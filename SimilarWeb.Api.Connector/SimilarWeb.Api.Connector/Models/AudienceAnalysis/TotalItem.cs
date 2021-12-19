using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Элемент списка из ответа на вызов метода NewVsReturning.
    /// </summary>
    public class TotalItem
    {
        #region Свойства 

        [JsonProperty("new_users")]
        public decimal NewUsers { get; set; }

        [JsonProperty("returning_users")]
        public decimal ReturningUsers { get; set; }

        #endregion
    }
}
