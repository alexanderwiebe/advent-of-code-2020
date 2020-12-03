namespace services

open System
open System.Text.RegularExpressions

module Day03 =
    let runSled input right down =
        input
        |>  Seq.mapi (fun i (row:string) ->
                match (row.Substring(((i/down)*right % row.Length) , 1), i % down) with
                | (".", _) when i % down = 0 -> 0
                | ("#", _) when i % down = 0 -> 1
                | _ -> 0)
        |> Seq.sum