using SimilarWeb.Api.Connector.Models.Common;
using System.Net.Http;

namespace SimilarWeb.Api.Connector.Models.Webhooks
{
    /// <summary>
    /// Параметры для вызова метода GetList.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class GetListParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/webhooks/subscriptions";

        /// <summary>
        /// HTTP метод используемый в запросе.
        /// </summary>
        public override HttpMethod HttpMethod => HttpMethod.Get;

        #endregion
    }
}
