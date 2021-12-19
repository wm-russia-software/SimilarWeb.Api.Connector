namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Параметры для вызова метода MobileWebPagesPerVisit.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebPagesPerVisitParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v2/website/{Website}/mobile-web/pages-per-visit";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
