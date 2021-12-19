using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.IndustryAnalysis
{
    /// <summary>
    /// Параметры для вызова метода TopSitesMobile.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class TopSitesMobileParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/topsites/mobile";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

        /// <summary>
        /// Страница ответа, каждая содержит 100 сайтов и доступно 100 страниц.
        /// </summary>        
        [ParameterName("page")]
        public int Page { get; set; }

        /// <summary>
        /// Начало периода.
        /// </summary>        
        [ParameterName("start_date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Окончание периода.
        /// </summary>        
        [ParameterName("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>        
        [ParameterName("country")]
        public string Country { get; set; }

        #endregion
    }
}
