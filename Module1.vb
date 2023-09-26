Module Module1

    Sub Main()
        'Ejercicio1()
        'Ejercicio2()
        'Ejercicio3()
        'Ejercicio4()
    End Sub
    Sub Ejercicio1()

        Dim distanciaKm As Double = 42.195

        Dim horas As Integer = 2
        Dim minutos As Integer = 35
        Dim tiempoTotalMin As Integer = horas * 60 + minutos
        Dim velocidadKmH As Double = distanciaKm / (horas + minutos / 60)
        Dim velocidadKmMin As Double = distanciaKm / tiempoTotalMin
        Dim velocidadKmS As Double = distanciaKm / (tiempoTotalMin * 60)
        Dim velocidadMMin As Double = distanciaKm * 1000 / tiempoTotalMin
        Dim velocidadMS As Double = distanciaKm * 1000 / (tiempoTotalMin * 60)

        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmH.ToString("0.00") & " Km/h")
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmMin.ToString("0.00") & " Km/min")
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmS.ToString("0.000") & " Km/s")
        Console.WriteLine("Velocidad media en m/min: " & velocidadMMin.ToString("0.00") & " m/min")
        Console.WriteLine("Velocidad media en m/s: " & velocidadMS.ToString("0.000") & " m/s")

        Console.ReadKey()

    End Sub
    Sub Ejercicio2()

        Dim totalInfracciones As Integer = ObtenerTotalInfracciones()
        Dim promedioMatutino As Double = totalInfracciones * 0.2 / 12
        Dim promedioTarde As Double = totalInfracciones * 0.35 / 12
        Dim promedioNocturno As Double = totalInfracciones * 0.45 / 12


        Console.WriteLine("Promedio diario matutino de infracciones: " & promedioMatutino.ToString("0.00"))
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioTarde.ToString("0.00"))
        Console.WriteLine("Promedio diario nocturno de infracciones: " & promedioNocturno.ToString("0.00"))

        Console.ReadKey()

    End Sub
    Function ObtenerTotalInfracciones() As Integer
        Return 100
    End Function

    Sub Ejercicio3()

        Dim entero = False
        Console.Write("Ingrese el primer número entero (N1): ")
        Dim N1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero (N2): ")
        Dim N2 As Integer = Integer.Parse(Console.ReadLine())

        If EsDivisor(N1, N2) Then
            Console.WriteLine(N1 & " es divisor de " & N2)
        Else
            Console.WriteLine(N1 & " no es divisor de " & N2)
        End If

        Console.ReadKey()
    End Sub

    Function EsDivisor(ByVal divisor As Integer, ByVal numero As Integer) As Boolean
        Return numero Mod divisor = 0
    End Function

    Sub Ejercicio4()

        Console.Write("Ingrese el primer número entero: ")
        Dim numero1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        Dim numero2 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el tercer número entero: ")
        Dim numero3 As Integer = Integer.Parse(Console.ReadLine())


        Dim mayor As Integer, medio As Integer, menor As Integer
        DeterminarMayorMedioMenor(numero1, numero2, numero3, mayor, medio, menor)

        Console.WriteLine("El mayor número es: " & mayor)
        Console.WriteLine("El número medio es: " & medio)
        Console.WriteLine("El menor número es: " & menor)
        Console.WriteLine("Desarrollado por: Carmen Magdalena Vasquez Martinez")
        Console.WriteLine("estudiante de: Licenciatura en Computacion")
        Console.WriteLine("Codigo: vm0310032022")

        Console.ReadKey()
    End Sub

    Sub DeterminarMayorMedioMenor(ByVal numero1 As Integer, ByVal numero2 As Integer, ByVal numero3 As Integer, ByRef mayor As Integer, ByRef medio As Integer, ByRef menor As Integer)

        mayor = Math.Max(numero1, Math.Max(numero2, numero3))
        menor = Math.Min(numero1, Math.Min(numero2, numero3))
        medio = numero1 + numero2 + numero3 - mayor - menor

    End Sub



End Module
