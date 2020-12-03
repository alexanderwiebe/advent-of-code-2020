module Day03.test

open System
open System.IO
open Xunit
open services

[<Fact>]
let ``should reduce string list to char list`` () =
    let input = File.ReadAllLines("day03sample.data")
    let actual = input |> Seq.mapi (fun i row -> row.Substring((i*3 % row.Length) , 1))
    let expected = [|".";".";"#";".";"#";"#";".";"#";"#";"#";"#"|]
    Assert.Equal(expected, actual)

[<Fact>]
let ``should reduce then convert`` () =
    let input = File.ReadAllLines("day03sample.data")
    let actual = input |> Seq.mapi (fun i row -> match row.Substring((i*3 % row.Length) , 1) with
                                                    | "." -> 0
                                                    | "#" -> 1)
    let expected = [|0;0;1;0;1;1;0;1;1;1;1|]
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``should do above and sum`` () =
    let input = File.ReadAllLines("day03sample.data")
    let actual = input |> Seq.mapi (fun i row -> match row.Substring((i*3 % row.Length) , 1) with
                                                    | "." -> 0
                                                    | "#" -> 1)
                       |> Seq.sum
    let expected = 7
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``should work the same with the day03 function``  () =
    let input = File.ReadAllLines("day03sample.data")
    let actual = Day03.runSled input
    let expected = 7
    Assert.Equal(expected, actual)