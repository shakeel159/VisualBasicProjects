

Class MainWindow
    ' Sign Up link → opens Register window
    Private Sub lnkRegister_Click(sender As Object, e As RoutedEventArgs)
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
    Private Sub LogIn_Click(sender As Object, e As RoutedEventArgs)

        SessionManager.LoadUsers()
        'Does User Exist'
        'Dim hashedInput = HashPassword(txtPassword.Text) this is for hashing password
        Dim userFound = SessionManager.UserList.FirstOrDefault(Function(u) u.Username = txtUsername.Text)
        For Each u As UserModel In SessionManager.UserList
            MessageBox.Show("Username in list: '" & u.Username & "'")
        Next
        If userFound IsNot Nothing Then
            SessionManager.Login(txtUsername.Text)
            Dim dashboardWin As New DashboardWindow()
            dashboardWin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sorry bud")
        End If

    End Sub

End Class
