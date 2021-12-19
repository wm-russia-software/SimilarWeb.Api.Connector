using SimilarWeb.Api.Connector.Models.MobileAppsEngagement;

namespace SimilarWeb.Api.Connector
{
    /// <summary>
    /// Набор методов для работы с группой запросов MobileAppsEngagement.
    /// </summary>
    /// <seealso cref="BaseApiHandler" />
    public class MobileAppsEngagement : BaseApiHandler
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        public MobileAppsEngagement(string apiKey) : base(apiKey)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="apiKey">Ключ для доступа к Api</param>
        /// <param name="apiUrl">Url для доступа к Api</param>
        public MobileAppsEngagement(string apiKey, string apiUrl) : base(apiKey, apiUrl)
        {

        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Возвращает разбивку демографических данных приложений по возрастным группам.
        /// </summary>
        /// <param name="appDemographicsAgeParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AppDemographicsAgeResponse GetAppDemographicsAge(AppDemographicsAgeParameters appDemographicsAgeParameters)
        {
            return Invoke<AppDemographicsAgeResponse>(appDemographicsAgeParameters);
        }

        /// <summary>
        /// Возвращает демографические данные приложений по полу.
        /// </summary>
        /// <param name="appDemographicsGenderParameters">Параметры запроса..</param>
        /// <returns></returns>
        public AppDemographicsGenderResponse GetAppDemographicsGender(AppDemographicsGenderParameters appDemographicsGenderParameters)
        {
            return Invoke<AppDemographicsGenderResponse>(appDemographicsGenderParameters);
        }

        /// <summary>
        /// Возвращает количество пользователей, загружающих приложение из Google Play / Apple App store за заданный период времени.
        /// </summary>
        /// <param name="appDownloadsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public AppDownloadsResponse GetAppDownloads(AppDownloadsParameters appDownloadsParameters)
        {
            return Invoke<AppDownloadsResponse>(appDownloadsParameters);
        }

        /// <summary>
        /// Возвращает количество уникальных ежедневных активных пользователей запрошенного приложения.
        /// </summary>
        /// <param name="dailyActiveUsersParameters">Параметры запроса.</param>
        /// <returns></returns>
        public DailyActiveUsersResponse GetDailyActiveUsers(DailyActiveUsersParameters dailyActiveUsersParameters)
        {
            return Invoke<DailyActiveUsersResponse>(dailyActiveUsersParameters);
        }

        /// <summary>
        /// Возвращает % устройств на определенном рынке с установленным приложением.
        /// </summary>
        /// <param name="installPenetrationParameters">Параметры запроса.</param>
        /// <returns></returns>
        public InstallPenetrationResponse GetInstallPenetration(InstallPenetrationParameters installPenetrationParameters)
        {
            return Invoke<InstallPenetrationResponse>(installPenetrationParameters);
        }

        /// <summary>
        /// Возвращает количество уникальных активных пользователей за месяц для приложений Android.
        /// </summary>
        /// <param name="monthlyActiveUsersAndroidParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MonthlyActiveUsersAndroidResponse GetMonthlyActiveUsersAndroid(MonthlyActiveUsersAndroidParameters monthlyActiveUsersAndroidParameters)
        {
            return Invoke<MonthlyActiveUsersAndroidResponse>(monthlyActiveUsersAndroidParameters);
        }

        /// <summary>
        /// Возвращает количество уникальных активных пользователей за месяц для приложений iOS.
        /// </summary>
        /// <param name="monthlyActiveUsersIOSParameters">Параметры запроса.</param>
        /// <returns></returns>
        public MonthlyActiveUsersIOSResponse GetMonthlyActiveUsersIOS(MonthlyActiveUsersIOSParameters monthlyActiveUsersIOSParameters)
        {
            return Invoke<MonthlyActiveUsersIOSResponse>(monthlyActiveUsersIOSParameters);
        }

        /// <summary>
        /// Возвращает количество уникальных установок запрошенного приложения.
        /// </summary>
        /// <param name="uniqueInstallsParameters">Параметры запроса.</param>
        /// <returns></returns>
        public UniqueInstallsResponse GetUniqueInstalls(UniqueInstallsParameters uniqueInstallsParameters)
        {
            return Invoke<UniqueInstallsResponse>(uniqueInstallsParameters);
        }

        #endregion
    }
}
