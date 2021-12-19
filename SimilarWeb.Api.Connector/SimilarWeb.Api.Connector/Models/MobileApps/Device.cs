using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    #region Перечисления

    /// <summary>
    /// Перечисление типов устройств.
    /// </summary>
    public enum Device
    {
        [ParameterName("androidphone")]
        AndroidPhone,

        [ParameterName("iphone")]

        Iphone,
        [ParameterName("ipad")]
        Ipad
    }

    #endregion
}
