<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edytujd
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.trans = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.miejsce = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.nrzlec = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DoKiedy = New System.Windows.Forms.DateTimePicker
        Me.odkiedy = New System.Windows.Forms.DateTimePicker
        Me.surname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nrd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(48, 206)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Transport:"
        '
        'trans
        '
        Me.trans.Location = New System.Drawing.Point(78, 97)
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(150, 20)
        Me.trans.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Miejsce:"
        '
        'miejsce
        '
        Me.miejsce.Location = New System.Drawing.Point(78, 71)
        Me.miejsce.Name = "miejsce"
        Me.miejsce.Size = New System.Drawing.Size(150, 20)
        Me.miejsce.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Nr zlec:"
        '
        'nrzlec
        '
        Me.nrzlec.Location = New System.Drawing.Point(78, 175)
        Me.nrzlec.Name = "nrzlec"
        Me.nrzlec.Size = New System.Drawing.Size(150, 20)
        Me.nrzlec.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Do kiedy:"
        '
        'DoKiedy
        '
        Me.DoKiedy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DoKiedy.Location = New System.Drawing.Point(78, 149)
        Me.DoKiedy.Name = "DoKiedy"
        Me.DoKiedy.Size = New System.Drawing.Size(150, 20)
        Me.DoKiedy.TabIndex = 26
        Me.DoKiedy.Value = New Date(2008, 10, 26, 0, 0, 0, 0)
        '
        'odkiedy
        '
        Me.odkiedy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.odkiedy.Location = New System.Drawing.Point(78, 123)
        Me.odkiedy.Name = "odkiedy"
        Me.odkiedy.Size = New System.Drawing.Size(150, 20)
        Me.odkiedy.TabIndex = 25
        Me.odkiedy.Value = New Date(2008, 10, 26, 0, 0, 0, 0)
        '
        'surname
        '
        Me.surname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.surname.FormattingEnabled = True
        Me.surname.Location = New System.Drawing.Point(78, 44)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(150, 21)
        Me.surname.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Od kiedy:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Pracownik:"
        '
        'nrd
        '
        Me.nrd.Enabled = False
        Me.nrd.Location = New System.Drawing.Point(78, 15)
        Me.nrd.Name = "nrd"
        Me.nrd.Size = New System.Drawing.Size(150, 20)
        Me.nrd.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nr delegcji:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'edytujd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(244, 238)
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
        Me.Name = "edytujd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edytuj wyjazd służbowy"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents trans As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents miejsce As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nrzlec As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DoKiedy As System.Windows.Forms.DateTimePicker
    Friend WithEvents odkiedy As System.Windows.Forms.DateTimePicker
    Friend WithEvents surname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nrd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
