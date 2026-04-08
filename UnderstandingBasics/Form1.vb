Imports System.Security.Cryptography

Public Class Form1
    Private Sub bynSubmit_Click(sender As Object, e As EventArgs) Handles bynSubmit.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim cGender As String
        Dim stOccupation As String
        Dim astFullDiscribtion(4) As String

        stFirstName = txtBoxFirstName.Text
        stLastName = txtBoxLastName.Text
        cGender = cmboBoxGender.Text
        stOccupation = cmbBoxOccupation.SelectedItem

        MsgBox(stFirstName + " " + stLastName + " has been added to the system")

        DataGridView.Rows.Add(stFirstName, stLastName, cGender, stOccupation)


    End Sub

    Private Sub cmboBoxGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxGender.SelectedIndexChanged


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtGender_Click(sender As Object, e As EventArgs) Handles txtGender.Click

    End Sub

    Private Sub txtBoxOccpupation_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBoxOccupation.Items.Add("Student")
        cmbBoxOccupation.Items.Add("Nurse")
        cmbBoxOccupation.Items.Add("Doctor")
        cmbBoxOccupation.Items.Add("Teacher")
        cmbBoxOccupation.Items.Add("Creator")
        cmbBoxOccupation.Items.Add("Film")
        cmbBoxOccupation.Items.Add("Corporate")
        cmbBoxOccupation.Items.Add("Transportation")
        cmbBoxOccupation.Items.Add("Unemployed")
        cmbBoxOccupation.Items.Add("Other")

        DataGridView.Rows.Add("Test", "Employee", "M", "Nurse")
        DataGridView.Rows.Add("Test", "Student", "M", "Student")
        DataGridView.Rows.Add("Test", "Doc", "F", "Doctor")
        DataGridView.Rows.Add("Developer", "Shakeel", "M", "Developer")

    End Sub

    Private Sub txtMainBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim stFirstNameSearch As String = txtFirstNameSearch.Text.ToLower().Trim()
        Dim stLastNameSearch As String = txtLastNameSearch.Text.ToLower().Trim()
        Dim found As Boolean = False

        For Each row As DataGridViewRow In DataGridView.Rows
            If row.Cells(0).Value IsNot Nothing Then
                Dim FirstName As String = row.Cells(0).Value.ToString().ToLower()
                Dim LastName As String = row.Cells(1).Value.ToString().ToLower()

                If FirstName.Contains(stFirstNameSearch) AndAlso LastName.Contains(stLastNameSearch) Then
                    row.Visible = True
                    found = True
                Else
                    row.Visible = False
                End If
            End If
        Next

        If Not found Then
            MsgBox("No results found for: ")
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles SearchNameLebel.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LastNameLebel.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirstNameSearch.Clear()
        txtLastNameSearch.Clear()
        For Each row As DataGridViewRow In DataGridView.Rows
            row.Visible = True
        Next
    End Sub
End Class
