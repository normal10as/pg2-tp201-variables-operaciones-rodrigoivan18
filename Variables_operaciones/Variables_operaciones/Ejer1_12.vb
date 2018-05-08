Module Ejer1_12

    'Ingresar un número real por teclado y mostrar su valor aproximado por exceso, su valor
    'aproximado por defecto y su valor redondeado.

    Sub Main()

        Dim numero As Single

        Console.Write("Ingrese un número: ")
        numero = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso {0}", numero, Math.Ceiling(numero))
        Console.WriteLine("Valor aproximado por defecto {0}", numero, Math.Floor(numero))
        Console.WriteLine("Valor redondeado {0}", numero, Math.Round(numero))

        Console.ReadKey()

    End Sub

End Module
