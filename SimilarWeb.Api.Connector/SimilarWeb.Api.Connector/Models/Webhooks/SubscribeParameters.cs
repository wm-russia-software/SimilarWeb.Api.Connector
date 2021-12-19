using SimilarWeb.Api.Connector.Models.Common;
using System.Net.Http;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Параметры для вызова метода Subscribe.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class SubscribeParameters : BaseCommonParameters
    {
        #region Свойства 

        /// <summary>
        /// HTTP метод используемый в запросе.
        /// </summary>
        public override HttpMethod HttpMethod => HttpMethod.Post;

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/webhooks/subscribe";

        #endregion
    }
}
