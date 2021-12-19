using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Ответ на вызов метода GetSimilarSites. Содержит 40 самых похожих веб-сайтов для данного домена и их оценку сходства.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class SimilarSitesResponse : BaseResponse<SimilarSitesRequest>
    {
        #region Свойства

        [JsonProperty("similar_sites")]
        public List<SimilarSitesScoreItem> SimilarSites { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
