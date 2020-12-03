module Day02.test

open System
open Xunit
open services

[<Fact>]
let ``should parse a password`` () =
    let expected = ["1-3"; "a:"; "abcde";]
    let actual = Day02.parsePassword "1-3 a: abcde"
    Assert.Equal(expected, actual)

[<Fact>]
let ``should convert initial parts to regex`` () =
    let expected = "a{1,3}"
    let actual = Day02.createRegex [|"1-3"; "a:"; "abcde";|]
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``should return 1 if match`` () =
    let expected = 1
    let actual = Day02.checkRegex "abcde" "a{1,3}"
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``should return 0 if not a match`` () =
    let expected = 0
    let actual = Day02.checkRegex "cdefg" "b{1,3}"
    Assert.Equal(expected, actual)
    
[<Fact>]
let ``should run across a list of possibilities`` () =
    let expected = 2
    let input = [|
        "1-3 a: abcde"
        "1-3 b: cdefg"
        "2-9 c: ccccccccc"
    |]
    let actual = Day02.runner input
    Assert.Equal(expected, actual)

[<Fact>]
let ``sample from real data`` () =
    let expected = 2
    let input = [|
        "2-6 c: fcpwjqhcgtffzlbj"
        "6-9 x: xxxtwlxxx"
        "5-6 w: wwwwlwwwh"
        "7-10 q: nfbrgwqlvljgq"
        "2-3 g: gjggg"
    |]
    let actual = Day02.runner input
    Assert.Equal(expected, actual)


