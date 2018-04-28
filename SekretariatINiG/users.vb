Imports System.Windows.Forms

Public Class users

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

    Private Sub usplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usplus.Click

        Dim RowNR As Integer
        Dim nr As String


        RowNR = usbaza.RowCount()
        nr = 0
        On Error Resume Next
        nr = usbaza.Item(0, RowNR - 1).Value

        nr = nr + 1
        dodajus.usid.Text = nr.ToString

        dodajus.show()



    End Sub

    Private Sub usminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usminus.Click

        If usbaza.RowCount = 0 Then
            MsgBox("Brak rekordów usunięcia")
        Else
            usun.Show()
        End If


    End Sub

    Private Sub usedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usedit.Click
        Dim y As Integer

        y = usbaza.SelectedRows.Item(0).Index

        edytujus.usid.Text = usbaza.Item(0, y).Value
        edytujus.uzytkownik.Text = usbaza.Item(1, y).Value
        edytujus.haslo.Text = usbaza.Item(2, y).Value
        edytujus.Show()

    End Sub
End Class
