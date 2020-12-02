open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcome to advent of code day 1"
  let parseFile = File.ReadAllLines("day01.data")
  
  let total = Day01.findDoubles parseFile

  printfn "total: %i" total
  Console.ReadKey() |> ignore
  0 // return an integer exit code
