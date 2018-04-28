Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajs

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim cmd2 As String
        Dim data As SqlDataAdapter
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim nrse As Integer
        Dim tabelap As DataTable

        If (nazwas.Text = "" Or nrs.Text = "") Then
            MsgBox("Wypełnij wszystkie pola formularza!")
        Else

            cmd2 = "select * from stanowiska where s_id =" & nrs.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then

                nrse = Val(nrs.Text)
                cmd = "Insert into stanowiska values('" & nrse & "','" & nazwas.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "insertst")
                inigconnect.Close()
                Call stpracy()
                Me.Close()
            Else

                MsgBox("Stanowisko o podanym numerze już istnieje w bazie danych")

            End If


        End If



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nrs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrs.TextChanged

    End Sub

    Private Sub nazwas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nazwas.TextChanged

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click

        Dim cmd As String
        Dim cmd2 As String
        Dim data As SqlDataAdapter
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim nrse As Integer
        Dim tabelap As DataTable

        If (nazwas.Text = "" Or nrs.Text = "") Then
            MsgBox("Wypełnij wszystkie pola formularza!")
        Else

            cmd2 = "select * from stanowiska where s_id =" & nrs.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then

                nrse = Val(nrs.Text)
                cmd = "Insert into stanowiska values('" & nrse & "','" & nazwas.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "insertst")
                inigconnect.Close()
                Call stpracy()
                Me.Close()
                Call jeszcze()

            Else

                MsgBox("Stanowisko o podanym numerze już istnieje w bazie danych")

            End If


        End If






    End Sub

    Private Sub dodajs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
