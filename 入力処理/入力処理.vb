Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class 入力処理
    
    <TestMethod()> Public Sub TestMethod1()
        Dim 入力値 As String 
        Dim 解 As Double 
        Dim 数値 As String = 0<=9 
        Dim プラス記号 As String = "+"
        入力値 = Console.ReadLine() 
        If 入力値 = プラス記号 Then
        ElseIf 入力値 = 数値 Then
            解 = 数値
            End if
        Console.WriteLine(解)
    End Sub

End Class