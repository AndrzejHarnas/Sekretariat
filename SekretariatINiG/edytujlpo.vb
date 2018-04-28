Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujlpo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable




        If Nrlpo.Text = "" Or Odkogo.Text = "" Or dokogo.Text = "" Or Datao.Text = "" Or R.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            Odkogo.DisplayMember = "f_id"
            cmd = "Update lpoleconeo set f_id='" & Odkogo.Text & "', datao='" & Datao.Text & "',R='" & R.Text & "' ,  dokogo='" & dokogo.Text & "' where lpo_id='" & Nrlpo.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            Call lpo()
            Dim z As Integer
            Dim x As Integer
            x = Val(Nrlpo.Text)
            z = x - 1
            On Error Resume Next
            glowny.Baza.Item(1, z).Selected = True

            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Odkogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odkogo.SelectedIndexChanged

    End Sub

    Private Sub Datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datao.ValueChanged

    End Sub

    Private Sub R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.TextChanged

    End Sub

    Private Sub dokogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dokogo.TextChanged

    End Sub
End Class
