namespace MathMech_lessons

open System.Reflection

module Main =
    // Возведение в степень
    let f1 (x: float) (y: int) : float =
        if x = 0.0 && y = 0 then
            printfn "Undefined"
            0.0
        elif x = 0.0 then
            0.0
        elif x = 1.0 then
            1.0
        else if y < 0 then
            let mutable p = 1.0

            for n in 0..-1..y do
                p <- p * (1.0 / x)

            p
        elif y = 0 then
            1.0
        else
            let mutable k = 1.0

            for m in 1..y do
                k <- k * x

            k

    [<EntryPoint>]
    let main (argv: string array) = 0
