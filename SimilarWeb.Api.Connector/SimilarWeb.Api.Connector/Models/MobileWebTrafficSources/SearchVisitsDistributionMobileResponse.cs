using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetSearchVisitsDistributionMobile. Содержит распределение ежемесячных платных и брендированных поисковых посещений для мобильного веб-трафика.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class SearchVisitsDistributionMobileResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("data")]
        public List<DataItem> Data { get; set; }

        #endregion
    }
}
