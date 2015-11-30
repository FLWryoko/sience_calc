Imports System

Module base

    Dim 入力値 As String 
    Dim 変換値 As Double  = CType(入力値,Double)
    Dim 解 As String 

    Public Sub Main()
       入力処理
    End Sub
    
    
   Public Sub 入力処理()
        
        入力値 = Console.ReadLine()
        Dim 変換値 As Double  = CType(入力値,Double)
        
    End Sub

    Public Sub 演算処理
       
        Dim x As Double = 変換値
        Dim z As Double 
        z = x
        解 = z
    End Sub

        Sub コンソール出力
        
         Console.WriteLine(解)
    End Sub

End Module

