module Day04.test

open System
open System.IO
open Xunit
open services

[<Fact>]
let ``validate the formatting`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isFormatted input
    Assert.Equal(true, actual)

[<Fact>]
let ``validate the birth year`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isBirthYear input
    Assert.Equal(true, actual)

[<Fact>]
let ``validate the issue year`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isIssueYear input
    Assert.Equal(true, actual)

[<Fact>]
let ``validate the expire year`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isExpired input
    Assert.Equal(true, actual)
    
[<Fact>]
let ``validate the height`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isHeight input
    Assert.Equal(true, actual)
  
[<Fact>]
let ``validate the haircolor`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isHairColor input
    Assert.Equal(true, actual)
  
[<Fact>]
let ``validate the eyecolor`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isEyeColor input
    Assert.Equal(true, actual)
    
[<Fact>]
let ``validate the passport id`` () =
    let input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm"
    let actual = Day04.isPassportID input
    Assert.Equal(true, actual)
    
[<Fact>]
let ``validate the runner on sample`` () =
    let input = File.ReadAllLines("day04sampleregexed.data")
    let actual = Day04.runner input
    Assert.Equal(2, actual)
    
[<Fact>]
let ``validate the runner on other`` () =
    let input = File.ReadAllLines("day04p2sampleregexed.data")
    let actual = Day04.runner input
    Assert.Equal(4, actual)