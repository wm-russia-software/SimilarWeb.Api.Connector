using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Базовый класс ответа для группы методов Desktop*Keywords.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public abstract class BaseSearchResponse : BaseResponse<RequestWithLimit>
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
