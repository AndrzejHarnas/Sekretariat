Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujnrf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable




        If nrw.Text = "" Or firma.Text = "" Or nrfax.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            firma.DisplayMember = "f_id"
            cmd = "Update nrfaxow set f_id='" & firma.Text & "', nr_fax='" & nrfax.Text & "' where nr_id='" & nrw.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            Call Module1.nrfax()
            Dim x As Integer
            x = Val(nrw.Text) - 1
            On Error Resume Next
            glowny.Baza.Item(1, x).Selected = True


            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nrw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrw.TextChanged

    End Sub

    Private Sub firma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firma.SelectedIndexChanged

    End Sub

    Private Sub nrfax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrfax.TextChanged

    End Sub
End Class
