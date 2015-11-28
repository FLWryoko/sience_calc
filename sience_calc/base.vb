Imports System

Module base

    Sub Main()
       
        入力()
    End Sub
    
    Public Sub 入力()
        Console.ReadLine(x)

    End Sub

    Class 電卓
    
        Class 初期値
        Public Dim x As Double 
        Public Dim y As Double 
        Public Dim z As Double 
        End Class

    Class 加算
        Inherits 初期値
    Public Sub sum()
            Dim z = x+y
                
        Console.Writeline(z)

                End Sub
        End Class
    End Class
End Module
