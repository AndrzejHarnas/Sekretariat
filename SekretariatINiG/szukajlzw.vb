Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajlzw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable

        If nadawca.Visible = False And dataw.Visible = False And adresat.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where p_id ='" & nadawca.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where dataw " & rownanie.Text & " '" & dataw.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = False And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where f_id ='" & adresat.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where p_id ='" & nadawca.Text & "' and dataw " & rownanie.Text & " '" & dataw.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where p_id ='" & nadawca.Text & "' and f_id ='" & adresat.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where dataw  " & rownanie.Text & " '" & dataw.Text & "' and f_id ='" & adresat.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"

            cmd = "select lzw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw, nazwaf+', '+Miasto+', ul.: '+ulica  from lzw where p_id='" & nadawca.Text & "' and dataw  " & rownanie.Text & " '" & dataw.Text & "' and f_id ='" & adresat.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad
            inigconnect.Close()
            Call tabelalzw()

            Me.Close()

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chnadawca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chnadawca.CheckedChanged
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable

        If Chnadawca.Checked = True Then

            cmd = "select p_id, imie+' '+nazwisko+', '+symbol as praco from pr;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            nadawca.DataSource = tabelas
            nadawca.DisplayMember = "praco"

            inigconnect.Close()

            nadawca.Visible = True
            nadawca.Enabled = True

        Else
            nadawca.Enabled = False
            nadawca.Visible = False

        End If


    End Sub

    Private Sub chdataw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chdataw.CheckedChanged

        If chdataw.Checked = True Then

            dataw.Visible = True
            dataw.Enabled = True
            dataw.Text = Now().Date
            rownanie.Enabled = True
            rownanie.Visible = True
            rownanie.Text = "="

        Else
            dataw.Enabled = False
            dataw.Visible = False
            rownanie.Enabled = False
            rownanie.Visible = False

        End If


    End Sub

    Private Sub Chadresat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chadresat.CheckedChanged

        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable


        If Chadresat.Checked = True Then

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            adresat.DataSource = tabelas
            adresat.DisplayMember = "firma"

            inigconnect.Close()

            adresat.Visible = True
            adresat.Enabled = True

        Else
            adresat.Enabled = False
            adresat.Visible = False

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub adresat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adresat.SelectedIndexChanged

    End Sub

    Private Sub dataw_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataw.ValueChanged

    End Sub

    Private Sub nadawca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nadawca.SelectedIndexChanged

    End Sub
End Class
