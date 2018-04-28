Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class edytujlpw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable




        If Nrlpw.Text = "" Or Odkogo.Text = "" Or dokogo.Text = "" Or Dataw.Text = "" Or R.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            Odkogo.DisplayMember = "p_id"
            dokogo.DisplayMember = "f_id"
            cmd = "Update lpoleconew set p_id='" & Odkogo.Text & "', dataw='" & Dataw.Text & "',R='" & R.Text & "' ,  f_id='" & dokogo.Text & "' where lpw_id='" & Nrlpw.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            Call lpw()
            Dim z As Integer
            Dim x As Integer
            x = Val(Nrlpw.Text)
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

    Private Sub edytujlpw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
