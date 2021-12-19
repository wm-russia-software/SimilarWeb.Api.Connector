using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetBounceRate. Содержит показатель отказов для данного домена.	
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class BounceRateResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public List<BounceRateDataListItem> BounceRate { get; set; }

        #endregion
    }
}
