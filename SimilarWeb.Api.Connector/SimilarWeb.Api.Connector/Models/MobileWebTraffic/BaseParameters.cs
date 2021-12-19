using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileWebTraffic
{
    /// <summary>
    /// Базовый класс параметров.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public abstract class BaseParameters : BaseCommonParameters
    {
        #region Свойства

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
        /// Показывать общие данные Google Analytics, если доступны.
        /// </summary>        
        [ParameterName("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
