Module Ejer1_6
    'Crear un programa que calcule la sumatoria y la media de cuatro números enteros ingresados
    'por teclado.

    Sub Main()
        Dim a, b, c, d As Byte
        Dim suma As UShort

        Console.Write("Ingrese un número {0 - 255}: ")
        a = Console.ReadLine()

        Console.Write("Ingrese un número {0 - 255}: ")
        b = Console.ReadLine()

        Console.Write("Ingrese un número {0 - 255}: ")
        c = Console.ReadLine()

        Console.Write("Ingrese un número {0 - 255}: ")
        d = Console.ReadLine()

        suma = a + b + c + d

        Console.WriteLine("La sumatoria de los 4 numeros ingresados es {0} y la media es {1}", suma, suma / 4)

        Console.ReadKey()
    End Sub

End Module
