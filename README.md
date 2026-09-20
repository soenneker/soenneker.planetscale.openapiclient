[![](https://img.shields.io/nuget/v/soenneker.planetscale.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.planetscale.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.planetscale.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.planetscale.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.planetscale.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.planetscale.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.PlanetScale.OpenApiClient
### A generated OpenAPI client for PlanetScale.

## Installation

```
dotnet add package Soenneker.PlanetScale.OpenApiClient
```

## Generated API

Generated with Kiota from https://api.planetscale.com/v1/openapi-spec.
`openapi.json` records the downloaded specification; `openapi.fixed.json` records
the normalized input used for generation. Source includes the request builders
and models for the full specification.

For dependency injection and service-token authentication, use
`Soenneker.PlanetScale.OpenApiClientUtil`. For direct use, construct
`PlanetScaleOpenApiClient` with a configured Kiota `IRequestAdapter`.

Regenerate using `Soenneker.PlanetScale.Runners.OpenApiClient`; see that repository's
README for the local command. Generated source should be changed through the runner.
