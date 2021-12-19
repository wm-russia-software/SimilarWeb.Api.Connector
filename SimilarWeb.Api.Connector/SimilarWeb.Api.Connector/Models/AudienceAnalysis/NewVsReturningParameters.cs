namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Параметры для вызова метода NewVsReturning.
    /// </summary>
    /// <seealso cref="BaseParameters" />
    public class NewVsReturningParameters : BaseParameters
    {
        #region Свойства

        /// <summary>
        /// Относительный путь к конечной точке метода API.
        /// </summary>
        public override string MethodPath => $"v1/website/{Website}/audience/new-vs-returning";

        /// <summary>
        /// Имя веб-сайта для которого выполняется запрос.
        /// </summary>
        public string Website { get; set; }

        #endregion
    }
}
