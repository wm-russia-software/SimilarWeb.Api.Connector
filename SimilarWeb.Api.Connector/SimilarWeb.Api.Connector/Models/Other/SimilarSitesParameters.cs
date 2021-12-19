using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Параметры для вызова метода SimilarSites.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class SimilarSitesParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/similar-sites/similarsites";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>        
        public string Website { get; set; }

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

        #endregion
    }
}
