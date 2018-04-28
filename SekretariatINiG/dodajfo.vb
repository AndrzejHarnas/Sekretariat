Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class dodajfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable


        If Odkogo.Text = "" Or Datao.Text = "" Or Nrw.Text = "" Or dokogo.Text = "" Or dotyczy.text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            Odkogo.DisplayMember = "nr_id"
            cmd2 = "select * from faxo where nrfo ='" & Nrw.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                cmd = "insert into faxo values('" & Nrw.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & dokogo.Text & "', '" & dotyczy.text & "');"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call ofax()


                Me.Close()
            Else
                MsgBox("Przesyłka o podanym Nr: już istnieje w bazie danych")

            End If






        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable


        If Odkogo.Text = "" Or Datao.Text = "" Or Nrw.Text = "" Or dokogo.Text = "" Or dotyczy.text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            Odkogo.DisplayMember = "nr_id"
            cmd2 = "select * from faxo where nrfo ='" & Nrw.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                cmd = "insert into faxo values('" & Nrw.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & dokogo.Text & "', '" & dotyczy.text & "');"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call ofax()


                Me.Close()

                Call jeszcze()

            Else
                MsgBox("Przesyłka o podanym Nr: już istnieje w bazie danych")

            End If






        End If








    End Sub
End Class
