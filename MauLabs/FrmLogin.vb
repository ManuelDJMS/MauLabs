Public Class FrmLogin


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim num As Integer = 10
        If num < 10 Then
            num = num + 1
        Else
            'Timer1.Stop()
            'While Panel2.Location.X <= 693
            '    Panel2.Left -= 1

            '    If (Panel2.Location.X = 375) Then
            '        'Panel2.Location.X
            '    End If
            'End While
        End If
    End Sub
End Class