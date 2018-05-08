Module Ejer1_14

    'Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los
    'siguientes valores en el momento de la ejecución: día del año, mes, hora y minuto

    Sub Main()

        Console.WriteLine("Día del año: " & Date.Today.DayOfYear)
        Console.WriteLine("Mes del año: " & Date.Today.Month)
        Console.WriteLine("Hora y minuto del año: " & Date.Now.Hour & ":" & Date.Now.Minute)

        Console.ReadKey()

    End Sub

End Module
