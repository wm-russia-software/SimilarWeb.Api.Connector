using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Базовый класс ответа. 
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public abstract class BaseRankingResponse : BaseResponse<RequestWithLimit>
    {
        #region Свойства

        [JsonProperty("visits")]
        public int Visits { get; set; }

        [JsonProperty("global_ranking")]
        public int? GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int? CategoryRanking { get; set; }

        #endregion
    }
}
