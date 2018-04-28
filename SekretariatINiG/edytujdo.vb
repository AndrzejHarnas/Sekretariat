Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujdo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        Dim ds As DataSet
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable




        If nrk.Text = "" Or odkogo.Text = "" Or datao.Text = "" Or dotyczy.Text = "" Or symbol.Text = "" Then


            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            odkogo.DisplayMember = "f_id"
            symbol.DisplayMember = "z_id"
           

            cmd = "Update dzienniko set datao='" & datao.Text & "', f_id='" & odkogo.Text & "',  dotyczy='" & dotyczy.Text & "',z_id='" & symbol.Text & "' where do_id='" & nrk.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")

            inigconnect.Close()
            Call odziennik()


            Dim z As Integer
            Dim x As Integer
            x = Val(nrk.Text)
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
