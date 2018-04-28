Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajlpo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable

        If nadawca.Visible = False And datao.Visible = False And adresat.Visible = False And R.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id ='" & nadawca.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where datao " & rownanie.Text & " '" & datao.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = False And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where dokogo like '%" & adresat.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = False And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where R like '%" & R.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = False And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id= '" & nadawca.Text & "' and datao " & rownanie.Text & " '" & datao.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id= '" & nadawca.Text & "' and dokogo like '%" & adresat.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id= '" & nadawca.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where datao " & rownanie.Text & " '" & datao.Text & "' and dokogo like '%" & adresat.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where datao " & rownanie.Text & " '" & datao.Text & "' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = False And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where dokogo like '%" & adresat.Text & "%' and R like '%" & R.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = True And R.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id = '" & nadawca.Text & "' and datao " & rownanie.Text & " '" & datao.Text & "' and dokogo like '%" & adresat.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id = '" & nadawca.Text & "' and R like '%" & R.Text & "%' and dokogo like '%" & adresat.Text & "%' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = False And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where f_id = '" & nadawca.Text & "' and R like '%" & R.Text & "%' and datao " & rownanie.Text & " '" & datao.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where dokogo like '%" & adresat.Text & "%' and R like '%" & R.Text & "%' and datao " & rownanie.Text & " '" & datao.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = True And R.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lpo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma , datao, R, dokogo from lpo where dokogo like '%" & adresat.Text & "%' and R like '%" & R.Text & "%' and datao " & rownanie.Text & " '" & datao.Text & "' and f_id ='" & nadawca.Text & "' ;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalpo()

            Me.Close()

        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nadawca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nadawca.SelectedIndexChanged

    End Sub

    Private Sub datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datao.ValueChanged

    End Sub

    Private Sub adresat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adresat.TextChanged

    End Sub

    Private Sub Chnadawca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chnadawca.CheckedChanged
        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelas As DataTable

        If Chnadawca.Checked = True Then

            cmd = "select f_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma from firmy;"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            nadawca.DataSource = tabelas
            nadawca.DisplayMember = "firma"

            inigconnect.Close()


            nadawca.Enabled = True
            nadawca.Visible = True

        Else

            nadawca.Enabled = False
            nadawca.Visible = False

        End If


    End Sub

    Private Sub chdatao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chdatao.CheckedChanged

        If chdatao.Checked = True Then
            datao.Enabled = True
            datao.Visible = True
            datao.Text = Now().Date
            rownanie.Enabled = True
            rownanie.Visible = True
            rownanie.Text = "="


        Else

            datao.Enabled = False
            datao.Visible = False
            rownanie.Enabled = False
            rownanie.Visible = False


        End If
    End Sub

    Private Sub Chadresat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chadresat.CheckedChanged

        If Chadresat.Checked = True Then
            adresat.Enabled = True
            adresat.Visible = True

        Else

            adresat.Enabled = False
            adresat.Visible = False

        End If
    End Sub

    Private Sub chnr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chnr.CheckedChanged

        If chnr.Checked = True Then
            R.Enabled = True
            R.Visible = True

        Else

            R.Enabled = False
            R.Visible = False

        End If
    End Sub

    Private Sub szukajlpo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
