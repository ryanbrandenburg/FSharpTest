namespace AspNet.Template.ac841e6f568d457aa6c686af5ed8f550

open System

type ErrorViewModel private () =
    member val RequestId : string = null with get, set

    member val ShowRequestId : bool = true with get, set
