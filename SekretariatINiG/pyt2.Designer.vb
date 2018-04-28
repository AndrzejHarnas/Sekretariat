<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pyt2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.usdele = New System.Windows.Forms.CheckBox
        Me.usdpo = New System.Windows.Forms.CheckBox
        Me.usfaxw = New System.Windows.Forms.CheckBox
        Me.usfaxo = New System.Windows.Forms.CheckBox
        Me.usdpw = New System.Windows.Forms.CheckBox
        Me.usfirm = New System.Windows.Forms.CheckBox
        Me.uslpo = New System.Windows.Forms.CheckBox
        Me.uslpw = New System.Windows.Forms.CheckBox
        Me.uslzo = New System.Windows.Forms.CheckBox
        Me.uslzw = New System.Windows.Forms.CheckBox
        Me.usnrfax = New System.Windows.Forms.CheckBox
        Me.uspr = New System.Windows.Forms.CheckBox
        Me.usstan = New System.Windows.Forms.CheckBox
        Me.uszakl = New System.Windows.Forms.CheckBox
        Me.dlog = New System.Windows.Forms.CheckBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(65, 410)
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
        Me.OK_Button.Text = "Usuń"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Anuluj"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zaznacz tabele których zawartość chcesz  usunąć:"
        '
        'usdele
        '
        Me.usdele.AutoSize = True
        Me.usdele.Location = New System.Drawing.Point(45, 219)
        Me.usdele.Name = "usdele"
        Me.usdele.Size = New System.Drawing.Size(115, 17)
        Me.usdele.TabIndex = 3
        Me.usdele.Text = "Wyjazdy służbowe"
        Me.usdele.UseVisualStyleBackColor = True
        '
        'usdpo
        '
        Me.usdpo.AutoSize = True
        Me.usdpo.Location = New System.Drawing.Point(45, 35)
        Me.usdpo.Name = "usdpo"
        Me.usdpo.Size = New System.Drawing.Size(148, 17)
        Me.usdpo.TabIndex = 4
        Me.usdpo.Text = "Dziennik: pisma odebrane"
        Me.usdpo.UseVisualStyleBackColor = True
        '
        'usfaxw
        '
        Me.usfaxw.AutoSize = True
        Me.usfaxw.Location = New System.Drawing.Point(45, 104)
        Me.usfaxw.Name = "usfaxw"
        Me.usfaxw.Size = New System.Drawing.Size(144, 17)
        Me.usfaxw.TabIndex = 5
        Me.usfaxw.Text = "Fax: dokumenty wysłane"
        Me.usfaxw.UseVisualStyleBackColor = True
        '
        'usfaxo
        '
        Me.usfaxo.AutoSize = True
        Me.usfaxo.Location = New System.Drawing.Point(45, 81)
        Me.usfaxo.Name = "usfaxo"
        Me.usfaxo.Size = New System.Drawing.Size(149, 17)
        Me.usfaxo.TabIndex = 6
        Me.usfaxo.Text = "Fax: dokumenty odebrane"
        Me.usfaxo.UseVisualStyleBackColor = True
        '
        'usdpw
        '
        Me.usdpw.AutoSize = True
        Me.usdpw.Location = New System.Drawing.Point(45, 58)
        Me.usdpw.Name = "usdpw"
        Me.usdpw.Size = New System.Drawing.Size(143, 17)
        Me.usdpw.TabIndex = 7
        Me.usdpw.Text = "Dziennik: pisma wysłane"
        Me.usdpw.UseVisualStyleBackColor = True
        '
        'usfirm
        '
        Me.usfirm.AutoSize = True
        Me.usfirm.Location = New System.Drawing.Point(45, 311)
        Me.usfirm.Name = "usfirm"
        Me.usfirm.Size = New System.Drawing.Size(50, 17)
        Me.usfirm.TabIndex = 8
        Me.usfirm.Text = "Firmy"
        Me.usfirm.UseVisualStyleBackColor = True
        '
        'uslpo
        '
        Me.uslpo.AutoSize = True
        Me.uslpo.Location = New System.Drawing.Point(45, 127)
        Me.uslpo.Name = "uslpo"
        Me.uslpo.Size = New System.Drawing.Size(142, 17)
        Me.uslpo.TabIndex = 9
        Me.uslpo.Text = "Listy polecone odebrane"
        Me.uslpo.UseVisualStyleBackColor = True
        '
        'uslpw
        '
        Me.uslpw.AutoSize = True
        Me.uslpw.Location = New System.Drawing.Point(45, 150)
        Me.uslpw.Name = "uslpw"
        Me.uslpw.Size = New System.Drawing.Size(137, 17)
        Me.uslpw.TabIndex = 10
        Me.uslpw.Text = "Listy polecone wysłane"
        Me.uslpw.UseVisualStyleBackColor = True
        '
        'uslzo
        '
        Me.uslzo.AutoSize = True
        Me.uslzo.Location = New System.Drawing.Point(45, 173)
        Me.uslzo.Name = "uslzo"
        Me.uslzo.Size = New System.Drawing.Size(135, 17)
        Me.uslzo.TabIndex = 11
        Me.uslzo.Text = "Listy zwykłe otrzymane"
        Me.uslzo.UseVisualStyleBackColor = True
        '
        'uslzw
        '
        Me.uslzw.AutoSize = True
        Me.uslzw.Location = New System.Drawing.Point(45, 196)
        Me.uslzw.Name = "uslzw"
        Me.uslzw.Size = New System.Drawing.Size(127, 17)
        Me.uslzw.TabIndex = 12
        Me.uslzw.Text = "Listy zwykłe wysłane"
        Me.uslzw.UseVisualStyleBackColor = True
        '
        'usnrfax
        '
        Me.usnrfax.AutoSize = True
        Me.usnrfax.Location = New System.Drawing.Point(45, 334)
        Me.usnrfax.Name = "usnrfax"
        Me.usnrfax.Size = New System.Drawing.Size(142, 17)
        Me.usnrfax.TabIndex = 13
        Me.usnrfax.Text = "Książka numerów tel/fax"
        Me.usnrfax.UseVisualStyleBackColor = True
        '
        'uspr
        '
        Me.uspr.AutoSize = True
        Me.uspr.Location = New System.Drawing.Point(45, 242)
        Me.uspr.Name = "uspr"
        Me.uspr.Size = New System.Drawing.Size(81, 17)
        Me.uspr.TabIndex = 14
        Me.uspr.Text = "Pracownicy"
        Me.uspr.UseVisualStyleBackColor = True
        '
        'usstan
        '
        Me.usstan.AutoSize = True
        Me.usstan.Location = New System.Drawing.Point(45, 265)
        Me.usstan.Name = "usstan"
        Me.usstan.Size = New System.Drawing.Size(81, 17)
        Me.usstan.TabIndex = 15
        Me.usstan.Text = "Stanowiska"
        Me.usstan.UseVisualStyleBackColor = True
        '
        'uszakl
        '
        Me.uszakl.AutoSize = True
        Me.uszakl.Location = New System.Drawing.Point(45, 288)
        Me.uszakl.Name = "uszakl"
        Me.uszakl.Size = New System.Drawing.Size(66, 17)
        Me.uszakl.TabIndex = 16
        Me.uszakl.Text = "Zakłady"
        Me.uszakl.UseVisualStyleBackColor = True
        '
        'dlog
        '
        Me.dlog.AutoSize = True
        Me.dlog.Location = New System.Drawing.Point(45, 357)
        Me.dlog.Name = "dlog"
        Me.dlog.Size = New System.Drawing.Size(110, 17)
        Me.dlog.TabIndex = 17
        Me.dlog.Text = "Dziennik logowań"
        Me.dlog.UseVisualStyleBackColor = True
        '
        'pyt2
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(274, 451)
        Me.Controls.Add(Me.dlog)
        Me.Controls.Add(Me.uszakl)
        Me.Controls.Add(Me.usstan)
        Me.Controls.Add(Me.uspr)
        Me.Controls.Add(Me.usnrfax)
        Me.Controls.Add(Me.uslzw)
        Me.Controls.Add(Me.uslzo)
        Me.Controls.Add(Me.uslpw)
        Me.Controls.Add(Me.uslpo)
        Me.Controls.Add(Me.usfirm)
        Me.Controls.Add(Me.usdpw)
        Me.Controls.Add(Me.usfaxo)
        Me.Controls.Add(Me.usfaxw)
        Me.Controls.Add(Me.usdpo)
        Me.Controls.Add(Me.usdele)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pyt2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuwanie zawartośći bazy INiGKrosno:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents usdele As System.Windows.Forms.CheckBox
    Friend WithEvents usdpo As System.Windows.Forms.CheckBox
    Friend WithEvents usfaxw As System.Windows.Forms.CheckBox
    Friend WithEvents usfaxo As System.Windows.Forms.CheckBox
    Friend WithEvents usdpw As System.Windows.Forms.CheckBox
    Friend WithEvents usfirm As System.Windows.Forms.CheckBox
    Friend WithEvents uslpo As System.Windows.Forms.CheckBox
    Friend WithEvents uslpw As System.Windows.Forms.CheckBox
    Friend WithEvents uslzo As System.Windows.Forms.CheckBox
    Friend WithEvents uslzw As System.Windows.Forms.CheckBox
    Friend WithEvents usnrfax As System.Windows.Forms.CheckBox
    Friend WithEvents uspr As System.Windows.Forms.CheckBox
    Friend WithEvents usstan As System.Windows.Forms.CheckBox
    Friend WithEvents uszakl As System.Windows.Forms.CheckBox
    Friend WithEvents dlog As System.Windows.Forms.CheckBox

End Class
