Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajlpw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable

        If nadawca.Visible = False And dataw.Visible = False And adresat.Visible = False And R.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id ='" & nadawca.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()
        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where dataw " & rownanie.Text & " '" & dataw.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = False And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where f_id ='" & adresat.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = False And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where R like '%" & R.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()


        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and dataw " & rownanie.Text & " '" & dataw.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and f_id='" & adresat.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where dataw '" & rownanie.text & " ' '" & dataw.Text & "' and f_id = '" & adresat.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where dataw '" & rownanie.text & " ' '" & dataw.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = False And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where f_id = '" & adresat.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and dataw '" & rownanie.text & " ' '" & dataw.Text & "' and f_id = '" & adresat.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and dataw '" & rownanie.text & " ' '" & dataw.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = False And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id = '" & nadawca.Text & "' and f_id = '" & adresat.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = False And dataw.Visible = True And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where dataw '" & rownanie.text & " ' '" & dataw.Text & "' and f_id = '" & adresat.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

            Me.Close()

        ElseIf nadawca.Visible = True And dataw.Visible = True And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "p_id"
            adresat.DisplayMember = "f_id"


            cmd = "select lpw_id, imie+' '+nazwisko+', '+symbol as praco ,dataw,R, nazwaf+', '+Miasto+', ul.: '+ulica  from lpw where p_id ='" & nadawca.Text & "' and dataw '" & rownanie.text & " ' '" & dataw.Text & "' and f_id = '" & adresat.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpw()

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

            nadawca.Enabled = True
            nadawca.Visible = True

        Else

            nadawca.Enabled = False
            nadawca.Visible = False

        End If


    End Sub

    Private Sub chdataw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chdataw.CheckedChanged

        If chdataw.Checked = True Then

            dataw.Text = Now().Date
            dataw.Enabled = True
            dataw.Visible = True
            rownanie.Visible = True
            rownanie.Enabled = True
            rownanie.Text = "="

        Else
            dataw.Enabled = False
            dataw.Visible = False
            rownanie.Visible = False
            rownanie.Enabled = False



        End If


    End Sub

    Private Sub Chadresat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chadresat.CheckedChanged
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable

        If Chadresat.Checked = True Then

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            adresat.DataSource = tabelas
            adresat.DisplayMember = "firma"

            inigconnect.Close()

            adresat.Visible = True
            adresat.Enabled = True

        Else
            adresat.Visible = False
            adresat.Enabled = False

        End If



    End Sub

    Private Sub ChR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChR.CheckedChanged

        If ChR.Checked = True Then

            R.Enabled = True
            R.Visible = True

        Else

            R.Enabled = False
            R.Visible = False

        End If

    End Sub
End Class
