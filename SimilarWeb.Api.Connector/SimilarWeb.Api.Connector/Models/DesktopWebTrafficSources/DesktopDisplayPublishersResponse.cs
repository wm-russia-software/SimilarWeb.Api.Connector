using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopDisplayPublishers. Содержит ведущих издателей, отправляющих трафик в данный домен, а также долю трафика на одного издателя и количество посещений медийной рекламы.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DesktopDisplayPublishersResponse : BaseResponse<RequestWithLimit>
    {
        #region Свойства
        [JsonProperty("publishers")]
        public List<Publisher> Publishers { get; set; }

        [JsonProperty("visits")]
        public int Visits { get; set; }

        [JsonProperty("global_ranking")]
        public int GlobalRanking { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_ranking")]
        public int CategoryRanking { get; set; }

        #endregion
    }
}
