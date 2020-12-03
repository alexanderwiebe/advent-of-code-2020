namespace services

open System
open System.Text.RegularExpressions

module Day03 =
    let runSled input =
        input
        |>  Seq.mapi (fun i (row:string) ->
                match row.Substring((i*3 % row.Length) , 1) with
                | "." -> 0
                | "#" -> 1
                | _ -> 0)
        |> Seq.sum