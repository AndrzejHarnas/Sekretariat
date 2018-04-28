Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable




        Odkogo.DisplayMember = "nr_id"


        If dokogo.Text = "" Or Odkogo.Text = "" Or Datao.Text = "" Or Nrw.Text = "" Or dotyczy.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd = "Update faxo set nr_id='" & Odkogo.Text & "', datao ='" & Datao.Text & "', dokogo='" & dokogo.Text & "', dotyczy='" & dotyczy.Text & "' where nrfo ='" & Nrw.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()


            Call ofax()
            Dim z As Integer
            Dim x As Integer
            x = Val(Nrw.Text)
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
