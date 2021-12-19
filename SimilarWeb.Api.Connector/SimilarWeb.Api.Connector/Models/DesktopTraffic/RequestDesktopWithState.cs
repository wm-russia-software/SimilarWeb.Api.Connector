using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Запрос из метаданных ответа с данными по штату USA.
    /// </summary>
    /// <seealso cref="BaseRequestDesktop" />
    public class RequestDesktopWithState : BaseRequestDesktop
    {
        #region Свойства

        [JsonProperty("state")]
        public string State { get; set; }

        #endregion
    }
}
