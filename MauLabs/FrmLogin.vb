Public Class FrmLogin


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim num As Integer = 10
        If num < 10 Then
            num = num + 1
        Else
            Timer1.Stop()
            While Panel1.Width < 286
                Panel1.Width += 1
            End While
        End If
    End Sub
End Class