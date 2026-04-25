Public Class MenuBar
    Private Sub cbLogOut_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim selected As ComboBoxItem = TryCast(cbLogOut.SelectedItem, ComboBoxItem)
        If selected Is Nothing Then Return

        If selected.Content.ToString() = "Sign Out" Then
            ' Reset the combobox back to showing "Logged In"
            cbLogOut.SelectedItem = Nothing

            ' Navigate to login window
            Dim loginWin As New MainWindow()
            loginWin.Show()

            ' Close whatever window MenuBar is inside
            Window.GetWindow(Me).Close()
        End If
    End Sub
End Class
