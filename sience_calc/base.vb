Imports System

Module base

    Sub Main()
       
        result()
    End Sub
    
    Sub result()
        
        Console.Writeline()
    End Sub

    Class calc
    
        Class dafault_tvalue
        Public Dim x As Double 
        Public Dim y As Double 
        Public Dim z As Double 
        End Class

    Class addition
        Inherits dafault_tvalue 
    Public Sub sum()
            Dim z = x+y
                result()
                End Sub
        End Class
    End Class
End Module
