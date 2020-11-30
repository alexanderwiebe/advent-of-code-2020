namespace services

open System

module Day1 =
    let findDoubles list = list |> Seq.map System.Int32.Parse |> Seq.pairwise |> Seq.find (fun elem -> fst elem + snd elem = 20) |> fun elem -> fst elem * snd elem