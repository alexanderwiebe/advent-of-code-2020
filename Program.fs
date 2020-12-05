open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcome to advent of code day 5"
  let parseFile = File.ReadAllLines("day05.data")
  
  let total = Day05.runner2 parseFile

  printfn "total: %i" total
  Console.ReadKey() |> ignore
  0 // return an integer exit code
