using SimilarWeb.Api.Connector.Models.Common;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Базовый класс параметров с указанием лимита. 
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public abstract class BaseParametersWithLimit : BaseParameters
    {

        #region Свойства

        /// <summary>
        /// Ограничение количества возвращаемых элементов. 
        /// </summary>
        [ParameterName("limit")]
        public int Limit { get; set; }

        #endregion
    }
}
