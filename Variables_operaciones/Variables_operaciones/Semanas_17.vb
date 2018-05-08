Module Semanas_17
    Const dias_anio As Integer = 365
    Sub main()

        Const dias_laborales As Short = 250
        Const dias_semana As Short = 7
        Dim semanas_laborales As Short = dias_laborales / dias_semana
        Console.WriteLine("semanas del anio: " & Convert.ToInt16(dias_anio / dias_laborales))
        Console.WriteLine("semanas laborales: " & semanas_laborales)
        Console.ReadKey()
        'Dim dias_años As Integer = 365
        'Dim dias_laborales As Short = 250
        'Dim dias_semanas As Short = 7
        'Dim semanas_años As Short
        'semanas_años = dias_años / dias_semanas
        'Dim semanas_laborales As Short
        'semanas_laborales = dias_laborales / dias_semanas
        'Console.WriteLine("semanas del anio: " & semanas_años)
        'Console.WriteLine("semanas del anio: " & semanas_laborales)
        'Console.ReadKey()

    End Sub
End Module
