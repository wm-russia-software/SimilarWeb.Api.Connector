using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Ответ на вызов метода GetDesktopVsMobileSplit. Содержит долю трафика для настольных компьютеров и мобильных устройств за выбранный период времени (минимум 1 месяц).
    /// </summary>
    /// <seealso cref="BaseResponse&lt;TRequest&gt;" />
    public class DesktopVsMobileSplitResponse : BaseResponse<RequestWithGranularityAndLimit>
    {
        #region Свойства

        [JsonProperty("desktop_visit_share")]
        public decimal DesktopVisitShare { get; set; }

        [JsonProperty("mobile_web_visit_share")]
        public decimal MobileWebVisitShare { get; set; }

        #endregion
    }
}
