Public Class Register
    Private Sub ComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        cbGender.Items.Add("Male")
        cbGender.Items.Add("Female")
        cbGender.Items.Add("Other")
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim dashboardWin As New DashboardWindow()
        dashboardWin.Show()
    End Sub
End Class
