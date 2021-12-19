using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Детализация мобильные/настольные платформы на дату.
    /// </summary>
    public class MobileDesktopShareValueItem
    {
        #region Свойства

        [JsonProperty("desktop_share")]
        public decimal DesktopShare { get; set; }

        [JsonProperty("mobile_share")]
        public decimal MobileShare { get; set; }

        #endregion
    }
}
