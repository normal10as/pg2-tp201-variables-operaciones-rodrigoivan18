Module Ejer1_13

    'Elabore un programa que lea tres números y muestre el mayor.

    Sub Main()

        Dim a As UShort = 355
        Dim b As UShort = 14
        Dim c As UShort = 369
        'Dim mayor As UShort

        'If a > b And a > c Then
        '    mayor = a
        'ElseIf b > c Then
        '    mayor = b
        'Else
        '    mayor = c
        'End If

        'Console.WriteLine("Los números son {0} - {1} - {2}, el mayor es {3}", a, b, c, mayor)

        Console.WriteLine("El mayor de los valores es: " & Math.Max(a, Math.Max(b, c)))

        Console.ReadKey()

    End Sub

End Module
