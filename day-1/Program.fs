open System
open System.IO

let first filename =
    File.ReadLines filename
        |> Seq.map int
        |> Seq.windowed 2
        |> Seq.map (fun xs -> if xs[0] < xs[1] then 1 else 0)
        |> Seq.sum
        |> printfn "%d"

let second filename =
    File.ReadLines filename
        |> Seq.map int
        |> Seq.windowed 3
        |> Seq.map Seq.sum
        |> Seq.windowed 2
        |> Seq.map (fun xs -> if xs[0] < xs[1] then 1 else 0)
        |> Seq.sum
        |> printfn "%d"

[<EntryPoint>]
let main argv =
    let filename = "input.txt"
    first filename
    second filename
                 // (fun xs -> match xs |> Seq.toList with | head :: tail -> Seq.fold (fun (s, c) t -> if t < s then (t, c + 1) else (t, c)) (head, 0) tail |> snd | _ -> 0)
    0 // return an integer exit code
