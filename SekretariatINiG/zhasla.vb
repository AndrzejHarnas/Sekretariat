Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class zhasla

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds2 As DataSet
        Dim tabelad2 As DataTable


        If haslo.Text = "" Or uzytkownik.Text = "" Or nhaslo.Text = "" Or pnhaslo.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")


        Else

            cmd = "select * from users where u_name = '" & uzytkownik.Text & "' and pasw ='" & haslo.Text & "';"
            Call polacz()
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            inigconnect.Close()

            If tabelad.Rows.Count <> 0 Then



                If nhaslo.Text = pnhaslo.Text Then
                    cmd2 = "Update users set pasw ='" & nhaslo.Text & "' where u_name ='" & uzytkownik.Text & "';"
                    Call polacz()
                    data2 = New SqlDataAdapter(cmd2, inigconnect)
                    ds2 = New DataSet
                    data2.Fill(ds2, "dele")
                    tabelad2 = ds2.Tables("dele")
                    inigconnect.Close()
                    Me.Close()
                Else

                    MsgBox("Powtórz poprawnie nowe hasło!")

                End If

            Else
                MsgBox("Błędna nazwa użytkownika bądź hasło!")
            End If




            End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
