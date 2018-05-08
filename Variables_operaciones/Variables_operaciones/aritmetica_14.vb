Module aritmetica_14
    Sub main()
        Dim a As Byte = 2
        Dim b As Byte = 5
        Dim c As Single = 3.5
        Dim d As Single = 6.1
        Dim suma_enteros As Byte
        Dim suma_flotantes As Single
        Dim suma_entero_flotante As Single
        suma_enteros = a + b
        suma_flotantes = c + d
        suma_entero_flotante = a + c
        Console.WriteLine("La suam de los enteros de a y b es: " & suma_enteros)
        Console.WriteLine("La suma de los flotates de c y d es: " & suma_flotantes)
        Console.WriteLine("La suma de entero con flotante de a y c es :" & suma_entero_flotante)
        Console.ReadKey()

    End Sub
End Module
