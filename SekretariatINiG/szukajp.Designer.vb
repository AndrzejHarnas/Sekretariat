<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajp
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
        Me.stp = New System.Windows.Forms.ComboBox
        Me.zp = New System.Windows.Forms.ComboBox
        Me.surname = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chst = New System.Windows.Forms.CheckBox
        Me.Chnazwisko = New System.Windows.Forms.CheckBox
        Me.Chzp = New System.Windows.Forms.CheckBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(63, 103)
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
        'stp
        '
        Me.stp.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.stp.AllowDrop = True
        Me.stp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.stp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.stp.BackColor = System.Drawing.Color.White
        Me.stp.DisplayMember = """"""
        Me.stp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stp.DropDownWidth = 200
        Me.stp.Enabled = False
        Me.stp.FormattingEnabled = True
        Me.stp.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.stp.Items.AddRange(New Object() {"1"})
        Me.stp.Location = New System.Drawing.Point(133, 43)
        Me.stp.Name = "stp"
        Me.stp.Size = New System.Drawing.Size(121, 21)
        Me.stp.TabIndex = 22
        Me.stp.Visible = False
        '
        'zp
        '
        Me.zp.AllowDrop = True
        Me.zp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.zp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.zp.BackColor = System.Drawing.Color.White
        Me.zp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zp.Enabled = False
        Me.zp.FormattingEnabled = True
        Me.zp.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.zp.Location = New System.Drawing.Point(133, 70)
        Me.zp.Name = "zp"
        Me.zp.Size = New System.Drawing.Size(121, 21)
        Me.zp.TabIndex = 24
        Me.zp.Visible = False
        '
        'surname
        '
        Me.surname.BackColor = System.Drawing.Color.White
        Me.surname.Enabled = False
        Me.surname.Location = New System.Drawing.Point(133, 16)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(121, 20)
        Me.surname.TabIndex = 17
        Me.surname.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(61, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Zakład:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Stanowisko pracy:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(50, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nazwisko:"
        '
        'chst
        '
        Me.chst.AutoSize = True
        Me.chst.Location = New System.Drawing.Point(112, 46)
        Me.chst.Name = "chst"
        Me.chst.Size = New System.Drawing.Size(15, 14)
        Me.chst.TabIndex = 35
        Me.chst.UseVisualStyleBackColor = True
        '
        'Chnazwisko
        '
        Me.Chnazwisko.AutoSize = True
        Me.Chnazwisko.Location = New System.Drawing.Point(112, 19)
        Me.Chnazwisko.Name = "Chnazwisko"
        Me.Chnazwisko.Size = New System.Drawing.Size(15, 14)
        Me.Chnazwisko.TabIndex = 39
        Me.Chnazwisko.UseVisualStyleBackColor = True
        '
        'Chzp
        '
        Me.Chzp.AutoSize = True
        Me.Chzp.Location = New System.Drawing.Point(112, 73)
        Me.Chzp.Name = "Chzp"
        Me.Chzp.Size = New System.Drawing.Size(15, 14)
        Me.Chzp.TabIndex = 41
        Me.Chzp.UseVisualStyleBackColor = True
        '
        'szukajp
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(271, 144)
        Me.Controls.Add(Me.Chzp)
        Me.Controls.Add(Me.Chnazwisko)
        Me.Controls.Add(Me.chst)
        Me.Controls.Add(Me.stp)
        Me.Controls.Add(Me.zp)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szukaj pracownika"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents zp As System.Windows.Forms.ComboBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stp As System.Windows.Forms.ComboBox
    Friend WithEvents chst As System.Windows.Forms.CheckBox
    Friend WithEvents Chnazwisko As System.Windows.Forms.CheckBox
    Friend WithEvents Chzp As System.Windows.Forms.CheckBox

End Class
