namespace services

open System
open System.Text.RegularExpressions

module Day02 =
    let parsePassword (passwordConfig:string) : string [] = passwordConfig.Split(" ")
    
    
    let createRegex (passwordParsed: string[]) :string =
        match passwordParsed with
        | [| quantity; seek; _; |] ->
            let regexes = quantity.Split("-")
            $"{seek.Substring(0,1)}{{{regexes.[0]},{regexes.[1]}}}"
            
    let createMinMax (passwordParsed: string[]) :(int * int) =
        match passwordParsed with
        | [| quantity; seek; _; |] ->
            let regexes = quantity.Split("-")
            (Int32.Parse regexes.[0], Int32.Parse regexes.[1])
            
    let checkRegex text regex =
        if Regex.IsMatch(text, regex) then 1
        else 0
    
    let checkRange (text:string) (minMax:int * int) =
        if text.Length >= fst minMax && text.Length <= snd minMax then 1
        else 0
      
    let runner passwordList =
        passwordList |> Seq.map parsePassword
        |> Seq.map (fun passParts -> passParts |> createMinMax |> checkRange (Regex.Replace(passParts.[2], $"[^{passParts.[1].Substring(0,1)}]", ""))) 
// |> checkRegex (Regex.Replace(passParts.[2], $"[^{passParts.[1].Substring(0,1)}]", "")))
        |> Seq.sum