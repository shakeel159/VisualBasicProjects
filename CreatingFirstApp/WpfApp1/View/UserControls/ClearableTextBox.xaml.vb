Public Class ClearableTextBox
    Private _placeholder As String

    Public Property Placeholder() As String
        Get
            Return _placeholder
        End Get
        Set(ByVal value As String)
            _placeholder = value
            txtInput.Text = _placeholder
        End Set
    End Property
    Private Sub txtInput_GotFocus(sender As Object, e As RoutedEventArgs)
        ' clear placeholder when user clicks in
        If txtInput.Text = _placeholder Then
            txtInput.Text = ""
        End If
    End Sub

    Private Sub txtInput_LostFocus(sender As Object, e As RoutedEventArgs)
        ' restore placeholder if user left it empty
        If String.IsNullOrEmpty(txtInput.Text) Then
            txtInput.Text = _placeholder
        End If
    End Sub

End Class
