using System.Net.Http;

namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Базовый набор параметров для всех методов API.
    /// </summary>
    public abstract class BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// HTTP метод используемый в запросе.
        /// </summary>        
        public virtual HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public abstract string MethodPath { get; }

        #endregion
    }

}
