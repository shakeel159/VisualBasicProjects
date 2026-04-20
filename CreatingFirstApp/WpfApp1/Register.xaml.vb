
Public Class Register
    ' ✅ Remove ComboBox_SelectionChanged entirely or leave empty
    Private Sub ComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        ' nothing needed here
    End Sub
    Private Sub Register_Loaded(sender As Object, e As RoutedEventArgs)
        ' ✅ Move items here, NOT in SelectionChanged
        cbGender.Items.Add("Male")
        cbGender.Items.Add("Female")
        cbGender.Items.Add("Other")
        cbGender.SelectedIndex = 0
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        ' Clear previous errors first
        txtUsername.ClearError()
        txtPassword.ClearError()

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim gender As String = cbGender.SelectedItem.ToString()

        ' Step 1 - Validate username
        Dim UsernameError As String = ValidationService.ValidateUsername(username)
        If UsernameError IsNot Nothing Then
            txtUsername.ShowError(UsernameError)
            Return
        End If

        'step 2 - Validate password
        Dim PasswordError As String = ValidationService.ValidatePassword(password)
        If PasswordError IsNot Nothing Then
            txtPassword.ShowError(PasswordError)
            Return
        End If

        'Step 3 - Do rest with other inputs


        ' Step 4 - Save new user ✅ not ValidateLogin
        Try
            Dim newUser As New UserModel()
            newUser.Username = username
            newUser.Password = password
            newUser.Email = email
            newUser.Gender = gender
            newUser.FirstName = firstName
            newUser.LastName = lastName

            UserService.SaveUser(newUser)

            ' ✅ Debug check - read all users and display them
            Dim allUsers As List(Of UserModel) = UserService.GetAllUsers()
            Dim userList As String = "Users in database:" & Environment.NewLine

            For Each u As UserModel In allUsers
                userList &= $"- {u.Username} | {u.LastName} | {u.Email} " & Environment.NewLine
            Next

            MessageBox.Show(userList, "Database Check", MessageBoxButton.OK, MessageBoxImage.Information)

            Dim loginWin As New MainWindow()
            loginWin.Show()
            Me.Close()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
    ' ✅ Window level error for general errors like SaveUser failing
    Private Sub ShowError(message As String)
        lblError.Text = message
        lblError.Visibility = Visibility.Visible
    End Sub

    Private Sub HideError()
        lblError.Text = ""
        lblError.Visibility = Visibility.Collapsed
    End Sub
End Class
