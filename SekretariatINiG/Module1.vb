Imports System.Data.SqlClient
Module Module1

    Public inigconnect As New SqlConnection()
    Public connstring As String

    Public zest As String

    Public Sub polacz()

        connstring = "Data Source= .\SQLExpress; Initial Catalog= inigkrosno; Integrated Security=SSPI "
        inigconnect = New SqlConnection(connstring)

        'Integrated Security=True;Connect Timeout=30;User Instance=True

    End Sub

    Sub kadra()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelapr As DataTable

        Call polacz()
        'tabela(pracowników)
        glowny.Baza.DataSource = Nothing
        Call polacz()
        cmd = "select * from pr"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "praco")
        tabelapr = ds.Tables("praco")

        glowny.Baza.DataSource = tabelapr
        inigconnect.Close()
        Call tabelakadra()





    End Sub

    Sub firma()
        'tabela zakłady

        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaz As DataTable

        Call polacz()
        'tabela(zakłady)
        glowny.Baza.DataSource = Nothing
        cmd = "select * from zaklady"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "zak")
        tabelaz = ds.Tables("zak")

        glowny.Baza.DataSource = tabelaz
        inigconnect.Close()

        Call tabelafirma()


    End Sub

    Sub stpracy()
        'tabela stanowiska
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable

        Call polacz()

        glowny.Baza.DataSource = Nothing
        cmd = "select * from stanowiska"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        tabelas = ds.Tables("stano")

        glowny.Baza.DataSource = tabelas
        inigconnect.Close()
        Call tabelastpracy()

    End Sub
    Sub klienci()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(firmy)
        glowny.Baza.DataSource = Nothing
        cmd = "select * from firmy"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fir")
        tabelaf = ds.Tables("fir")

        glowny.Baza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelaklienci()


    End Sub
    Sub lzo()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(listy zwykle otrzymane)
        glowny.Baza.DataSource = Nothing
        cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo order by lzo_id desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "lzo")
        tabelaf = ds.Tables("lzo")

        glowny.Baza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalzo()


    End Sub
    Sub lzw()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(listy zwykle wysłane)
        glowny.Baza.DataSource = Nothing
        cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as prac, dataw, nazwaf+', '+Miasto+', ul.: '+ulica as firma from lzw order by lzw_id desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "lzo")
        tabelaf = ds.Tables("lzo")

        glowny.Baza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalzw()


    End Sub
    Sub lpo()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(listy polecone otrzymane)
        glowny.Baza.DataSource = Nothing
        cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, R, dokogo from lpo order by lpo_id desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "lpo")
        tabelaf = ds.Tables("lpo")

        glowny.Baza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalpo()


    End Sub
    Sub lpw()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable
        Call polacz()
        'tabela(listy polecone wysłane)
        glowny.Baza.DataSource = Nothing
        cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as prac, dataw, R, nazwaf+', '+Miasto+', ul.: '+ulica as firma from lpw order by lpw_id desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "lpw")
        tabelaf = ds.Tables("lpw")

        glowny.Baza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalpw()


    End Sub
    Sub tabelakadra()
        glowny.Baza.Columns(0).HeaderText = "Nr id:"
        glowny.Baza.Columns(0).Width = 60
        glowny.Baza.Columns(1).HeaderText = "Stopień naukowy:"
        glowny.Baza.Columns(1).Width = 120
        glowny.Baza.Columns(2).HeaderText = "Imię:"
        glowny.Baza.Columns(2).Width = 100
        glowny.Baza.Columns(3).HeaderText = "Nazwisko:"
        glowny.Baza.Columns(3).Width = 100
        glowny.Baza.Columns(4).HeaderText = "Data ur:"
        glowny.Baza.Columns(4).Width = 80
        glowny.Baza.Columns(5).HeaderText = "Miejsce zam.:"
        glowny.Baza.Columns(5).Width = 100
        glowny.Baza.Columns(6).HeaderText = "Ulica:"
        glowny.Baza.Columns(6).Width = 140
        glowny.Baza.Columns(7).HeaderText = "Kod poczt.:"
        glowny.Baza.Columns(7).Width = 90
        glowny.Baza.Columns(8).HeaderText = "Stanowsiko pracy:"
        glowny.Baza.Columns(8).Width = 150
        glowny.Baza.Columns(9).HeaderText = "Zakład:"
        glowny.Baza.Columns(9).Width = 80
        glowny.Baza.Columns(10).HeaderText = "Status:"
        glowny.Baza.Columns(10).Width = 100
        glowny.Baza.Columns(11).HeaderText = "Status:"
        glowny.Baza.Columns(11).Width = 0

    End Sub

    Sub tabelafirma()
        glowny.Baza.Columns(0).HeaderText = "Nr zakładu:"
        glowny.Baza.Columns(0).Width = 120
        glowny.Baza.Columns(1).HeaderText = "Nazwa zakładu:"
        glowny.Baza.Columns(1).Width = 862
        glowny.Baza.Columns(2).HeaderText = "Symbol:"
        glowny.Baza.Columns(2).Width = 120
    End Sub

    Sub tabelastpracy()

        glowny.Baza.Columns(0).HeaderText = "Nr stanowiska:"
        glowny.Baza.Columns(0).Width = 120
        glowny.Baza.Columns(1).HeaderText = "Nazwa stanowiska:"
        glowny.Baza.Columns(1).Width = 966

    End Sub
    Sub tabelaklienci()
        glowny.Baza.Columns(0).HeaderText = "Nr firmy:"
        glowny.Baza.Columns(0).Width = 100
        glowny.Baza.Columns(1).HeaderText = "Nazwa firmy:"
        glowny.Baza.Columns(1).Width = 400
        glowny.Baza.Columns(2).HeaderText = "Miejscowość:"
        glowny.Baza.Columns(2).Width = 132
        glowny.Baza.Columns(3).HeaderText = "Ulica:"
        glowny.Baza.Columns(3).Width = 370
        glowny.Baza.Columns(4).HeaderText = "Kod poczt.:"
        glowny.Baza.Columns(4).Width = 100
    End Sub
    Sub tabelalzo()
        glowny.Baza.Columns(0).HeaderText = "Nr:"
        glowny.Baza.Columns(0).Width = 41
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 515
        glowny.Baza.Columns(2).HeaderText = "Data otrzymania:"
        glowny.Baza.Columns(2).Width = 120
        glowny.Baza.Columns(3).HeaderText = "Do kogo:"
        glowny.Baza.Columns(3).Width = 425
    End Sub
    Sub tabelalzw()
        glowny.Baza.Columns(0).HeaderText = "Nr:"
        glowny.Baza.Columns(0).Width = 41
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 455
        glowny.Baza.Columns(2).HeaderText = "Data wysłania:"
        glowny.Baza.Columns(2).Width = 120
        glowny.Baza.Columns(3).HeaderText = "Do kogo:"
        glowny.Baza.Columns(3).Width = 485
    End Sub
    Sub tabelalpo()
        glowny.Baza.Columns(0).HeaderText = "Nr:"
        glowny.Baza.Columns(0).Width = 41
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 410
        glowny.Baza.Columns(2).HeaderText = "Data odbioru:"
        glowny.Baza.Columns(2).Width = 120
        glowny.Baza.Columns(3).HeaderText = "Polecony nr:"
        glowny.Baza.Columns(3).Width = 120
        glowny.Baza.Columns(4).HeaderText = "Do kogo:"
        glowny.Baza.Columns(4).Width = 410
    End Sub

    Sub tabelalpw()
        glowny.Baza.Columns(0).HeaderText = "Nr:"
        glowny.Baza.Columns(0).Width = 41
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 410
        glowny.Baza.Columns(2).HeaderText = "Data wysłania :"
        glowny.Baza.Columns(2).Width = 120
        glowny.Baza.Columns(3).HeaderText = "Polecony nr:"
        glowny.Baza.Columns(3).Width = 120
        glowny.Baza.Columns(4).HeaderText = "Do kogo:"
        glowny.Baza.Columns(4).Width = 410
    End Sub

    Sub jeszcze()

        Dim RowNR As Integer
        Dim nr As String
        Dim cmd As String
        Dim cmd2 As String
        Dim Data As New SqlDataAdapter
        Dim Data2 As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable
        Dim tabelaz As DataTable
        Call polacz()
        '------------------------------Pracownicy---------------------------
        If glowny.Baza.Columns(0).HeaderText = "Nr id:" Then


            RowNR = glowny.Baza.RowCount()
            nr = 0
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajp.nrid.Text = nr.ToString

            dodajp.stp.DataSource = Nothing
            dodajp.zp.DataSource = Nothing

            cmd = "select * from stanowiska"
            cmd2 = "select * from zaklady;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            Data2 = New SqlDataAdapter(cmd2, inigconnect)

            ds = New DataSet

            Data.Fill(ds, "stano")
            Data2.Fill(ds, "zak")
            tabelas = ds.Tables("stano")
            tabelaz = ds.Tables("zak")

            dodajp.stp.DataSource = tabelas
            dodajp.stp.DisplayMember = "nazwa_s"

            dodajp.zp.DataSource = tabelaz
            dodajp.zp.DisplayMember = "symbol"


            inigconnect.Close()



            dodajp.Show()

            '---------------------------Zakłady-------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr zakładu:" Then

            RowNR = glowny.Baza.RowCount()
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajz.Nrz.Text = nr.ToString
            dodajz.Show()


            '----------------------Stanowiska--------------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr stanowiska:" Then

            RowNR = glowny.Baza.RowCount()
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajs.nrs.Text = nr.ToString
            dodajs.Show()

            '---------------------Delegacje------------------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr delegacji:" Then

            Dim x As String
            Call wyjazdy()

            dodajd.surname.DataSource = Nothing

            cmd = "select p_id, imie + ' ' + nazwisko + ' '+ symbol as dane from pr where st_id ='1';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajd.surname.DataSource = tabelas
            dodajd.surname.DisplayMember = "dane"

            dodajd.odkiedy.Value = Now().Date
            dodajd.DoKiedy.Value = Now().Date

            inigconnect.Close()


            dodajd.Show()

            '-------------------------Firmy------------------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr firmy:" Then
            Call klienci()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajf.Nrf.Text = nr.ToString
            dodajf.Show()

            '-----------------------------------Listy zwykłe otrzymane-------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data otrzymania:" Then
            Call lzo()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlzo.Nrlzo.Text = nr.ToString
            dodajlzo.Datao.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlzo.Odkogo.DataSource = tabelas
            dodajlzo.Odkogo.DisplayMember = "firma"

            inigconnect.Close()

            dodajlzo.Show()

            '--------------------------Listy zwykłe wysłane-----------------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania:" Then

            Call lzw()
            Dim tabelap As DataTable
            Dim ds2 As DataSet

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlzw.Nrlzw.Text = nr.ToString
            dodajlzw.Dataw.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlzw.dokogo.DataSource = tabelas
            dodajlzw.dokogo.DisplayMember = "firma"

            inigconnect.Close()

            cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds2 = New DataSet

            Data2.Fill(ds2, "pra")
            tabelap = ds2.Tables("pra")


            dodajlzw.Odkogo.DataSource = tabelap
            dodajlzw.Odkogo.DisplayMember = "praco"

            inigconnect.Close()
            dodajlzw.Show()

            '-------------------------listy polecone odebrane--------------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data odbioru:" Then
            Call lpo()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlpo.Nrlpo.Text = nr.ToString
            dodajlpo.Datao.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlpo.Odkogo.DataSource = tabelas
            dodajlpo.Odkogo.DisplayMember = "firma"

            inigconnect.Close()

            dodajlpo.Show()

            '---------------------------listy polecone wysłane---------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania :" Then

            Call lpw()
            Dim tabelap As DataTable
            Dim ds2 As DataSet

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlpw.Nrlpw.Text = nr.ToString
            dodajlpw.Dataw.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlpw.dokogo.DataSource = tabelas
            dodajlpw.dokogo.DisplayMember = "firma"

            inigconnect.Close()

            cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds2 = New DataSet

            Data2.Fill(ds2, "pra")
            tabelap = ds2.Tables("pra")


            dodajlpw.Odkogo.DataSource = tabelap
            dodajlpw.Odkogo.DisplayMember = "praco"

            inigconnect.Close()
            dodajlpw.Show()

            '----------------ksiazka numerow--------------------

        ElseIf glowny.Baza.Columns(2).HeaderText = "Nr tel/fax:" Then

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajnrf.nrw.Text = nr.ToString

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajnrf.firma.DataSource = tabelas
            dodajnrf.firma.DisplayMember = "firma"

            inigconnect.Close()


            dodajnrf.Show()

            '---------------------------faxy wysłane-----------------

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wys.:" Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            Call wfax()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajfw.Nrw.Text = nr.ToString

            cmd = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")

            inigconnect.Close()

            dodajfw.Odkogo.DataSource() = tabelas
            dodajfw.Odkogo.DisplayMember = "praco"
            dodajfw.Dataw.Text = Now().Date

            str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajfw.dokogo.DataSource = tabe
            dodajfw.dokogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajfw.Show()
            '----------------faxy odebrane-------------------------------------------
        ElseIf glowny.Baza.Columns(3).HeaderText = "Data odb.:" Then


            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            Call ofax()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajfo.Nrw.Text = nr.ToString
            dodajfo.Datao.Text = Now().Date

            str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajfo.Odkogo.DataSource = tabe
            dodajfo.Odkogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajfo.Show()

            '-------------------------dziennik odebrane-----------------------
        ElseIf glowny.Baza.Columns(1).HeaderText = "Data otrz.:" Then

            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable
            Dim tabelap As DataTable


            Call odziennik()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajdo.nrk.Text = nr.ToString
            dodajdo.datao.Text = Now().Date

            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajdo.odkogo.DataSource = tabe
            dodajdo.odkogo.DisplayMember = "firma"
            inigconnect.Close()

            cmd = "select z_id, symbol from zaklady"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "pr")
            tabelap = ds.Tables("pr")

            dodajdo.symbol.DataSource = tabelap
            dodajdo.symbol.DisplayMember = "symbol"
            inigconnect.Close()


            dodajdo.Show()

            '------------------dziennik wysłane---------------------------------
        ElseIf glowny.Baza.Columns(1).HeaderText = "Data wys.:" Then

            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable
            Dim tabelap As DataTable


            Call wdziennik()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajdw.nrk.Text = nr.ToString
            dodajdw.dataw.Text = Now().Date

            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajdw.dokogo.DataSource = tabe
            dodajdw.dokogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajdw.Show()



        End If





    End Sub

    Sub wyjazdy()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()
        'tabela(pracowników)
        glowny.Baza.DataSource = Nothing
        cmd = "select * from wyjazd order by od desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "wyj")
        tabelad = ds.Tables("wyj")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelawyjazdy()






    End Sub
    Sub nrfax()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()
        'tabela(pracowników)
        glowny.Baza.DataSource = Nothing
        cmd = "select nr_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, nr_fax from faxy"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelanrfax()

    End Sub

    Sub wfax()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()
        'tabela(pracowników)
        glowny.Baza.DataSource = Nothing
        cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax order by nrfw desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelawfax()

    End Sub
    Sub ofax()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()
        glowny.Baza.DataSource = Nothing
        cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax order by nrfo desc;"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelaofax()

    End Sub

    Sub odziennik()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()
        glowny.Baza.DataSource = Nothing
        cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien order by do_id desc;"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelaodziennik()

    End Sub

    Sub wdziennik()
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Call polacz()

        glowny.Baza.DataSource = Nothing
        cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien order by dw_id desc;"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()


        Call tabelawdziennik()

    End Sub
    Sub tabelanrfax()
        glowny.Baza.Columns(0).HeaderText = "Lp:"
        glowny.Baza.Columns(0).Width = 81
        glowny.Baza.Columns(1).HeaderText = "Nazwa firmy:"
        glowny.Baza.Columns(1).Width = 590
        glowny.Baza.Columns(2).HeaderText = "Nr tel/fax:"
        glowny.Baza.Columns(2).Width = 430
    End Sub
    Sub tabelaodziennik()
        glowny.Baza.Columns(0).HeaderText = "Nr kol.:"
        glowny.Baza.Columns(0).Width = 80
        glowny.Baza.Columns(1).HeaderText = "Data otrz.:"
        glowny.Baza.Columns(1).Width = 130
        glowny.Baza.Columns(2).HeaderText = "Od kogo:"
        glowny.Baza.Columns(2).Width = 390
        glowny.Baza.Columns(3).HeaderText = "Treść:"
        glowny.Baza.Columns(3).Width = 388
        glowny.Baza.Columns(4).HeaderText = "Do kogo:"
        glowny.Baza.Columns(4).Width = 116

    End Sub
    Sub tabelawdziennik()
        glowny.Baza.Columns(0).HeaderText = "Nr kol.:"
        glowny.Baza.Columns(0).Width = 80
        glowny.Baza.Columns(1).HeaderText = "Data wys.:"
        glowny.Baza.Columns(1).Width = 130
        glowny.Baza.Columns(2).HeaderText = "Do kogo:"
        glowny.Baza.Columns(2).Width = 390
        glowny.Baza.Columns(3).HeaderText = "Treść:"
        glowny.Baza.Columns(3).Width = 388
        glowny.Baza.Columns(4).HeaderText = "Znak pisma:"
        glowny.Baza.Columns(4).Width = 116

    End Sub


    Sub tabelawfax()
        glowny.Baza.Columns(0).HeaderText = "Nr wys.:"
        glowny.Baza.Columns(0).Width = 80
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 300
        glowny.Baza.Columns(2).HeaderText = "Data wys.:"
        glowny.Baza.Columns(2).Width = 130
        glowny.Baza.Columns(3).HeaderText = "Dotyczy:"
        glowny.Baza.Columns(3).Width = 300
        glowny.Baza.Columns(4).HeaderText = "Do kogo:"
        glowny.Baza.Columns(4).Width = 300
        glowny.Baza.Columns(5).HeaderText = "Nr fax:"
        glowny.Baza.Columns(5).Width = 116

    End Sub
    Sub tabelaofax()
        glowny.Baza.Columns(0).HeaderText = "Nr wys.:"
        glowny.Baza.Columns(0).Width = 80
        glowny.Baza.Columns(1).HeaderText = "Od kogo:"
        glowny.Baza.Columns(1).Width = 300
        glowny.Baza.Columns(2).HeaderText = "Nr fax:"
        glowny.Baza.Columns(2).Width = 116
        glowny.Baza.Columns(3).HeaderText = "Data odb.:"
        glowny.Baza.Columns(3).Width = 130
        glowny.Baza.Columns(4).HeaderText = "Dotyczy:"
        glowny.Baza.Columns(4).Width = 300
        glowny.Baza.Columns(5).HeaderText = "Do kogo:"
        glowny.Baza.Columns(5).Width = 300

    End Sub

    Sub tabelawyjazdy()
        glowny.Baza.Columns(0).HeaderText = "Nr delegacji:"
        glowny.Baza.Columns(0).Width = 100
        glowny.Baza.Columns(1).HeaderText = "Stopień naukowy:"
        glowny.Baza.Columns(1).Width = 140
        glowny.Baza.Columns(2).HeaderText = "Imię:"
        glowny.Baza.Columns(2).Width = 120
        glowny.Baza.Columns(3).HeaderText = "Nazwisko:"
        glowny.Baza.Columns(3).Width = 120
        glowny.Baza.Columns(4).HeaderText = "Zakład:"
        glowny.Baza.Columns(4).Width = 100
        glowny.Baza.Columns(5).HeaderText = "Miejsce wyjazdu:"
        glowny.Baza.Columns(5).Width = 160
        glowny.Baza.Columns(6).HeaderText = "Rodzaj transportu:"
        glowny.Baza.Columns(6).Width = 160
        glowny.Baza.Columns(7).HeaderText = "Od kiedy:"
        glowny.Baza.Columns(7).Width = 110
        glowny.Baza.Columns(8).HeaderText = "Do kiedy:"
        glowny.Baza.Columns(8).Width = 110
        glowny.Baza.Columns(9).HeaderText = "Nr zlec.:"
        glowny.Baza.Columns(9).Width = 100
        glowny.Baza.Columns(10).Width = 0
        glowny.Baza.Columns(11).Width = 0
    End Sub


    Sub tabelausers()
        users.usbaza.Columns(0).HeaderText = "Nr id.:"
        users.usbaza.Columns(0).Width = 58
        users.usbaza.Columns(1).HeaderText = "Nazwa użytkownika:"
        users.usbaza.Columns(1).Width = 135
        users.usbaza.Columns(2).HeaderText = "Hasło:"
        users.usbaza.Columns(2).Width = 135

    End Sub

    Sub tabelalogo()
        dzlogin.usbaza.Columns(0).HeaderText = "Nr: "
        dzlogin.usbaza.Columns(0).Width = 58
        dzlogin.usbaza.Columns(1).HeaderText = "Nazwa użytkownika:"
        dzlogin.usbaza.Columns(1).Width = 135
        dzlogin.usbaza.Columns(2).HeaderText = "Data logowania:"
        dzlogin.usbaza.Columns(2).Width = 135

    End Sub
    Sub dodaj()
        Dim RowNR As Integer
        Dim nr As String
        Dim cmd As String
        Dim cmd2 As String
        Dim Data As New SqlDataAdapter
        Dim Data2 As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable
        Dim tabelaz As DataTable

        '-------------------Pracownicy-----------------------------------------

        If glowny.Baza.Columns(0).HeaderText = "Nr id:" Then
            Call kadra()

            RowNR = glowny.Baza.RowCount()
            nr = 0
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value

            nr = nr + 1
            dodajp.nrid.Text = nr.ToString

            dodajp.stp.DataSource = Nothing
            dodajp.zp.DataSource = Nothing

            cmd = "select * from stanowiska"
            cmd2 = "select * from zaklady;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            Data2 = New SqlDataAdapter(cmd2, inigconnect)

            ds = New DataSet

            Data.Fill(ds, "stano")
            Data2.Fill(ds, "zak")
            tabelas = ds.Tables("stano")
            tabelaz = ds.Tables("zak")

            dodajp.stp.DataSource = tabelas
            dodajp.stp.DisplayMember = "nazwa_s"

            dodajp.zp.DataSource = tabelaz
            dodajp.zp.DisplayMember = "symbol"


            inigconnect.Close()



            dodajp.Show()
            '--------------------------------------Zakłady----------------------------------

        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr zakładu:" Then

            Call firma()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajz.Nrz.Text = nr.ToString
            dodajz.Show()


            '------------------------Stanowiska-----------------------------------

        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr stanowiska:" Then
            Call stpracy()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajs.nrs.Text = nr.ToString
            dodajs.Show()

            '---------------------------delegacje---------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr delegacji:" Then
            Dim x As String
            Call wyjazdy()

            dodajd.surname.DataSource = Nothing

            cmd = "select p_id, imie + ' ' + nazwisko + ' '+ symbol as dane from pr where st_id ='1';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajd.surname.DataSource = tabelas
            dodajd.surname.DisplayMember = "dane"

            dodajd.odkiedy.Value = Now().Date
            dodajd.DoKiedy.Value = Now().Date

            inigconnect.Close()


            dodajd.Show()

            '---------------------------Firmy----------------------------------------------------------
        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr firmy:" Then
            Call klienci()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajf.Nrf.Text = nr.ToString
            dodajf.Show()

            '------------------------Listy zwykłe otrzymane -----------------------------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data otrzymania:" Then
            Call lzo()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlzo.Nrlzo.Text = nr.ToString
            dodajlzo.Datao.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlzo.Odkogo.DataSource = tabelas
            dodajlzo.Odkogo.DisplayMember = "firma"

            inigconnect.Close()

            dodajlzo.Show()

            '-------------------------listy zwykłe wysłane-------------------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania:" Then
            Call lzw()
            Dim tabelap As DataTable
            Dim ds2 As DataSet



            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlzw.Nrlzw.Text = nr.ToString
            dodajlzw.Dataw.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlzw.dokogo.DataSource = tabelas
            dodajlzw.dokogo.DisplayMember = "firma"

            inigconnect.Close()

            cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds2 = New DataSet

            Data2.Fill(ds2, "prac")
            tabelap = ds2.Tables("prac")


            dodajlzw.Odkogo.DataSource = tabelap
            dodajlzw.Odkogo.DisplayMember = "praco"

            inigconnect.Close()

            dodajlzw.Show()
            '-----------------------------Listy polecone odebrane------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data odbioru:" Then
            Call lpo()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlpo.Nrlpo.Text = nr.ToString
            dodajlpo.Datao.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlpo.Odkogo.DataSource = tabelas
            dodajlpo.Odkogo.DisplayMember = "firma"

            inigconnect.Close()

            dodajlpo.Show()

            '-----------------------listy polecone wysłane--------------------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania :" Then
            Call lpw()
            Dim tabelap As DataTable
            Dim ds2 As DataSet



            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajlpw.Nrlpw.Text = nr.ToString
            dodajlpw.Dataw.Text = Now().Date

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajlpw.dokogo.DataSource = tabelas
            dodajlpw.dokogo.DisplayMember = "firma"

            inigconnect.Close()

            cmd2 = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds2 = New DataSet

            Data2.Fill(ds2, "prac")
            tabelap = ds2.Tables("prac")


            dodajlpw.Odkogo.DataSource = tabelap
            dodajlpw.Odkogo.DisplayMember = "praco"

            inigconnect.Close()

            dodajlpw.Show()
            '------------------------ Numery faxów---------------------
        ElseIf glowny.Baza.Columns(2).HeaderText = "Nr tel/fax:" Then
            Call nrfax()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, RowNR - 1).Value
            nr = nr + 1
            dodajnrf.nrw.Text = nr.ToString

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            dodajnrf.firma.DataSource = tabelas
            dodajnrf.firma.DisplayMember = "firma"

            inigconnect.Close()


            dodajnrf.Show()

            '-------------------faxy wysłane-------------------------------

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wys.:" Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            Call wfax()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajfw.Nrw.Text = nr.ToString

            cmd = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")

            inigconnect.Close()

            dodajfw.Odkogo.DataSource() = tabelas
            dodajfw.Odkogo.DisplayMember = "praco"
            dodajfw.Dataw.Text = Now().Date

            str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajfw.dokogo.DataSource = tabe
            dodajfw.dokogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajfw.Show()
            '------------------------faxy odebrane-----------------------------------
        ElseIf glowny.Baza.Columns(3).HeaderText = "Data odb.:" Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            Call ofax()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajfo.Nrw.Text = nr.ToString
            dodajfo.Datao.Text = Now().Date

            str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajfo.Odkogo.DataSource = tabe
            dodajfo.Odkogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajfo.Show()
            '---------------------------dziennik odebrane --------------------------------
        ElseIf glowny.Baza.Columns(1).HeaderText = "Data otrz.:" Then

            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable
            Dim tabelap As DataTable


            Call odziennik()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajdo.nrk.Text = nr.ToString
            dodajdo.datao.Text = Now().Date

            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajdo.odkogo.DataSource = tabe
            dodajdo.odkogo.DisplayMember = "firma"
            inigconnect.Close()

            cmd = "select z_id, symbol from zaklady"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "pr")
            tabelap = ds.Tables("pr")

            dodajdo.symbol.DataSource = tabelap
            dodajdo.symbol.DisplayMember = "symbol"
            inigconnect.Close()


            dodajdo.Show()
            '---------------------------dziennik wyslane --------------------------------
        ElseIf glowny.Baza.Columns(1).HeaderText = "Data wys.:" Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable
            Dim tabelap As DataTable


            Call wdziennik()

            RowNR = glowny.Baza.RowCount()
            On Error Resume Next
            nr = glowny.Baza.Item(0, 0).Value
            nr = nr + 1
            dodajdw.nrk.Text = nr.ToString
            dodajdw.dataw.Text = Now().Date

            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            dodajdw.dokogo.DataSource = tabe
            dodajdw.dokogo.DisplayMember = "firma"
            inigconnect.Close()

            dodajdw.Show()


        End If





    End Sub
    Sub find()
        If glowny.Baza.Columns(0).HeaderText = "Nr id:" Then

            szukajp.Show()

        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr delegacji:" Then

            szukajd.Show()

        ElseIf glowny.Baza.Columns(0).HeaderText = "Nr firmy:" Then

            szukajf.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data otrzymania:" Then

            szukajlzo.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania:" Then

            szukajlzw.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data odbioru:" Then

            szukajlpo.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wysłania :" Then

            szukajlpw.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Nr tel/fax:" Then

            szukajnrf.Show()

        ElseIf glowny.Baza.Columns(2).HeaderText = "Data wys.:" Then

            szukajfw.Show()

        ElseIf glowny.Baza.Columns(3).HeaderText = "Data odb.:" Then

            szukajfo.Show()

        ElseIf glowny.Baza.Columns(1).HeaderText = "Data otrz.:" Then

            szukajdo.Show()

        ElseIf glowny.Baza.Columns(1).HeaderText = "Data wys.:" Then

            szukajdw.Show()


        End If





    End Sub
    Sub kopiaz()
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable
        Dim pacz As String
        Dim conn As String
        Dim inigconnect2 As New SqlConnection
        glowny.backupd.Reset()

        Call polacz()
        inigconnect.Open()
        inigconnect.ChangeDatabase("master")
        inigconnect.Close()

        conn = "Data Source=.\SQLExpress; Initial Catalog= master; Integrated Security=SSPI "
        inigconnect2 = New SqlConnection(conn)

        glowny.backupd.ShowDialog()
        pacz = glowny.backupd.FileName

        If pacz <> "" Then
            cmd = "BACKUP DATABASE inigkrosno to DISK='" & pacz & "'; "
            'cmd = "EXEC kopia2"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.wiersz2.Items.Add("BACKUP w lokalizacji " & pacz & " został utworzony poprawnie")

        End If
        inigconnect2.Close()
    End Sub

    Sub odtw()
        Dim cmd As String
        Dim Data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable
        Dim pacz As String
        Dim conn As String
        Dim inigconnect2 As New SqlConnection
        Dim flag As Integer

        Call polacz()
        inigconnect.Open()
        inigconnect.ChangeDatabase("master")
        inigconnect.Close()
        glowny.restore.Reset()

        glowny.restore.ShowDialog()
        pacz = glowny.restore.FileName

        If glowny.restore.FileName <> "" Then
            flag = 0
            conn = "Data Source=.\SQLExpress; Initial Catalog= master; Integrated Security=SSPI "
            inigconnect2 = New SqlConnection(conn)

            cmd = "RESTORE DATABASE inigkrosno from DISK='" & pacz & "'; "
            'cmd = "EXEC kopia2"
            Call polacz()
            Data = New SqlDataAdapter(cmd, inigconnect2)
            ds = New DataSet



            Data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            inigconnect2.Close()
            flag = 1
            glowny.wiersz2.Items.Add("Baza danych INiGKrosno została przywrócona z lokalizacji: " & pacz & "")
        End If



        inigconnect2.Close()
    End Sub
    Sub uzytk()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(firmy)
        users.usbaza.DataSource = Nothing
        cmd = "select * from users"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fir")
        tabelaf = ds.Tables("fir")

        users.usbaza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelausers()


    End Sub
    Sub ulogo()


        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(firmy)
        users.usbaza.DataSource = Nothing
        cmd = "select * from vlogowania order by nr_l desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fir")
        tabelaf = ds.Tables("fir")

        dzlogin.usbaza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalogo()


    End Sub
End Module
