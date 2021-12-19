using System;
using System.Collections.Generic;
using System.Text;
using SimilarWeb.Api.Connector.Models.AudienceAnalysis;
using SimilarWeb.Api.Connector.Models.DesktopTraffic;
using SimilarWeb.Api.Connector.Test;

namespace SimilarWeb.Api.Connector.Test
{
    public partial class ApiHandler : BaseApiHandler
    {
        public ApiHandler(string ApiKey) : base(ApiKey)
        {

        }
        public static ApiHandler _apiHandler = new ApiHandler("");

        public AudienceInterestsMethods AudienceInterests = new AudienceInterestsMethods(_apiHandler);

    }

    public partial class ApiHandler : BaseApiHandler
    {
        public class AudienceInterestsMethods
        {
            private ApiHandler ApiHandler { get; set; }

            public AudienceInterestsMethods(ApiHandler apiHandler) => ApiHandler = apiHandler;

            public void ttt()
            {
                ApiHandler.Invoke<AudienceInterestsResponse>(null);

            }
        }
    }
}



/*public static class MainTest 
{
    public static ApiHandler ApiHandler = new ApiHandler("");

} */

//}
/*
    namespace SimilarWeb.Api.Connector.Test
{
    using ApiHandler0 = SimilarWeb.Api.Connector.Test.MainTest;
    public static class AudienceInterests
    {
        public static void ttt()
        {
            ApiHandler0.ApiHandler.Invoke<AudienceInterestsResponse>(null);

            //ApiHandler.ApiHandler.Invoke <AudienceInterestsResponse> (null);
            //BaseApiHandler.Invoke<AudienceInterestsResponse>(null);

        }


    }

}
*/








namespace SimilarWeb.Api.Connector
{
    /*
    public class Main : BaseApiHandler
    {

        public Main(string ApiKey) : base(ApiKey)
        {
        
        }


        /// <summary>
        /// Возвращает список дополнительных веб-сайтов, которые часто посещались одними и теми же посетителями данного домена в течение сеанса просмотра, а также их оценку близости и совпадение (средний % посетителей, которые посетили оба сайта в один и тот же день).
        /// </summary>
        /// <param name="requestParameters">The request parameters.</param>
        /// <returns></returns>
        public static AudienceInterestsResponse GetAudienceInterest(AudienceInterestsParameters requestParameters)
        {

            return Invoke<AudienceInterestsResponse>(requestParameters);
        }


        public static class DesktopTraffic
        {
            /// <summary>
            /// Возвращает среднюю продолжительность посещения в указанном домене (в секундах).
            /// </summary>
            /// <param name="averageVisitDurationParameters">The average visit duration parameters.</param>
            /// <returns></returns>
            public static AverageVisitDurationResponse GetAverageVisitDuration(AverageVisitDurationParameters averageVisitDurationParameters)
            {

                return Invoke<AverageVisitDurationResponse>(averageVisitDurationParameters);
            }
        }

    
    }
*/
}

