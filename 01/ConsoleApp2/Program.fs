open System

// Функция для считывания римских цифр от пользователя
let rec readRoman acc =
    let input = Console.ReadLine()
    if input = "000" then
        List.rev acc  // Разворачиваем список, чтобы сохранить порядок ввода
    else
        readRoman (input :: acc)  // Добавляем введённую цифру в аккумулятор

[<EntryPoint>]
let main argv =
    printfn "Введите римские цифры (I, II, III, IV, V, VI, VII, VIII, IX):"
    printfn "(000 — конец ввода)"
    
    // Считываем список римских цифр от пользователя
    let romanNumerals = readRoman []
    
    // Преобразуем список римских цифр в десятичные числа с помощью List.map
    let decimalNumbers =
        List.map (fun roman ->
            match roman with
            | "I" -> 1
            | "II" -> 2
            | "III" -> 3
            | "IV" -> 4
            | "V" -> 5
            | "VI" -> 6
            | "VII" -> 7
            | "VIII" -> 8
            | "IX" -> 9
            | _ -> 0  // На случай неизвестной римской цифры
        ) romanNumerals
    
    // Выводим результаты
    printfn "Римские цифры: %A" romanNumerals
    printfn "Десятичные числа: %A" decimalNumbers
    0