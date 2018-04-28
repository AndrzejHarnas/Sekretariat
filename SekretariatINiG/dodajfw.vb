Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajfw
    Dim cmd2 As String
    Dim data2 As SqlDataAdapter
    Dim ds As DataSet
    Dim tabelap As DataTable
    Dim fid As String
    Dim nid As String



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Nrw.Text = "" Or dokogo.Text = "" Or Dataw.Text = "" Or Odkogo.Text = "" Or dotyczy.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            Dim cmd As String
            Dim Data As SqlDataAdapter
            Dim tabela As DataTable


            cmd2 = "select * from faxw where nrfw =" & Nrw.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                Odkogo.DisplayMember = "p_id"

                dokogo.DisplayMember = "nr_id"
                nid = dokogo.Text

                cmd = "insert into faxw values('" & Nrw.Text & "','" & Odkogo.Text & "','" & Dataw.Text & "','" & dokogo.Text & "', '" & dotyczy.Text & "') ;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "prac")
                tabela = ds.Tables("prac")





                dokogo.DisplayMember = "firma"

                Me.Close()
                Call wfax()


            Else
                MsgBox("Fax o podanym Nr wys.: istnieje już w bazie danych!")

            End If


        End If





    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dokogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dokogo.SelectedIndexChanged

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click

        If Nrw.Text = "" Or dokogo.Text = "" Or Dataw.Text = "" Or Odkogo.Text = "" Or dotyczy.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            Dim cmd As String
            Dim Data As SqlDataAdapter
            Dim tabela As DataTable


            cmd2 = "select * from faxw where nrfw =" & Nrw.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                Odkogo.DisplayMember = "p_id"

                dokogo.DisplayMember = "nr_id"
                nid = dokogo.Text

                cmd = "insert into faxw values('" & Nrw.Text & "','" & Odkogo.Text & "','" & Dataw.Text & "','" & dokogo.Text & "', '" & dotyczy.Text & "') ;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "prac")
                tabela = ds.Tables("prac")


                dokogo.DisplayMember = "firma"

                Me.Close()
                Call wfax()
                Call jeszcze()


            Else
                MsgBox("Fax o podanym Nr wys.: istnieje już w bazie danych!")

            End If


        End If







    End Sub

    Private Sub dodajfw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
