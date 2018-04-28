<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.drukuj = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'drukuj
        '
        Me.drukuj.Location = New System.Drawing.Point(200, 126)
        Me.drukuj.Name = "drukuj"
        Me.drukuj.Size = New System.Drawing.Size(144, 61)
        Me.drukuj.TabIndex = 0
        Me.drukuj.Text = "Prinnt"
        Me.drukuj.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 331)
        Me.Controls.Add(Me.drukuj)
        Me.Name = "test"
        Me.Text = "test"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents drukuj As System.Windows.Forms.Button
End Class
