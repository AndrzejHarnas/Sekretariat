<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Me.usbaza = New System.Windows.Forms.DataGridView
        Me.usmenu = New System.Windows.Forms.ToolStrip
        Me.usplus = New System.Windows.Forms.ToolStripButton
        Me.usminus = New System.Windows.Forms.ToolStripButton
        Me.usedit = New System.Windows.Forms.ToolStripButton
        Me.home = New System.Windows.Forms.ToolStripButton
        CType(Me.usbaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.usmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'usbaza
        '
        Me.usbaza.AllowUserToAddRows = False
        Me.usbaza.AllowUserToDeleteRows = False
        Me.usbaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usbaza.Location = New System.Drawing.Point(33, 37)
        Me.usbaza.MultiSelect = False
        Me.usbaza.Name = "usbaza"
        Me.usbaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usbaza.Size = New System.Drawing.Size(372, 296)
        Me.usbaza.TabIndex = 1
        '
        'usmenu
        '
        Me.usmenu.Dock = System.Windows.Forms.DockStyle.None
        Me.usmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usplus, Me.usminus, Me.usedit, Me.home})
        Me.usmenu.Location = New System.Drawing.Point(33, 9)
        Me.usmenu.Name = "usmenu"
        Me.usmenu.Size = New System.Drawing.Size(135, 25)
        Me.usmenu.TabIndex = 2
        Me.usmenu.Text = "ToolStrip1"
        '
        'usplus
        '
        Me.usplus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.usplus.Image = CType(resources.GetObject("usplus.Image"), System.Drawing.Image)
        Me.usplus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.usplus.Name = "usplus"
        Me.usplus.Size = New System.Drawing.Size(23, 22)
        Me.usplus.Text = "Dodaj "
        '
        'usminus
        '
        Me.usminus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.usminus.Image = CType(resources.GetObject("usminus.Image"), System.Drawing.Image)
        Me.usminus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.usminus.Name = "usminus"
        Me.usminus.Size = New System.Drawing.Size(23, 22)
        Me.usminus.Text = "Usuń"
        '
        'usedit
        '
        Me.usedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.usedit.Image = CType(resources.GetObject("usedit.Image"), System.Drawing.Image)
        Me.usedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.usedit.Name = "usedit"
        Me.usedit.Size = New System.Drawing.Size(23, 22)
        Me.usedit.Text = "Edytuj"
        '
        'home
        '
        Me.home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.home.Image = CType(resources.GetObject("home.Image"), System.Drawing.Image)
        Me.home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(23, 22)
        Me.home.Text = "Strona główna "
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 356)
        Me.Controls.Add(Me.usmenu)
        Me.Controls.Add(Me.usbaza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Użytkownicy"
        CType(Me.usbaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.usmenu.ResumeLayout(False)
        Me.usmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usbaza As System.Windows.Forms.DataGridView
    Friend WithEvents usmenu As System.Windows.Forms.ToolStrip
    Friend WithEvents usplus As System.Windows.Forms.ToolStripButton
    Friend WithEvents usminus As System.Windows.Forms.ToolStripButton
    Friend WithEvents usedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents home As System.Windows.Forms.ToolStripButton

End Class
