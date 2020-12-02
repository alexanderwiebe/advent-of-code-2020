namespace services

open System

module Day2 =
    let findDoubles list =
        list 
        |> Seq.collect (fun item -> list |> Seq.map(fun newItem -> (newItem, item)))
        |> Seq.collect (fun (a,b) -> list |> Seq.map(fun double -> (a, b, double)))
        |> Seq.map (fun (a, b, c) -> (System.Int32.Parse(a), System.Int32.Parse(b), System.Int32.Parse(c)))
        |> Seq.find (fun (a, b, c) -> a + b + c = 2020)
        |> fun (a, b, c) -> a * b * c