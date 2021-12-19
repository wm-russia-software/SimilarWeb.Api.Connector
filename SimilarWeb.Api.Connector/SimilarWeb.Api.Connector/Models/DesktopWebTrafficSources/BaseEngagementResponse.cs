using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Базовый класс запоса из метаданных группы методов EngagementMetrics.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public abstract class BaseEngagementResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("data")]
        public List<EngagementData> Data { get; set; }

        #endregion
    }
}
