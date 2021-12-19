using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Параметры для вызова метода Technographics.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class TechnographicsParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/technographics/all";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Получение информации только для основного домена.
        /// </summary>
        [ParameterName("main_domain_only")]
        public bool MainDomainOnly { get; set; }

        #endregion
    }
}
