using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Ответ на вызов метода GetInstallPenetration. Содержит % устройств на определенном рынке с установленным приложением.
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class InstallPenetrationResponse : BaseResponse<RequestWithGranularityAndDate>
    {
        #region Свойства

        [JsonProperty("current_installs")]
        public List<CurrentInstalls> CurrentInstalls { get; set; }

        #endregion
    }
}
