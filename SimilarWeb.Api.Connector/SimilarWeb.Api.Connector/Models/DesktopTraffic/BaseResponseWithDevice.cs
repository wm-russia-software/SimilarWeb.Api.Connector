using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Базовый класс ответа на вызов метода, с информацией об устройстве. 
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseResponseWithDevice<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("meta")]
        public MetaWithDevice<TRequest> Meta { get; set; }

        #endregion
    }
}
