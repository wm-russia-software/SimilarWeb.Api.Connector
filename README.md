# SimilarWeb.Api.Connector
This library provides functionality for connecting and using data gathering methods from SimilarWeb API.
SimilarWeb is a popular platform for web analytics, deep data analysis and business intelligence.

## Installation
Package is available at [nuget](https://www.nuget.org/packages/SW.Api.Connector). You can either use your favorite package manager or run 

```bash
Install-Package SW.Api.Connector -Version 1.1.0
```

## Usage

```c#
using SimilarWeb.Api.Connector.Models.AudienceAnalysis;
using SimilarWeb.Api.Connector.Models.Common;
using SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis;
using SimilarWeb.Api.Connector.Models.DesktopTraffic;
using SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources;
using SimilarWeb.Api.Connector.Models.IndustryAnalysis;
using SimilarWeb.Api.Connector.Models.MobileApps;
using SimilarWeb.Api.Connector.Models.MobileAppsEngagement;
using SimilarWeb.Api.Connector.Models.MobileWebTraffic;
using SimilarWeb.Api.Connector.Models.MobileWebTrafficSources;
using SimilarWeb.Api.Connector.Models.Other;
using SimilarWeb.Api.Connector.Models.SalesSolution;
using SimilarWeb.Api.Connector.Models.SegmentAnalysis;
using SimilarWeb.Api.Connector.Models.TotalTraffic;
using SimilarWeb.Api.Connector.Models.Utilities;
using SimilarWeb.Api.Connector.Models.Webhooks;
using SimilarWeb.Api.Connector.Models.WebsiteContent;

...

// Connect to API with your SimilarWeb API key
DesktopTraffic desktopTraffic = new DesktopTraffic(yourSimilarWebApiKey);

// Setting analytics parameters
Models.DesktopTraffic.AverageVisitDurationParameters averageVisitDurationParameters = new Models.DesktopTraffic.AverageVisitDurationParameters
{
    Country = "ru",
    StartDate = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month - 1, 1),
    EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1),
    Website = "lenta.ru"
};

// Obtaining result. Fill free to use other available API methods.
Models.DesktopTraffic.AverageVisitDurationResponse averageVisitDurationResponse = desktopTraffic.GetAverageVisitDuration(averageVisitDurationParameters);

```

For more information about using SimilarWeb API take a look at our [documentation](https://documenter.getpostman.com/view/5388671/RzfcNs8W).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)

