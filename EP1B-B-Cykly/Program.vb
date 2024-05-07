Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer

    Do
      Console.Write("Zadej èíslo: ")
      cislo = Console.ReadLine
      Console.WriteLine($"Zadané èíslo je {cislo}")
    Loop

  End Sub
End Module
