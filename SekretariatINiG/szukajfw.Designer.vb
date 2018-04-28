<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajfw
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Dataw = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nadawca = New System.Windows.Forms.ComboBox
        Me.Chn = New System.Windows.Forms.CheckBox
        Me.Chdw = New System.Windows.Forms.CheckBox
        Me.Cha = New System.Windows.Forms.CheckBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(199, 98)
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
        Me.adresat.Location = New System.Drawing.Point(95, 65)
        Me.adresat.Name = "adresat"
        Me.adresat.Size = New System.Drawing.Size(431, 21)
        Me.adresat.TabIndex = 37
        Me.adresat.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Adresat:"
        '
        'Dataw
        '
        Me.Dataw.Enabled = False
        Me.Dataw.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dataw.Location = New System.Drawing.Point(163, 39)
        Me.Dataw.Name = "Dataw"
        Me.Dataw.Size = New System.Drawing.Size(363, 20)
        Me.Dataw.TabIndex = 36
        Me.Dataw.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Data wys.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nadawca:"
        '
        'nadawca
        '
        Me.nadawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nadawca.Enabled = False
        Me.nadawca.Location = New System.Drawing.Point(94, 12)
        Me.nadawca.Name = "nadawca"
        Me.nadawca.Size = New System.Drawing.Size(432, 21)
        Me.nadawca.TabIndex = 35
        Me.nadawca.Visible = False
        '
        'Chn
        '
        Me.Chn.AutoSize = True
        Me.Chn.Location = New System.Drawing.Point(73, 15)
        Me.Chn.Name = "Chn"
        Me.Chn.Size = New System.Drawing.Size(15, 14)
        Me.Chn.TabIndex = 41
        Me.Chn.UseVisualStyleBackColor = True
        '
        'Chdw
        '
        Me.Chdw.AutoSize = True
        Me.Chdw.Location = New System.Drawing.Point(73, 42)
        Me.Chdw.Name = "Chdw"
        Me.Chdw.Size = New System.Drawing.Size(15, 14)
        Me.Chdw.TabIndex = 42
        Me.Chdw.UseVisualStyleBackColor = True
        '
        'Cha
        '
        Me.Cha.AutoSize = True
        Me.Cha.Location = New System.Drawing.Point(73, 68)
        Me.Cha.Name = "Cha"
        Me.Cha.Size = New System.Drawing.Size(15, 14)
        Me.Cha.TabIndex = 43
        Me.Cha.UseVisualStyleBackColor = True
        '
        'rownanie
        '
        Me.rownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rownanie.Enabled = False
        Me.rownanie.Items.AddRange(New Object() {"<=", "=", ">="})
        Me.rownanie.Location = New System.Drawing.Point(94, 38)
        Me.rownanie.Name = "rownanie"
        Me.rownanie.Size = New System.Drawing.Size(63, 21)
        Me.rownanie.TabIndex = 44
        Me.rownanie.Visible = False
        '
        'szukajfw
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 139)
        Me.Controls.Add(Me.rownanie)
        Me.Controls.Add(Me.Cha)
        Me.Controls.Add(Me.Chdw)
        Me.Controls.Add(Me.Chn)
        Me.Controls.Add(Me.adresat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dataw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nadawca)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajfw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szukaj: fax wysłany"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents adresat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Dataw As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nadawca As System.Windows.Forms.ComboBox
    Friend WithEvents Chn As System.Windows.Forms.CheckBox
    Friend WithEvents Chdw As System.Windows.Forms.CheckBox
    Friend WithEvents Cha As System.Windows.Forms.CheckBox
    Friend WithEvents rownanie As System.Windows.Forms.ComboBox

End Class
