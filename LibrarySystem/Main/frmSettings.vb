Public Class frmSettings

    Private Sub frmSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub btnHOME_Click(sender As Object, e As EventArgs) Handles btnHOME.Click
        frmMain.Show()
        Me.Dispose()
    End Sub
End Class