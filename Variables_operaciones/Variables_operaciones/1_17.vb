Module _1_17
    Enum diadelasemana
        lunes = 0
        martes = 1
        miercoles = 2
        jueves = 3
        viernes = 4
        sabado = 5
        domingo = 6
    End Enum
    Sub main()

        Dim dias As Byte
        Dim fecha As Date
        Console.WriteLine("ingrese una fecha: ")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese dias que quieras sumar: ")
        dias = Console.ReadLine
        fecha = fecha.AddDays(dias)
        Console.WriteLine("La suma es: " & fecha)
        Console.ReadKey()

    End Sub
End Module
