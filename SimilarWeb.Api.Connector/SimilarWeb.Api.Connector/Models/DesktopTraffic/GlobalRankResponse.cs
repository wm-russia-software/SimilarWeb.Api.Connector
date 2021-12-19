using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetGlobalRank. Содержит ежемесячный глобальный рейтинг SimilarWeb для заданного домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class GlobalRankResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("global_rank")]
        public List<GlobalRankData> GlobalRank { get; set; }

        #endregion
    }
}
