using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Параметры для вызова метода ListCategories.
    /// </summary>
    /// <seealso cref="BaseCommonParameters" />
    public class ListCategoriesParameters : BaseCommonParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => "v1/TopSites/categories";

        #endregion
    }
}
