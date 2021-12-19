﻿using SimilarWeb.Api.Connector.Models.Common;
using System;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Параметры для вызова метода LeadEnrichment.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class LeadEnrichmentParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/lead-enrichment/all";

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
        /// Показывать общие данные Google Analytics, если доступны.
        /// </summary>        
        [ParameterName("show_verified")]
        public bool ShowVerified { get; set; }

        #endregion
    }
}
