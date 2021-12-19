namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Параметры для вызова метода MobileWebAverageVisitDuration.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebAverageVisitDurationParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v2/website/{Website}/mobile-web/average-visit-duration";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
