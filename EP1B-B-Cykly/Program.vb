Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer
    Dim pocet As Integer = 0

    Do
      Console.Write("Zadej èíslo: ")
      cislo = Console.ReadLine
      pocet = pocet + 1
      Console.WriteLine($"{pocet}. zadané èíslo je {cislo}")
    Loop While pocet < 10

  End Sub
End Module
