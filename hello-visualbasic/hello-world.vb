Module Module1
    Sub Main() 
        Console.WriteLine("Hello, World.")
    End Sub
End Module
 
'non-console example:
Class Form1
    Public Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load()
        MsgBox("Hello, World.")
    End Sub
End Class