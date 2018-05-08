Module Variables
    'Sub Main()
    '    Dim nombre As String = "Fernando"
    '    Dim tipo_documento As String = "DNI"
    '    Dim num_documento As UInteger = 37353440
    '    Dim localidad As String = "Posadas"
    '    Dim fecha_de_nacimiento As Date = #02/26/1993#
    '    Dim edad As Byte = 25
    '    Dim altura_corporal As Single = 1.86
    '    Dim estado_civil As String = "solero"
    '    Dim argentino as Boolean = true
    '    Console.WriteLine(nombre & " " & tipo_documento & " " & num_documento & " " & localidad & " " & fecha_de_nacimiento & " " & edad & " " & estado_civil & " " & altura_corporal & " " & " " & nacionalidad)
    '    Console.writeline("Nombre: "& nombre)
    '    Console.ReadKey()
    'End Sub

    Public nombre As String = "Fernando"
    Private DNI As Integer = 37353440
    Private fecha_de_nacimiento As Date = #02/26/1993#


    Sub Main()

        Dim localidad As String = "Posadas"
        Dim edad As Integer = 25
        Dim altura_corporal As Single = 1.86
        Dim estado_civil As String = "solero"
        Dim nacionalidad As String = "Argentino"
        Console.WriteLine(nombre & " " & DNI & " " & localidad & " " & fecha_de_nacimiento & " " & edad & " " & estado_civil & " " & altura_corporal & " " & " " & nacionalidad)


        Console.ReadKey()
    End Sub
End Module
