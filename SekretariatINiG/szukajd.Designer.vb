<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szukajd
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
        Me.Chp = New System.Windows.Forms.CheckBox
        Me.Chz = New System.Windows.Forms.CheckBox
        Me.Chodj = New System.Windows.Forms.CheckBox
        Me.Chprz = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Datewyj = New System.Windows.Forms.DateTimePicker
        Me.Dateprzyj = New System.Windows.Forms.DateTimePicker
        Me.pracownik = New System.Windows.Forms.ComboBox
        Me.zaklad = New System.Windows.Forms.ComboBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(65, 107)
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
        'Chp
        '
        Me.Chp.AutoSize = True
        Me.Chp.Location = New System.Drawing.Point(91, 9)
        Me.Chp.Name = "Chp"
        Me.Chp.Size = New System.Drawing.Size(15, 14)
        Me.Chp.TabIndex = 1
        Me.Chp.UseVisualStyleBackColor = True
        '
        'Chz
        '
        Me.Chz.AutoSize = True
        Me.Chz.Location = New System.Drawing.Point(91, 32)
        Me.Chz.Name = "Chz"
        Me.Chz.Size = New System.Drawing.Size(15, 14)
        Me.Chz.TabIndex = 2
        Me.Chz.UseVisualStyleBackColor = True
        '
        'Chodj
        '
        Me.Chodj.AutoSize = True
        Me.Chodj.Location = New System.Drawing.Point(91, 55)
        Me.Chodj.Name = "Chodj"
        Me.Chodj.Size = New System.Drawing.Size(15, 14)
        Me.Chodj.TabIndex = 3
        Me.Chodj.UseVisualStyleBackColor = True
        '
        'Chprz
        '
        Me.Chprz.AutoSize = True
        Me.Chprz.Location = New System.Drawing.Point(91, 78)
        Me.Chprz.Name = "Chprz"
        Me.Chprz.Size = New System.Drawing.Size(15, 14)
        Me.Chprz.TabIndex = 4
        Me.Chprz.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pracownik:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Zakład:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data wyjazdu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data przyjazdu:"
        '
        'Datewyj
        '
        Me.Datewyj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datewyj.Location = New System.Drawing.Point(112, 51)
        Me.Datewyj.Name = "Datewyj"
        Me.Datewyj.Size = New System.Drawing.Size(146, 20)
        Me.Datewyj.TabIndex = 9
        Me.Datewyj.Visible = False
        '
        'Dateprzyj
        '
        Me.Dateprzyj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dateprzyj.Location = New System.Drawing.Point(112, 75)
        Me.Dateprzyj.Name = "Dateprzyj"
        Me.Dateprzyj.Size = New System.Drawing.Size(146, 20)
        Me.Dateprzyj.TabIndex = 10
        Me.Dateprzyj.Visible = False
        '
        'pracownik
        '
        Me.pracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pracownik.FormattingEnabled = True
        Me.pracownik.Location = New System.Drawing.Point(112, 6)
        Me.pracownik.Name = "pracownik"
        Me.pracownik.Size = New System.Drawing.Size(146, 21)
        Me.pracownik.TabIndex = 11
        Me.pracownik.Visible = False
        '
        'zaklad
        '
        Me.zaklad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zaklad.FormattingEnabled = True
        Me.zaklad.Location = New System.Drawing.Point(112, 29)
        Me.zaklad.Name = "zaklad"
        Me.zaklad.Size = New System.Drawing.Size(146, 21)
        Me.zaklad.TabIndex = 12
        Me.zaklad.Visible = False
        '
        'szukajd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(271, 148)
        Me.Controls.Add(Me.zaklad)
        Me.Controls.Add(Me.pracownik)
        Me.Controls.Add(Me.Dateprzyj)
        Me.Controls.Add(Me.Datewyj)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chprz)
        Me.Controls.Add(Me.Chodj)
        Me.Controls.Add(Me.Chz)
        Me.Controls.Add(Me.Chp)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "szukajd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wyszukaj wyjazd służbowy"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Chp As System.Windows.Forms.CheckBox
    Friend WithEvents Chz As System.Windows.Forms.CheckBox
    Friend WithEvents Chodj As System.Windows.Forms.CheckBox
    Friend WithEvents Chprz As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Datewyj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dateprzyj As System.Windows.Forms.DateTimePicker
    Friend WithEvents pracownik As System.Windows.Forms.ComboBox
    Friend WithEvents zaklad As System.Windows.Forms.ComboBox

End Class
