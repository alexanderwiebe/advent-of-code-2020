open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcome to advent of code day 6"
  let parseFile = File.ReadAllLines("day06.data")
  
  let total = Day06.runner parseFile

  printfn "total: %i" total
  Console.ReadKey() |> ignore
  0 // return an integer exit code
