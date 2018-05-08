Module Ejer1_7
    'Crear un módulo llamado semanas y en el declarar las siguientes constantes: días del año, días
    'laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas semanas son
    'laborables.

    Sub Main()

        Const dias_de_la_semana As Byte = 7
        Const dias_laborales As Byte = 250
        Const dias_del_año As UShort = 365

        Console.WriteLine("El año tiene {0} semanas y {1} son semanas laborales", dias_del_año / dias_de_la_semana, dias_laborales / dias_de_la_semana)

        Console.ReadKey()

    End Sub

End Module
