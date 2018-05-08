Module Dias
    Sub main()
        Dim hoy As Date
        hoy = Now
        Dim findeaño As New DateTime(Year(Now()), 12, 31)
        Console.WriteLine("faltan {0} dias para fin de año ", findeaño.DayOfYear - hoy.DayOfYear)
        Console.WriteLine("hoy es {0} y faltan {1} dias para fin de año ", hoy.Date, findeaño.DayOfYear - hoy.DayOfYear)
        '{0} toma el primer parametro (hoy.date)separado por una "," y sigue el siguiente parametro {1}(findeaño.DayOfYear - hoy.DayOfYear)
        Console.ReadKey()
    End Sub
End Module
