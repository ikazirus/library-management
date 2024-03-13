Public Class frmBusy
    Dim x As Integer = 0
    Public duration As Integer = 1

    Private Sub frmBusy_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If x <= duration Then
            x = x + 1
        Else
            duration = 1
            Me.Dispose()
        End If
    End Sub
End Class