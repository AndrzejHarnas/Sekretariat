Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class oddo


    Public Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        If zest = "Pismaod" Then


            glowny.Baza.DataSource = Nothing
            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where datao >= '" & od.Text & "' and datao <= '" & dok.Text & "' order by do_id desc;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaodziennik()

        ElseIf zest = "Pismaw" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where dataw >= '" & od.Text & "' and dataw <= '" & dok.Text & "' order by dw_id desc;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()

        ElseIf zest = "faxo" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where datao >= '" & od.Text & "' and datao <= '" & dok.Text & "' order by nrfo desc;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()

        ElseIf zest = "faxw" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where dataw >= '" & od.Text & "' and dataw <= '" & dok.Text & "' order by nrfw desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawfax()

        ElseIf zest = "lpo" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, R, dokogo from lpo where datao >= '" & od.Text & "' and datao <= '" & dok.Text & "' order by lpo_id desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelalpo()

        ElseIf zest = "lpw" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as prac, dataw, R, nazwaf+', '+Miasto+', ul.: '+ulica as firma from lpw where dataw >= '" & od.Text & "' and dataw <= '" & dok.Text & "' order by lpw_id desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelalpw()

        ElseIf zest = "lzo" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where datao >= '" & od.Text & "' and datao <= '" & dok.Text & "' order by lzo_id desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelalzo()

        ElseIf zest = "lzw" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as prac, dataw, nazwaf+', '+Miasto+', ul.: '+ulica as firma from lzw where dataw >= '" & od.Text & "' and dataw <= '" & dok.Text & "' order by lzw_id desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelalzw()

        ElseIf zest = "delegacje" Then
            glowny.Baza.DataSource = Nothing
            cmd = "select * from wyjazd where od >= '" & od.Text & "' and od <= '" & dok.Text & "' order by od desc"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawyjazdy()

        End If



        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub oddo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
