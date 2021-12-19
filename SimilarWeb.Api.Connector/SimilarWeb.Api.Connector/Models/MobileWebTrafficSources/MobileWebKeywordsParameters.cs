using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Параметры для вызова метода MobileWebKeywords.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class MobileWebKeywordsParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/mobile-traffic-sources/mobile-search";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Ограничение количества возвращаемых элементов. 
        /// </summary>        
        [ParameterName("limit")]
        public int Limit { get; set; }

        #endregion
    }
}
