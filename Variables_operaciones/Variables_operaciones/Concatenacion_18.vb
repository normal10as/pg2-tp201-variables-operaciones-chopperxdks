Module Concatenacion_18
    Sub main()
        Dim nombre_empresa As String = "Gigared"
        Dim nombre_calle As String = "Almirante Bronw"
        Dim altura_calle As Short = 1564
        Dim fecha As Date = #04/15/2018#
        Console.WriteLine(nombre_empresa & nombre_calle + Convert.ToString(altura_calle) + Convert.ToString(fecha)) 'conversion explicita
        Console.WriteLine(nombre_empresa & " " & nombre_calle & " " & altura_calle & " " & fecha) 'conversion implicita
        Console.ReadKey()
    End Sub
End Module
