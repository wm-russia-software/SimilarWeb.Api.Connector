using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Метаданные с информацией об устройстве, ответа на вызов метода группы DesktopTraffic.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    /// <seealso cref="BaseMeta&lt;TRequest&gt;" />
    public class MetaWithDevice<TRequest> : BaseMeta<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("device")]
        public string Device { get; set; }

        #endregion
    }
}
