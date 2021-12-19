using System.Runtime.Serialization;

namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Тип события web-хука
    /// </summary>
    public enum WebHookEventType
    {
        /// <summary>
        /// Дневной
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily = 0,

        /// <summary>
        /// Месячный
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly = 1
    }
}
