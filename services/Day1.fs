namespace services

open System

module Day1 =
    let findDoubles list = list |> Seq.map System.Int32.Parse
        