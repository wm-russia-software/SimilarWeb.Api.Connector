using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Разделение мобильные/настольные платформы на дату.
    /// </summary>
    public class MobileDesktopShare
    {
        #region Свойства

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public MobileDesktopShareValueItem Value { get; set; }

        #endregion
    }
}
