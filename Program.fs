// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let calcDistance (input:string) =
    input.ToCharArray()
        |> Array.toSeq 
        |> Seq.pairwise
        |> Seq.map(fun x -> ("123456789.0".IndexOf(snd x), "123456789.0".IndexOf(fst x)))
        |> Seq.sumBy (fun x-> System.Math.Sqrt(System.Math.Pow(float(fst (x) / 3 - snd (x) / 3), 2.0) + System.Math.Pow(float(fst (x) % 3 - snd (x) % 3), 2.0)))
                
[<EntryPoint>]
let main argv = 
    let testData = ["7851"; "219.45.143.143";"123456789.0"]        

    for i in testData do
        printfn "%s -> %0.02f" i (calcDistance i)

    //List.zip input.Tail
    //    |> printfn "%A "
    
    System.Console.ReadKey() |> ignore
    
    0 // return an integer exit code
