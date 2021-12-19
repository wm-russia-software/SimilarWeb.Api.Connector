using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebTrafficSourcesOverview. Содержит примерный объем мобильного веб-трафика с разбивкой по источникам.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebTrafficSourcesOverviewResponse : BaseResponse<RequestWithGranularity>
    {
        #region Свойства

        [JsonProperty("visits")]
        public Dictionary<string, List<OverviewVisitItem>> Visits { get; set; }

        #endregion
    }
}
