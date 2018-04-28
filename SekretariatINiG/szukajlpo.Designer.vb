<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajlpo
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
        Me.nadawca = New System.Windows.Forms.ComboBox
        Me.datao = New System.Windows.Forms.DateTimePicker
        Me.adresat = New System.Windows.Forms.TextBox
        Me.Chadresat = New System.Windows.Forms.CheckBox
        Me.chdatao = New System.Windows.Forms.CheckBox
        Me.Chnadawca = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.R = New System.Windows.Forms.TextBox
        Me.chnr = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rownanie = New System.Windows.Forms.ComboBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(138, 120)
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
        'nadawca
        '
        Me.nadawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nadawca.Enabled = False
        Me.nadawca.FormattingEnabled = True
        Me.nadawca.Location = New System.Drawing.Point(138, 12)
        Me.nadawca.Name = "nadawca"
        Me.nadawca.Size = New System.Drawing.Size(253, 21)
        Me.nadawca.TabIndex = 1
        Me.nadawca.Visible = False
        '
        'datao
        '
        Me.datao.Enabled = False
        Me.datao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datao.Location = New System.Drawing.Point(208, 39)
        Me.datao.Name = "datao"
        Me.datao.Size = New System.Drawing.Size(183, 20)
        Me.datao.TabIndex = 2
        Me.datao.Visible = False
        '
        'adresat
        '
        Me.adresat.Enabled = False
        Me.adresat.Location = New System.Drawing.Point(138, 65)
        Me.adresat.Name = "adresat"
        Me.adresat.Size = New System.Drawing.Size(253, 20)
        Me.adresat.TabIndex = 3
        Me.adresat.Visible = False
        '
        'Chadresat
        '
        Me.Chadresat.AutoSize = True
        Me.Chadresat.Location = New System.Drawing.Point(117, 68)
        Me.Chadresat.Name = "Chadresat"
        Me.Chadresat.Size = New System.Drawing.Size(15, 14)
        Me.Chadresat.TabIndex = 15
        Me.Chadresat.UseVisualStyleBackColor = True
        '
        'chdatao
        '
        Me.chdatao.AutoSize = True
        Me.chdatao.Location = New System.Drawing.Point(117, 43)
        Me.chdatao.Name = "chdatao"
        Me.chdatao.Size = New System.Drawing.Size(15, 14)
        Me.chdatao.TabIndex = 14
        Me.chdatao.UseVisualStyleBackColor = True
        '
        'Chnadawca
        '
        Me.Chnadawca.AutoSize = True
        Me.Chnadawca.Location = New System.Drawing.Point(117, 15)
        Me.Chnadawca.Name = "Chnadawca"
        Me.Chnadawca.Size = New System.Drawing.Size(15, 14)
        Me.Chnadawca.TabIndex = 13
        Me.Chnadawca.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Adresat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Data otrzymania:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nadawca:"
        '
        'R
        '
        Me.R.Enabled = False
        Me.R.Location = New System.Drawing.Point(138, 91)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(253, 20)
        Me.R.TabIndex = 4
        Me.R.Visible = False
        '
        'chnr
        '
        Me.chnr.AutoSize = True
        Me.chnr.Location = New System.Drawing.Point(117, 94)
        Me.chnr.Name = "chnr"
        Me.chnr.Size = New System.Drawing.Size(15, 14)
        Me.chnr.TabIndex = 17
        Me.chnr.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nr przesyłki:"
        '
        'rownanie
        '
        Me.rownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rownanie.Enabled = False
        Me.rownanie.FormattingEnabled = True
        Me.rownanie.Items.AddRange(New Object() {"<=", "=", ">="})
        Me.rownanie.Location = New System.Drawing.Point(138, 38)
        Me.rownanie.Name = "rownanie"
        Me.rownanie.Size = New System.Drawing.Size(64, 21)
        Me.rownanie.TabIndex = 19
        Me.rownanie.Visible = False
        '
        'szukajlpo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(409, 161)
        Me.Controls.Add(Me.rownanie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chnr)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.nadawca)
        Me.Controls.Add(Me.datao)
        Me.Controls.Add(Me.adresat)
        Me.Controls.Add(Me.Chadresat)
        Me.Controls.Add(Me.chdatao)
        Me.Controls.Add(Me.Chnadawca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajlpo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wyszukaj: Listy polecone otrzymane"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents nadawca As System.Windows.Forms.ComboBox
    Friend WithEvents datao As System.Windows.Forms.DateTimePicker
    Friend WithEvents adresat As System.Windows.Forms.TextBox
    Friend WithEvents Chadresat As System.Windows.Forms.CheckBox
    Friend WithEvents chdatao As System.Windows.Forms.CheckBox
    Friend WithEvents Chnadawca As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents R As System.Windows.Forms.TextBox
    Friend WithEvents chnr As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rownanie As System.Windows.Forms.ComboBox

End Class
