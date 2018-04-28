Imports System.Data.SqlClient

Public Class edytujlzo

    Private Sub Odkogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odkogo.SelectedIndexChanged

    End Sub

    Private Sub Datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datao.ValueChanged

    End Sub

    Private Sub Dokogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dokogo.TextChanged

    End Sub

    Private Sub Nrlzo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nrlzo.TextChanged

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable




        If Nrlzo.Text = "" Or Odkogo.Text = "" Or Dokogo.Text = "" Or Datao.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            Odkogo.DisplayMember = "f_id"
            cmd = "Update lzwykleo set f_id='" & Odkogo.Text & "', datao='" & Datao.Text & "',  dokogo='" & Dokogo.Text & "' where lzo_id='" & Nrlzo.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            Call lzo()
            Dim z As Integer
            Dim x As Integer
            x = Val(Nrlzo.Text)
            z = x - 1
            On Error Resume Next
            glowny.Baza.Item(1, z).Selected = True

            Me.Close()
        End If





    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class