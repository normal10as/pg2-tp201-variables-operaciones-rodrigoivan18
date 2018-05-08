Module Ejer1_15

    'Crear un programa que lea separadamente un número de día (1 a 31) y una hora (0 a 24).
    'Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla.

    Sub Main()

        Dim numero_de_dia As UShort
        Dim hora As UShort
        Dim fecha As Date = Now

        Console.Write("Ingrese número de dias {1 a 31}: ")
        numero_de_dia = Console.ReadLine()

        Console.WriteLine()

        Console.Write("Ingrese una hora {0 a 24}: ")
        hora = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine(New Date(fecha.Year, fecha.Month, numero_de_dia, hora, fecha.Minute, 0))

        Console.ReadKey()

    End Sub

End Module
