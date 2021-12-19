using System;

namespace SimilarWeb.Api.Connector.Models.Common
{
    /// <summary>
    /// Класс атрибута для выставления названий именам полей используемым в запросе.
    /// </summary>
    /// <seealso cref="Attribute" />
    public class ParameterName : Attribute
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор экземпляра <see cref="ParameterName"/> класса.
        /// </summary>
        /// <param name="name">Имя параметра.</param>
        public ParameterName(string name)
        {
            Name = name;
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Имя параметра.
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}
