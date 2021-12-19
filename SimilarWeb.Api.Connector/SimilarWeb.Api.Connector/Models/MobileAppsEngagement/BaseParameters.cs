﻿using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
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
        /// Гранулярность по времени.
        /// </summary>        
        [ParameterName("granularity")]
        public Granularity Granularity { get; set; }

        #endregion
    }
}
