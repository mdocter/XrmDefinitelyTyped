﻿namespace DG.XrmDefinitelyTyped

open System
open Microsoft.Xrm.Sdk.Client

type XrmAuthentication = {
  url: Uri
  username: string
  password: string
  domain: string option
  ap: AuthenticationProviderType option
}

type XrmVersion = int * int * int * int

type FormIntersect = string * Guid[]

type XrmDefinitelyTypedSettings = {
  out: string option
  entities: string[] option
  solutions: string[] option
  crmVersion: XrmVersion option
  formIntersects: FormIntersect [] option
}
