Module _1_13
    Sub main()
        Dim a, b, c As Int16
        Console.WriteLine("Ingrece tres numeros: ")
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine
        If a > b And a > c Then
            Console.WriteLine("es el mayor: " & a)
        ElseIf b > c Then
            Console.WriteLine("es el mayor: " & b)
        Else
            Console.WriteLine("es el mayor: " & c)
        End If
        Console.ReadKey()
    End Sub
End Module
