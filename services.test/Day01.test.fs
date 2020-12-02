module Day01.test

open System
open Xunit
open services

[<Fact>]
let ``should convert strings to ints`` () =
    let expected = 241861950
    let actual = Day01.findDoubles [|"1721"; "979"; "366"; "299"; "675"; "1456"|]
    Assert.Equal(expected, actual)
