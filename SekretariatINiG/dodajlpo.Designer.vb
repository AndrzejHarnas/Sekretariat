﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodajlpo
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
        Me.R = New System.Windows.Forms.TextBox
        Me.Nrlpo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Datao = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Odkogo = New System.Windows.Forms.ComboBox
        Me.dokogo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.nastepny = New System.Windows.Forms.Button
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(140, 152)
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
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancel"
        '
        'R
        '
        Me.R.Location = New System.Drawing.Point(100, 95)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(301, 20)
        Me.R.TabIndex = 4
        '
        'Nrlpo
        '
        Me.Nrlpo.Location = New System.Drawing.Point(356, 9)
        Me.Nrlpo.Name = "Nrlpo"
        Me.Nrlpo.Size = New System.Drawing.Size(45, 20)
        Me.Nrlpo.TabIndex = 1
        Me.Nrlpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nr:"
        '
        'Datao
        '
        Me.Datao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datao.Location = New System.Drawing.Point(100, 69)
        Me.Datao.Name = "Datao"
        Me.Datao.Size = New System.Drawing.Size(301, 20)
        Me.Datao.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nr przesyłki R:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data odbioru:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Od kogo:"
        '
        'Odkogo
        '
        Me.Odkogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Odkogo.Location = New System.Drawing.Point(100, 42)
        Me.Odkogo.Name = "Odkogo"
        Me.Odkogo.Size = New System.Drawing.Size(301, 21)
        Me.Odkogo.TabIndex = 2
        '
        'dokogo
        '
        Me.dokogo.Location = New System.Drawing.Point(100, 121)
        Me.dokogo.Name = "dokogo"
        Me.dokogo.Size = New System.Drawing.Size(301, 20)
        Me.dokogo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Do kogo:"
        '
        'nastepny
        '
        Me.nastepny.Image = Global.Sekretariat.My.Resources.Resources.skipover
        Me.nastepny.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nastepny.Location = New System.Drawing.Point(374, 155)
        Me.nastepny.Name = "nastepny"
        Me.nastepny.Size = New System.Drawing.Size(27, 23)
        Me.nastepny.TabIndex = 17
        Me.nastepny.UseVisualStyleBackColor = True
        '
        'dodajlpo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(419, 193)
        Me.Controls.Add(Me.nastepny)
        Me.Controls.Add(Me.dokogo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.Nrlpo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Datao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Odkogo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dodajlpo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodaj: Listy polecone odebrane"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents R As System.Windows.Forms.TextBox
    Friend WithEvents Nrlpo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Datao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Odkogo As System.Windows.Forms.ComboBox
    Friend WithEvents dokogo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nastepny As System.Windows.Forms.Button

End Class
