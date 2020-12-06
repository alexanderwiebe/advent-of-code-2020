module Day06.test

open System
open System.IO
open Xunit
open services

let samp0 = "FBFBBFFRLR" // row 44, 
let samp1 = "BFFFBBFRRR" //row 70, column 7, seat ID 567.
let samp2 = "FFFBBBFRRR" //row 14, column 7, seat ID 119.
let samp3 = "BBFFBBFRLL" //row 102, column 4, seat ID 820.


[<Fact>]
let ``row test`` () =
    let expected = 44
    let actual = Day05.rowCount samp0
    Assert.Equal(true, true)
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``col test`` () =
    let expected = 5
    let actual = Day05.colCount samp0
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``seat id 0`` () =
    let expected = 357
    let actual = Day05.seatId samp0
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``seat id 1`` () =
    let expected = 567
    let actual = Day05.seatId samp1
    Assert.Equal(expected, actual)

[<Fact>]
let ``seat id 2`` () =
    let expected = 119
    let actual = Day05.seatId samp2
    Assert.Equal(expected, actual)

[<Fact>]
let ``seat id 3`` () =
    let expected = 820
    let actual = Day05.seatId samp3
    Assert.Equal(expected, actual)