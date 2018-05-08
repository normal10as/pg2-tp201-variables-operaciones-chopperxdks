Module _1_12
    Sub main()
        Dim num As Single = Console.ReadLine
        Console.WriteLine(num)
        Dim exceso As Single
        exceso = Math.Ceiling(num)
        Console.WriteLine("exceso: " & exceso)
        Dim defecto As Single
        defecto = Math.Floor(num)
        Console.WriteLine("defecto: " & defecto)
        Dim redondeo As Int16
        redondeo = Math.Round(num)
        Console.WriteLine("redondeo: " & redondeo)
        Console.ReadKey()

    End Sub
End Module
