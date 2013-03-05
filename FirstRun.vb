Public Class FirstRun

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcForm.Show()
        Me.Dispose()
    End Sub

    Private Sub FirstRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calcForm.Hide()
    End Sub
End Class
