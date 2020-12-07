module Day06.test

open System
open System.IO
open Xunit
open services

let sampleInput = File.ReadLines("day06sample.data")


[<Fact>]
let ``grouping works`` () =
    let expected = ["a"; "abcd"; "efgh";]
    let actual = Day06.grouping [|"a"; ""; "ab"; "cd"; ""; "ef"; "gh"|]
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``grouping sample data`` () =
    let input = [|"abc"; ""; "a"; "b"; "c"; ""; "ab"; "ac"; ""; "a"; "a"; "a"; "a"; ""; "b"|]
    let expected = ["abc"; "abc"; "abac"; "aaaa"; "b"]
    let actual = Day06.grouping input
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``counting sample data`` () =
    let input = [|"abc"; ""; "a"; "b"; "c"; ""; "ab"; "ac"; ""; "a"; "a"; "a"; "a"; ""; "b"|]
    let expected = [3; 3; 3; 1; 1]
    let actual = Day06.counting <| Day06.grouping input
    Assert.Equal(expected, actual)
    