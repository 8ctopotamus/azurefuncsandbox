namespace AzureFunctions.Function

open System
open System.IO
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module SimpleHttpTrigger = 
  [<FunctionName ("SimpleHttpTrigger")>]
  let run ([<HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)>]req: HttpRequest) (log: ILogger) =
    async {
      log.LofInformation("F# HTTP trigger function processed a request.")
    } |> Async.StartAsTask