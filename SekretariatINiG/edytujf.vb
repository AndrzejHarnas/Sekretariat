Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable


        If Nrf.Text = "" Or nazwaf.Text = "" Or Miasto.Text = "" Or Ulica.Text = "" Or kod_poczt.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else


            cmd = "Update firmy set nazwaf='" & nazwaf.Text & "', Miasto ='" & Miasto.Text & "', ulica='" & Ulica.Text & "', kod_poczt ='" & kod_poczt.Text & "' where f_id ='" & Nrf.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()


            Call klienci()
            Dim z As Integer
            Dim x As Integer
            x = Val(Nrf.Text)
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

End Class
