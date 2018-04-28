Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim nride As Integer
        Dim cmd As String
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim tabelad As DataTable


        If Nrf.Text = "" Or nazwaf.Text = "" Or Miasto.Text = "" Or Ulica.Text = "" Or kod_poczt.Text = "" Then
            MsgBox("Wypełnij wszystkie pola formularza!")
        Else
            cmd2 = "select * from firmy where f_id =" & Nrf.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")
            nride = Val(Nrf.Text)
            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then

                cmd = "Insert into firmy values('" & nride & "','" & nazwaf.Text & "','" & Miasto.Text & "', '" & Ulica.Text & "','" & kod_poczt.Text & "' );"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")
                inigconnect.Close()
                Call klienci()

                Me.Close()

            Else

                MsgBox(" Firma o podanym numerze znajduje się już w bazie danych")

            End If


        End If



        






    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim nride As Integer
        Dim cmd As String
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim tabelad As DataTable


        If Nrf.Text = "" Or nazwaf.Text = "" Or Miasto.Text = "" Or Ulica.Text = "" Or kod_poczt.Text = "" Then
            MsgBox("Wypełnij wszystkie pola formularza!")
        Else
            cmd2 = "select * from firmy where f_id =" & Nrf.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")
            nride = Val(Nrf.Text)
            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then

                cmd = "Insert into firmy values('" & nride & "','" & nazwaf.Text & "','" & Miasto.Text & "', '" & Ulica.Text & "','" & kod_poczt.Text & "' );"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")
                inigconnect.Close()
                Call klienci()

                Me.Close()
                Call jeszcze()

            Else

                MsgBox(" Firma o podanym numerze znajduje się już w bazie danych")

            End If


        End If





    End Sub
End Class
