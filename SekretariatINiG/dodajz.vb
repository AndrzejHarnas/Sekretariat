Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajz


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim cmd2 As String
        Dim data As SqlDataAdapter
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim nrze As Integer
        Dim tabelap As DataTable

        If (nazwaz.Text = "" Or znak.Text = "" Or Nrz.Text = "") Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd2 = "select * from zaklady where z_id =" & Nrz.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then




                nrze = Val(Nrz.Text)


                cmd = "Insert into zaklady values('" & nrze & "','" & nazwaz.Text & "','" & znak.Text & "');"



                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "insert")
                inigconnect.Close()

                Call firma()
                Me.Close()


            Else

                MsgBox("Zakład o podanym numerze już istnieje w bazie danych")


            End If
        End If





    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Nrz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nrz.TextChanged

    End Sub

    Private Sub znak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles znak.TextChanged

    End Sub

    Private Sub nazwaz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nazwaz.TextChanged

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click

        Dim cmd As String
        Dim cmd2 As String
        Dim data As SqlDataAdapter
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim nrze As Integer
        Dim tabelap As DataTable

        If (nazwaz.Text = "" Or znak.Text = "" Or Nrz.Text = "") Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd2 = "select * from zaklady where z_id =" & Nrz.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then




                nrze = Val(Nrz.Text)


                cmd = "Insert into zaklady values('" & nrze & "','" & nazwaz.Text & "','" & znak.Text & "');"



                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "insert")
                inigconnect.Close()

                Call firma()
                Me.Close()
                Call jeszcze()


            Else

                MsgBox("Zakład o podanym numerze już istnieje w bazie danych")


            End If
        End If






    End Sub
End Class
