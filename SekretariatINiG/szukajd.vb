Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        Dim cmd As String
        Dim cmd2 As String
        Dim ds As DataSet
        Dim Data As SqlDataAdapter
        Dim tabela As DataTable



        If (pracownik.Visible = False And zaklad.Visible = False And Datewyj.Visible = False And Dateprzyj.Visible = False) Then

            MsgBox("Wypełnij przynajmniej jedno pole żeby znależć delegację!")

        ElseIf (pracownik.Text <> "" And zaklad.Visible = False And Datewyj.Visible = False And Dateprzyj.Visible = False) Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Text <> "" And Datewyj.Visible = False And Dateprzyj.Visible = False) Then

            cmd = "select * from wyjazd where symbol='" & zaklad.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Visible = False And Datewyj.Text <> "" And Dateprzyj.Visible = False) Then

            cmd = "select * from wyjazd where od='" & Datewyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()

        ElseIf (pracownik.Visible = False And zaklad.Visible = False And Datewyj.Visible = False And Dateprzyj.Text <> "") Then

            cmd = "select * from wyjazd where do='" & Dateprzyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()

        ElseIf (pracownik.Text <> "" And zaklad.Text <> "" And Datewyj.Visible = False And Dateprzyj.Visible = False) Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "' and symbol = '" & zaklad.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()

        ElseIf (pracownik.Text <> "" And zaklad.Visible = False And Datewyj.Text <> "" And Dateprzyj.Visible = False) Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "' and od = '" & Datewyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Text <> "" And zaklad.Visible = False And Datewyj.Visible = False And Dateprzyj.Text <> "") Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "' and do = '" & Dateprzyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Text <> "" And Datewyj.Text <> "" And Dateprzyj.Visible = False) Then

            cmd = "select * from wyjazd where symbol='" & zaklad.Text & "' and od ='" & Datewyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Text <> "" And Datewyj.Visible = False And Dateprzyj.Text <> "") Then

            cmd = "select * from wyjazd where symbol='" & zaklad.Text & "' and do ='" & Dateprzyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Visible = False And Datewyj.Text <> "" And Dateprzyj.Text <> "") Then

            cmd = "select * from wyjazd where od='" & Datewyj.Text & "' and do ='" & Dateprzyj.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Text <> "" And zaklad.Text <> "" And Datewyj.Text <> "" And Dateprzyj.Visible = False) Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "' and od = '" & Datewyj.Text & "'and symbol ='" & zaklad.Text & "' ;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()

        ElseIf (pracownik.Text <> "" And zaklad.Text <> "" And Datewyj.Visible = False And Dateprzyj.Text <> "") Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where nazwisko='" & pracownik.Text & "' and do = '" & Dateprzyj.Text & "'and symbol ='" & zaklad.Text & "' ;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Visible = False And zaklad.Text <> "" And Datewyj.Text <> "" And Dateprzyj.Text <> "") Then


            cmd = "select * from wyjazd where od='" & Datewyj.Text & "' and do = '" & Dateprzyj.Text & "'and symbol ='" & zaklad.Text & "' ;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()
        ElseIf (pracownik.Text <> "" And zaklad.Text <> "" And Datewyj.Text <> "" And Dateprzyj.Text <> "") Then

            pracownik.DisplayMember = "p_id"
            cmd2 = "select nazwisko from pr where p_id='" & pracownik.Text & "';"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            pracownik.DataSource = tabela
            pracownik.DisplayMember = "nazwisko"

            inigconnect.Close()

            cmd = "select * from wyjazd where od='" & Datewyj.Text & "' and do = '" & Dateprzyj.Text & "'and symbol ='" & zaklad.Text & "'and nazwisko ='" & pracownik.Text & "' ;"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelawyjazdy()
            Me.Close()


        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub szukajd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pracownik.SelectedIndexChanged

    End Sub

    Private Sub Chz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chz.CheckedChanged
        If Chz.Checked = True Then
            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelas As DataTable

            cmd = "select z_id, symbol from zaklady ORDER BY symbol;"

            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "stano")
            tabelas = ds.Tables("stano")


            zaklad.DataSource = tabelas
            zaklad.DisplayMember = "symbol"
            zaklad.Visible = True
        Else
            zaklad.Visible = False

        End If
    End Sub

    Private Sub Chp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chp.CheckedChanged

        
        If Chp.Checked = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelas As DataTable

            cmd = "select p_id, nazwisko + ' ' + imie as dane from pr order by nazwisko;"

            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "stano")
            tabelas = ds.Tables("stano")


            pracownik.DataSource = tabelas
            pracownik.DisplayMember = "dane"


            pracownik.Visible = True

        Else
            pracownik.Visible = False

        End If




    End Sub

    Private Sub Chodj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chodj.CheckedChanged

        If Chodj.Checked = True Then

            Datewyj.Visible = True
            Datewyj.Text = Now().Date
        Else
            Datewyj.Visible = False

        End If

    End Sub

    Private Sub Chprz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chprz.CheckedChanged


        If Chprz.Checked = True Then

            Dateprzyj.Visible = True
            Dateprzyj.Text = Now().Date

        Else
            Dateprzyj.Visible = False

        End If



    End Sub

    Private Sub zaklad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zaklad.SelectedIndexChanged

    End Sub

    Private Sub Datewyj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datewyj.ValueChanged

    End Sub

    Private Sub Dateprzyj_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dateprzyj.ValueChanged

    End Sub
End Class
