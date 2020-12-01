open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcom to advent of code day 1"
  let parseFile = File.ReadAllLines("day01.data")
  
  let total = Day1.findDoubles parseFile

  printfn "total: %i" total
  System.Console.ReadKey()
  0 // return an integer exit code
