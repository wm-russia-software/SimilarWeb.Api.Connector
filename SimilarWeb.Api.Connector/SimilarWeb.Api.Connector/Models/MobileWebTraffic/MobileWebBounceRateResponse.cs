using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetMobileWebBounceRate. Содержит показатель отказов мобильного Интернета для данного домена.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class MobileWebBounceRateResponse : BaseResponse<Request>
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public List<BounceRateItem> BounceRate { get; set; }

        #endregion
    }
}
