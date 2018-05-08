Module _1_16
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
