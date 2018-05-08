Module Ejer1_11

    '    Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la
    'décima potencia y su raíz cuadrada.

    Sub Main()
        Dim numero As Short

        Console.Write("Ingrese un número: ")
        numero = Console.ReadLine()

        Console.WriteLine("El valor absoluto de {0} es {1}", numero, Math.Abs(numero))
        Console.WriteLine("El resultado de elevar {0} a la décima potencia es {1}", numero, Math.Pow(numero, 10))
        Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, Math.Sqrt(numero))

        Console.ReadKey()

    End Sub

End Module
