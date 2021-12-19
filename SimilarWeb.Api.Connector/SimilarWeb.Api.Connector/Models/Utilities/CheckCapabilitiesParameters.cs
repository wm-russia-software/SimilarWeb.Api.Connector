using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Параметры для вызова метода CheckCapabilities.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class CheckCapabilitiesParameters : BaseCommonParameters
    {
        #region Свойства

        public override string MethodPath => "capabilities";

        #endregion
    }
}
