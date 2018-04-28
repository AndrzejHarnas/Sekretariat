Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class szukajlzo

    
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable

        If nadawca.Visible = False And datao.Visible = False And adresat.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = False Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma ,datao, dokogo from lzo where f_id ='" & nadawca.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = False Then


            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where datao " & rownanie.Text & " '" & datao.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = False And adresat.Visible = True Then


            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where dokogo like '%" & adresat.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()
        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = False Then

            nadawca.DisplayMember = "f_id"


            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma, datao, dokogo from lzo where f_id='" & nadawca.Text & "' and datao " & rownanie.Text & " '" & datao.Text & "';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = False And adresat.Visible = True Then

            nadawca.DisplayMember = "f_id"

            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where f_id='" & nadawca.Text & "' and dokogo like '%" & adresat.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()

        ElseIf nadawca.Visible = False And datao.Visible = True And adresat.Visible = True Then


            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where datao " & rownanie.Text & " '" & datao.Text & "' and dokogo like '%" & adresat.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

            Me.Close()

        ElseIf nadawca.Visible = True And datao.Visible = True And adresat.Visible = True Then
            nadawca.DisplayMember = "f_id"


            cmd = "select lzo_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, datao, dokogo from lzo where f_id ='" & nadawca.Text & "' and datao " & rownanie.Text & "  '" & datao.Text & "' and dokogo like '%" & adresat.Text & "%';"
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")
            glowny.Baza.DataSource = tabelad

            inigconnect.Close()
            Call tabelalzo()

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

        If Chnadawca.Checked = "true" Then


            cmd = "select f_id, nazwaf+', '+Miasto+', ul.:'+ulica as firma from firmy;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "prac")
            tabelas = ds.Tables("prac")


            nadawca.DataSource = tabelas
            nadawca.DisplayMember = "firma"

            inigconnect.Close()

            nadawca.Visible = True
            nadawca.Enabled = True

        Else
            nadawca.Visible = False
            nadawca.Enabled = False

        End If



    End Sub

    Private Sub Chadresat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chadresat.CheckedChanged

        If Chadresat.Checked = "true" Then

            adresat.Visible = True
            adresat.Enabled = True

        Else
            adresat.Visible = False
            adresat.Enabled = False

        End If



    End Sub

    Private Sub chdatao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chdatao.CheckedChanged
        If chdatao.Checked = "true" Then

            datao.Visible = True
            datao.Enabled = True
            datao.Text = Now().Date
            rownanie.Enabled = True
            rownanie.Visible = True
            rownanie.Text = "="
        Else
            datao.Visible = False
            datao.Enabled = False
            rownanie.Enabled = False
            rownanie.Visible = False

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub nadawca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nadawca.SelectedIndexChanged

    End Sub

    Private Sub adresat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adresat.TextChanged

    End Sub

    Private Sub datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datao.ValueChanged

    End Sub

    Private Sub szukajlzo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
