Module Ejer1_5
    'Crear un programa que resuelva la siguiente ecuación 􀀁 = 􀀃􀀄􀀅􀀆􀀇􀀈
    '􀀉􀀇 donde a=1, b=5 y c=2.
    'Mostrar el resultado obtenido.

    Sub Main()

        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2
        Dim resultado_ecuacion As Single

        resultado_ecuacion = (b ^ 2 - 4 * a * c) / (2 * a)

        Console.WriteLine("El resultadp de la ecuación es {0}", resultado_ecuacion)

        Console.ReadKey()
    End Sub

End Module
