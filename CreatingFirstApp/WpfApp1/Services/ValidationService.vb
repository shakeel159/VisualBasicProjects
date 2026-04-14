Public Class ValidationService
    'Types of validation for a login form
    '1. Empty field check          → fields Not blank
    '2. Whitespace check           → Not just spaces
    '3. Length check               → reasonable input length
    '4. No special character check → prevent injection attempts
    '5. Credential check           → matches JSON file

    'Validate Username
    Public Shared Function ValidateUsername(username As String) As String
        If String.IsNullOrWhiteSpace(username) Then
            Return "Username is required."
        End If

        If username.Length < 3 Then
            Return "Username must be at least 3 characters."
        End If

        If username.Length > 20 Then
            Return "Username cannot exceed 20 characters."
        End If

        Return Nothing ' Nothing means no error
    End Function

    Public Shared Function ValidatePassword(password As String) As String
        If String.IsNullOrWhiteSpace(password) Then
            Return "password is required."
        End If

        If password.Length < 4 Then
            Return "password must be at least 3 characters."
        End If

        Return Nothing ' Nothing means no error
    End Function

    Public Shared Function ValidateEmail(email As String) As String
        If String.IsNullOrWhiteSpace(email) Then
            Return "Email is required."
        End If
        ' Check 2 - no spaces allowed
        If email.Contains(" ") Then
            Return "Email cannot contain spaces."
        End If
        ' Check 3 - must contain @
        If Not email.Contains("@") Then
            Return "Email must contain @."
        End If
        ' Check 4 - must have text before @
        Dim atIndex As Integer = email.IndexOf("@")
        If atIndex = 0 Then
            Return "Email must have a name before @."
        End If
        ' Check 5 - must have domain after @
        Dim domain As String = email.Substring(atIndex + 1)
        If String.IsNullOrWhiteSpace(domain) Then
            Return "Email must have a domain after @."
        End If
        ' Check 6 - domain must contain a dot
        If Not domain.Contains(".") Then
            Return "Email domain must contain a dot (e.g. .com)."
        End If
        ' Check 7 - nothing after last dot
        Dim lastDot As Integer = domain.LastIndexOf(".")
        Dim extension As String = domain.Substring(lastDot + 1)
        If String.IsNullOrWhiteSpace(extension) Then
            Return "Email must have a valid extension (e.g. .com)."
        End If
        ' Check 8 - reasonable length
        If email.Length > 254 Then
            Return "Email is too long."
        End If
        Return Nothing ' no error
    End Function
End Class
