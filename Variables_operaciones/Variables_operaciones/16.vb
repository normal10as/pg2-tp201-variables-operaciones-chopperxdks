Module _16
    Sub main()
        Console.WriteLine("Ingrese un numero: ")
        Dim a As Byte = Console.ReadLine
        Console.WriteLine("Ingrese otro numero: ")
        Dim b As Byte = Console.ReadLine
        Console.WriteLine("Ingrese otro numero: ")
        Dim c As Byte = Console.ReadLine
        Console.WriteLine("Ingrese otro numero: ")
        Dim d As Byte = Console.ReadLine
        Dim x As Byte
        Dim y As Single
        x = a + b + c + d
        ' y = x / 4
        Console.WriteLine("La sumatoria es: " & x)
        Console.WriteLine("La media es: " & x / 4)
        ' Console.WriteLine("La media es: " & y)
        Console.ReadKey()

    End Sub
End Module
