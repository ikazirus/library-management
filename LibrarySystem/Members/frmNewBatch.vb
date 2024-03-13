Public Class frmNewBatch

    Private Sub frmNewBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Me.DepartmentTableAdapter.Fill(Me.LibrarydbDataSet.department)
        Me.YearTableAdapter.Fill(Me.LibrarydbDataSet.year)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtMemNum.Text Is Nothing Then
        Else
            numberOfStudents = Val(txtMemNum.Text)
            depID = cbxDep.SelectedValue
            Year = cbxYear.SelectedValue

            If rbtFullT.Checked Then
                CourseType = "Full Time"
            ElseIf rbtPart.Checked Then
                CourseType = "Part Time"
            End If


            If Not txtMemNum.Text = Nothing Then
                Dim form As New frmNewMember
                form.Show()
                Me.Dispose()
            Else
                MsgBox("Enter the number of Students in the batch. You can't add an empty batch")
                txtMemNum.BackColor = Color.MistyRose
                Me.Refresh()
            End If

        End If

    End Sub

    Private Sub btnCancelNBW_Click(sender As Object, e As EventArgs) Handles btnCancelNBW.Click
        txtMemNum.Clear()
        cbxDep.ResetText()
        cbxYear.ResetText()
        rbtFullT.Select()
    End Sub

End Class