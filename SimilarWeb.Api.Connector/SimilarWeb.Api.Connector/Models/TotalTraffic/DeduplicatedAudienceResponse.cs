using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetDeduplicatedAudience. Содержит анализ количества людей, посещающих веб-сайт с разных устройств (с дедупликацией по устройствам).
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DeduplicatedAudienceResponse : BaseResponse<RequestWithStateAndPage>
    {
        #region Свойства

        [JsonProperty("data")]
        public List<DeduplicatedAudienceDataItem> Data { get; set; }

        #endregion
    }
}
