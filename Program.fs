open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcome to advent of code day 3"
  let parseFile = File.ReadAllLines("day03.data")
  
  let total = Day03.runSled parseFile

  printfn "total: %i" total
  Console.ReadKey() |> ignore
  0 // return an integer exit code
