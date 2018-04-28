Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajp

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String     
        Dim ds As DataSet
        Dim Data As SqlDataAdapter
        Dim tabela As DataTable



        If (surname.Text = "" And stp.Text = "" And zp.Text = "") Then

            MsgBox("Wypełnij przynajmniej jedno pole żeby znależć pracownika!")

        ElseIf (surname.Text <> "" And stp.Text = "" And zp.Text = "") Then


            cmd = "select * from pr where nazwisko='" & surname.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text = "" And stp.Text <> "" And zp.Text = "") Then


            cmd = "select * from pr where nazwa_s ='" & stp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text = "" And stp.Text = "" And zp.Text <> "") Then


            cmd = "select * from pr where symbol ='" & zp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text <> "" And stp.Text <> "" And zp.Text = "") Then


            cmd = "select * from pr where nazwisko ='" & surname.Text & "' and nazwa_s='" & stp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text <> "" And stp.Text <> "" And zp.Text = "") Then


            cmd = "select * from pr where nazwisko ='" & surname.Text & "' and nazwa_s='" & stp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text <> "" And stp.Text = "" And zp.Text <> "") Then


            cmd = "select * from pr where nazwisko ='" & surname.Text & "' and symbol='" & zp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text = "" And stp.Text <> "" And zp.Text <> "") Then


            cmd = "select * from pr where nazwa_s ='" & stp.Text & "' and symbol='" & zp.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        ElseIf (surname.Text <> "" And stp.Text <> "" And zp.Text <> "") Then


            cmd = "select * from pr where nazwa_s ='" & stp.Text & "' and symbol='" & zp.Text & "' and nazwisko='" & surname.Text & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabela = ds.Tables("stano")
            inigconnect.Close()

            glowny.Baza.DataSource = tabela
            Call tabelakadra()
            Me.Close()
        Else
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub rownanie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub nrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub stn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub names_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub surname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surname.TextChanged

    End Sub

    Private Sub dtur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub stp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stp.SelectedIndexChanged

    End Sub

    Private Sub zp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zp.SelectedIndexChanged

    End Sub

    Private Sub city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub street_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub kot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        











    End Sub

   
    
    
    Private Sub chst_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chst.CheckedChanged

        If chst.Checked = True Then

            Dim cmd As String
            Dim Data As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelas As DataTable
        
            cmd = "select * from stanowiska"      
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet

            Data.Fill(ds, "stano")
            tabelas = ds.Tables("stano")


            stp.DataSource = tabelas
            stp.DisplayMember = "nazwa_s"

            inigconnect.Close()
            stp.Enabled = True
            stp.Visible = True


        Else

            stp.DataSource = Nothing     
            stp.Enabled = False
            stp.Visible = False

        End If


    End Sub

    

    Private Sub szukajp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub Chnazwisko_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chnazwisko.CheckedChanged

        If Chnazwisko.Checked = True Then

            surname.Enabled = True
            surname.Visible = True


        Else

            surname.Enabled = False
            surname.Visible = False
            surname.Text = ""

        End If



    End Sub


    Private Sub Chzp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chzp.CheckedChanged

        If Chzp.Checked = True Then

            Dim cmd2 As String
            Dim Data2 As New SqlDataAdapter
            Dim ds As DataSet
            Dim tabelaz As DataTable

            cmd2 = "select * from zaklady;"
            Data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet

            Data2.Fill(ds, "zak")

            tabelaz = ds.Tables("zak")


            zp.DataSource = tabelaz
            zp.DisplayMember = "symbol"


            inigconnect.Close()
            zp.Enabled = True
            zp.Visible = True

        Else
            zp.DataSource = Nothing
            zp.Enabled = False
            zp.Visible = False
        End If






    End Sub

   



   
End Class
