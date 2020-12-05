namespace services

open System
open System.Text.RegularExpressions

module Day04 =
    let isFormatted passport = Regex.IsMatch(passport, "(?=.*byr)(?=.*iyr)(?=.*eyr)(?=.*hgt)(?=.*hcl)(?=.*ecl)(?=.*pid).*$")
    
    let isBirthYear passport = Regex.Match(passport, "byr:(.*?)(\s|$)").Groups.[1].Value |> int |> fun byr -> byr >= 1920 && byr <= 2002
    let isIssueYear passport = Regex.Match(passport, "iyr:(.*?)(\s|$)").Groups.[1].Value |> int |> fun iyr -> iyr >= 2010 && iyr <= 2020
    let isExpired passport = Regex.Match(passport, "eyr:(.*?)(\s|$)").Groups.[1].Value |> int |> fun eyr -> eyr >= 2020 && eyr <= 2030
    let isHeight passport = Regex.Match(passport, "hgt:(.*?)(\s|$)").Groups.[1].Value |> function
        | text when text.EndsWith("in") -> Regex.Match(text, "(\d+)in").Groups.[1].Value |> int |> fun hgt -> hgt >= 59 && hgt <= 76
        | text when text.EndsWith("cm") -> Regex.Match(text, "(\d+)cm").Groups.[1].Value |> int |> fun hgt -> hgt >= 150 && hgt <= 193
        | _ -> false
    
    let isHairColor passport = Regex.Match(passport, "hcl:(.*?)(\s|$)").Groups.[1].Value
                               |> fun hcl -> hcl.Length = 7 && Regex.IsMatch(hcl, "[a-f0-9]{6}")
    let isEyeColor passport = Regex.Match(passport, "ecl:(.*?)(\s|$)").Groups.[1].Value |> function
        | "amb" | "blu" | "brn" | "gry" | "grn" | "hzl" | "oth" -> true
        | _ -> false
    let isPassportID passport = Regex.Match(passport, "pid:(.*?)(\s|$)").Groups.[1].Value
                                |> fun pid -> pid.Length = 9 && Regex.IsMatch(pid, "\d{9}")
 
    let runner passports =
        passports
        |> Seq.filter isFormatted
        |> Seq.filter isBirthYear
        |> Seq.filter isIssueYear
        |> Seq.filter isExpired
        |> Seq.filter isHeight
        |> Seq.filter isHairColor
        |> Seq.filter isEyeColor
        |> Seq.filter isPassportID
        |> Seq.length

// byr (Birth Year) - four digits; at least 1920 and at most 2002.
//iyr (Issue Year) - four digits; at least 2010 and at most 2020.
//eyr (Expiration Year) - four digits; at least 2020 and at most 2030.
//hgt (Height) - a number followed by either cm or in:
//If cm, the number must be at least 150 and at most 193.
//If in, the number must be at least 59 and at most 76.
//hcl (Hair Color) - a # followed by exactly six characters 0-9 or a-f.
//ecl (Eye Color) - exactly one of: amb blu brn gry grn hzl oth.
//pid (Passport ID) - a nine-digit number, including leading zeroes.
//cid (Country ID) - ignored, missing or not.