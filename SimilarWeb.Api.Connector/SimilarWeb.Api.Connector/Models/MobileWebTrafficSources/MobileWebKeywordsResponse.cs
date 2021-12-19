using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebKeywords. Содержит ключевые слова для поиска для данного домена, долю трафика ключевых слов, % изменений, объем ключевых слов, цену за клик, URL-адрес и позицию ключевого слова для посещений при поиске в мобильном Интернете.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebKeywordsResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("search")]
        public List<Search> Search { get; set; }

        [JsonProperty("visits")]
        public int Visits { get; set; }

        [JsonProperty("total_visits")]
        public int TotalVisits { get; set; }

        #endregion
    }
}
