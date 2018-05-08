Module Ejer1_8
    'Crear un módulo llamado concatenación y en el declarar variables para almacenar los siguientes
    'datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de inicio de
    'actividades. Mostrar los mismos concatenados en la salida de la consola dos veces: la primera
    'utilizando conversión explícita y la segunda conversión implícita.

    Sub Main()

        Dim nombre_empresa As String = "Anonymus"
        Dim nombre_calle As String = " . . . "
        Dim fecha_inicio As Date = #05/18/1995#

        Console.WriteLine("Conversión explícita. ")
        Console.WriteLine("Nombre de la empresa: " + nombre_empresa + " Dirección: " + nombre_calle + " Fecha de Inicio: " + Convert.ToString(fecha_inicio))

        Console.WriteLine()

        Console.WriteLine("Conversión implícita. ")
        Console.WriteLine("Nombre de la empresa: " & nombre_empresa & "Dirección: " & nombre_calle & "Fecha de Inicio: " & fecha_inicio)

        Console.ReadKey()

    End Sub

End Module
