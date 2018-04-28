Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class edytujfw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable




        Odkogo.DisplayMember = "p_id"
        dokogo.DisplayMember = "nr_id"

        If dokogo.Text = "" Or Odkogo.Text = "" Or Dataw.Text = "" Or Nrw.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd = "Update faxw set p_id='" & Odkogo.Text & "', dataw ='" & Dataw.Text & "', nr_id='" & dokogo.Text & "', dotyczy ='" & dotyczy.Text & "' where nrfw ='" & Nrw.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()


            Call wfax()
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
