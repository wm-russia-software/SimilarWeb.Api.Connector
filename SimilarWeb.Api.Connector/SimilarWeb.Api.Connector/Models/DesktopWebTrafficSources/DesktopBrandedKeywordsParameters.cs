using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода DesktopBrandedKeywords.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class DesktopBrandedKeywordsParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/traffic-sources/branded-search";

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
        /// Ограничение количества возвращаемых элементов. 
        /// </summary>        
        [ParameterName("limit")]
        public int Limit { get; set; }

        #endregion
    }
}
