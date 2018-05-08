Module Ejer1_17

    'Al programa anterior, utilizando una enumeración para los días de la semana en español,
    'mostrar que día que corresponde al resultado.

    Enum dias_semanas As Byte

        domingo
        lunes
        martes
        miercoles
        jueves
        viernes
        sabado

    End Enum

    Sub Main()

        Dim fecha As Date
        Dim dias_agregar As UShort

        Console.Write("Ingrese un fecha {dd/mm/aaa}: ")
        fecha = Console.ReadLine()

        Console.Write("Ingrese los dias ha agregar: ")
        dias_agregar = Console.ReadLine()

        fecha = fecha.AddDays(dias_agregar)
        Console.WriteLine("La fecha modificada es {0}", fecha)

        'Console.WriteLine("Fecha Ingresada {0} - Fecha Modificada {1}", fecha, fecha.AddDays(dias_agregar))

        Select Case fecha.DayOfWeek

            Case dias_semanas.domingo
                Console.WriteLine("Domingo")

            Case dias_semanas.lunes
                Console.WriteLine("Lunes")

            Case dias_semanas.martes
                Console.WriteLine("Martes")

            Case dias_semanas.miercoles
                Console.WriteLine("Miercoles")

            Case dias_semanas.jueves
                Console.WriteLine("Jueves")

            Case dias_semanas.viernes
                Console.WriteLine("Viernes")

            Case dias_semanas.sabado
                Console.WriteLine("Sabado")

            Case Else
                Console.WriteLine("Muy deforme tu día ameo :v")

        End Select

        Console.ReadKey()

    End Sub

End Module
