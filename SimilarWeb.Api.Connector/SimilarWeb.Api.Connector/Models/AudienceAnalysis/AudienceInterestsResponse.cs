using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Ответ на вызов метода GetAudienceInterests. Содержит список дополнительных веб-сайтов, которые часто посещались одними и теми же посетителями данного домена в течение сеанса просмотра, а также их оценку близости и совпадение (средний % посетителей, которые посетили оба сайта в один и тот же день).
    /// </summary>
    /// <seealso cref="BaseAudienceAnalysisResponse" />
    public class AudienceInterestsResponse : BaseAudienceAnalysisResponse
    {
        #region Свойства		

        [JsonProperty("records")]
        public List<Record> Records { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
