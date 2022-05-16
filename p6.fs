// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System
let suma a b = a+b
let resta a b= a-b
let multi a b=a*b
let div a b=a/b
[<EntryPoint>]
let main argv = 
    //printfn "Hola" 
    Console.WriteLine("======CALCULADORA========")
    Console.WriteLine("Introduzca 2 numero: ")
    let num1= Console.ReadLine()
    let num2= Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    Console.WriteLine("La suma de "+valor1.ToString()+" y "+valor2.ToString()+ " es: "+valor3.ToString())
    let valor3 = resta valor1 valor2
    Console.WriteLine("La Resta de "+valor1.ToString()+" y "+valor2.ToString()+ " es: "+valor3.ToString())
    let valor3 = multi valor1 valor2
    Console.WriteLine("La Multiplicacion de "+valor1.ToString()+" y "+valor2.ToString()+ " es: "+valor3.ToString())
    let valor3 = div valor1 valor2
    Console.WriteLine("La Division de "+valor1.ToString()+" y "+valor2.ToString()+ " es: "+valor3.ToString())


    let tecla= Console.ReadKey()
   
    0 // devolver un código de salida entero