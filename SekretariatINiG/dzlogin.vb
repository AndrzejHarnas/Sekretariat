Imports System.Windows.Forms

Public Class dzlogin

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home.Click
        Me.Close()
    End Sub

    Private Sub usedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usedit.Click

        szukajdl.datal.Text = Now.Date
        szukajdl.show()

    End Sub
End Class
