Imports System

Module Program

Sub Func3()
    Dim i As Integer
    For i = 1 To 5
        If i > 1 Then
            Dim j As Integer
            Dim k As Integer = 2
            k += 1
            j += 1
            Console.WriteLine("j = {0}, k = {1}", j, k)
        End If
    Next
End Sub


    Sub Main(args As String())
      Dim i As Integer
        For i = 1 To 2
         Console.WriteLine(" i vale {0}", i)
         Func3()
       Next
    End Sub
End Module
