namespace services

open System
open System.Text.RegularExpressions

module Day06 =
    let binaryParse (bas:int) (str:string) = Convert.ToInt32(str, bas)
    let rowCount (ticket:string) =
        ticket.Substring(0, 7)
        |> Seq.map (fun row -> match row with
            | 'F' -> '0'
            | 'B' -> '1'
            | _ -> '0')
        |> String.Concat
        |> binaryParse 2
        
    let colCount (ticket:string) =
        ticket.Substring(7,3)
        |> Seq.map (fun col -> match col with
                    | 'L' -> '0'
                    | 'R' -> '1'
                    | _ -> '0')
        |> String.Concat
        |> binaryParse 2
        
    let seatId (ticket:string) = ((rowCount ticket) * 8) + (colCount ticket)
    
    let runner tickets =
        tickets
        |> Seq.map seatId
        |> Seq.max
        
    let runner2 tickets =
        tickets
        |> Seq.map seatId
        |> Seq.sort
        |> Seq.pairwise
        |> Seq.filter (fun (a, b) -> a+1 <> b)
        |> Seq.head
        |> fun (a, _) -> a + 1
        