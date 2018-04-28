Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajdw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
      

        odbiorca.DisplayMember = "f_id"

        If dataw.Visible = False And odbiorca.Visible = False And znakp.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf dataw.Visible = True And odbiorca.Visible = False And znakp.Visible = False Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where dataw " & rownanie.Text & "  '" & dataw.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = False And odbiorca.Visible = True And znakp.Visible = False Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where f_id = '" & odbiorca.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = False And odbiorca.Visible = False And znakp.Visible = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where znakp like '%" & znakp.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = True And odbiorca.Visible = True And znakp.Visible = False Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where dataw " & rownanie.Text & " '" & dataw.Text & "' and f_id = '" & odbiorca.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = True And odbiorca.Visible = False And znakp.Visible = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where dataw " & rownanie.Text & " '" & dataw.Text & "' and znakp like '%" & znakp.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = False And odbiorca.Visible = True And znakp.Visible = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where f_id ='" & odbiorca.Text & "' and znakp like '%" & znakp.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        ElseIf dataw.Visible = True And odbiorca.Visible = True And znakp.Visible = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelad As DataTable

            glowny.Baza.DataSource = Nothing
            cmd = "select dw_id, dataw, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, znakp from wdzien where dataw " & rownanie.Text & " '" & dataw.Text & "' and f_id ='" & odbiorca.Text & "' and znakp like '%" & znakp.Text & "%';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()


            Call tabelawdziennik()
            Me.Close()

        End If








    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chdw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chdw.CheckedChanged

        If Chdw.Checked = True Then

            dataw.Enabled = True
            dataw.Visible = True
            dataw.Text = Now.Date
            rownanie.Enabled = True
            rownanie.Visible = True


        Else
            dataw.Enabled = False
            dataw.Visible = False
            rownanie.Enabled = False
            rownanie.Visible = False

        End If



    End Sub

    Private Sub Cho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cho.CheckedChanged

        If Cho.Checked = True Then


            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable


            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            odbiorca.DataSource = tabe
            odbiorca.DisplayMember = "firma"
            inigconnect.Close()



            odbiorca.Enabled = True
            odbiorca.Visible = True



        Else
            odbiorca.Enabled = False
            odbiorca.Visible = False

        End If
    End Sub

    Private Sub chzp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chzp.CheckedChanged

        If chzp.Checked = True Then

            znakp.Enabled = True
            znakp.Visible = True



        Else
            znakp.Enabled = False
            znakp.Visible = False

        End If
    End Sub
End Class
