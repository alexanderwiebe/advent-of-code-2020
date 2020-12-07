namespace services

open System
open System.Text.RegularExpressions

module Day06 =
    let grouping (answers:seq<string>) =
        answers
            |> Seq.toArray
            |> Array.fold (fun acc item -> match item with
                          | "" -> Array.append acc [|"";|]
                          | _ when acc.Length >= 2 -> Array.append acc.[..acc.Length-2] [|acc.[acc.Length-1] + item|]
                          | _ when acc.Length = 1 -> [|acc.[0] + item|]
                          | _ -> [|item|]) [||]
            
    let counting (ansGroup: string[]) =
        ansGroup
            |> Array.map (fun answers -> answers |> Seq.toList |> Set.ofList |> Set.count)
            
    let runner (answers:seq<string>) =
        answers
            |> grouping
            |> counting
            |> Array.sum