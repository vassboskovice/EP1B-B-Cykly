Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer
    Dim pocet As Integer = 0

    Do
      Console.Write("Zadej ��slo: ")
      cislo = Console.ReadLine
      pocet = pocet + 1
      Console.WriteLine($"{pocet}. zadan� ��slo je {cislo}")
    Loop Until pocet >= 10

  End Sub
End Module
