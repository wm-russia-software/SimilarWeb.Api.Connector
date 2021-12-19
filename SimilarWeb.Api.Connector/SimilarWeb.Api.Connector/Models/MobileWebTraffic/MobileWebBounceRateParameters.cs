namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Параметры для вызова метода MobileWebBounceRate
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebBounceRateParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v2/website/{Website}/mobile-web/bounce-rate";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
