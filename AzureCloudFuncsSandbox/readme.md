# Azure HTTP Func Sandbox

Messing around with Azure HTTP Functions in `F#`.

[Example of connecting MSAL](https://dev.azure.com/braustin-holdings/Main/_git/pipedrive-facade?path=/src/seed-customers/Program.fs)

**To run locally**

`dotnet build && func host start`

**Endpoint URL:**

`http://localhost:7071/api/SimpleHttpTrigger`

## Resources:
* [Work with Azure Functions Core Tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local?tabs=v4%2Clinux%2Ccsharp%2Cportal%2Cbash)
* [MS Azure Functions Reference](https://learn.microsoft.com/en-us/azure/azure-functions/functions-reference-fsharp)
* [Writing Azure Functions in F#](https://medium.com/datarisk-io/introdu%C3%A7%C3%A3o-ao-azure-functions-em-f-e083727662ed)
* [Deploying F# Azure Functions](https://medium.com/datarisk-io/deploying-f-azure-functions-93ad5cebe8d4)
* [Example with Auth Key](http://dontcodetired.com/blog/post/Azure-HTTP-Function-Authorization-with-Function-Keys)
* [CLI Create Functions](https://learn.microsoft.com/en-us/azure/azure-functions/scripts/functions-cli-create-serverless)

#### Create a new function:

1) `func init MyFuncName`

2) Update the `MyFuncName.csproj` to `MyFuncName.fsproj`.

3) Update the contents of `MyFuncName.fsproj`. 

**Original**

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <AzureFunctionsVersion>v4</AzureFunctionsVersion>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Sdk.Functions" Version="4.1.1" />
  </ItemGroup>
  <ItemGroup>
    <None Update="host.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="local.settings.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    </None>
  </ItemGroup>
</Project>
```

**Updated**

1) Change the `Update` attributes to `Includes`.
2) Add the `Condition` attribute.
3) Add the `<Compile>` tag.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <AzureFunctionsVersion>v4</AzureFunctionsVersion>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Sdk.Functions" Version="4.1.1" />
  </ItemGroup>
  <ItemGroup>
    <None Include="host.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Include="local.settings.json" Condition="Exists('local.settings.json')">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    </None>
    <Compile Include="MyFuncName.fs" />
  </ItemGroup>
</Project>
```

Next create a new file for the function's code: `UnitConverter.fs`. Boilerplace code can be found here:

### Deployment
...