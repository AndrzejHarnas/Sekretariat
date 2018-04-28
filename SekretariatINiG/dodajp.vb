Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dodajp

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim nride As Integer
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds2 As DataSet
        Dim tabelad As DataTable




        If (stn.Text = "" Or names.Text = "" Or surname.Text = "" Or dtur.Text = "" Or stp.Text = "" Or zp.Text = "" Or city.Text = "" Or street.Text = "" Or kot.Text = "" Or nrid.Text = 0) Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from pracownicy where p_id =" & nrid.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "pr")
            tabelap = ds.Tables("pr")
            inigconnect.Close()
            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                stp.DisplayMember = "s_id"
                zp.DisplayMember = "z_id"
                nride = Val(nrid.Text)

                cmd = "Insert into pracownicy values('" & nride & "','" & stp.Text & "','" & names.Text & "','" & surname.Text & "','" & dtur.Text & "','" & city.Text & "','" & street.Text & "','" & kot.Text & "','" & zp.Text & "','" & stn.Text & "','1');"

                data = New SqlDataAdapter(cmd, inigconnect)
                ds2 = New DataSet
                data.Fill(ds2, "prac")
                tabelad = ds2.Tables("prac")



                inigconnect.Close()

                stp.DisplayMember = "nazwas"
                zp.DisplayMember = "symbol"

                Call kadra()


                Me.Close()

            Else

                MsgBox(" Pracownik o podanym numerze znajduje się już w bazie danych")

            End If


        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dodajp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        

    End Sub

    Private Sub stn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stn.TextChanged

    End Sub

    Private Sub name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles names.TextChanged

    End Sub

    Private Sub surname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surname.TextChanged

    End Sub

    Private Sub dtur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtur.TextChanged

    End Sub

    Private Sub stp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click
        Dim nride As Integer
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelap As DataTable
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds2 As DataSet
        Dim tabelad As DataTable




        If (stn.Text = "" Or names.Text = "" Or surname.Text = "" Or dtur.Text = "" Or stp.Text = "" Or zp.Text = "" Or city.Text = "" Or street.Text = "" Or kot.Text = "" Or nrid.Text = 0) Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from pracownicy where p_id =" & nrid.Text & ";"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "pr")
            tabelap = ds.Tables("pr")
            inigconnect.Close()
            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then


                stp.DisplayMember = "s_id"
                zp.DisplayMember = "z_id"
                nride = Val(nrid.Text)

                cmd = "Insert into pracownicy values('" & nride & "','" & stp.Text & "','" & names.Text & "','" & surname.Text & "','" & dtur.Text & "','" & city.Text & "','" & street.Text & "','" & kot.Text & "','" & zp.Text & "','" & stn.Text & "','1');"

                data = New SqlDataAdapter(cmd, inigconnect)
                ds2 = New DataSet
                data.Fill(ds2, "prac")
                tabelad = ds2.Tables("prac")



                inigconnect.Close()

                stp.DisplayMember = "nazwas"
                zp.DisplayMember = "symbol"

                Call kadra()


                Me.Close()
                Call jeszcze()


            Else

                MsgBox("Pracownik o podanym numerze znajduje się już w bazie danych")

            End If


        End If
       


    End Sub
End Class
