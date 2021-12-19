using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetBounceRate. Содержит показатель отказов для указанного домена.    
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />    
    public class BounceRateResponse : BaseResponse<RequestDesktopWithState>
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public List<BounceRateDataItem> BounceRate { get; set; }

        #endregion        

    }
}
