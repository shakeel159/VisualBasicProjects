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
    ' Text property - exposes what user typed to outside windows
    Public ReadOnly Property Text As String
        Get
            If txtInput.Text = _placeholder Then
                Return "" ' return empty if only placeholder is showing
            End If
            Return txtInput.Text
        End Get
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
    ' Highlight textbox red on error
    Private Sub HighlightError(control As Control)
        control.BorderBrush = New SolidColorBrush(Colors.Red)
        control.BorderThickness = New Thickness(1.5)
    End Sub

    ' Reset textbox border on valid
    Private Sub ClearHighlight(control As Control)
        control.BorderBrush = New SolidColorBrush(Colors.LightGray)
        control.BorderThickness = New Thickness(1)
    End Sub
    ' Show error message below the textbox
    Public Sub ShowError(message As String)
        lblInputError.Text = message
        lblInputError.Visibility = Visibility.Visible
        txtInput.BorderBrush = New SolidColorBrush(Colors.Red)
        txtInput.BorderThickness = New Thickness(1.5)
    End Sub

    ' Clear error message
    Public Sub ClearError()
        lblInputError.Text = ""
        lblInputError.Visibility = Visibility.Collapsed
        txtInput.BorderBrush = New SolidColorBrush(Colors.LightGray)
        txtInput.BorderThickness = New Thickness(1)
    End Sub
End Class
