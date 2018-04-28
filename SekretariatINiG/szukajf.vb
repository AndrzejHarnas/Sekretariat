Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable


        If nazwaf.Text = "" Then

            MsgBox("Podaj nazwę firmy, którą chcesz odszukać!")

        Else


            cmd = "select * from firmy where nazwaf like '%" & nazwaf.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelaklienci()
            Me.Close()

        End If






        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
