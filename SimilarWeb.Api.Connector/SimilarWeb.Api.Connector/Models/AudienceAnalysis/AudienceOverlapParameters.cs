using SimilarWeb.Api.Connector.Models.Common;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Параметры для вызова метода AudienceOverlap.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class AudienceOverlapParameters : BaseParameters
    {
        #region Свойства        

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/website/audience/overlap";

        /// <summary>
        /// Список доменов по которым производится запрос.
        /// </summary>
        [ParameterName("domains")]
        public List<string> Domains { get; set; }

        #endregion
    }
}
