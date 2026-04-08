<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.cmboBoxGender = New System.Windows.Forms.ComboBox()
        Me.bynSubmit = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.Label()
        Me.cmbBoxOccupation = New System.Windows.Forms.ComboBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtLastNameSearch = New System.Windows.Forms.TextBox()
        Me.txtFirstNameSearch = New System.Windows.Forms.TextBox()
        Me.SearchNameLebel = New System.Windows.Forms.Label()
        Me.LastNameLebel = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(108, 57)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(144, 20)
        Me.txtBoxFirstName.TabIndex = 0
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Location = New System.Drawing.Point(108, 106)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(144, 20)
        Me.txtBoxLastName.TabIndex = 1
        '
        'cmboBoxGender
        '
        Me.cmboBoxGender.FormattingEnabled = True
        Me.cmboBoxGender.Items.AddRange(New Object() {"M", "F"})
        Me.cmboBoxGender.Location = New System.Drawing.Point(108, 153)
        Me.cmboBoxGender.Name = "cmboBoxGender"
        Me.cmboBoxGender.Size = New System.Drawing.Size(46, 21)
        Me.cmboBoxGender.TabIndex = 2
        '
        'bynSubmit
        '
        Me.bynSubmit.Location = New System.Drawing.Point(120, 293)
        Me.bynSubmit.Name = "bynSubmit"
        Me.bynSubmit.Size = New System.Drawing.Size(109, 30)
        Me.bynSubmit.TabIndex = 4
        Me.bynSubmit.Text = "Submit"
        Me.bynSubmit.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoSize = True
        Me.txtFirstName.Location = New System.Drawing.Point(33, 60)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(57, 13)
        Me.txtFirstName.TabIndex = 6
        Me.txtFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.AutoSize = True
        Me.txtLastName.Location = New System.Drawing.Point(33, 109)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(58, 13)
        Me.txtLastName.TabIndex = 7
        Me.txtLastName.Text = "Last Name"
        '
        'txtGender
        '
        Me.txtGender.AutoSize = True
        Me.txtGender.Location = New System.Drawing.Point(33, 156)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(42, 13)
        Me.txtGender.TabIndex = 8
        Me.txtGender.Text = "Gender"
        '
        'txtOccupation
        '
        Me.txtOccupation.AutoSize = True
        Me.txtOccupation.Location = New System.Drawing.Point(33, 202)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(62, 13)
        Me.txtOccupation.TabIndex = 9
        Me.txtOccupation.Text = "Occupation"
        '
        'cmbBoxOccupation
        '
        Me.cmbBoxOccupation.FormattingEnabled = True
        Me.cmbBoxOccupation.Location = New System.Drawing.Point(108, 202)
        Me.cmbBoxOccupation.Name = "cmbBoxOccupation"
        Me.cmbBoxOccupation.Size = New System.Drawing.Size(121, 21)
        Me.cmbBoxOccupation.TabIndex = 11
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.LastName, Me.Gender, Me.Occupation})
        Me.DataGridView.Location = New System.Drawing.Point(383, 57)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(369, 237)
        Me.DataGridView.TabIndex = 13
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'Gender
        '
        Me.Gender.HeaderText = "G"
        Me.Gender.Name = "Gender"
        Me.Gender.Width = 25
        '
        'Occupation
        '
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(634, 338)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(118, 31)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtLastNameSearch
        '
        Me.txtLastNameSearch.Location = New System.Drawing.Point(520, 344)
        Me.txtLastNameSearch.Name = "txtLastNameSearch"
        Me.txtLastNameSearch.Size = New System.Drawing.Size(91, 20)
        Me.txtLastNameSearch.TabIndex = 15
        '
        'txtFirstNameSearch
        '
        Me.txtFirstNameSearch.Location = New System.Drawing.Point(407, 344)
        Me.txtFirstNameSearch.Name = "txtFirstNameSearch"
        Me.txtFirstNameSearch.Size = New System.Drawing.Size(91, 20)
        Me.txtFirstNameSearch.TabIndex = 16
        '
        'SearchNameLebel
        '
        Me.SearchNameLebel.AutoSize = True
        Me.SearchNameLebel.Location = New System.Drawing.Point(410, 326)
        Me.SearchNameLebel.Name = "SearchNameLebel"
        Me.SearchNameLebel.Size = New System.Drawing.Size(57, 13)
        Me.SearchNameLebel.TabIndex = 17
        Me.SearchNameLebel.Text = "First Name"
        '
        'LastNameLebel
        '
        Me.LastNameLebel.AutoSize = True
        Me.LastNameLebel.Location = New System.Drawing.Point(526, 326)
        Me.LastNameLebel.Name = "LastNameLebel"
        Me.LastNameLebel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLebel.TabIndex = 18
        Me.LastNameLebel.Text = "Last Name"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(639, 384)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 27)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.LastNameLebel)
        Me.Controls.Add(Me.SearchNameLebel)
        Me.Controls.Add(Me.txtFirstNameSearch)
        Me.Controls.Add(Me.txtLastNameSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.cmbBoxOccupation)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.bynSubmit)
        Me.Controls.Add(Me.cmboBoxGender)
        Me.Controls.Add(Me.txtBoxLastName)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents cmboBoxGender As ComboBox
    Friend WithEvents bynSubmit As Button
    Friend WithEvents txtFirstName As Label
    Friend WithEvents txtLastName As Label
    Friend WithEvents txtGender As Label
    Friend WithEvents txtOccupation As Label
    Friend WithEvents cmbBoxOccupation As ComboBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Occupation As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtLastNameSearch As TextBox
    Friend WithEvents txtFirstNameSearch As TextBox
    Friend WithEvents SearchNameLebel As Label
    Friend WithEvents LastNameLebel As Label
    Friend WithEvents btnReset As Button
End Class
