module Day1.test

open System
open Xunit
open services

[<Fact>]
let ``should convert strings to ints`` () =
    let expected = [2; 4; 6; 8; 10]
    let actual = Day1.findDoubles [|"2"; "4"; "6"; "8"; "10"|]
    Assert.Equal(expected, actual)