using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    #region Перечисления

    /// <summary>
    /// Магазин программного обеспечения.
    /// </summary>
    public enum Store
    {
        [ParameterName("google")]
        Google,

        [ParameterName("apple")]
        Apple
    }

    #endregion
}
