using Ak.Framework.Core.Extensions;
using System.Configuration;

namespace SimilarWeb.Api.Connector.Tests.App
{
    /// <summary>
    /// Настройки
    /// </summary>
    internal class Settings
    {
        #region Свойства

        /// <summary>
        /// Ключ API для доступа к SimilarWeb
        /// </summary>
        public static string SimilarWebApiKey => ConfigurationManager.AppSettings["SimilarWebApiKey"].ToStr();

        #endregion
    }
}
