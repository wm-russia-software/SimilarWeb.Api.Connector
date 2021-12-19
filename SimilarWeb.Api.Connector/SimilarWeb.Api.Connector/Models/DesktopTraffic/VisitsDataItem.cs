using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    ///  Визиты. 
    /// </summary>
    /// <seealso cref="BaseDataItem" />
    public class VisitsDataItem : BaseDataItem
    {
        #region Свойства

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        #endregion
    }
}
