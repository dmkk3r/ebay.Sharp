# ebay.Sharp

**eBay.Sharp** is an unofficial .NET SDK that simplifies integration with eBay's APIs, making it easier for developers to build applications and services that interact with eBay's marketplace.

## Features
- Easy-to-use .NET library for eBay API integration.
- Comprehensive support for eBay API operations.
- [eBay API Documentation](https://developer.ebay.com/api-docs)

## Installation
You can install **eBay.Sharp** via NuGet Package Manager:

```shell
dotnet add package eBay.Sharp
```

## Usage
Here's a quick example of how to get started using eBay.Sharp to retrieve information about eBay listings:

```csharp
using eBay.Sharp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEbaySharp(new EbayConfiguration {
    EnvironmentType = EbayConfiguration.Environment.Production,
    GlobalId = "EBAY-DE",
    AppId = "APP-ID"
});

var app = builder.Build();

app.MapGet("/finding", async ([FromServices] FindingService findingService) => {
    var findItemsByKeywordsRequest = new FindItemsByKeywordsRequest {
        Keywords = "N64 Mario Tennis PAL ovp -(trainer, sleeves, VGA)",
        PaginationInput = new PaginationInput {
            EntriesPerPage = "100"
        },
        ItemFilter = new ItemFilter {
            Name = "ListingType",
            Value = new List<string> {
                "Auction",
                "FixedPrice"
            }
        },
    };

    var findItemsByKeywordsResponse = await findingService.FindItemsByKeywordsAsync(findItemsByKeywordsRequest);

    return Results.Ok(findItemsByKeywordsResponse);
});

app.Run();
```

## Implemented API Operations
- [ ] Buy API
- [ ] Sell API
- [ ] Commerce API
- [ ] Developer API
- [ ] Finding API
- [ ] Shopping API
- [ ] Trading API

## Contributing
We welcome contributions from the community. If you'd like to contribute to eBay.Sharp, please follow our Contribution Guidelines.

## License
eBay.Sharp is released under the MIT License. See LICENSE for details.

## Contact
For bug reports or feature requests, please open an issue.
