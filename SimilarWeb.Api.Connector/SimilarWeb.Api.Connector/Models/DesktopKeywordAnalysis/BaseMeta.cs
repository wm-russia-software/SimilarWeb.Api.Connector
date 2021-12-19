using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Базовый класс метаданных возвращаемых методами группы DesktopKeywordAnalysis.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    public abstract class BaseMeta<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("request")]
        public TRequest Request { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion
    }
}
