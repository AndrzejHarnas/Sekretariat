<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajlpw
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
        Me.adresat = New System.Windows.Forms.ComboBox
        Me.nadawca = New System.Windows.Forms.ComboBox
        Me.dataw = New System.Windows.Forms.DateTimePicker
        Me.Chadresat = New System.Windows.Forms.CheckBox
        Me.chdataw = New System.Windows.Forms.CheckBox
        Me.Chnadawca = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.R = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ChR = New System.Windows.Forms.CheckBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(149, 122)
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
        'adresat
        '
        Me.adresat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.adresat.Enabled = False
        Me.adresat.FormattingEnabled = True
        Me.adresat.Location = New System.Drawing.Point(135, 65)
        Me.adresat.Name = "adresat"
        Me.adresat.Size = New System.Drawing.Size(285, 21)
        Me.adresat.TabIndex = 28
        Me.adresat.Visible = False
        '
        'nadawca
        '
        Me.nadawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nadawca.Enabled = False
        Me.nadawca.FormattingEnabled = True
        Me.nadawca.Location = New System.Drawing.Point(135, 12)
        Me.nadawca.Name = "nadawca"
        Me.nadawca.Size = New System.Drawing.Size(285, 21)
        Me.nadawca.Sorted = True
        Me.nadawca.TabIndex = 27
        Me.nadawca.Visible = False
        '
        'dataw
        '
        Me.dataw.Enabled = False
        Me.dataw.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataw.Location = New System.Drawing.Point(197, 39)
        Me.dataw.Name = "dataw"
        Me.dataw.Size = New System.Drawing.Size(223, 20)
        Me.dataw.TabIndex = 26
        Me.dataw.Visible = False
        '
        'Chadresat
        '
        Me.Chadresat.AutoSize = True
        Me.Chadresat.Location = New System.Drawing.Point(114, 68)
        Me.Chadresat.Name = "Chadresat"
        Me.Chadresat.Size = New System.Drawing.Size(15, 14)
        Me.Chadresat.TabIndex = 25
        Me.Chadresat.UseVisualStyleBackColor = True
        '
        'chdataw
        '
        Me.chdataw.AutoSize = True
        Me.chdataw.Location = New System.Drawing.Point(114, 43)
        Me.chdataw.Name = "chdataw"
        Me.chdataw.Size = New System.Drawing.Size(15, 14)
        Me.chdataw.TabIndex = 24
        Me.chdataw.UseVisualStyleBackColor = True
        '
        'Chnadawca
        '
        Me.Chnadawca.AutoSize = True
        Me.Chnadawca.Location = New System.Drawing.Point(114, 15)
        Me.Chnadawca.Name = "Chnadawca"
        Me.Chnadawca.Size = New System.Drawing.Size(15, 14)
        Me.Chnadawca.TabIndex = 23
        Me.Chnadawca.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Adresat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Data wysłania:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nadawca:"
        '
        'R
        '
        Me.R.Enabled = False
        Me.R.Location = New System.Drawing.Point(135, 92)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(285, 20)
        Me.R.TabIndex = 29
        Me.R.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nr przesyłki:"
        '
        'ChR
        '
        Me.ChR.AutoSize = True
        Me.ChR.Location = New System.Drawing.Point(114, 95)
        Me.ChR.Name = "ChR"
        Me.ChR.Size = New System.Drawing.Size(15, 14)
        Me.ChR.TabIndex = 31
        Me.ChR.UseVisualStyleBackColor = True
        '
        'rownanie
        '
        Me.rownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rownanie.Enabled = False
        Me.rownanie.FormattingEnabled = True
        Me.rownanie.Items.AddRange(New Object() {"<=", "=", ">="})
        Me.rownanie.Location = New System.Drawing.Point(135, 39)
        Me.rownanie.Name = "rownanie"
        Me.rownanie.Size = New System.Drawing.Size(56, 21)
        Me.rownanie.Sorted = True
        Me.rownanie.TabIndex = 32
        Me.rownanie.Visible = False
        '
        'szukajlpw
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 163)
        Me.Controls.Add(Me.rownanie)
        Me.Controls.Add(Me.ChR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.adresat)
        Me.Controls.Add(Me.nadawca)
        Me.Controls.Add(Me.dataw)
        Me.Controls.Add(Me.Chadresat)
        Me.Controls.Add(Me.chdataw)
        Me.Controls.Add(Me.Chnadawca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajlpw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szukaj: Listy polecone wysłane"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents adresat As System.Windows.Forms.ComboBox
    Friend WithEvents nadawca As System.Windows.Forms.ComboBox
    Friend WithEvents dataw As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chadresat As System.Windows.Forms.CheckBox
    Friend WithEvents chdataw As System.Windows.Forms.CheckBox
    Friend WithEvents Chnadawca As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents R As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChR As System.Windows.Forms.CheckBox
    Friend WithEvents rownanie As System.Windows.Forms.ComboBox

End Class
