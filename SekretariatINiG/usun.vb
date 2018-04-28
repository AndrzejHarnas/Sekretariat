Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class usun

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim x As Integer
        Dim y As Integer
        Dim cmd As String
        Dim cmd2 As String
        Dim Data As New SqlDataAdapter
        Dim Data2 As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable
        Dim tabelap As DataTable

        If glowny.Baza.Visible = True Then

            x = glowny.Baza.SelectedRows.Item(0).Index

            '-------------------pracownicy-----------------------
            If glowny.Baza.Columns(0).HeaderText = "Nr id:" Then

                y = glowny.Baza.Item(0, x).Value

                cmd2 = "select lzw_id, d_id, nrfw, lpw_id from lzwyklew, faxw, lpoleconew, delegacje where lzwyklew.p_id ='" & y & "' or delegacje.p_id ='" & y & "' or faxw.p_id ='" & y & "' or lpoleconew.p_id ='" & y & "' ;"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                Data2.Fill(ds, "prac")
                tabelap = ds.Tables("prac")

                If tabelap.Rows.Count = 0 Then

                    y = glowny.Baza.Item(0, x).Value
                    cmd = "Delete from pracownicy where p_id='" & y & "';"
                    Data = New SqlDataAdapter(cmd, inigconnect)
                    ds = New DataSet
                    Data.Fill(ds, "stano")
                    tabelas = ds.Tables("stano")
                    inigconnect.Close()
                    Call kadra()

                Else

                    MsgBox(Prompt:="Nie można usunąć pracownika, Najpierw usuń wszystkie wpisy dotyczące tego pracownika")

                End If

                '--------------------------Zakłady----------------------------
            ElseIf glowny.Baza.Columns(0).HeaderText = "Nr zakładu:" Then
                y = glowny.Baza.Item(0, x).Value
                cmd2 = "select p_id, do_id from pracownicy, dzienniko where pracownicy.z_id ='" & y & "' or dzienniko.z_id ='" & y & "';"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                Data2.Fill(ds, "prac")
                tabelap = ds.Tables("prac")

                'MsgBox(tabelap.Rows.Count)

                If tabelap.Rows.Count = 0 Then
                    y = glowny.Baza.Item(0, x).Value
                    cmd = "Delete from zaklady where z_id='" & y & "';"
                    Data = New SqlDataAdapter(cmd, inigconnect)
                    Data.Fill(ds, "zak")
                    tabelas = ds.Tables("zak")
                    inigconnect.Close()
                    Call firma()
                Else
                    MsgBox(Prompt:="Nie można usunąć zakładu, najpierw usuń/edytuj wszystkie wpisy dotyczące tego zakładu!")
                End If


                '--------------------------stanowiska-----------------------------------
            ElseIf glowny.Baza.Columns(0).HeaderText = "Nr stanowiska:" Then

                y = glowny.Baza.Item(0, x).Value

                cmd2 = "select p_id from pracownicy where pracownicy.s_id ='" & y & "';"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                Data2.Fill(ds, "prac")
                tabelap = ds.Tables("prac")


                If tabelap.Rows.Count = 0 Then
                    y = glowny.Baza.Item(0, x).Value
                    cmd = "Delete from stanowiska where s_id='" & y & "';"
                    Data = New SqlDataAdapter(cmd, inigconnect)
                    ds = New DataSet
                    Data.Fill(ds, "st")
                    tabelas = ds.Tables("st")
                    inigconnect.Close()
                    Call stpracy()
                Else
                    MsgBox(Prompt:="Nie można usunąć stanowiska pracy, do którego przypisani są pracownicy!" & Chr(13) & Chr(10) & "Najpierw usuń/edytuj wszystkich pracowników posiadających" & Chr(10) & "takie stanowisko pracy!")
                End If

                '-----------------------------------delegacje-------------------------
            ElseIf glowny.Baza.Columns(0).HeaderText = "Nr delegacji:" Then
                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from delegacje where d_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "st")
                tabelas = ds.Tables("st")
                inigconnect.Close()
                Call wyjazdy()
                '--------------------------------firmy-----------------------------------
            ElseIf glowny.Baza.Columns(0).HeaderText = "Nr firmy:" Then

                y = glowny.Baza.Item(0, x).Value

                cmd2 = "select lzo_id, lzw_id, do_id, dw_id, lpo_id, lpw_id, nr_id from  nrfaxow, lpoleconew, lpoleconeo, dziennikw, lzwykleo, lzwyklew, dzienniko where lzwykleo.f_id ='" & y & "' or lzwyklew.f_id ='" & y & "' or dzienniko.f_id ='" & y & "' or dziennikw.f_id ='" & y & "' or lpoleconeo.f_id ='" & y & "' or lpoleconew.f_id ='" & y & "' or nrfaxow.f_id ='" & y & "';"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                Data2.Fill(ds, "prac")
                tabelap = ds.Tables("prac")


                If tabelap.Rows.Count = 0 Then


                    Dim str As String
                    str = glowny.Baza.Item(0, x).Value
                    cmd = "Delete from firmy where f_id='" & str & "';"
                    Data = New SqlDataAdapter(cmd, inigconnect)
                    ds = New DataSet
                    Data.Fill(ds, "st")
                    tabelas = ds.Tables("st")
                    inigconnect.Close()
                    Call klienci()
                Else

                    MsgBox(Prompt:="Nie można usunąć firmy, która w przeszłości współpracowała z Instytutem!" & Chr(13) & Chr(10) & "Najpierw usuń/edytuj wszystkie wpisy dotyczące tej firmy")

                End If


                '-----------------------Listy zwykłe otrzymane-------------------------------------------
            ElseIf glowny.Baza.Columns(2).HeaderText = "Data otrzymania:" Then
                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from lzwykleo where lzo_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzo")
                tabelas = ds.Tables("lzo")
                inigconnect.Close()
                Call lzo()

                '-------------------------Listy zwykłe wysłane-----------------------------------

            ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania:" Then
                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from lzwyklew where lzw_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call lzw()



                '-------------------------Listy polecone odebrane-----------------------------------

            ElseIf glowny.Baza.Columns(2).HeaderText = "Data odbioru:" Then
                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from lpoleconeo where lpo_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lpo")
                tabelas = ds.Tables("lpo")
                inigconnect.Close()
                Call lpo()

                '------------------------Listy polecone wysłane----------------------------------
            ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania :" Then
                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from lpoleconew where lpw_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call lpw()


                '-----------------------ksiązka numerów---------------------------------------------
            ElseIf glowny.Baza.Columns(2).HeaderText = "Nr tel/fax:" Then

                y = glowny.Baza.Item(0, x).Value

                cmd2 = "select nrfo, nrfw from faxo, faxw where faxo.nr_id = " & y & " or faxw.nr_id =" & y & ";"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds = New DataSet
                Data2.Fill(ds, "prac")
                tabelap = ds.Tables("prac")


                If tabelap.Rows.Count = 0 Then



                    Dim str As String
                    str = glowny.Baza.Item(0, x).Value
                    cmd = "Delete from nrfaxow where nr_id='" & str & "';"
                    Data = New SqlDataAdapter(cmd, inigconnect)
                    ds = New DataSet
                    Data.Fill(ds, "lzw")
                    tabelas = ds.Tables("lzw")
                    inigconnect.Close()
                    Call Module1.nrfax()
                Else

                    MsgBox(Prompt:="Nie można usunąć numeru tel/fax firmy, która w przeszłości współpracowała z Instytutem!" & Chr(13) & Chr(10) & "Najpierw usuń/edytuj wszystkie wpisy dotyczące tego numeru")

                End If


                '------------------------faxy wysłane-------------------
            ElseIf glowny.Baza.Columns(2).HeaderText = "Data wys.:" Then

                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from faxw where nrfw='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call Module1.wfax()
                '-----------------------------faxy odebrane-----------------
            ElseIf glowny.Baza.Columns(3).HeaderText = "Data odb.:" Then

                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from faxo where nrfo='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call Module1.ofax()

            ElseIf glowny.Baza.Columns(1).HeaderText = "Data otrz.:" Then

                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from dzienniko where do_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call Module1.odziennik()

            ElseIf glowny.Baza.Columns(1).HeaderText = "Data wys.:" Then

                Dim str As String
                str = glowny.Baza.Item(0, x).Value
                cmd = "Delete from dziennikw where dw_id='" & str & "';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                Data.Fill(ds, "lzw")
                tabelas = ds.Tables("lzw")
                inigconnect.Close()
                Call Module1.wdziennik()




            End If

        Else
            x = users.usbaza.SelectedRows.Item(0).Index
            Dim str As String
            str = users.usbaza.Item(0, x).Value
            cmd = "Delete from users where u_id='" & str & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "lzw")
            tabelas = ds.Tables("lzw")
            inigconnect.Close()
            Call Module1.uzytk()



        End If















        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub usun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
