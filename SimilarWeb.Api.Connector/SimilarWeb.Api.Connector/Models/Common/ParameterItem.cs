namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Элемент списка значений передаваемых в URL запроса.
    /// </summary>
    public class ParametersItem
    {
        #region Свойства        
        /// <summary>
        /// Название параметра.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение параметра.
        /// </summary>
        public string Value { get; set; }

        #endregion
    }
}
