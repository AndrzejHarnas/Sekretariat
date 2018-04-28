<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajdo
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.symbol = New System.Windows.Forms.ComboBox
        Me.odkogo = New System.Windows.Forms.ComboBox
        Me.datao = New System.Windows.Forms.DateTimePicker
        Me.Chdo = New System.Windows.Forms.CheckBox
        Me.Chn = New System.Windows.Forms.CheckBox
        Me.cho = New System.Windows.Forms.CheckBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(187, 104)
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
        Me.Label5.Location = New System.Drawing.Point(17, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Odbiorca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nadawca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Data otrz.:"
        '
        'symbol
        '
        Me.symbol.Enabled = False
        Me.symbol.FormattingEnabled = True
        Me.symbol.Location = New System.Drawing.Point(95, 70)
        Me.symbol.Name = "symbol"
        Me.symbol.Size = New System.Drawing.Size(392, 21)
        Me.symbol.TabIndex = 14
        Me.symbol.Visible = False
        '
        'odkogo
        '
        Me.odkogo.Enabled = False
        Me.odkogo.FormattingEnabled = True
        Me.odkogo.Location = New System.Drawing.Point(95, 41)
        Me.odkogo.Name = "odkogo"
        Me.odkogo.Size = New System.Drawing.Size(392, 21)
        Me.odkogo.TabIndex = 13
        Me.odkogo.Visible = False
        '
        'datao
        '
        Me.datao.Enabled = False
        Me.datao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datao.Location = New System.Drawing.Point(165, 15)
        Me.datao.Name = "datao"
        Me.datao.Size = New System.Drawing.Size(322, 20)
        Me.datao.TabIndex = 12
        Me.datao.Visible = False
        '
        'Chdo
        '
        Me.Chdo.AutoSize = True
        Me.Chdo.Location = New System.Drawing.Point(74, 18)
        Me.Chdo.Name = "Chdo"
        Me.Chdo.Size = New System.Drawing.Size(15, 14)
        Me.Chdo.TabIndex = 19
        Me.Chdo.UseVisualStyleBackColor = True
        '
        'Chn
        '
        Me.Chn.AutoSize = True
        Me.Chn.Location = New System.Drawing.Point(74, 44)
        Me.Chn.Name = "Chn"
        Me.Chn.Size = New System.Drawing.Size(15, 14)
        Me.Chn.TabIndex = 20
        Me.Chn.UseVisualStyleBackColor = True
        '
        'cho
        '
        Me.cho.AutoSize = True
        Me.cho.Location = New System.Drawing.Point(74, 73)
        Me.cho.Name = "cho"
        Me.cho.Size = New System.Drawing.Size(15, 14)
        Me.cho.TabIndex = 21
        Me.cho.UseVisualStyleBackColor = True
        '
        'rownanie
        '
        Me.rownanie.Enabled = False
        Me.rownanie.FormattingEnabled = True
        Me.rownanie.Items.AddRange(New Object() {"<=", "=", ">="})
        Me.rownanie.Location = New System.Drawing.Point(95, 15)
        Me.rownanie.Name = "rownanie"
        Me.rownanie.Size = New System.Drawing.Size(64, 21)
        Me.rownanie.TabIndex = 22
        Me.rownanie.Visible = False
        '
        'szukajdo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(509, 145)
        Me.Controls.Add(Me.rownanie)
        Me.Controls.Add(Me.cho)
        Me.Controls.Add(Me.Chn)
        Me.Controls.Add(Me.Chdo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.symbol)
        Me.Controls.Add(Me.odkogo)
        Me.Controls.Add(Me.datao)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajdo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szukaj: dziennik - pisma otrzymane"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents symbol As System.Windows.Forms.ComboBox
    Friend WithEvents odkogo As System.Windows.Forms.ComboBox
    Friend WithEvents datao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chdo As System.Windows.Forms.CheckBox
    Friend WithEvents Chn As System.Windows.Forms.CheckBox
    Friend WithEvents cho As System.Windows.Forms.CheckBox
    Friend WithEvents rownanie As System.Windows.Forms.ComboBox

End Class
