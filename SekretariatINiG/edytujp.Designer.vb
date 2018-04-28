<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edytujp
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
        Me.nrid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.kot = New System.Windows.Forms.TextBox
        Me.street = New System.Windows.Forms.TextBox
        Me.city = New System.Windows.Forms.TextBox
        Me.zp = New System.Windows.Forms.ComboBox
        Me.dtur = New System.Windows.Forms.TextBox
        Me.surname = New System.Windows.Forms.TextBox
        Me.names = New System.Windows.Forms.TextBox
        Me.stn = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.stat = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(91, 350)
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
        Me.OK_Button.TabIndex = 11
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 12
        Me.Cancel_Button.Text = "Anuluj"
        '
        'stp
        '
        Me.stp.AllowDrop = True
        Me.stp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stp.DropDownWidth = 200
        Me.stp.FormattingEnabled = True
        Me.stp.Location = New System.Drawing.Point(127, 151)
        Me.stp.Name = "stp"
        Me.stp.Size = New System.Drawing.Size(121, 21)
        Me.stp.TabIndex = 5
        '
        'nrid
        '
        Me.nrid.Enabled = False
        Me.nrid.Location = New System.Drawing.Point(275, 8)
        Me.nrid.Name = "nrid"
        Me.nrid.Size = New System.Drawing.Size(43, 20)
        Me.nrid.TabIndex = 12
        Me.nrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(237, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Nr id:"
        '
        'kot
        '
        Me.kot.Location = New System.Drawing.Point(127, 321)
        Me.kot.Name = "kot"
        Me.kot.Size = New System.Drawing.Size(121, 20)
        Me.kot.TabIndex = 10
        '
        'street
        '
        Me.street.Location = New System.Drawing.Point(127, 295)
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(121, 20)
        Me.street.TabIndex = 9
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(127, 269)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(121, 20)
        Me.city.TabIndex = 8
        '
        'zp
        '
        Me.zp.AllowDrop = True
        Me.zp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.zp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.zp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zp.FormattingEnabled = True
        Me.zp.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.zp.Location = New System.Drawing.Point(127, 178)
        Me.zp.Name = "zp"
        Me.zp.Size = New System.Drawing.Size(121, 21)
        Me.zp.TabIndex = 6
        '
        'dtur
        '
        Me.dtur.Location = New System.Drawing.Point(127, 125)
        Me.dtur.Name = "dtur"
        Me.dtur.Size = New System.Drawing.Size(121, 20)
        Me.dtur.TabIndex = 4
        '
        'surname
        '
        Me.surname.Location = New System.Drawing.Point(127, 99)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(121, 20)
        Me.surname.TabIndex = 3
        '
        'names
        '
        Me.names.Location = New System.Drawing.Point(127, 73)
        Me.names.Name = "names"
        Me.names.Size = New System.Drawing.Size(121, 20)
        Me.names.TabIndex = 2
        '
        'stn
        '
        Me.stn.Location = New System.Drawing.Point(127, 47)
        Me.stn.Name = "stn"
        Me.stn.Size = New System.Drawing.Size(121, 20)
        Me.stn.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Kod poczt. (xx-xxx):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(76, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Ulica:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(39, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Miejscowość:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(61, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Zakład:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(16, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Stanowisko pracy:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(61, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Adres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(22, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Data ur (rrmmdd):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(54, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nazwisko:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(77, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Imię:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(18, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Stopień naukowy:"
        '
        'stat
        '
        Me.stat.AllowDrop = True
        Me.stat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.stat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.stat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stat.FormattingEnabled = True
        Me.stat.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.stat.Location = New System.Drawing.Point(127, 205)
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(121, 21)
        Me.stat.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(64, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Status:"
        '
        'edytujp
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(329, 391)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.stat)
        Me.Controls.Add(Me.stp)
        Me.Controls.Add(Me.nrid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kot)
        Me.Controls.Add(Me.street)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.zp)
        Me.Controls.Add(Me.dtur)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.names)
        Me.Controls.Add(Me.stn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "edytujp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edycja pracownika"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents stp As System.Windows.Forms.ComboBox
    Friend WithEvents nrid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents kot As System.Windows.Forms.TextBox
    Friend WithEvents street As System.Windows.Forms.TextBox
    Friend WithEvents city As System.Windows.Forms.TextBox
    Friend WithEvents zp As System.Windows.Forms.ComboBox
    Friend WithEvents dtur As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents names As System.Windows.Forms.TextBox
    Friend WithEvents stn As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stat As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
