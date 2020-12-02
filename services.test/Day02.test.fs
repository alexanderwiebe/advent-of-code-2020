module Day02.test

open System
open Xunit
open services

[<Fact>]
let ``should parse a password`` () =
    let expected = ["1-3"; "a:"; "abcde";]
    let actual = Day02.parsePassword "1-3 a: abcde"
    Assert.Equal(expected, actual)
