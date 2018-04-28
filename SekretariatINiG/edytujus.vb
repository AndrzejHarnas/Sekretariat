Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujus

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim tabelad As DataTable
        Dim data As SqlDataAdapter




        If uzytkownik.Text = "" Or haslo.Text = "" Or usid.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else


            cmd = "Update users set u_name= '" & uzytkownik.Text & "', pasw= '" & haslo.Text & "' where u_id='" & usid.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            Call uzytk()


            Me.Close()

          

        End If






    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
