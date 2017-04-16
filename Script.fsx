#load "FizzBuzz.fs"
open FizzBuzz
let fizzBuzz : unit =
    for i in 1 .. 100 do
        if (i % 3 = 0 && i % 5 = 0) then
            printfn "FizzBuzz"
        if (i % 3 = 0) then
            printfn "Fizz"
        if (i % 5 = 0) then
            printfn "Buzz"
