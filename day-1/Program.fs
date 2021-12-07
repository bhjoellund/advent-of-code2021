open System
open System.IO

let mapSum (xs: seq<int array>) =
    Seq.map (fun (xs: int array) -> if xs[0] < xs[1] then 1 else 0) xs |> Seq.sum

let first lines =
    lines
    |> Seq.windowed 2
    |> mapSum

let second lines =
    lines
    |> Seq.windowed 3
    |> Seq.map Seq.sum
    |> Seq.windowed 2
    |> mapSum

[<EntryPoint>]
let main _ =
    let filename = "input.txt"
    let lines =  File.ReadLines filename |> Seq.map int
    first lines |> printfn "%d"
    second lines |> printfn "%d"
    0
