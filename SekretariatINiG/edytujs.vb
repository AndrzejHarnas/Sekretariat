Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujs

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim nr As Integer
        Dim ds As DataSet
        Dim Data As SqlDataAdapter
        Dim tabla As DataTable

        If nrs.Text = "" Or nazwas.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            nr = Val(nrs.Text)
            cmd = "Update stanowiska set nazwa_s='" & nazwas.Text & "' where s_id ='" & nr & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabla = ds.Tables("stano")

            inigconnect.Close()
            Me.Close()
            Call stpracy()

            Dim x As Integer
            x = nr - 1
            On Error Resume Next
            glowny.Baza.Item(1, x).Selected = True



        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub edytujs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nrs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrs.TextChanged

    End Sub

    Private Sub nazwas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nazwas.TextChanged

    End Sub
End Class
