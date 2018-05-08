Module Ejer1_9
    'Crear un programa que muestre las tablas de verdad booleanas (And, Or, Not y Xor)

    Sub Main()

        Dim v As Boolean = True
        Dim f As Boolean = False

        Console.WriteLine("Tabla de verdad - ( And )")
        Console.WriteLine()

        Console.WriteLine("{0} And {1}: {2}", v, v, v And v)
        Console.WriteLine("{0} And {1}: {2}", v, f, v And f)
        Console.WriteLine("{0} And {1}: {2}", f, v, f And v)
        Console.WriteLine("{0} And {1}: {2}", f, f, f And f)

        Console.WriteLine()
        Console.WriteLine("Tabla de verdad - ( Or )")
        Console.WriteLine()

        Console.WriteLine("{0} Or {1}: {2}", v, v, v Or v)
        Console.WriteLine("{0} Or {1}: {2}", v, f, v Or f)
        Console.WriteLine("{0} Or {1}: {2}", f, v, f Or v)
        Console.WriteLine("{0} Or {1}: {2}", f, f, f Or f)

        Console.WriteLine()
        Console.WriteLine("Tabla de verdad - ( Not )")
        Console.WriteLine()

        Console.WriteLine("Not {0}: {1}", v, Not v)
        Console.WriteLine("Not {0}: {1}", f, Not f)

        Console.WriteLine()
        Console.WriteLine("Tabla de verdad - ( Xor )")
        Console.WriteLine()

        Console.WriteLine("{0} Xor {1}: {2}", v, v, v Xor v)
        Console.WriteLine("{0} Xor {1}: {2}", v, f, v Xor f)
        Console.WriteLine("{0} Xor {1}: {2}", f, v, f Xor v)
        Console.WriteLine("{0} Xor {1}: {2}", f, f, f Xor f)

        Console.ReadKey()

    End Sub

End Module
