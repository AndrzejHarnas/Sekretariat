Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class edytujz

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim nr As Integer
        Dim ds As DataSet
        Dim Data As SqlDataAdapter
        Dim tabla As DataTable

        If Nrz.Text = "" Or nazwaz.Text = "" Or znak.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            nr = Val(Nrz.Text)
            cmd = "Update zaklady set nazwa_z='" & nazwaz.Text & "',symbol ='" & znak.Text & "' where z_id ='" & nr & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabla = ds.Tables("stano")

            inigconnect.Close()
            Me.Close()
            Call firma()

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

    Private Sub Nrz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nrz.TextChanged

    End Sub

    Private Sub edytujz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub znak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles znak.TextChanged

    End Sub

    Private Sub nazwaz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nazwaz.TextChanged

    End Sub


End Class
