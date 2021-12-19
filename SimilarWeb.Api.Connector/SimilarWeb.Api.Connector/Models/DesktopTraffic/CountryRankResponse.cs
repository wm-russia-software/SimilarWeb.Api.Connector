using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetCountryRank. Содержит ежемесячный рейтинг страны в SimilarWeb для заданного домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class CountryRankResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("country_rank")]
        public List<CountryRankDataItem> CountryRank { get; set; }

        #endregion
    }
}
