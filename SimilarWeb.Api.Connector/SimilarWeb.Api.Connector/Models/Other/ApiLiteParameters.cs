using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Параметры для вызова метода ApiLite.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class ApiLiteParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/general-data/all";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        #endregion
    }
}
