using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Базовый класс метаданных с полем LastUpdate.
    /// </summary>
    /// <typeparam name="TRequest">Тип запроса.</typeparam>
    /// <seealso cref="BaseMeta&lt;TRequest&gt;" />
    public abstract class BaseMetaWithLastUpdate<TRequest> : BaseMeta<TRequest> where TRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        #endregion
    }
}
