Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajfw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable


        If nadawca.Visible = False And Dataw.Visible = False And adresat.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf nadawca.Visible = True And Dataw.Visible = False And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where p_id ='" & nadawca.Text & "'"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = False And Dataw.Visible = True And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where dataw " & rownanie.Text & " '" & Dataw.Text & "'"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = False And Dataw.Visible = False And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "nr_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where nr_id ='" & adresat.Text & "'"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = True And Dataw.Visible = True And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "nr_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where p_id ='" & nadawca.Text & "' and dataw " & rownanie.Text & " '" & Dataw.Text & "'; "
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = True And Dataw.Visible = False And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "nr_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where p_id ='" & nadawca.Text & "' and nr_id ='" & adresat.Text & "'; "
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = False And Dataw.Visible = True And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "nr_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where dataw " & rownanie.Text & " '" & Dataw.Text & "' and nr_id ='" & adresat.Text & "'; "
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()

        ElseIf nadawca.Visible = True And Dataw.Visible = True And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "nr_id"
            cmd = "select nrfw, imie+' '+nazwisko+', '+symbol as praco, dataw, dotyczy, nazwaf+', '+Miasto+', '+ulica as firma, nr_fax from wfax where p_id='" & nadawca.Text & "'  and dataw " & rownanie.Text & " '" & Dataw.Text & "' and nr_id ='" & adresat.Text & "'; "
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelawfax()
            Me.Close()



        End If


        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chn.CheckedChanged

        If Chn.Checked = True Then
           
            Dim cmd As String
            Dim Data As SqlDataAdapter
            Dim ds As DataSet
            Dim tabelas As DataTable




            

            cmd = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")

            inigconnect.Close()

            nadawca.DataSource() = tabelas
            nadawca.DisplayMember = "praco"

            nadawca.Enabled = True
            nadawca.Visible = True

        Else

            nadawca.Enabled = False
            nadawca.Visible = False

        End If




    End Sub

    Private Sub Chdw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chdw.CheckedChanged
        If Chdw.Checked = True Then

            Dataw.Enabled = True
            Dataw.Visible = True
            Dataw.Text = Now().Date
            rownanie.Enabled = True
            rownanie.Visible = True
            rownanie.Text = "="

        Else

            Dataw.Enabled = False
            Dataw.Visible = False
            rownanie.Enabled = False
            rownanie.Visible = False

        End If

    End Sub

    Private Sub Cha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cha.CheckedChanged
        If Cha.Checked = True Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            Str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(Str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            adresat.DataSource = tabe
            adresat.DisplayMember = "firma"
            inigconnect.Close()
            adresat.Enabled = True
            adresat.Visible = True

        Else

            adresat.Enabled = False
            adresat.Visible = False

        End If



    End Sub
End Class
