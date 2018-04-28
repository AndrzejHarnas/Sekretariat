Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Data.Sql
Imports Microsoft.SqlServer




Public Class glowny

    Private WithEvents dokument As PrintDocument
    Private WithEvents dokument2 As PrintDocument
    Private strona As Integer
    Private i As Integer




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Logowanie.Show()



    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub


    Private Sub ZamknijToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZamknijToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Pasek_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Pasek.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub PracownicyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracownicyToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = False
        Call kadra()
        naglowek.Text = "Pracownicy"

    End Sub

    Private Sub StanowiskaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StanowiskaToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call stpracy()
        naglowek.Text = "Stanowiska pracy"


    End Sub

    Private Sub ZakładyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZakładyToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        Call firma()
        naglowek.Text = "Zakłady"


    End Sub


    Public Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Call dodaj()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If Baza.RowCount = 0 Then
            MsgBox("Brak rekordów usunięcia")
        Else
            usun.Show()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Dim y As Integer
        Dim cmd As String
        Dim cmd2 As String
        Dim cmd3 As String
        Dim Data As New SqlDataAdapter
        Dim Data2 As New SqlDataAdapter
        Dim Data3 As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable
        Dim tabelaz As DataTable
        Dim tabelastat As DataTable



        If Baza.SelectedRows.Count = 0 Then

            MsgBox("Zaznacz rekord do edycji!")

        Else

            '-------------------Pracownicy--------------------------
            If Baza.Columns(0).HeaderText = "Nr id:" Then


                y = Baza.SelectedRows.Item(0).Index


                edytujp.nrid.Text = Baza.Item(0, y).Value
                edytujp.stn.Text = Baza.Item(1, y).Value
                edytujp.names.Text = Baza.Item(2, y).Value
                edytujp.surname.Text = Baza.Item(3, y).Value
                edytujp.dtur.Text = Baza.Item(4, y).Value
                edytujp.city.Text = Baza.Item(5, y).Value
                edytujp.street.Text = Baza.Item(6, y).Value
                edytujp.kot.Text = Baza.Item(7, y).Value


                edytujp.stp.DataSource = Nothing
                edytujp.zp.DataSource = Nothing
                edytujp.stat.DataSource = Nothing

                cmd = "select * from stanowiska"
                cmd2 = "select * from zaklady;"
                cmd3 = "select * from status;"

                Data = New SqlDataAdapter(cmd, inigconnect)
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                Data3 = New SqlDataAdapter(cmd3, inigconnect)

                ds = New DataSet

                Data.Fill(ds, "stano")
                Data2.Fill(ds, "zak")
                Data3.Fill(ds, "statu")

                tabelas = ds.Tables("stano")
                tabelaz = ds.Tables("zak")
                tabelastat = ds.Tables("statu")

                edytujp.stp.DataSource = tabelas
                edytujp.stp.DisplayMember = "nazwa_s"

                edytujp.zp.DataSource = tabelaz
                edytujp.zp.DisplayMember = "symbol"

                edytujp.stat.DataSource = tabelastat
                edytujp.stat.DisplayMember = "stan"


                inigconnect.Close()

                edytujp.stp.Text = Baza.Item(8, y).Value
                edytujp.zp.Text = Baza.Item(9, y).Value
                edytujp.stat.Text = Baza.Item(10, y).Value

                edytujp.Show()


                '--------------------Zakłady----------------------------
            ElseIf Baza.Columns(0).HeaderText = "Nr zakładu:" Then

                y = Baza.SelectedRows.Item(0).Index

                edytujz.Nrz.Text = Baza.Item(0, y).Value
                edytujz.nazwaz.Text = Baza.Item(1, y).Value
                edytujz.znak.Text = Baza.Item(2, y).Value

                edytujz.Show()


                '---------------------stanowiska------------------------------------------------

            ElseIf Baza.Columns(0).HeaderText = "Nr stanowiska:" Then

                y = Baza.SelectedRows.Item(0).Index

                edytujs.nazwas.Text = Baza.Item(1, y).Value
                edytujs.nrs.Text = Baza.Item(0, y).Value

                edytujs.Show()
                '------------------delegacje-----------------------------------
            ElseIf Baza.Columns(0).HeaderText = "Nr delegacji:" Then


                dodajd.surname.DataSource = Nothing

                cmd = "select p_id, imie + ' ' + nazwisko + ' '+ symbol as dane from pr where st_id ='1';"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "prac")
                tabelas = ds.Tables("prac")


                edytujd.surname.DataSource = tabelas
                edytujd.surname.DisplayMember = "dane"



                y = Baza.SelectedRows.Item(0).Index
                edytujd.nrd.Text = Baza.Item(0, y).Value
                edytujd.surname.Text = "" & Baza.Item(2, y).Value & " " & Baza.Item(3, y).Value & " " & Baza.Item(4, y).Value & ""
                edytujd.miejsce.Text = Baza.Item(5, y).Value
                edytujd.trans.Text = Baza.Item(6, y).Value
                edytujd.odkiedy.Text = Baza.Item(7, y).Value
                edytujd.DoKiedy.Text = Baza.Item(8, y).Value
                edytujd.nrzlec.Text = Baza.Item(9, y).Value

                edytujd.Show()
                '------------------------firmy-------------------------------------------
            ElseIf Baza.Columns(0).HeaderText = "Nr firmy:" Then

                y = Baza.SelectedRows.Item(0).Index

                edytujf.Nrf.Text = Baza.Item(0, y).Value
                edytujf.Nrf.Enabled = False
                edytujf.nazwaf.Text = Baza.Item(1, y).Value
                edytujf.Miasto.Text = Baza.Item(2, y).Value
                edytujf.Ulica.Text = Baza.Item(3, y).Value
                edytujf.kod_poczt.Text = Baza.Item(4, y).Value
                edytujf.Show()

                '----------------------------Listy zwykłe otrzymane-------------------------------------
            ElseIf Baza.Columns(2).HeaderText = "Data otrzymania:" Then

                cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "prac")
                tabelas = ds.Tables("prac")


                edytujlzo.Odkogo.DataSource = tabelas
                edytujlzo.Odkogo.DisplayMember = "firma"

                inigconnect.Close()

                y = Baza.SelectedRows.Item(0).Index

                edytujlzo.Nrlzo.Text = Baza.Item(0, y).Value
                edytujlzo.Odkogo.Text = Baza.Item(1, y).Value
                edytujlzo.Datao.Text = Baza.Item(2, y).Value
                edytujlzo.Dokogo.Text = Baza.Item(3, y).Value

                edytujlzo.Show()


                '-------------------listy zwykle wysłane------------------------------
            ElseIf Baza.Columns(2).HeaderText = "Data wysłania:" Then

                Dim ds2 As DataSet
                Dim tabela As DataTable

                cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "fir")
                tabelas = ds.Tables("fir")


                edytujlzw.dokogo.DataSource = tabelas
                edytujlzw.dokogo.DisplayMember = "firma"

                inigconnect.Close()

                cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds2 = New DataSet

                Data2.Fill(ds2, "pr")
                tabela = ds2.Tables("pr")


                edytujlzw.Odkogo.DataSource = tabela
                edytujlzw.Odkogo.DisplayMember = "praco"

                inigconnect.Close()

                y = Baza.SelectedRows.Item(0).Index

                edytujlzw.Nrlzw.Text = Baza.Item(0, y).Value
                edytujlzw.Odkogo.Text = Baza.Item(1, y).Value
                edytujlzw.Dataw.Text = Baza.Item(2, y).Value
                edytujlzw.dokogo.Text = Baza.Item(3, y).Value

                edytujlzw.Show()
                '-------------Listy polecone odebrane---------------------------
            ElseIf Baza.Columns(2).HeaderText = "Data odbioru:" Then

                cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "firm")
                tabelas = ds.Tables("firm")

                inigconnect.Close()

                edytujlpo.Odkogo.DataSource = tabelas
                edytujlpo.Odkogo.DisplayMember = "firma"



                y = Baza.SelectedRows.Item(0).Index

                edytujlpo.Nrlpo.Text = Baza.Item(0, y).Value
                edytujlpo.Odkogo.Text = Baza.Item(1, y).Value
                edytujlpo.Datao.Text = Baza.Item(2, y).Value
                edytujlpo.R.Text = Baza.Item(3, y).Value
                edytujlpo.dokogo.Text = Baza.Item(4, y).Value


                edytujlpo.Show()
                '--------------------------------Listy polecone wysłane -------------------------
            ElseIf Baza.Columns(2).HeaderText = "Data wysłania :" Then

                Dim ds2 As DataSet
                Dim tabela As DataTable

                cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "fir")
                tabelas = ds.Tables("fir")


                edytujlpw.dokogo.DataSource = tabelas
                edytujlpw.dokogo.DisplayMember = "firma"

                inigconnect.Close()

                cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
                Data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds2 = New DataSet

                Data2.Fill(ds2, "pr")
                tabela = ds2.Tables("pr")


                edytujlpw.Odkogo.DataSource = tabela
                edytujlpw.Odkogo.DisplayMember = "praco"

                inigconnect.Close()

                y = Baza.SelectedRows.Item(0).Index

                edytujlpw.Nrlpw.Text = Baza.Item(0, y).Value
                edytujlpw.Odkogo.Text = Baza.Item(1, y).Value
                edytujlpw.Dataw.Text = Baza.Item(2, y).Value
                edytujlpw.R.Text = Baza.Item(3, y).Value
                edytujlpw.dokogo.Text = Baza.Item(4, y).Value

                edytujlpw.Show()

                '-----------------ksiazka numerow-------------------------------------
            ElseIf Baza.Columns(2).HeaderText = "Nr tel/fax:" Then


                cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "fir")
                tabelas = ds.Tables("fir")


                edytujnrf.firma.DataSource = tabelas
                edytujnrf.firma.DisplayMember = "firma"

                y = Baza.SelectedRows.Item(0).Index

                edytujnrf.nrw.Text = Baza.Item(0, y).Value
                edytujnrf.firma.Text = Baza.Item(1, y).Value
                edytujnrf.nrfax.Text = Baza.Item(2, y).Value


                edytujnrf.Show()

                '-----------------------------faxy wysłane---------------------------------

            ElseIf Baza.Columns(2).HeaderText = "Data wys.:" Then
                Dim Str As String
                Dim ds3 As DataSet
                Dim Data4 As SqlDataAdapter
                Dim tabe As DataTable



                cmd = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "prac")
                tabelas = ds.Tables("prac")

                inigconnect.Close()

                edytujfw.Odkogo.DataSource() = tabelas
                edytujfw.Odkogo.DisplayMember = "praco"



                Str = "select nazwaf+', '+Miasto+', '+ulica+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
                Data4 = New SqlDataAdapter(Str, inigconnect)
                ds3 = New DataSet

                Data4.Fill(ds3, "f")
                tabe = ds3.Tables("f")

                edytujfw.dokogo.DataSource = tabe
                edytujfw.dokogo.DisplayMember = "firma"
                inigconnect.Close()


                y = Baza.SelectedRows.Item(0).Index

                edytujfw.Dataw.Text = Baza.Item(2, y).Value
                edytujfw.Nrw.Text = Baza.Item(0, y).Value
                edytujfw.Odkogo.Text = Baza.Item(1, y).Value
                edytujfw.dokogo.Text = "" & Baza.Item(4, y).Value & ", nr fax: " & Baza.Item(5, y).Value & ""
                edytujfw.dotyczy.Text = Baza.Item(3, y).Value


                edytujfw.Show()
                '-----------------------faxy odebrane -----------------------------------

            ElseIf Baza.Columns(3).HeaderText = "Data odb.:" Then
                Dim Str As String
                Dim ds3 As DataSet
                Dim Data4 As SqlDataAdapter
                Dim tabe As DataTable



                Str = "select nazwaf+', '+Miasto+', '+ulica+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
                Data4 = New SqlDataAdapter(Str, inigconnect)
                ds3 = New DataSet

                Data4.Fill(ds3, "f")
                tabe = ds3.Tables("f")

                edytujfo.Odkogo.DataSource = tabe
                edytujfo.Odkogo.DisplayMember = "firma"
                inigconnect.Close()


                y = Baza.SelectedRows.Item(0).Index

                edytujfo.Datao.Text = Baza.Item(3, y).Value
                edytujfo.Nrw.Text = Baza.Item(0, y).Value
                edytujfo.dokogo.Text = Baza.Item(5, y).Value
                edytujfo.Odkogo.Text = "" & Baza.Item(1, y).Value & ", nr fax: " & Baza.Item(2, y).Value & ""
                edytujfo.dotyczy.Text = Baza.Item(4, y).Value



                edytujfo.Show()
                '------------------------------------dziennik odebrane-------------------
            ElseIf Baza.Columns(1).HeaderText = "Data otrz.:" Then

                Dim str As String
                Dim data4 As SqlDataAdapter
                Dim ds3 As DataSet
                Dim tabe As DataTable
                Dim tabelap As DataTable




                str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
                data4 = New SqlDataAdapter(str, inigconnect)
                ds3 = New DataSet

                data4.Fill(ds3, "f")
                tabe = ds3.Tables("f")

                edytujdo.odkogo.DataSource = tabe
                edytujdo.odkogo.DisplayMember = "firma"
                inigconnect.Close()

                cmd = "select z_id, symbol from zaklady"
                Data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet

                Data.Fill(ds, "pr")
                tabelap = ds.Tables("pr")

                edytujdo.symbol.DataSource = tabelap
                edytujdo.symbol.DisplayMember = "symbol"
                inigconnect.Close()

                y = Baza.SelectedRows.Item(0).Index

                edytujdo.datao.Text = Baza.Item(1, y).Value
                edytujdo.nrk.Text = Baza.Item(0, y).Value
                edytujdo.odkogo.Text = Baza.Item(2, y).Value
                edytujdo.symbol.Text = Baza.Item(4, y).Value
                edytujdo.dotyczy.Text = Baza.Item(3, y).Value



                edytujdo.Show()
                '------------------------------------dziennik wysłane-------------------
            ElseIf Baza.Columns(1).HeaderText = "Data wys.:" Then

                Dim str As String
                Dim data4 As SqlDataAdapter
                Dim ds3 As DataSet
                Dim tabe As DataTable


                str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
                data4 = New SqlDataAdapter(str, inigconnect)
                ds3 = New DataSet

                data4.Fill(ds3, "f")
                tabe = ds3.Tables("f")

                edytujdw.dokogo.DataSource = tabe
                edytujdw.dokogo.DisplayMember = "firma"
                inigconnect.Close()

                y = Baza.SelectedRows.Item(0).Index

                edytujdw.dataw.Text = Baza.Item(1, y).Value
                edytujdw.nrk.Text = Baza.Item(0, y).Value
                edytujdw.dokogo.Text = Baza.Item(2, y).Value
                edytujdw.znakp.Text = Baza.Item(4, y).Value
                edytujdw.dotyczy.Text = Baza.Item(3, y).Value



                edytujdw.Show()




            End If


        End If

    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles szukaj.Click

        Call find()

    End Sub

    Private Sub Toolmenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolmenu.ItemClicked

    End Sub

    Private Sub Toolpr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = False
        Call kadra()

    End Sub

    Private Sub Toolst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call stpracy()

    End Sub

    Private Sub DelegacjeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelegacjeToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = True
        Call wyjazdy()
        naglowek.Text = "Wyjazdy służbowe"

    End Sub

    Private Sub ToolZak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call firma()





    End Sub



    Private Sub Toolwyj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = True
        Call wyjazdy()




    End Sub

    Private Sub plik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mplik.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cosik.ItemClicked

    End Sub

    Private Sub dodajdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dodajdel.Click
        Dim y As Integer
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable

        If Baza.SelectedRows.Count = 0 Then

            MsgBox("Zaznacz pracownika, który wyjeżdża na delegację!")

        Else
            y = Baza.SelectedRows.Item(0).Index

            cmd = "select p_id, imie + ' ' + nazwisko + ' '+ symbol as dane from pr where p_id ='" & Baza.Item(0, y).Value & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajd.surname.DataSource = tabelas
            dodajd.surname.DisplayMember = "dane"

            dodajd.odkiedy.Value = Now().Date
            dodajd.DoKiedy.Value = Now().Date

            inigconnect.Close()



            dodajd.surname.Enabled = False
            dodajd.DoKiedy.Text = Now().Date
            dodajd.odkiedy.Text = Now().Date

            dodajd.Show()
            dodajd.surname.Enabled = False


        End If





    End Sub

    Private Sub OtrzymaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymaneToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        Call lzo()
        naglowek.Text = "Listy zwykłe otrzymane"



    End Sub

    Private Sub FirmyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmyToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        Call klienci()
        naglowek.Text = "Firmy"

    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        Call klienci()

    End Sub


    Private Sub toolshow_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = False
        Call kadra()
        naglowek.Text = "Pracownicy"

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = True
        Call wyjazdy()
        naglowek.Text = "Wyjazdy służbowe"


    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call firma()
        naglowek.Text = "Zakłady"
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call stpracy()
        naglowek.Text = "Stanowiska pracy"
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call klienci()
        naglowek.Text = "Firmy"
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzo()
        naglowek.Text = "Listy zwykłe odebrane"



    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzw()
        naglowek.Text = "Listy zwykłe wysłane"
    End Sub

    Private Sub WysłaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzw()
        naglowek.Text = "Listy zwykłe wysłane"
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpo()
        naglowek.Text = "Listy polecone odebrane"
    End Sub

    Private Sub OdebraneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdebraneToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpo()
        naglowek.Text = "Listy polecone otrzymane"

    End Sub

    Private Sub ToolStripButton4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpw()
        naglowek.Text = "Listy polecone wysłane"
    End Sub

    Private Sub WysłaneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpw()
        naglowek.Text = "Listy polecone wysłane"
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call nrfax()
        naglowek.Text = "Książka nr tel/Fax"
    End Sub

    Private Sub KsiążkaNumerówToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KsiążkaNumerówToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call nrfax()
        naglowek.Text = "Książka nr tel/fax"
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wfax()
        naglowek.Text = "Faxy wysłane"

    End Sub

    Private Sub WysłanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wfax()
        naglowek.Text = "Faxy wysłane"

    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call ofax()
        naglowek.Text = "Faxy odebrane"

    End Sub

    Private Sub OtrzymanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymanyToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call ofax()
        naglowek.Text = "Faxy otrzymane"

    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call odziennik()
        naglowek.Text = "Dziennik - pisma odebrane"

    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wdziennik()
        naglowek.Text = "Dziennik - pisma wysłane"

    End Sub

    Private Sub PismaOdebraneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaOdebraneToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call odziennik()
        naglowek.Text = "Dziennik - pisma odebrane"

    End Sub

    Private Sub PismaWysłaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaWysłaneToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wdziennik()
        naglowek.Text = "Dziennik - pisma wysłane"

    End Sub

    Private Sub drukuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drukuj.Click

        dokument = New PrintDocument
        dokument.DefaultPageSettings.PaperSize.RawKind = PaperKind.A4



        dokument.DefaultPageSettings.Landscape = True





        podglad.Document() = dokument
        podglad.PrintPreviewControl.Zoom = 1.0
        podglad.WindowState = FormWindowState.Maximized
        podglad.ShowDialog()





    End Sub

    Private Sub dokument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles dokument.PrintPage

        Dim x As Single
        Dim y As Single
        Dim z As Single
        Dim g As Single
        Dim font As New Font("TimesNewRoman", 10, FontStyle.Bold)
        Dim fonthead As New Font("TimesNewRoman", 14, FontStyle.Bold)
        Dim cz As New Font("TimesNewRoman", 8, FontStyle.Italic)
        Dim data As String
        Dim kolorcz As New SolidBrush(Color.Black)
        Dim kolorczer As New SolidBrush(Color.Blue)
        Dim k As Integer
        Dim flag As Integer
        Dim licznik As Integer

        data = "Data: " & Now().ToString & ""
        flag = 28
        k = 0
        x = 50
        y = 20
        licznik = Baza.RowCount
        x = x + 850
        e.Graphics.DrawString(data, font, kolorcz, x, y)
        x = x - 850
        e.Graphics.DrawString("Instytut Nafty i Gazu", font, kolorcz, x, y)
        y = y + 15
        x = x + 15
        e.Graphics.DrawString("Oddział Krosno ", font, kolorcz, x, y)
        y = y + 15
        x = x - 13
        e.Graphics.DrawString("ul. Armii Krajowej 3 ", font, kolorcz, x, y)
        y = y + 15
        x = x + 15
        e.Graphics.DrawString("38-400 Krosno ", font, kolorcz, x, y)


        If Baza.Columns(0).HeaderText = "Nr firmy:" Then

            y = y + 15
            x = x + 440
            e.Graphics.DrawString("Zestawienie Firm", fonthead, kolorczer, x, y)
            x = x - 425
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 300
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 150
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 300
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x - 850
            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 100
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = z + 200
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 300
                z = z - 150
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 150
                z = z + 150
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 300
                z = z - 150
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 850
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 300
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 150
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 300
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x - 850
                i = i + 1
                k = k + 1
                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 100
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = z + 200
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 300
                    z = z - 150
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 150
                    z = z + 150
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 300
                    z = z - 150
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x - 850
            Loop


        ElseIf Baza.Columns(0).HeaderText = "Nr stanowiska:" Then

            y = y + 15
            x = x + 350
            e.Graphics.DrawString("Zestawienie stanowisk pracy w INiG", fonthead, kolorczer, x, y)
            x = x - 165
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 150
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x - 150

            Using tpen As New Pen(Color.Black, 2)

                y = y - 1
                z = 150
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 150
                z = z + 380
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 150

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 150
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                i = i + 1
                k = k + 1
                x = x - 150

                Using tpen As New Pen(Color.Black, 1)

                    y = y - 1
                    z = 150
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 150
                    z = z + 380
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)

                End Using
                x = x - 150
            Loop
        ElseIf Baza.Columns(0).HeaderText = "Nr zakładu:" Then
            y = y + 15
            x = x + 350
            e.Graphics.DrawString("Zestawienie zakładów w INiG", fonthead, kolorczer, x, y)
            x = x - 220
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 500
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x - 620
            Using tpen As New Pen(Color.Black, 2)

                y = y - 1
                z = 120
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = z + 380
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 500
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 620

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 500
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)


                i = i + 1
                k = k + 1
                x = x - 620
                Using tpen As New Pen(Color.Black, 1)

                    y = y - 1
                    z = 120
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = z + 380
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 500
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)

                End Using
                x = x - 620

            Loop
        ElseIf Baza.Columns(0).HeaderText = "Nr id:" Then

            y = y + 15
            x = x + 350
            e.Graphics.DrawString("Zestawienie pracowników INiG", fonthead, kolorczer, x, y)
            x = x - 367
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 50
            e.Graphics.DrawString("St. nauk.:", font, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x + 70
            e.Graphics.DrawString(Baza.Columns(5).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(6).HeaderText, font, kolorcz, x, y)
            x = x + 180
            e.Graphics.DrawString(Baza.Columns(7).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(8).HeaderText, font, kolorcz, x, y)
            x = x + 210
            e.Graphics.DrawString(Baza.Columns(9).HeaderText, font, kolorcz, x, y)
            x = x - 980

            Using tpen As New Pen(Color.Black, 2)

                y = y - 1
                z = 50
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 50
                z = 90
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 90
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 90
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 90
                z = 70
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 70
                z = 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = 180
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 180
                z = 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = 210
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 210
                z = 80
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = x - 980


            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 50
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 90
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 90
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 90
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x + 70
                e.Graphics.DrawString(Baza.Item(5, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(6, i).Value, cz, kolorcz, x, y)
                x = x + 180
                e.Graphics.DrawString(Baza.Item(7, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(8, i).Value, cz, kolorcz, x, y)
                x = x + 210
                e.Graphics.DrawString(Baza.Item(9, i).Value, cz, kolorcz, x, y)
                x = x - 980

                Using tpen As New Pen(Color.Black, 1)

                    y = y - 1
                    z = 50
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 50
                    z = 90
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 90
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 90
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 90
                    z = 70
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 70
                    z = 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = 180
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 180
                    z = 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = 210
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 210
                    z = 80
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using

                x = x - 980


                i = i + 1
                k = k + 1
            Loop

        ElseIf Baza.Columns(0).HeaderText = "Nr delegacji:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Wyjazdy służbowe INiG", fonthead, kolorczer, x, y)
            x = x - 382
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x + 70
            e.Graphics.DrawString("Wyjazd do:", font, kolorcz, x, y)
            x = x + 180
            e.Graphics.DrawString("Transport:", font, kolorcz, x, y)
            x = x + 180
            e.Graphics.DrawString(Baza.Columns(7).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(8).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(9).HeaderText, font, kolorcz, x, y)
            x = x - 910

            Using tpen As New Pen(Color.Black, 2)

                y = y - 1
                z = 100
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = 90
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 90
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 90
                z = 70
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 70
                z = 180
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 180
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 180
                z = 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = x - 910
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 90
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 90
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x + 70
                e.Graphics.DrawString(Baza.Item(5, i).Value, cz, kolorcz, x, y)
                x = x + 180
                e.Graphics.DrawString(Baza.Item(6, i).Value, cz, kolorcz, x, y)
                x = x + 180
                e.Graphics.DrawString(Baza.Item(7, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(8, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(9, i).Value, cz, kolorcz, x, y)
                x = x - 910
                Using tpen As New Pen(Color.Black, 1)

                    y = y - 1
                    z = 100
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = 90
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 90
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 90
                    z = 70
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 70
                    z = 180
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 180
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 180
                    z = 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x - 910
                i = i + 1
                k = k + 1
            Loop




        ElseIf Baza.Columns(2).HeaderText = "Nr tel/fax:" Then

            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Zestawienie numerów tel/fax", fonthead, kolorczer, x, y)
            x = x - 265
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 400
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x - 500
            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 100
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = z + 300
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 400
                z = z - 150
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 500

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 400
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)


                i = i + 1
                k = k + 1
                x = x - 500

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 100
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = z + 300
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 400
                    z = z - 150
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x - 500
            Loop
        ElseIf Baza.Columns(2).HeaderText = "Data wysłania:" Then

            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Listy zwykłe wysłane", fonthead, kolorczer, x, y)
            x = x - 370
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 370
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x - 590

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 100
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 370
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 590

            End Using

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 370
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x - 590

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 100
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 370
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 590

                End Using
                i = i + 1
                k = k + 1

            Loop
        ElseIf Baza.Columns(2).HeaderText = "Data otrzymania:" Then

            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Listy zwykłe otrzymane", fonthead, kolorczer, x, y)
            x = x - 370
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 100
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 370
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x - 590

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 100
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 100
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 370
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 590

            End Using

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 100
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 370
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x - 590

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 100
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 100
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 370
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 590

                End Using
                i = i + 1
                k = k + 1

            Loop
        ElseIf Baza.Columns(2).HeaderText = "Data wysłania :" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Listy polecone wysłane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 360
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x - 680

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 80
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 360
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 360
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 360
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 680

            End Using
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 360
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x - 680

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 80
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 360
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 360
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 360
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 680

                End Using



                i = i + 1
                k = k + 1

            Loop
        ElseIf Baza.Columns(2).HeaderText = "Data odbioru:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Listy polecone odebrane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 360
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x - 680

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 80
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 360
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 360
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 360
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 680

            End Using
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 360
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x - 680

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 80
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 360
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 360
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 360
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 680

                End Using

                i = i + 1
                k = k + 1

            Loop

        ElseIf Baza.Columns(2).HeaderText = "Data wys.:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Fax: dokumenty wysłane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 60
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 200
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 370
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x + 230
            e.Graphics.DrawString(Baza.Columns(5).HeaderText, font, kolorcz, x, y)
            x = x - 940

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 60
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 60
                z = 200
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 200
                z = 80
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 370
                z = 230
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 230
                z = 100
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 940

            End Using
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 60
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 200
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 370
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x + 230
                e.Graphics.DrawString(Baza.Item(5, i).Value, cz, kolorcz, x, y)
                x = x - 940

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 60
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 60
                    z = 200
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 200
                    z = 80
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 370
                    z = 230
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 230
                    z = 100
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 940

                End Using


                i = i + 1
                k = k + 1
            Loop
        ElseIf Baza.Columns(3).HeaderText = "Data odb.:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Fax: dokumenty odebrane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 60
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 240
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 120
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x + 370
            e.Graphics.DrawString(Baza.Columns(5).HeaderText, font, kolorcz, x, y)
            x = x - 870

            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 60
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 60
                z = 240
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 240
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 120
                z = 80
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 370
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 370
                z = 180
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 870

            End Using
            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 60
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 240
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 120
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x + 370
                e.Graphics.DrawString(Baza.Item(5, i).Value, cz, kolorcz, x, y)
                x = x - 870

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 60
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 60
                    z = 240
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 240
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 120
                    z = 80
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 370
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 370
                    z = 180
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 870

                End Using


                i = i + 1
                k = k + 1

            Loop
        ElseIf Baza.Columns(1).HeaderText = "Data wys.:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Dziennik: pisma wysłane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 60
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 300
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 480
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x - 920
            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 60
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 60
                z = 80
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 300
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 300
                z = 480
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 480
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 920
            End Using

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 60
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 300
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 480
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x - 920

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 60
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 60
                    z = 80
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 300
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 300
                    z = 480
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 480
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 920
                End Using



                i = i + 1
                k = k + 1

            Loop
        ElseIf Baza.Columns(1).HeaderText = "Data otrz.:" Then
            y = y + 15
            x = x + 400
            e.Graphics.DrawString("Dziennik: pisma otrzymane", fonthead, kolorczer, x, y)
            x = x - 410
            y = y + 50
            e.Graphics.DrawString(Baza.Columns(0).HeaderText, font, kolorcz, x, y)
            x = x + 60
            e.Graphics.DrawString(Baza.Columns(1).HeaderText, font, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString(Baza.Columns(2).HeaderText, font, kolorcz, x, y)
            x = x + 300
            e.Graphics.DrawString(Baza.Columns(3).HeaderText, font, kolorcz, x, y)
            x = x + 480
            e.Graphics.DrawString(Baza.Columns(4).HeaderText, font, kolorcz, x, y)
            x = x - 920
            Using tpen As New Pen(Color.Black, 2)
                y = y - 1
                z = 60
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 60
                z = 80
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 80
                z = 300
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 300
                z = 480
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x + 480
                z = 120
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                x = x - 920
            End Using

            Do While i < licznik And k < flag
                y = y + 24
                e.Graphics.DrawString(Baza.Item(0, i).Value, cz, kolorcz, x, y)
                x = x + 60
                e.Graphics.DrawString(Baza.Item(1, i).Value, cz, kolorcz, x, y)
                x = x + 80
                e.Graphics.DrawString(Baza.Item(2, i).Value, cz, kolorcz, x, y)
                x = x + 300
                e.Graphics.DrawString(Baza.Item(3, i).Value, cz, kolorcz, x, y)
                x = x + 480
                e.Graphics.DrawString(Baza.Item(4, i).Value, cz, kolorcz, x, y)
                x = x - 920

                Using tpen As New Pen(Color.Black, 1)
                    y = y - 1
                    z = 60
                    g = 20
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 60
                    z = 80
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 80
                    z = 300
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 300
                    z = 480
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x + 480
                    z = 120
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                    x = x - 920
                End Using



                i = i + 1
                k = k + 1

            Loop







        End If

        If i < licznik Then
            e.HasMorePages = True
        Else

            e.HasMorePages = False
            i = 0
        End If


    End Sub

    Private Sub drukujd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drukujd.Click
        If Baza.RowCount = 0 Then
            MsgBox("Wydrók niemożliwy - brak rekordów")
        Else


            dokument2 = New PrintDocument
            Page.Document = dokument2
            Page.ShowDialog()
            podglad.Document() = dokument2
            podglad.Document.DefaultPageSettings.PaperSize.RawKind = True
            podglad.Document.DefaultPageSettings.PaperSize.RawKind = PaperKind.A5
            podglad.Document() = dokument2
            podglad.PrintPreviewControl.Zoom = 1.0
            podglad.WindowState = FormWindowState.Maximized

            podglad.ShowDialog()

        End If




    End Sub

    Private Sub dokument2_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles dokument2.PrintPage
        Dim x As Single
        Dim y As Single
        Dim z As Single
        Dim g As Single
        Dim font As New Font("TimesNewRoman", 10, FontStyle.Bold)
        Dim fonthead As New Font("TimesNewRoman", 14, FontStyle.Bold)
        Dim cz As New Font("TimesNewRoman", 7, FontStyle.Regular)
        Dim cz2 As New Font("TimesNewRoman", 10, FontStyle.Bold)
        Dim font2 As New Font("TimesNewRoman", 10, FontStyle.Regular)
        Dim kolorcz As New SolidBrush(Color.Black)
        Dim kolorczer As New SolidBrush(Color.Blue)
        Dim l As Integer
        Dim cz3 As New Font("TimesNewRoman", 6, FontStyle.Regular)
        Dim i As Integer

        If strona = 0 Then
            l = Baza.SelectedRows.Item(0).Index
            y = 20
            x = 20
            y = y + 100

            Using tpen As New Pen(Color.Black, 2)

                z = 267
                g = 450
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
                y = y - 100
                x = x + 267
                g = 550
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            Using tpen As New Pen(Color.Black, 1)

                z = 267
                g = 70
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 180
            y = y + 85
            e.Graphics.DrawString("pieczątka instytucji", cz, kolorcz, x, y)
            x = x + 217
            y = y - 80
            e.Graphics.DrawString("STWIERDZENIE POBYTU SŁUŻBOWEGO *)", cz, kolorcz, x, y)
            y = y + 15
            x = x + 5
            e.Graphics.DrawString("(Podać daty przybycia i wyjazdu oraz liczbę", cz, kolorcz, x, y)
            y = y + 15
            x = x - 7
            e.Graphics.DrawString("noclegów bezpłatnych lub tańszych niż ryczałt).", cz, kolorcz, x, y)
            y = y + 15
            x = x + 2
            e.Graphics.DrawString("Adnotacje te zaopatrzyć pieczęcią i podpisem.", cz, kolorcz, x, y)
            y = 120
            x = 73
            e.Graphics.DrawString("POLECENIE WYJAZDU", font, kolorcz, x, y)
            x = x - 42
            y = y + 20
            e.Graphics.DrawString("SŁUŻBOWEGO Nr: " & Baza.Item(0, l).Value, font, kolorcz, x, y)
            y = y + 25

            x = x + 30
            e.Graphics.DrawString("na wezwanie-zaproszenie *)", font, kolorcz, x, y)
            y = y + 20
            x = x - 30
            e.Graphics.DrawString(Baza.Item(11, l).Value, cz2, kolorcz, x, y)
            x = x + 75
            e.Graphics.DrawString("nr.............................", cz, kolorcz, x, y)
            x = x - 30
            y = y + 20
            e.Graphics.DrawString("z dnia...........................................", cz, kolorcz, x, y)
            y = y + 25
            x = x - 50
            e.Graphics.DrawString("dla: ", cz, kolorcz, x, y)
            'x = x + 15
            y = y + 10
            e.Graphics.DrawString("" & Baza.Item(1, l).Value & " " & Baza.Item(2, l).Value & " " & Baza.Item(3, l).Value, cz2, kolorcz, x, y)
            x = x + 90
            y = y + 16
            e.Graphics.DrawString("(Imię i nazwisko)", cz, kolorcz, x, y)
            x = x - 90
            y = y + 20
            e.Graphics.DrawString(Baza.Item(10, l).Value, cz2, kolorcz, x, y)
            x = x + 60
            y = y + 16
            e.Graphics.DrawString("(stanowisko służbowe, nr leg.)", cz, kolorcz, x, y)
            y = y + 25
            x = x - 60
            e.Graphics.DrawString("do: ", cz, kolorcz, x, y)
            y = y + 10
            e.Graphics.DrawString(Baza.Item(5, l).Value, cz2, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString("na czas: ", cz, kolorcz, x, y)
            y = y + 10
            x = x + 10
            e.Graphics.DrawString("od: ", cz, kolorcz, x, y)
            x = x + 30
            y = y - 2
            e.Graphics.DrawString(Baza.Item(7, l).Value, cz2, kolorcz, x, y)
            x = x + 90
            y = y + 2
            e.Graphics.DrawString(" do: ", cz, kolorcz, x, y)
            x = x + 30
            y = y - 2
            e.Graphics.DrawString(Baza.Item(8, l).Value, cz2, kolorcz, x, y)
            x = x - 160
            y = y + 25
            e.Graphics.DrawString("w celu: ", cz, kolorcz, x, y)
            y = y + 10
            e.Graphics.DrawString(Baza.Item(9, l).Value, cz2, kolorcz, x, y)
            y = y + 25
            x = x - 6
            Using tpen As New Pen(Color.Black, 2)

                z = 267
                g = 70
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using

            y = y + 2
            x = x + 6
            e.Graphics.DrawString("Środki lokomocji: ", cz, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString(Baza.Item(6, l).Value, cz2, kolorcz, x, y)
            y = y + 95
            e.Graphics.DrawString(Now().Date.ToShortDateString, cz2, kolorcz, x, y)
            x = x + 110
            e.Graphics.DrawString("...............................................", cz, kolorcz, x, y)
            y = y + 15
            x = x - 85
            e.Graphics.DrawString("(data)", cz, kolorcz, x, y)
            x = x + 107
            e.Graphics.DrawString("(podpis zlec. wyjazd)", cz, kolorcz, x, y)
            y = y + 25
            x = x - 137
            e.Graphics.DrawString("Proszę o wypłacenie zaliczki w kwocie zł....................................... słownie zł......................................................................", cz, kolorcz, x, y)
            y = y + 15
            x = x + 125
            Using tpen As New Pen(Color.Black, 0.5)

                z = 180
                g = 1
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 125
            y = y + 15
            e.Graphics.DrawString("............................................... na pokrycie wydatków zgodniez poleceniem wyjazdu służbowego nr..................................", cz, kolorcz, x, y)
            y = y + 25
            x = x + 380
            e.Graphics.DrawString("......................................................", cz, kolorcz, x, y)
            y = y + 10
            x = x + 35
            e.Graphics.DrawString("podpis delegowanego", cz, kolorcz, x, y)
            y = y + 25
            x = x - 415
            e.Graphics.DrawString("Zatwierdzono na zł..............................................słownie zł...................................................................................................", cz, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString("do wypłaty z sum.....................................................", cz, kolorcz, x, y)
            y = y - 5
            x = x + 250
            Using tpen As New Pen(Color.Black, 2)

                z = 180
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            Using tpen As New Pen(Color.Black, 1)

                z = 180
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x + 180
            Using tpen As New Pen(Color.Black, 2)

                z = 102
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            Using tpen As New Pen(Color.Black, 1)

                z = 102
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 90
            y = y + 20
            Using tpen As New Pen(Color.Black, 1)

                z = 90
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using

            x = x - 22
            y = y - 18
            e.Graphics.DrawString("Konto", font2, kolorcz, x, y)
            x = x + 130
            e.Graphics.DrawString("Nr dowodu", font2, kolorcz, x, y)
            x = x - 445
            y = y + 20


            Using tpen As New Pen(Color.Black, 2)

                z = 200
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            Using tpen As New Pen(Color.Black, 1)

                z = 200
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)

            End Using
            x = x - 115
            y = y + 2
            e.Graphics.DrawString("Część", cz, kolorcz, x, y)
            x = x + 42
            e.Graphics.DrawString("Dział", cz, kolorcz, x, y)
            x = x + 36
            e.Graphics.DrawString("Rozdz.", cz, kolorcz, x, y)
            x = x + 52
            e.Graphics.DrawString("&", cz, kolorcz, x, y)
            x = x + 34
            e.Graphics.DrawString("Poz.", cz, kolorcz, x, y)
            x = x + 110
            y = y - 1
            e.Graphics.DrawString("Wn", font2, kolorcz, x, y)
            x = x + 90
            e.Graphics.DrawString("Ma", font2, kolorcz, x, y)
            x = x - 125
            y = y + 30
            e.Graphics.DrawString("...................................", cz, kolorcz, x, y)
            x = x + 135
            e.Graphics.DrawString("......................................................", cz, kolorcz, x, y)
            x = x - 95
            y = y + 10
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 115
            e.Graphics.DrawString("podpisy zatwierdzających", cz, kolorcz, x, y)
            e.HasMorePages = True
            strona = 1
        Else
            y = 20
            x = 20
            e.Graphics.DrawString("RACHUNEK KOSZTÓW PODRÓŻY", font, kolorcz, x, y)
            y = y + 15
            Using tpen As New Pen(Color.Black, 2)

                z = 534
                g = 535
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            Using tpen As New Pen(Color.Black, 2)

                z = 534
                g = 179
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            Using tpen As New Pen(Color.Black, 2)
                z = 534
                g = 35
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 179
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 178
            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 179
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 178
            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 20
            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y - 20
            x = x + 178
            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 20
            Using tpen As New Pen(Color.Black, 1)

                z = 178
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = x - 178
            Using tpen As New Pen(Color.Black, 1)

                z = 89
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = x + 89
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = x + 89
            Using tpen As New Pen(Color.Black, 1)

                z = 89
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 89
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 15

            x = 20

            Using tpen As New Pen(Color.Black, 1)

                z = 89
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 89
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 44.5
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 44.5
            Using tpen As New Pen(Color.Black, 1)

                z = 89
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 89
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 44.5
            Using tpen As New Pen(Color.Black, 1)

                z = 44.5
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            For i = 1 To 7
                y = y + 18
                x = 20

                Using tpen As New Pen(Color.Black, 1)

                    z = 89
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 89
                Using tpen As New Pen(Color.Black, 1)

                    z = 44.5
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 44.5
                Using tpen As New Pen(Color.Black, 1)

                    z = 44.5
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 44.5
                Using tpen As New Pen(Color.Black, 1)

                    z = 89
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 89
                Using tpen As New Pen(Color.Black, 1)

                    z = 44.5
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 44.5
                Using tpen As New Pen(Color.Black, 1)

                    z = 44.5
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
            Next

            x = 20
            y = 35
            Using tpen As New Pen(Color.Black, 2)

                z = 534
                g = 35
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using



            y = 35
            x = 376

            Using tpen As New Pen(Color.Black, 1)

                z = 80
                g = 35
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            e.HasMorePages = False
            strona = 0
            x = x + 80
            Using tpen As New Pen(Color.Black, 1)

                z = 98
                g = 20
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 20
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 20
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 15
            x = 376
            Using tpen As New Pen(Color.Black, 1)

                z = 80
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 80
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 20
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using


            For i = 1 To 7
                x = 376


                y = y + 18
                Using tpen As New Pen(Color.Black, 1)

                    z = 80
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 80
                Using tpen As New Pen(Color.Black, 1)

                    z = 78
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 78
                Using tpen As New Pen(Color.Black, 1)

                    z = 20
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
            Next
            x = 20
            y = y + 18
            Using tpen As New Pen(Color.Black, 1)

                z = 250
                g = 72
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 250


            Using tpen As New Pen(Color.Black, 1)

                z = 186
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 186

            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 20
                g = 18
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            For i = 1 To 5
                y = y + 18
                x = x - 264
                Using tpen As New Pen(Color.Black, 1)

                    z = 186
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 186

                Using tpen As New Pen(Color.Black, 1)

                    z = 78
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
                x = x + 78
                Using tpen As New Pen(Color.Black, 1)

                    z = 20
                    g = 18
                    e.Graphics.DrawRectangle(tpen, x, y, z, g)
                End Using
            Next
            y = y - 18
            x = 20
            Using tpen As New Pen(Color.Black, 1)

                z = 250
                g = 144
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 250
            y = y + 36
            Using tpen As New Pen(Color.Black, 1)

                z = 186
                g = 85
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 186

            Using tpen As New Pen(Color.Black, 1)

                z = 98
                g = 85
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 186
            y = y + 85

            Using tpen As New Pen(Color.Black, 1)

                z = 108
                g = 85
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 108
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 23
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 23
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 20
                g = 23
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            y = y + 23
            x = x - 156
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 62
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 78
                g = 62
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 78
            Using tpen As New Pen(Color.Black, 1)

                z = 20
                g = 62
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 264
            y = y + 62
            Using tpen As New Pen(Color.Black, 1)

                z = 108 + 78 + 78 + 20
                g = 78
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using

            x = 90
            y = 40
            e.Graphics.DrawString("WYJAZD", cz, kolorcz, x, y)
            x = x + 170
            e.Graphics.DrawString("PRZYJAZD", cz, kolorcz, x, y)
            x = x + 143
            e.Graphics.DrawString("Środki", cz, kolorcz, x, y)
            y = y + 10
            x = x - 8
            e.Graphics.DrawString("lokomocji", cz, kolorcz, x, y)
            y = y - 14
            x = x + 98
            e.Graphics.DrawString("Koszty", cz3, kolorcz, x, y)
            x = x - 6
            y = y + 8
            e.Graphics.DrawString("Przejazdu", cz3, kolorcz, x, y)
            x = 35
            y = y + 12
            e.Graphics.DrawString("miejscowość", cz, kolorcz, x, y)
            x = x + 85
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 44
            e.Graphics.DrawString("godz.", cz, kolorcz, x, y)
            x = x + 49
            e.Graphics.DrawString("miejscowość", cz, kolorcz, x, y)
            x = x + 85
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 44
            e.Graphics.DrawString("godz.", cz, kolorcz, x, y)
            x = x + 150
            e.Graphics.DrawString("zł", cz, kolorcz, x, y)
            x = x + 46
            e.Graphics.DrawString("gr", cz, kolorcz, x, y)
            x = 76
            y = y + 159
            e.Graphics.DrawString("R-k sprawdzono pod względem", cz, kolorcz, x, y)
            y = y + 10
            x = x + 12
            e.Graphics.DrawString("merytorycznym i rachunk.", cz, kolorcz, x, y)
            y = y + 35
            x = 24
            e.Graphics.DrawString(".......................................", cz, kolorcz, x, y)
            x = x + 132
            e.Graphics.DrawString(".......................................", cz, kolorcz, x, y)
            x = 68
            y = y + 10
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 130
            e.Graphics.DrawString("podpis", cz, kolorcz, x, y)
            x = 280
            y = y - 53
            e.Graphics.DrawString("Ryczałty na dojazdy", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Razem przejazdy, dojazdy", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Diety", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Noclegi wg rachunków", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Noclegi - ryczałt", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Inne wydatki wg załączników", cz, kolorcz, x, y)
            y = y + 18
            e.Graphics.DrawString("Słownie złotych:", cz, kolorcz, x, y)
            x = x + 185
            e.Graphics.DrawString("Ogółem:", cz, kolorcz, x, y)
            x = x - 162
            y = y + 85
            e.Graphics.DrawString("Załączam", cz, kolorcz, x, y)
            x = x + 76
            y = y + 2
            e.Graphics.DrawString("Pobrano zaliczkę", cz, kolorcz, x, y)
            x = x - 110
            y = y + 50
            e.Graphics.DrawString(".....................................", cz, kolorcz, x, y)
            x = x + 142
            e.Graphics.DrawString("do", cz, kolorcz, x, y)
            y = y + 13
            x = x - 110
            e.Graphics.DrawString("dowodów", cz, kolorcz, x, y)
            x = x + 80
            e.Graphics.DrawString("wypłaty - zwrotu", cz, kolorcz, x, y)
            x = x - 40
            y = y + 20
            e.Graphics.DrawString("Niniejszy rachunek przedkładam", cz, kolorcz, x, y)
            y = y + 45
            x = x - 68
            e.Graphics.DrawString(".....................................", cz, kolorcz, x, y)
            x = x + 140
            e.Graphics.DrawString("................................................", cz, kolorcz, x, y)
            x = x - 100
            y = y + 12
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 155
            e.Graphics.DrawString("podpis", cz, kolorcz, x, y)
            x = 22
            y = 289
            e.Graphics.DrawString("Zatwierdzono na zł.............................................słownie", cz, kolorcz, x, y)
            y = y + 15
            e.Graphics.DrawString("zł....................................................................................", cz, kolorcz, x, y)
            y = y + 15
            e.Graphics.DrawString("........................................................................................", cz, kolorcz, x, y)
            y = y + 15
            e.Graphics.DrawString("do wypłaty z sum............................................................", cz, kolorcz, x, y)
            y = y + 15
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 208
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 40
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 166
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 42
            Using tpen As New Pen(Color.Black, 1)

                z = 40
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x + 40
            Using tpen As New Pen(Color.Black, 1)

                z = 42
                g = 15
                e.Graphics.DrawRectangle(tpen, x, y, z, g)
            End Using
            x = x - 162
            y = y + 2
            e.Graphics.DrawString("Część", cz, kolorcz, x, y)
            x = x + 46
            e.Graphics.DrawString("Dział", cz, kolorcz, x, y)
            x = x + 35
            e.Graphics.DrawString("Rozdział", cz, kolorcz, x, y)
            x = x + 56
            e.Graphics.DrawString("&", cz, kolorcz, x, y)
            x = x + 35
            e.Graphics.DrawString("Poz.", cz, kolorcz, x, y)
            x = 22
            y = y + 15
            e.Graphics.DrawString("............", cz, kolorcz, x, y)
            y = y + 10
            x = x + 8
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x - 8
            y = y + 30
            e.Graphics.DrawString("........................................................................................", cz, kolorcz, x, y)
            y = y + 10
            x = x + 70
            e.Graphics.DrawString("podpisy zatwierdzających", cz, kolorcz, x, y)
            y = y + 17
            x = x - 70
            e.Graphics.DrawString("Kwituję odbiór zł................................................słownie", cz, kolorcz, x, y)
            y = y + 17
            e.Graphics.DrawString("zł....................................................................................", cz, kolorcz, x, y)
            y = y + 17
            e.Graphics.DrawString("........................................................................................", cz, kolorcz, x, y)
            y = y + 17
            e.Graphics.DrawString("........................................................................................", cz, kolorcz, x, y)
            y = y + 56
            e.Graphics.DrawString("........................................................................................", cz, kolorcz, x, y)
            y = y + 10
            x = x + 30
            e.Graphics.DrawString("data", cz, kolorcz, x, y)
            x = x + 150
            e.Graphics.DrawString("podpis", cz, kolorcz, x, y)
            x = 20
            y = y + 35
            e.Graphics.DrawString("Zaliczkę w kwocie zł............................................słownie zł..................................................................................................", cz, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString("........................................................................................................otrzymałem i zobowiązuję się rozliczyć z niej w termi-", cz, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString("nie 7 dni po zakończonej podróży upoważniając równocześnie zakład pracy do potrącenia kwoty nie rozliczonej zaliczki z", cz, kolorcz, x, y)
            y = y + 25
            e.Graphics.DrawString("najbliższej wypłaty wynagrodzenia.", cz, kolorcz, x, y)
            y = y + 70
            e.Graphics.DrawString("....................................................................................", cz, kolorcz, x, y)
            x = x + 280
            e.Graphics.DrawString("..........................................................................................", cz, kolorcz, x, y)
            x = x - 230
            y = y + 10
            e.Graphics.DrawString("imię i nazwisko delegowanego", cz, kolorcz, x, y)
            x = x + 310
            e.Graphics.DrawString("data i podpis delegowanego", cz, kolorcz, x, y)

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub PismaOtrzymaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaOtrzymaneToolStripMenuItem.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call odziennik()
        Call dodaj()
        naglowek.Text = "Dziennik - pisma otrzymane"


    End Sub


    Private Sub PismaWysłaneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaWysłaneToolStripMenuItem1.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wdziennik()
        Call dodaj()
        naglowek.Text = "Dziennik pisma wysłane"
    End Sub

    Private Sub OtrzymanyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymanyToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call ofax()
        Call dodaj()
        naglowek.Text = "Faxy otrzymane"


    End Sub

    Private Sub WysłanyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wfax()
        Call dodaj()
        naglowek.Text = "Faxy wysłane"
    End Sub

    Private Sub OdebranyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdebranyToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpo()
        Call dodaj()
        naglowek.Text = "Listy polecone odebrane"

    End Sub

    Private Sub WysłanyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpw()
        Call dodaj()
        naglowek.Text = "Listy polecone wysłane"
    End Sub

    Private Sub OtrzymanyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymanyToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzo()
        Call dodaj()
        naglowek.Text = "Listy zwykłe otrzymane"
    End Sub

    Private Sub WysłanyToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem3.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzw()
        Call dodaj()
        naglowek.Text = "Listy zwykłe wysłane"
    End Sub

    Private Sub DelegacjeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelegacjeToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = True
        Call wyjazdy()
        Call dodaj()
        naglowek.Text = "Wyjazdy służbowe"
    End Sub

    Private Sub PracownikaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracownikaToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = False
        Call kadra()
        Call dodaj()
        naglowek.Text = "Pracownicy"
    End Sub

    Private Sub ZakładToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZakładToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call firma()
        Call dodaj()
        naglowek.Text = "Zakłady"
    End Sub

    Private Sub StanowiskoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StanowiskoToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call stpracy()
        Call dodaj()
        naglowek.Text = "Stanowiska pracy"
    End Sub

    Private Sub NrTelfaxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NrTelfaxToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = False
        dodajdel.Visible = False
        drukujd.Visible = False
        Call nrfax()
        Call dodaj()
        naglowek.Text = "Książka nr tel/fax"
    End Sub

    Private Sub FirmęToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmęToolStripMenuItem.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call klienci()
        Call dodaj()
        naglowek.Text = "Firmy"
    End Sub

    Private Sub BackgroundWorker18_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker15_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker12_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub PismaOtrzymaneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaOtrzymaneToolStripMenuItem1.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call odziennik()
        Call find()
        naglowek.Text = "Dziennik - pisma otrzymane"





    End Sub

    Private Sub PismaWysłaneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaWysłaneToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wdziennik()
        Call find()
        naglowek.Text = "Dziennik - pisma wysłane"
    End Sub

    Private Sub OtrzymanyToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymanyToolStripMenuItem3.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call ofax()
        Call find()
        naglowek.Text = "Faxy otrzymane"
    End Sub

    Private Sub WysłanyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem4.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call wfax()
        Call find()
        naglowek.Text = "Faxy wysłane"
    End Sub

    Private Sub OdebraneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdebraneToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpo()
        Call find()
        naglowek.Text = "Listy polecone odebrane"
    End Sub

    Private Sub WysłaneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lpw()
        Call find()
        naglowek.Text = "Listy polecone wysłane"
    End Sub

    Private Sub OtrzymaneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymaneToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzo()
        Call find()
        naglowek.Text = "Listy zwykłe otrzymane"
    End Sub

    Private Sub WysłaneToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem3.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call lzw()
        Call find()
        naglowek.Text = "Listy zwykłe wysłane"
    End Sub

    Private Sub DelegacjeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelegacjeToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = True
        Call wyjazdy()
        Call find()
        naglowek.Text = "Wyjazdy służbowe"
    End Sub

    Private Sub PracownikaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracownikaToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call kadra()
        Call find()
        naglowek.Text = "Pracownicy"
    End Sub

    Private Sub NrTelfaxToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NrTelfaxToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call nrfax()
        Call find()
        naglowek.Text = "Książka nr tel/fax"
    End Sub

    Private Sub FirmyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmyToolStripMenuItem1.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        Call klienci()
        Call find()
        naglowek.Text = "Firmy"
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Application.Exit()
    End Sub

    Private Sub ZestawieniaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzestawienia.Click

    End Sub

    Private Sub PismaOdebraneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaOdebraneToolStripMenuItem1.Click

        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Dziennik - pisma otrzymane"
        Call odziennik()
        zest = "Pismaod"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()



    End Sub

    Private Sub PismaWysłaneToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PismaWysłaneToolStripMenuItem3.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Dziennik - pisma wysłane"
        Call wdziennik()
        zest = "Pismaw"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub OtrzymanyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymanyToolStripMenuItem4.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Fax - pisma otrzymane"
        Call ofax()
        zest = "faxo"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub WysłanyToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłanyToolStripMenuItem5.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Fax - pisma wysłane"
        Call wfax()
        zest = "faxw"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub OdebraneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdebraneToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Listy polecone odebrane"
        Call lpo()
        zest = "lpo"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub WysłaneToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem4.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Listy polecone wysłane"
        Call lpw()
        zest = "lpw"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub OtrzymaneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrzymaneToolStripMenuItem2.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Listy zwykłe otrzymane"
        Call lzo()
        zest = "lzo"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub WysłaneToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WysłaneToolStripMenuItem5.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = False
        drukujd.Visible = False
        naglowek.Text = "Listy zwykłe wysłane"
        Call lzw()
        zest = "lzw"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub DelegacjeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelegacjeToolStripMenuItem3.Click
        Toolmenu.Visible = True
        szukaj.Visible = True
        dodajdel.Visible = True
        drukujd.Visible = True
        naglowek.Text = "Wyjazdy służbowe"
        Call wyjazdy()
        zest = "delegacje"
        oddo.od.Text = Now().Date
        oddo.dok.Text = Now().Date
        oddo.Show()
    End Sub

    Private Sub ZapiszToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call kopiaz()





    End Sub

    Private Sub RESTOREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call odtw()

    End Sub

    Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosik2.Click

    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Call kopiaz()


    End Sub

    Private Sub rst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rst.Click
        Call odtw()

    End Sub

    Private Sub LogowanieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogowanieToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub usunb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usunb.Click
       
        pyt1.Show()


    End Sub

    Private Sub wiersz2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub uzytkownicy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uzytkownicy.Click

        Call uzytk()
        users.show()


    End Sub

    Private Sub userl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userl.Click
        Call ulogo()
        dzlogin.Show()

    End Sub

    Private Sub ZmianaHasłaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZmianaHasłaToolStripMenuItem.Click
        zhasla.Show()

    End Sub
End Class
