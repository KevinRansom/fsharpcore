// Learn more about F# at http://fsharp.org

open System


[<EntryPoint>]
let main argv =
    // If .tail doesn't happen will overflow
    let mutable str = ""
    let rec addValueToString (y:int) =
        if y > 0 then
            str <- str + (sprintf "%d" y)
            addValueToString (y - 1)
    let _ = addValueToString 65000

    printfn "Length of string should be: %d is actually: %d" 313894 (str.Length)
    Console.ReadLine()
    0 // return an integer exit code
