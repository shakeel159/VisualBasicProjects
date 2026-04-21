Public Class DashboardWindow
    ' ✅ Correct - load once when window opens
    Private Sub Dashboard_Loaded(sender As Object, e As RoutedEventArgs)
        LoadUsers()
    End Sub
    Private Sub LoadUsers()
        Try
            Dim users As List(Of UserModel) = UserService.GetAllUsers()
            UserList.Items.Clear()

            For Each u As UserModel In users
                UserList.Items.Add($"{u.Username} | {u.LastName} | {u.Email}")
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub
End Class
