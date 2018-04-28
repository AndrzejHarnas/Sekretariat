Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class pyt1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd1 As String
        Dim cmd2 As String
        Dim cmd3 As String
        Dim cmd4 As String
        Dim cmd5 As String
        Dim cmd6 As String
        Dim cmd7 As String
        Dim cmd8 As String
        Dim cmd9 As String
        Dim cmd10 As String
        Dim cmd11 As String
        Dim cmd12 As String
        Dim cmd13 As String
        Dim cmd14 As String
        Dim ds As DataSet
        Dim Data As SqlDataAdapter


        Call polacz()
        cmd1 = "delete from delegacje where d_id <> ' '"
        Data = New SqlDataAdapter(cmd1, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd2 = "delete from dzienniko where do_id <> ' '"
        Data = New SqlDataAdapter(cmd2, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd3 = "delete from dziennikw where dw_id <> ' '"
        Data = New SqlDataAdapter(cmd3, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd4 = "delete from faxo where nrfo <> ' '"
        Data = New SqlDataAdapter(cmd4, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd5 = "delete from faxw where nrfw <> ' '"
        Data = New SqlDataAdapter(cmd5, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd6 = "delete from firmy where f_id <> ' '"
        Data = New SqlDataAdapter(cmd6, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd7 = "delete from lpoleconeo where lpo_id <> ' '"
        Data = New SqlDataAdapter(cmd7, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd8 = "delete from lpoleconew where lpw_id <> ' '"
        Data = New SqlDataAdapter(cmd8, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd9 = "delete from lzwykleo where lzo_id <> ' '"
        Data = New SqlDataAdapter(cmd9, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd10 = "delete from lzwyklew where lzw_id <> ' '"
        Data = New SqlDataAdapter(cmd10, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd11 = "delete from nrfaxow where nr_id <> ' '"
        Data = New SqlDataAdapter(cmd11, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd12 = "delete from pracownicy where p_id <> ' '"
        Data = New SqlDataAdapter(cmd12, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd13 = "delete from stanowiska where s_id <> ' '"
        Data = New SqlDataAdapter(cmd13, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()

        cmd14 = "delete from zaklady where z_id <> ' '"
        Data = New SqlDataAdapter(cmd14, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "stano")
        inigconnect.Close()


        glowny.wiersz2.Items.Add("Usunięto całą zawartość bazy INiG Krosno")





        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.Close()
        pyt2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
