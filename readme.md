# Azure HTTP Func Sandbox

Messing around with Azure HTTP Functions in `F#`.

**To run locally**

`dotnet build && func host start`

**Endpoint URL:**

`http://localhost:7071/api/SimpleHttpTrigger`

## Resources:

### [Writing Azure Functions in F#](https://medium.com/datarisk-io/introdu%C3%A7%C3%A3o-ao-azure-functions-em-f-e083727662ed)

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
      <Compile Include="MyFuncName.fs" />
    </None>
  </ItemGroup>
</Project>

```

### [Deploying F# Azure Functions](https://medium.com/datarisk-io/deploying-f-azure-functions-93ad5cebe8d4)