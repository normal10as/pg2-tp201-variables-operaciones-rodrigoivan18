Module Ejer1_10

    'Realizar un programa que dé como resultado los intereses producidos y el capital
    'acumulado de un monto m invertido a un interés anual r durante t días. La fórmula utilizada es
    'I= 􀀊∗􀀌∗􀀍
    '􀀎􀀏􀀐∗􀀑􀀐􀀐 donde I es el interés producido. Ingresar por teclado el monto, el interés y el tiempo.

    Sub Main()

        Dim monto As Decimal
        Dim interes_anual, interes_producido As Single
        Dim tiempo As UShort

        Console.Write("Ingrese el monto: ")
        monto = Console.ReadLine()

        Console.Write("Ingrese el interés anual: ")
        interes_anual = Console.ReadLine()

        Console.Write("Ingrese total de días: ")
        tiempo = Console.ReadLine()

        interes_producido = (monto * interes_anual * tiempo) / (360 * 100)
        Console.WriteLine("El interés es de {0}", interes_producido)

        Console.ReadKey()

    End Sub

End Module
