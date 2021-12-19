namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода SearchVisitsDistributionMobile.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class SearchVisitsDistributionMobileParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/mobile-traffic-sources/search-visits-distribution";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        #endregion
    }
}
