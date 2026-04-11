Imports Newtonsoft.Json
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class UserService

    ' Path to your JSON file in the output folder
    Private Shared filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json")

    ' Load all users from JSON file
    Public Shared Function GetAllUsers() As List(Of UserModel)
        If Not File.Exists(filePath) Then
            Return New List(Of UserModel)
        End If

        Dim json As String = File.ReadAllText(filePath)
        Return JsonConvert.DeserializeObject(Of List(Of UserModel))(json)
    End Function
    ' Validate login credentials
    Public Shared Function ValidateLogin(username As String, password As String) As Boolean
        Dim users As List(Of UserModel) = GetAllUsers()
        Dim hashed As String = HashPassword(password)

        Dim foundUser As UserModel = users.FirstOrDefault(Function(u) u.Username.ToLower() = username.ToLower() AndAlso u.Password = hashed)

        Return foundUser IsNot Nothing
    End Function

    ' Save a new user to JSON file
    Public Shared Sub SaveUser(newUser As UserModel)
        Dim users As List(Of UserModel) = GetAllUsers()

        ' Check if username already exists
        Dim exists = users.Any(Function(u) u.Username.ToLower() = newUser.Username.ToLower())
        If exists Then
            Throw New Exception("Username already exists.")
        End If

        ' Hash password before saving
        newUser.Password = HashPassword(newUser.Password)
        users.Add(newUser)

        ' Write back to file
        Dim json As String = JsonConvert.SerializeObject(users, Formatting.Indented)
        File.WriteAllText(filePath, json)
    End Sub
    ' SHA256 password hashing
    Public Shared Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function
End Class
