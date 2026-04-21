Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json
Imports System.IO

Public Class SessionManager
    Public Shared Property CurrentUser As String = ""
    Public Shared Property IsAdmin As Boolean = False

    Public Shared UserList As List(Of UserModel)
    Public Shared Sub Login(username As String) 'Sub = Static'
        CurrentUser = username
        IsAdmin = (username.ToLower() = "admin") 'yes im hardcoding this'
    End Sub

    Public Shared Sub Logout()
        CurrentUser = ""
        IsAdmin = False
    End Sub
    Public Shared Sub LoadUsers()

        Dim jsonString As String = File.ReadAllText("users.json")
        UserList = JsonConvert.DeserializeObject(Of List(Of UserModel))(jsonString)
    End Sub
End Class
