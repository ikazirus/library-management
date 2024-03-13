Public Class frmDBconfig

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Connect()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        userId = txtUserName.Text
        password = txtPassword.Text
        server = txtServer.Text
        database = txtDatabase.Text
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class