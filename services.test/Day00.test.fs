module Day00.test

open System
open System.IO
open Xunit
open services

let sampleInput = File.ReadLines("day06sample.data")


[<Fact>]
let ``grouping works`` () =
    let expected = true
    let actual = true
    Assert.Equal(expected, actual)
    