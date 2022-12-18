
[<EntryPoint>]
let main args =

    let lines = System.IO.File.ReadAllLines args.[0]
    
    let mutable elves = []
    let mutable currentElve = 0

    for l in lines do 
        if l = "" then 
            elves <- elves @ [currentElve]
            currentElve <- 0
        else
            currentElve <- currentElve + (int l)
    elves <- elves @ [currentElve]

    printfn "Part 1: %A" (List.max elves)

    
    printfn "Part 2: %A" (List.sum (List.take 3 (List.sortDescending elves)))

    0
