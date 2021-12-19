using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopTrafficSourcesOverview. Содержит примерный объем трафика с разбивкой по источникам.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DesktopTrafficSourcesOverviewResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("visits")]
        public Dictionary<string, List<OverviewVisitItem>> Visits { get; set; }

        #endregion
    }
}
