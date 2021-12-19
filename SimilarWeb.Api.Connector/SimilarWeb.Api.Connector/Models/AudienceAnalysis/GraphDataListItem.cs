using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Распределение пользователей в разрезе временного диапазона.
    /// </summary>
    public class GraphDataListItem
    {
        #region Свойства 

        [JsonProperty("new_users")]
        public decimal NewUsers { get; set; }

        [JsonProperty("returning_users")]
        public decimal ReturningUsers { get; set; }

        #endregion
    }
}
