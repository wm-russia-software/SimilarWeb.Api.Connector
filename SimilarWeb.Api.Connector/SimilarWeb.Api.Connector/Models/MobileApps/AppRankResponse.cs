using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Ответ на вызов метода GetAppRank. Содержит рейтинг в Apple App Store / Google Play Store для данного приложения.
    /// </summary>
    /// <seealso cref="BaseResponseWithLastUpdate&lt;TRequest&gt;" />
    public class AppRankResponse : BaseResponseWithLastUpdate<AppRankRequest>
    {
        #region Свойства

        [JsonProperty("ranks")]
        public List<Rank> Ranks { get; set; }

        #endregion
    }
}
