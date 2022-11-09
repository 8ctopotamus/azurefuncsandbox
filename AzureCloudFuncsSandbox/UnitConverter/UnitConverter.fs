namespace UnitConverter

open System
open System.IO
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module UnitConverter =
  let celsiusToFahrenheit c = (c * 9/5) + 32

  [<FunctionName("UnitConverter")>]
  let run ([<HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)>]req: HttpRequest) (log: ILogger) =
    async {
      log.LogInformation("F# HTTP trigger function processed a request.")

      let celsiusOpt =
        if req.Query.ContainsKey("celcius") then
          Some(int req.Query.["celcius"].[0])
        else 
          None

      let response =
        match celsiusOpt with
        | Some c -> celsiusToFahrenheit c |> string
        | None -> ""
        
      return OkObjectResult(response) :> IActionResult

    } |> Async.StartAsTask