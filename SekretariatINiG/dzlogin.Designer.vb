<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dzlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dzlogin))
        Me.usmenu = New System.Windows.Forms.ToolStrip
        Me.usbaza = New System.Windows.Forms.DataGridView
        Me.usedit = New System.Windows.Forms.ToolStripButton
        Me.home = New System.Windows.Forms.ToolStripButton
        Me.usmenu.SuspendLayout()
        CType(Me.usbaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usmenu
        '
        Me.usmenu.Dock = System.Windows.Forms.DockStyle.None
        Me.usmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usedit, Me.home})
        Me.usmenu.Location = New System.Drawing.Point(31, 9)
        Me.usmenu.Name = "usmenu"
        Me.usmenu.Size = New System.Drawing.Size(89, 25)
        Me.usmenu.TabIndex = 4
        Me.usmenu.Text = "ToolStrip1"
        '
        'usbaza
        '
        Me.usbaza.AllowUserToAddRows = False
        Me.usbaza.AllowUserToDeleteRows = False
        Me.usbaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usbaza.Location = New System.Drawing.Point(31, 37)
        Me.usbaza.MultiSelect = False
        Me.usbaza.Name = "usbaza"
        Me.usbaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usbaza.Size = New System.Drawing.Size(372, 296)
        Me.usbaza.TabIndex = 3
        '
        'usedit
        '
        Me.usedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.usedit.Image = CType(resources.GetObject("usedit.Image"), System.Drawing.Image)
        Me.usedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.usedit.Name = "usedit"
        Me.usedit.Size = New System.Drawing.Size(23, 22)
        Me.usedit.Text = "Szukaj"
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
        'dzlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 356)
        Me.Controls.Add(Me.usmenu)
        Me.Controls.Add(Me.usbaza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dzlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dziennik logowania:"
        Me.usmenu.ResumeLayout(False)
        Me.usmenu.PerformLayout()
        CType(Me.usbaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usmenu As System.Windows.Forms.ToolStrip
    Friend WithEvents usedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents home As System.Windows.Forms.ToolStripButton
    Friend WithEvents usbaza As System.Windows.Forms.DataGridView

End Class
