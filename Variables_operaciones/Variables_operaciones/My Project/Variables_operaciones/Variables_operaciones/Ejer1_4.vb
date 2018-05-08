Module Ejer1_4

    'Crear un módulo llamado aritmética que Declare y asigne dos valores enteros y dos valores de
    'punto flotante. Luego demostrar las operaciones aritméticas básicas mezclando los tipos de
    'datos utilizados y mostrar los resultados por consola previo un mensaje adecuado. Por ejemplo:
    'sumar entero con entero, entero con punto flotante y punto flotante con punto flotante.

    Sub Main()

        Dim a As Short = 18
        Dim b As Short = 95
        Dim c As Single = 18.8
        Dim d As Single = 95.9595

        Console.WriteLine("Suma")
        Console.WriteLine("{0} + {1}: {2}", a, b, a + b)
        Console.WriteLine("{0} + {1}: {2}", c, d, c + d)
        Console.WriteLine("{0} + {1}: {2}", a, c, a + c)

        Console.WriteLine("Resta")
        Console.WriteLine("{0} - {1}: {2}", a, b, a - b)
        Console.WriteLine("{0} - {1}: {2}", c, d, c - d)
        Console.WriteLine("{0} - {1}: {2}", a, c, a - c)

        Console.WriteLine("Multiplicación")
        Console.WriteLine("{0} * {1}: {2}", a, b, a * b)
        Console.WriteLine("{0} * {1}: {2}", c, d, c * d)
        Console.WriteLine("{0} * {1}: {2}", a, c, a * c)

        Console.WriteLine("División")
        Console.WriteLine("{0} / {1}: {2}", b, a, b / a)
        Console.WriteLine("{0} / {1}: {2}", d, c, d / c)
        Console.WriteLine("{0} / {1}: {2}", d, a, d / a)

        Console.ReadKey()
    End Sub

End Module
