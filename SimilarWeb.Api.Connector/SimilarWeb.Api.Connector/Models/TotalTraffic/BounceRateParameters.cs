using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Параметры для вызова метода BounceRate.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class BounceRateParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/total-traffic-and-engagement/bounce-rate";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Гранулярность по времени.
        /// </summary>        
        [ParameterName("granularity")]
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Показывать общие данные Google Analytics, если доступны.
        /// </summary>        
        [ParameterName("show_verified")]
        public bool ShowVerified { get; set; }

        /// <summary>
        /// Устанавливает дату окончания периода как крайнюю доступную дату (Month To Date).
        /// </summary>        
        [ParameterName("mtd")]
        public bool Mtd { get; set; }

        #endregion
    }
}
