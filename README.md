[![](https://img.shields.io/nuget/v/soenneker.dtos.problemdetails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.problemdetails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.problemdetails/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.problemdetails/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.problemdetails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.problemdetails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.problemdetails/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.problemdetails/actions/workflows/codeql.yml)

# Soenneker.Dtos.ProblemDetails

A serializer-friendly problem-details DTO for APIs and clients that do not want a dependency on ASP.NET Core MVC's `ProblemDetails` type. It supports both `System.Text.Json` and Newtonsoft.Json.

## Install

```bash
dotnet add package Soenneker.Dtos.ProblemDetails
```

## Create a problem response

```csharp
using Soenneker.Dtos.ProblemDetails;

var problem = new ProblemDetailsDto
{
    Type = "https://api.example.com/problems/invalid-order",
    Title = "The order is invalid",
    Status = 400,
    Detail = "At least one line item is required.",
    Instance = "/orders/8f25"
};

problem.Extensions["orderId"] = "8f25";
problem.Extensions["retryable"] = false;
```

Extension entries are flattened into the top-level JSON object:

```json
{
  "type": "https://api.example.com/problems/invalid-order",
  "title": "The order is invalid",
  "status": 400,
  "detail": "At least one line item is required.",
  "instance": "/orders/8f25",
  "orderId": "8f25",
  "retryable": false
}
```

All standard members are optional. Newtonsoft.Json omits null standard members because its attributes specify `NullValueHandling.Ignore`; with `System.Text.Json`, null omission follows the options supplied to your serializer.

`Status` is payload data only—it does not set an HTTP response's status code. When deserializing, extension values may materialize as serializer-specific types such as `JsonElement` or `JToken`, so avoid assuming they round-trip to their original CLR types.
