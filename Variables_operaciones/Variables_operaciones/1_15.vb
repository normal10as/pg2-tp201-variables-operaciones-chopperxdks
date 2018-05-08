Module _1_15
    Sub main()
        Console.WriteLine("Ingrese un dia (1 a 31): ")
        Dim dias As Byte = Console.ReadLine
        Console.WriteLine("Ingrece la hora (0 a 24): ")
        Dim hora As Byte = Console.ReadLine
        Dim fecha As New DateTime(Now.Year, Now.Month, dias, hora, Now.Minute, Now.Second)
        fecha = Convert.ToString(fecha)
        Console.WriteLine(fecha)
        'Console.WriteLine(fecha & " " & "dia: " & dias & " " & "Horas: ")
        Console.ReadKey()

    End Sub
End Module
