Imports System.Windows.Forms
Imports System.Data.SqlClient



Public Class szukajfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable


        If nadawca.Visible = False And Datao.Visible = False And adresat.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")


        ElseIf nadawca.Visible = True And Datao.Visible = False And adresat.Visible = False Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where nr_id='" & nadawca.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        ElseIf nadawca.Visible = False And Datao.Visible = True And adresat.Visible = False Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where datao " & rownanie.Text & " '" & Datao.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        ElseIf nadawca.Visible = False And Datao.Visible = False And adresat.Visible = True Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where dokogo like '%" & adresat.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        ElseIf nadawca.Visible = True And Datao.Visible = True And adresat.Visible = False Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where nr_id ='" & nadawca.Text & "' and datao " & rownanie.Text & " '" & Datao.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        ElseIf nadawca.Visible = True And Datao.Visible = False And adresat.Visible = True Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where nr_id ='" & nadawca.Text & "' and dokogo like '%" & adresat.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()


        ElseIf nadawca.Visible = False And Datao.Visible = True And adresat.Visible = True Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where datao " & rownanie.Text & " '" & Datao.Text & "' and dokogo like '%" & adresat.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        ElseIf nadawca.Visible = True And Datao.Visible = True And adresat.Visible = True Then


            nadawca.DisplayMember = "nr_id"
            cmd = "select nrfo, nazwaf+', '+Miasto+', '+ulica as praco, nr_fax, datao, dotyczy, dokogo from ofax where nr_id='" & nadawca.Text & "' and datao " & rownanie.Text & " '" & Datao.Text & "' and dokogo like '%" & adresat.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelaofax()
            Me.Close()

        End If





    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chn.CheckedChanged

        If Chn.Checked = True Then
            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            str = "select nazwaf+', '+Miasto+', nr fax: '+nr_fax as firma, nr_id from firmy, nrfaxow where firmy.f_id = nrfaxow.f_id;"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            nadawca.DataSource = tabe
            nadawca.DisplayMember = "firma"
            inigconnect.Close()

            nadawca.Enabled = True
            nadawca.Visible = True


        Else
            nadawca.Enabled = False
            nadawca.Visible = False

        End If




    End Sub

    Private Sub Chdo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chdo.CheckedChanged


        If Chdo.Checked = True Then

            Datao.Enabled = True
            Datao.Visible = True
            Datao.Text = Now().Date
            rownanie.Enabled = True
            rownanie.Visible = True
            rownanie.Text = "="

        Else
            Datao.Enabled = False
            Datao.Visible = False
            rownanie.Enabled = False
            rownanie.Visible = False


        End If




    End Sub

    Private Sub Cha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cha.CheckedChanged



        If Cha.Checked = True Then

            adresat.Enabled = True
            adresat.Visible = True

        Else
            adresat.Enabled = False
            adresat.Visible = False

        End If



    End Sub

    Private Sub szukajfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
