using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Ответ на вызов метода GetCategoryRank. Содержит категорию данного домена и его глобальный рейтинг в данной категории.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class CategoryRankResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        #endregion
    }
}
