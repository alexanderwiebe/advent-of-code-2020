open System
open System.IO
open services

[<EntryPoint>]
let main argv =
  printfn "Welcome to advent of code day 3"
  let parseFile = File.ReadAllLines("day03.data")
  
  let total =
      [
          Day03.runSled parseFile 1 1
          Day03.runSled parseFile 3 1
          Day03.runSled parseFile 5 1
          Day03.runSled parseFile 7 1
          Day03.runSled parseFile 1 2
      ] |> Seq.reduce (fun acc item -> acc * item)

  printfn "total: %i" total
  Console.ReadKey() |> ignore
  0 // return an integer exit code
