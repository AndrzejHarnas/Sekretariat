Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajlpo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim tabelap As DataTable




        If Nrlpo.Text = "" Or Odkogo.Text = "" Or dokogo.Text = "" Or Datao.Text = "" Or R.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from lpoleconeo where lpo_id ='" & Nrlpo.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then



                Odkogo.DisplayMember = "f_id"

                cmd = "insert into lpoleconeo values('" & Nrlpo.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & R.Text & "','" & dokogo.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call lpo()


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
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim tabelap As DataTable




        If Nrlpo.Text = "" Or Odkogo.Text = "" Or dokogo.Text = "" Or Datao.Text = "" Or R.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from lpoleconeo where lpo_id ='" & Nrlpo.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then



                Odkogo.DisplayMember = "f_id"

                cmd = "insert into lpoleconeo values('" & Nrlpo.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & R.Text & "','" & dokogo.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call lpo()


                Me.Close()
                Call jeszcze()

            Else
                MsgBox("Przesyłka o podanym Nr: już istnieje w bazie danych")
            End If

        End If










    End Sub
End Class
