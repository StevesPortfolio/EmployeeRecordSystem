Public Class frmEmployee
    Private Sub btnNewEmpID_Click(sender As Object, e As EventArgs) Handles btnNewEmpID.Click

        AddRecordToFile(txtFirstName.Text, txtLastName.Text, txtPhone.Text)
        DisplayRecords(lstCurrentEmployees)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayRecords(lstCurrentEmployees)
    End Sub
End Class
