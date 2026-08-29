[![](https://img.shields.io/nuget/v/soenneker.dtos.problemdetails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.problemdetails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.problemdetails/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.problemdetails/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.problemdetails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.problemdetails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.problemdetails/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.problemdetails/actions/workflows/codeql.yml)

# Soenneker.Dtos.ProblemDetails

Describes a machine-readable API error without requiring a dependency on ASP.NET Core MVC's problem-details type.

## Install

```bash
dotnet add package Soenneker.Dtos.ProblemDetails
```

## What you get

- `ProblemDetailsDto` — Describes a machine-readable API error without requiring a dependency on ASP.NET Core MVC's problem-details type.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ProblemDetailsDto.Type` | URI reference that identifies the problem category and may resolve to human-readable documentation. When omitted, clients may treat it as `about:blank`. | URI reference that identifies the problem category and may resolve to human-readable documentation. When omitted, clients may treat it as `about:blank`. |
| `ProblemDetailsDto.Title` | Short, human-readable summary of the problem category. It should remain consistent across occurrences except when localized. | Short, human-readable summary of the problem category. It should remain consistent across occurrences except when localized. |
| `ProblemDetailsDto.Status` | HTTP status code generated for this occurrence of the problem. | HTTP status code generated for this occurrence of the problem. |
| `ProblemDetailsDto.Detail` | A human-readable explanation specific to this occurrence of the problem. | A human-readable explanation specific to this occurrence of the problem. |
| `ProblemDetailsDto.Instance` | URI reference that identifies this specific occurrence of the problem and may resolve to additional information. | URI reference that identifies this specific occurrence of the problem and may resolve to additional information. |
| `ProblemDetailsDto.Extensions` | Additional problem-specific members serialized alongside the standard fields. Problem type definitions MAY extend the problem details object with additional members. Extension members appear in the same namespace as other members of a problem type. | The round-tripping behavior for `Extensions` is determined by the implementation of the Input \ Output formatters. In particular, complex types or collection types may not round-trip to the original type when using the built-in JSON or XML formatters. |

## Important behavior

- `ProblemDetailsDto.Extensions`: The round-tripping behavior for `Extensions` is determined by the implementation of the Input \ Output formatters. In particular, complex types or collection types may not round-trip to the original type when using the built-in JSON or XML formatters.
