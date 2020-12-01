namespace services

open System

module Day1 =
    let findDoubles list =
        list 
        |> Seq.collect (fun item -> list |> Seq.map(fun newItem -> (newItem, item)))
        |> Seq.map (fun (a, b) -> (System.Int32.Parse(a), System.Int32.Parse(b)))
        |> Seq.find (fun elem -> fst elem + snd elem = 2020)
        |> fun elem -> fst elem * snd elem