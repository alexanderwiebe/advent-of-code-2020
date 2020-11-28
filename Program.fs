// Learn more about F# at http://fsharp.org

open System
open System.IO

let asdf = "wut up"

[<EntryPoint>]
let main argv =  
  let parseFile = File.ReadAllLines("numbers.txt")
  let parseList = 
    parseFile 
      |> Array.map(fun n -> n.Split(" ") ) 
      |> Array.reduce Array.append
  parseList |> Array.iter( fun n -> printfn "%s" n)
  // let numbers = parseFile |> List.map( fun n -> printfn "%c" n)
  let intList = parseList |> Array.map int

  let total = intList |> Array.sum
  printfn "total: %i" total
  printfn "Hello World from F#!"
  let fdsa = asdf + " asdf"
  0 // return an integer exit code
