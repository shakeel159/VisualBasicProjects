Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json

Public Class FileReader
    Dim jsonString As String = File.ReadAllText("users.json")
    Dim userList As List(Of User) = JsonConvert.DeserializeObject(Of List(Of User))(jsonString)

End Class
