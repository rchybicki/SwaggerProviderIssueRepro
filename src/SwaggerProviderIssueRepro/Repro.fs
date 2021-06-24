module Rhumbix

open SwaggerProvider

//type RhumbixLiveApi = SwaggerClientProvider<RhumbixSwaggerUrl>

type TestProvider = SwaggerClientProvider<"https://platform.rhumbix.com/public_api/v2/docs/schema.json">

let code = () //Code.code ()
