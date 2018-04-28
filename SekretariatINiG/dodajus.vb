Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class dodajus

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        Dim cmd As String
        Dim ds As DataSet
        Dim ds3 As DataSet
        Dim data As SqlDataAdapter
        Dim data3 As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim cmd3 As String
        Dim data2 As SqlDataAdapter
        Dim tabelap As DataTable
        Dim tabelaz As DataTable



        If uzytkownik.Text = "" Or haslo.Text = "" Or usid.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd3 = "select * from users where u_id ='" & usid.Text & "';"
            data3 = New SqlDataAdapter(cmd3, inigconnect)
            ds3 = New DataSet
            data3.Fill(ds3, "prac")
            tabelap = ds3.Tables("prac")
            inigconnect.Close()
            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then

                cmd2 = "select * from users where u_name ='" & uzytkownik.Text & "';"
                data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                data2.Fill(ds, "prac")
                tabelaz = ds.Tables("prac")
                inigconnect.Close()

                If tabelaz.Rows.Count = 0 Then

                    cmd = "insert into users values('" & usid.Text & "','" & uzytkownik.Text & "','" & haslo.Text & "');"
                    data = New SqlDataAdapter(cmd, inigconnect)
                    ds = New DataSet
                    data.Fill(ds, "dele")
                    tabelad = ds.Tables("dele")


                    inigconnect.Close()

                    Call uzytk()


                    Me.Close()

                Else

                    MsgBox("Użytkownik o podanej nazwie: istnieje w bazie danych")

                End If



            Else
                MsgBox("Użytkownik o podanym Nr id: istnieje w bazie danych")
            End If

            End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
