open System

// Сисок пользователя
let rec readR acc =
    let ch = Console.ReadLine()
    if ch = "000" then
        List.rev acc
    else
        readR (int(ch) :: acc) 

[<EntryPoint>]
let main argv =
    printfn "Введите цифры (по одной):"
    printfn "(000 — конец ввода)"
    
    let nume = readR []
    
    let ch =
        List.fold (fun acc x ->
            if x % 2 = 0 then  
                acc * 10 + x  
                // + el (сдвигая разряды)
            else
                acc 
        ) 0 nume 
    
    printfn "Исходные цифры: %A" nume
    printfn "Число из чётных цифр: %i" ch
    0

