using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetSearchVisitsDistributionDesktop. Содержит ежемесячное распределение платных и брендированных поисковых посещений для настольного трафика.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class SearchVisitsDistributionDesktopResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("data")]
        public List<VisitDistributionDataListItem> Data { get; set; }

        #endregion
    }
}
