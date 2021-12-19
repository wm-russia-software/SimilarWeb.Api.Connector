﻿using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Базовый класс параметров для методов использующих параметр main_domain_only.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public abstract class BaseParametersWithDomain : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Получение информации только для основного домена.
        /// </summary>
        [ParameterName("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        #endregion
    }
}
