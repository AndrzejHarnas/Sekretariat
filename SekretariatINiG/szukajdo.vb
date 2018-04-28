Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajdo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        odkogo.DisplayMember = "f_id"
        symbol.DisplayMember = "z_id"


        If datao.Visible = False And odkogo.Visible = False And symbol.Visible = False Then

            MsgBox("Wybierz przynajmniej jedno kryterium wyszukiwania!")

        ElseIf datao.Visible = True And odkogo.Visible = False And symbol.Visible = False Then



            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where datao " & rownanie.Text & "  '" & datao.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()
        

        ElseIf datao.Visible = False And odkogo.Visible = True And symbol.Visible = False Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where f_id ='" & odkogo.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()

        ElseIf datao.Visible = False And odkogo.Visible = False And symbol.Visible = True Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where z_id ='" & symbol.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()


        ElseIf datao.Visible = True And odkogo.Visible = True And symbol.Visible = False Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where datao " & rownanie.Text & " '" & datao.Text & "' and f_id ='" & odkogo.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()

        ElseIf datao.Visible = True And odkogo.Visible = False And symbol.Visible = True Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where datao " & rownanie.Text & " '" & datao.Text & "' and z_id ='" & symbol.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()

        ElseIf datao.Visible = False And odkogo.Visible = True And symbol.Visible = True Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where f_id='" & odkogo.Text & "' and z_id ='" & symbol.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()

        ElseIf datao.Visible = True And odkogo.Visible = True And symbol.Visible = True Then


            cmd = "select do_id, datao, nazwaf+', '+Miasto+', '+ulica as praco, dotyczy, symbol from odzien where datao " & rownanie.Text & " '" & datao.Text & "' and f_id='" & odkogo.Text & "' and z_id ='" & symbol.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "fax")
            tabelad = ds.Tables("fax")

            glowny.Baza.DataSource = tabelad
            inigconnect.Close()

            Me.Close()
            Call tabelaodziennik()


        End If





    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Chdo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chdo.CheckedChanged

        If Chdo.Checked = True Then

            datao.Visible = True
            datao.Enabled = True
            datao.Text = Now.Date
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

    Private Sub Chn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chn.CheckedChanged

        If Chn.Checked = True Then

            Dim str As String
            Dim data3 As SqlDataAdapter
            Dim ds3 As DataSet
            Dim tabe As DataTable

           
            str = "select f_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma from firmy"
            data3 = New SqlDataAdapter(str, inigconnect)
            ds3 = New DataSet

            data3.Fill(ds3, "f")
            tabe = ds3.Tables("f")

            odkogo.DataSource = tabe
            odkogo.DisplayMember = "firma"
            inigconnect.Close()

            odkogo.Visible = True
            odkogo.Enabled = True


        Else

            odkogo.Visible = False
            odkogo.Enabled = False

        End If


    End Sub

    Private Sub cho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cho.CheckedChanged
        If cho.Checked = True Then
            Dim cmd As String
            Dim Data As SqlDataAdapter
            Dim ds As DataSet
            Dim tabelap As DataTable



            cmd = "select z_id, symbol from zaklady"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "pr")
            tabelap = ds.Tables("pr")

            symbol.DataSource = tabelap
            symbol.DisplayMember = "symbol"
            inigconnect.Close()

            symbol.Visible = True
            symbol.Enabled = True


        Else

            symbol.Visible = False
            symbol.Enabled = False

        End If
    End Sub

    Private Sub datao_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datao.ValueChanged

    End Sub

    Private Sub odkogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odkogo.SelectedIndexChanged

    End Sub

    Private Sub symbol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles symbol.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
