Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajlzo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim tabelap As DataTable
        Dim data2 As SqlDataAdapter





        If Nrlzo.Text = "" Or Odkogo.Text = "" Or Dokogo.Text = "" Or Datao.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd2 = "select * from lzwykleo where lzo_id ='" & Nrlzo.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                Odkogo.DisplayMember = "f_id"

                cmd = "insert into lzwykleo values('" & Nrlzo.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & Dokogo.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call lzo()


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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Nrlzo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nrlzo.TextChanged

    End Sub

    Private Sub Odkogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odkogo.SelectedIndexChanged

    End Sub

    Private Sub Datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datao.ValueChanged

    End Sub

    Private Sub Dokogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dokogo.TextChanged

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim tabelap As DataTable
        Dim data2 As SqlDataAdapter





        If Nrlzo.Text = "" Or Odkogo.Text = "" Or Dokogo.Text = "" Or Datao.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else
            cmd2 = "select * from lzwykleo where lzo_id ='" & Nrlzo.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                Odkogo.DisplayMember = "f_id"

                cmd = "insert into lzwykleo values('" & Nrlzo.Text & "','" & Odkogo.Text & "','" & Datao.Text & "','" & Dokogo.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()

                Call lzo()


                Me.Close()

                Call jeszcze()

            Else

                MsgBox("Przesyłka o podanym Nr: już istnieje w bazie danych")

            End If
        End If






    End Sub
End Class
