Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class edytujd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable


        surname.DisplayMember = "p_id"

        If nrd.Text = "" Or surname.Text = "" Or nrzlec.Text = "" Or miejsce.Text = "" Or trans.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else


            cmd = "Update delegacje set p_id='" & surname.Text & "', miejsce='" & miejsce.Text & "',  transport='" & trans.Text & "',od='" & odkiedy.Value & "', do='" & DoKiedy.Value & "', nr_zlec='" & nrzlec.Text & "' where d_id='" & nrd.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()


            Call wyjazdy()


            Me.Close()

        End If

        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub surname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surname.SelectedIndexChanged

    End Sub

    Private Sub odkiedy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odkiedy.ValueChanged

    End Sub
End Class
