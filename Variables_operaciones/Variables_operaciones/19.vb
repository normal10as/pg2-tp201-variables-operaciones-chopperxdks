Module _19
    Sub main()
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False

        Console.WriteLine(verdadero And falso)
        Console.Write(verdadero And verdadero)
        Console.WriteLine(falso And falso)

        Console.WriteLine(verdadero Or verdadero)
        Console.WriteLine(verdadero Or falso)
        Console.WriteLine(falso Or falso)

        Console.WriteLine(verdadero Xor verdadero)
        Console.WriteLine(verdadero Xor falso)
        Console.WriteLine(falso Xor falso)

        Console.ReadKey()

    End Sub
End Module
