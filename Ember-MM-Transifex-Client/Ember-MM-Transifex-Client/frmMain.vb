Public Class frmMain

    Private Sub mnuEditSettings_Click(sender As Object, e As EventArgs) Handles mnuEditSettings.Click
        Using dlgSettings As New dlgSettings
            dlgSettings.ShowDialog()
        End Using
    End Sub
End Class
