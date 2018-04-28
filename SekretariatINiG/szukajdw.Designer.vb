<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajdw
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
        Me.chzp = New System.Windows.Forms.CheckBox
        Me.Cho = New System.Windows.Forms.CheckBox
        Me.Chdw = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.odbiorca = New System.Windows.Forms.ComboBox
        Me.dataw = New System.Windows.Forms.DateTimePicker
        Me.znakp = New System.Windows.Forms.TextBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(194, 102)
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
        'chzp
        '
        Me.chzp.AutoSize = True
        Me.chzp.Location = New System.Drawing.Point(78, 71)
        Me.chzp.Name = "chzp"
        Me.chzp.Size = New System.Drawing.Size(15, 14)
        Me.chzp.TabIndex = 30
        Me.chzp.UseVisualStyleBackColor = True
        '
        'Cho
        '
        Me.Cho.AutoSize = True
        Me.Cho.Location = New System.Drawing.Point(78, 42)
        Me.Cho.Name = "Cho"
        Me.Cho.Size = New System.Drawing.Size(15, 14)
        Me.Cho.TabIndex = 29
        Me.Cho.UseVisualStyleBackColor = True
        '
        'Chdw
        '
        Me.Chdw.AutoSize = True
        Me.Chdw.Location = New System.Drawing.Point(78, 16)
        Me.Chdw.Name = "Chdw"
        Me.Chdw.Size = New System.Drawing.Size(15, 14)
        Me.Chdw.TabIndex = 28
        Me.Chdw.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Znak pisma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Odbiorca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Data wys.:"
        '
        'odbiorca
        '
        Me.odbiorca.Enabled = False
        Me.odbiorca.FormattingEnabled = True
        Me.odbiorca.Location = New System.Drawing.Point(99, 39)
        Me.odbiorca.Name = "odbiorca"
        Me.odbiorca.Size = New System.Drawing.Size(392, 21)
        Me.odbiorca.TabIndex = 23
        Me.odbiorca.Visible = False
        '
        'dataw
        '
        Me.dataw.Enabled = False
        Me.dataw.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataw.Location = New System.Drawing.Point(149, 13)
        Me.dataw.Name = "dataw"
        Me.dataw.Size = New System.Drawing.Size(342, 20)
        Me.dataw.TabIndex = 22
        Me.dataw.Visible = False
        '
        'znakp
        '
        Me.znakp.Enabled = False
        Me.znakp.Location = New System.Drawing.Point(99, 68)
        Me.znakp.Name = "znakp"
        Me.znakp.Size = New System.Drawing.Size(392, 20)
        Me.znakp.TabIndex = 31
        Me.znakp.Visible = False
        '
        'rownanie
        '
        Me.rownanie.Enabled = False
        Me.rownanie.FormattingEnabled = True
        Me.rownanie.Items.AddRange(New Object() {"<=", "=", ">="})
        Me.rownanie.Location = New System.Drawing.Point(99, 12)
        Me.rownanie.Name = "rownanie"
        Me.rownanie.Size = New System.Drawing.Size(44, 21)
        Me.rownanie.TabIndex = 32
        Me.rownanie.Text = "="
        Me.rownanie.Visible = False
        '
        'szukajdw
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(513, 143)
        Me.Controls.Add(Me.rownanie)
        Me.Controls.Add(Me.znakp)
        Me.Controls.Add(Me.chzp)
        Me.Controls.Add(Me.Cho)
        Me.Controls.Add(Me.Chdw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.odbiorca)
        Me.Controls.Add(Me.dataw)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "szukajdw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szukaj: dziennik - pisma wysłane"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents chzp As System.Windows.Forms.CheckBox
    Friend WithEvents Cho As System.Windows.Forms.CheckBox
    Friend WithEvents Chdw As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents odbiorca As System.Windows.Forms.ComboBox
    Friend WithEvents dataw As System.Windows.Forms.DateTimePicker
    Friend WithEvents znakp As System.Windows.Forms.TextBox
    Friend WithEvents rownanie As System.Windows.Forms.ComboBox

End Class
