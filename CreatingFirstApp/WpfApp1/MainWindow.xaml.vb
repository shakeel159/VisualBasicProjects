Class MainWindow
    ' Sign Up link → opens Register window
    Private Sub lnkSignUp_Click(sender As Object, e As RoutedEventArgs)
        Dim registerWin As New Register()
        registerWin.Show()
        Me.Hide()
    End Sub
    ' Guest link → opens Dashboard/Home window without login
    Private Sub lnkGuest_Click(sender As Object, e As RoutedEventArgs)
        Dim dashboardWin As New DashboardWindow()
        dashboardWin.Show()
        Me.Hide()
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        btnSignIn.Content = "Run"
    End Sub
End Class
