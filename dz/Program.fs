// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System;
let rec read() =
    match System.Double.TryParse(System.Console.ReadLine()) with
    | false, _ -> printfn "?"; read()
    | _, x -> x
let solve a b c =
  let disc = b * b - 4.0 * a *c
  let calc op = ((op (-b) (sqrt disc)) / (2.0*a))  
  calc (+), calc(-)
Console.Write("Введите коэффициент a: ");
let a = read();
Console.Write("Введите коэффициент b: ");
let b = read()
Console.Write("Введите коэффициент c: ");
let c = read()
Console.WriteLine("Ваше уравнение: {0}*x^2 + {1}*x + {2} = 0", a, b, c); 
Console.Write("Корни уравнения: ");
solve a b c |> printfn "%A"
Console.ReadKey() |> ignore

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
