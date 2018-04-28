Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujdw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim ds As DataSet
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable




        If nrk.Text = "" Or dokogo.Text = "" Or dataw.Text = "" Or dotyczy.Text = "" Or znakp.Text = "" Then


            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            dokogo.DisplayMember = "f_id"

            cmd = "Update dziennikw set dataw='" & dataw.Text & "', f_id='" & dokogo.Text & "',  dotyczy='" & dotyczy.Text & "',znakp='" & znakp.Text & "' where dw_id='" & nrk.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")

            inigconnect.Close()
            Call wdziennik()


            Dim z As Integer
            Dim x As Integer
            x = Val(nrk.Text)
            z = x - 1
            On Error Resume Next
            glowny.Baza.Item(1, z).Selected = True

            Me.Close()

        End If








        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
