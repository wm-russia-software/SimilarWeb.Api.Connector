using SimilarWeb.Api.Connector.Models.Common;
using System.Net.Http;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Параметры для вызова метода UnSubscribe.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class UnSubscribeParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// HTTP метод используемый в запросе.
        /// </summary>
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/webhooks/unsubscribe/{SubscriptionId}";

        /// <summary>
        /// Идентификатор подписки.
        /// </summary>
        public string SubscriptionId { get; set; }

        #endregion
    }
}
