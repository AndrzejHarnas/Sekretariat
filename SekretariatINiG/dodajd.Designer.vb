<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodajd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.nrd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.surname = New System.Windows.Forms.ComboBox
        Me.odkiedy = New System.Windows.Forms.DateTimePicker
        Me.DoKiedy = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.nrzlec = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.miejsce = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.trans = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.nastepny = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 210)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(7, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nr delegcji:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'nrd
        '
        Me.nrd.Location = New System.Drawing.Point(74, 16)
        Me.nrd.Name = "nrd"
        Me.nrd.Size = New System.Drawing.Size(150, 20)
        Me.nrd.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pracownik:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Od kiedy:"
        '
        'surname
        '
        Me.surname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.surname.FormattingEnabled = True
        Me.surname.Location = New System.Drawing.Point(74, 45)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(150, 21)
        Me.surname.TabIndex = 7
        '
        'odkiedy
        '
        Me.odkiedy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.odkiedy.Location = New System.Drawing.Point(74, 124)
        Me.odkiedy.Name = "odkiedy"
        Me.odkiedy.Size = New System.Drawing.Size(150, 20)
        Me.odkiedy.TabIndex = 11
        Me.odkiedy.Value = New Date(2008, 10, 26, 0, 0, 0, 0)
        '
        'DoKiedy
        '
        Me.DoKiedy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DoKiedy.Location = New System.Drawing.Point(74, 150)
        Me.DoKiedy.Name = "DoKiedy"
        Me.DoKiedy.Size = New System.Drawing.Size(150, 20)
        Me.DoKiedy.TabIndex = 12
        Me.DoKiedy.Value = New Date(2008, 10, 26, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Do kiedy:"
        '
        'nrzlec
        '
        Me.nrzlec.Location = New System.Drawing.Point(74, 176)
        Me.nrzlec.Name = "nrzlec"
        Me.nrzlec.Size = New System.Drawing.Size(150, 20)
        Me.nrzlec.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nr zlec:"
        '
        'miejsce
        '
        Me.miejsce.Location = New System.Drawing.Point(74, 72)
        Me.miejsce.Name = "miejsce"
        Me.miejsce.Size = New System.Drawing.Size(150, 20)
        Me.miejsce.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Miejsce:"
        '
        'trans
        '
        Me.trans.Location = New System.Drawing.Point(74, 98)
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(150, 20)
        Me.trans.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Transport:"
        '
        'nastepny
        '
        Me.nastepny.Image = Global.Sekretariat.My.Resources.Resources.skipover
        Me.nastepny.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nastepny.Location = New System.Drawing.Point(208, 213)
        Me.nastepny.Name = "nastepny"
        Me.nastepny.Size = New System.Drawing.Size(27, 23)
        Me.nastepny.TabIndex = 20
        Me.nastepny.UseVisualStyleBackColor = True
        '
        'dodajd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(240, 251)
        Me.Controls.Add(Me.nastepny)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.trans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.miejsce)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nrzlec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DoKiedy)
        Me.Controls.Add(Me.odkiedy)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nrd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dodajd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodaj delegację:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nrd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents surname As System.Windows.Forms.ComboBox
    Friend WithEvents odkiedy As System.Windows.Forms.DateTimePicker
    Friend WithEvents DoKiedy As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nrzlec As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents miejsce As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trans As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nastepny As System.Windows.Forms.Button

End Class
