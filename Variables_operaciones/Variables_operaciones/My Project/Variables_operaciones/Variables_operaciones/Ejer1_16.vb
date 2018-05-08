Module Ejer1_16

    'Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como
    'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada

    Sub Main()

        'Dim fecha As Date = Date.Today 

        Dim fecha As Date
        Dim dias_agregar As UShort

        Console.WriteLine("Ingrese un fecha {dd/mm/aaa}: ")
        fecha = Console.ReadLine()

        Console.Write("Ingrese los dias ha agregar: ")
        dias_agregar = Console.ReadLine()

        'Console.WriteLine("Fecha Actual {0} - Fecha Modificada {1}", fecha, fecha.AddDays(dias_agregar))
        Console.WriteLine("Fecha Ingresada {0} - Fecha Modificada {1}", fecha, fecha.AddDays(dias_agregar))

        Console.ReadKey()

    End Sub

End Module
