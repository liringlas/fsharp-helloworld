// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

// Getting an array if int
let range from until = 
    [|from..until|]

let fromZero = range 0

printfn "%A" (fromZero 15)

let heroes =
    [|"Emily"; "Akhmed"; "Gruntor"; "Gwydion"; "Rakshas"; "Konstantin"; ""; " "; "   "|]

let isEqual a b =
    a = b

let isNotEqual a b =
    a <> b

let printerate items =
    for item in items do
        printfn "Iterating %d" item

let printString item = 
    printfn "Printing %s" item

let isValidString str =
    String.IsNullOrWhiteSpace str |> not

let isRakshas hero =
    hero = "Rakshas"

[<EntryPoint>]
let main argv =

    // One way to iterate
    printerate (range 0 15)


    // Equality checks 
    isEqual 1 1 |> printfn "Is it equal? %b"
    isNotEqual 1 2 |> printfn "Is it NOT equal? %b"

    // Other way for boolean equality reverse
    isEqual 1 2 
    |> not 
    |> printfn "Is it equal |> NOT? %b"

    // Another way to iterate
    heroes
    |> Array.filter isValidString
    |> Array.iter printString 

    let person =
        if argv.Length > 0 then
            argv.[0]
        else
            "Anonymous"

    let mutable enemy = "Anonymous"
    let isRakshasAmongHeroes = Array.tryFind isRakshas heroes

    if isRakshasAmongHeroes |> Option.isNone |> not then
        enemy <- "Rakshas"

    printfn "The enemy is %s" enemy
            
    printfn "Hello world from %s" person
    printfn "Arguments: %A" argv
    0 // return an integer exit code 