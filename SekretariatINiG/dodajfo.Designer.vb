﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodajfo
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
        Me.Nrw = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Datao = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Odkogo = New System.Windows.Forms.ComboBox
        Me.dokogo = New System.Windows.Forms.TextBox
        Me.nastepny = New System.Windows.Forms.Button
        Me.dotyczy = New System.Windows.Forms.TextBox
        Me.dot = New System.Windows.Forms.Label
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(197, 202)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
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
        Me.Label5.Location = New System.Drawing.Point(18, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Do kogo:"
        '
        'Nrw
        '
        Me.Nrw.Location = New System.Drawing.Point(462, 6)
        Me.Nrw.Name = "Nrw"
        Me.Nrw.Size = New System.Drawing.Size(45, 20)
        Me.Nrw.TabIndex = 27
        Me.Nrw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nr wys.:"
        '
        'Datao
        '
        Me.Datao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datao.Location = New System.Drawing.Point(75, 59)
        Me.Datao.Name = "Datao"
        Me.Datao.Size = New System.Drawing.Size(432, 20)
        Me.Datao.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Data odb.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Od kogo:"
        '
        'Odkogo
        '
        Me.Odkogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Odkogo.Location = New System.Drawing.Point(75, 32)
        Me.Odkogo.Name = "Odkogo"
        Me.Odkogo.Size = New System.Drawing.Size(432, 21)
        Me.Odkogo.TabIndex = 28
        '
        'dokogo
        '
        Me.dokogo.Location = New System.Drawing.Point(75, 170)
        Me.dokogo.Name = "dokogo"
        Me.dokogo.Size = New System.Drawing.Size(431, 20)
        Me.dokogo.TabIndex = 35
        '
        'nastepny
        '
        Me.nastepny.Image = Global.Sekretariat.My.Resources.Resources.skipover
        Me.nastepny.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nastepny.Location = New System.Drawing.Point(477, 205)
        Me.nastepny.Name = "nastepny"
        Me.nastepny.Size = New System.Drawing.Size(27, 23)
        Me.nastepny.TabIndex = 36
        Me.nastepny.UseVisualStyleBackColor = True
        '
        'dotyczy
        '
        Me.dotyczy.Location = New System.Drawing.Point(75, 85)
        Me.dotyczy.Multiline = True
        Me.dotyczy.Name = "dotyczy"
        Me.dotyczy.Size = New System.Drawing.Size(429, 79)
        Me.dotyczy.TabIndex = 37
        '
        'dot
        '
        Me.dot.AutoSize = True
        Me.dot.Location = New System.Drawing.Point(21, 117)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(48, 13)
        Me.dot.TabIndex = 38
        Me.dot.Text = "Dotyczy:"
        '
        'dodajfo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(522, 243)
        Me.Controls.Add(Me.dot)
        Me.Controls.Add(Me.dotyczy)
        Me.Controls.Add(Me.nastepny)
        Me.Controls.Add(Me.dokogo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nrw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Datao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Odkogo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dodajfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodaj: fax odebrany"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Nrw As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Datao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Odkogo As System.Windows.Forms.ComboBox
    Friend WithEvents dokogo As System.Windows.Forms.TextBox
    Friend WithEvents nastepny As System.Windows.Forms.Button
    Friend WithEvents dotyczy As System.Windows.Forms.TextBox
    Friend WithEvents dot As System.Windows.Forms.Label

End Class
