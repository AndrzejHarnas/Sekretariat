Imports System.Windows.Forms
Imports System.Data.SqlClient





Public Class dodajdo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable




        If nrk.Text = "" Or odkogo.Text = "" Or datao.Text = "" Or dotyczy.Text = "" Or symbol.Text = "" Then


            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            odkogo.DisplayMember = "f_id"
            symbol.DisplayMember = "z_id"
            cmd2 = "select * from dzienniko where do_id ='" & nrk.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                cmd = "insert into dzienniko values('" & nrk.Text & "','" & datao.Text & "','" & odkogo.Text & "','" & dotyczy.Text & "','" & symbol.Text & "');"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call odziennik()


                Me.Close()
            Else
                MsgBox("Pismo o podanym Nr kol.: już istnieje w bazie danych")

            End If



        End If




    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click

        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim tabelad As DataTable




        If nrk.Text = "" Or odkogo.Text = "" Or datao.Text = "" Or dotyczy.Text = "" Or symbol.Text = "" Then


            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            odkogo.DisplayMember = "f_id"
            symbol.DisplayMember = "z_id"
            cmd2 = "select * from dzienniko where do_id ='" & nrk.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                cmd = "insert into dzienniko values('" & nrk.Text & "','" & datao.Text & "','" & odkogo.Text & "','" & dotyczy.Text & "','" & symbol.Text & "');"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call odziennik()


                Me.Close()
                Call jeszcze()

            Else
                MsgBox("Pismo o podanym Nr kol.: już istnieje w bazie danych")

            End If

        End If





    End Sub
End Class
