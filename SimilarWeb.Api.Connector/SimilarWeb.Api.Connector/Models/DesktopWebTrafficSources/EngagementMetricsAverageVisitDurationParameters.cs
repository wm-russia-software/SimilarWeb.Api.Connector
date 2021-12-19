using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода EngagementMetricsAverageVisitDuration.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class EngagementMetricsAverageVisitDurationParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/traffic-sources/engagement-metrics/average-duration";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Получение информации только для основного домена.
        /// </summary>        
        [ParameterName("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        /// <summary>
        /// Гранулярность по времени.
        /// </summary>        
        [ParameterName("granularity")]
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Устанавливает дату окончания периода как крайнюю доступную дату (Month To Date).
        /// </summary>        
        [ParameterName("mtd")]
        public bool Mtd { get; set; }

        #endregion
    }
}
