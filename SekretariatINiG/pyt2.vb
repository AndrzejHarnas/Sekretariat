Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class pyt2

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

        Me.Close()
        Call polacz()

        If usdele.Checked = True Then

            cmd1 = "delete from delegacje where d_id <> '0'"
            Data = New SqlDataAdapter(cmd1, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Wyjazdy słóżbowe - usunięta ")

        End If

        If usdpo.Checked = True Then
            cmd2 = "delete from dzienniko where do_id <> '0'"
            Data = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Dziennik: pisma odebrane - usunięta ")
        End If

        If usdpw.Checked = True Then

            cmd3 = "delete from dziennikw where dw_id <> '0'"
            Data = New SqlDataAdapter(cmd3, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Dziennik: pisma wysłane - usunięta ")
        End If

        If usfaxo.Checked = True Then

            cmd4 = "delete from faxo where nrfo <> '0'"
            Data = New SqlDataAdapter(cmd4, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Fax: pisma odebrane - usunięta ")
        End If

        If usfaxw.Checked = True Then

            cmd5 = "delete from faxw where nrfw <> '0'"
            Data = New SqlDataAdapter(cmd5, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Fax: pisma wysłane - usunięta ")
        End If

        If usfirm.Checked = True Then

            cmd6 = "delete from firmy where f_id <> '0'"
            Data = New SqlDataAdapter(cmd6, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Firmy - usunięta ")
        End If

        If uslpo.Checked = True Then

            cmd7 = "delete from lpoleconeo where lpo_id <> '0'"
            Data = New SqlDataAdapter(cmd7, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Listy polecone odebrane - usunięta ")
        End If

        If uslpw.Checked = True Then

            cmd8 = "delete from lpoleconew where lpw_id <> '0'"
            Data = New SqlDataAdapter(cmd8, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Listy polecone wysłane - usunięta ")
        End If

        If uslzo.Checked = True Then

            cmd9 = "delete from lzwykleo where lzo_id <> '0'"
            Data = New SqlDataAdapter(cmd9, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Listy zwykłe otrzymane - usunięta ")
        End If

        If uslzw.Checked = True Then

            cmd10 = "delete from lzwyklew where lzw_id <> '0'"
            Data = New SqlDataAdapter(cmd10, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Listy zwykłe wysłane - usunięta ")
        End If

        If usnrfax.Checked = True Then

            cmd11 = "delete from nrfaxow where nr_id <> '0'"
            Data = New SqlDataAdapter(cmd11, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Książka nr: tel/fax - usunięta ")

        End If

        If uspr.Checked = True Then

            cmd12 = "delete from pracownicy where p_id <> '0'"
            Data = New SqlDataAdapter(cmd12, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Pracownicy - usunięta ")
        End If

        If usstan.Checked = True Then

            cmd13 = "delete from stanowiska where s_id <> '0'"
            Data = New SqlDataAdapter(cmd13, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Stanowiska - usunięta ")
        End If

        If uszakl.Checked = True Then

            cmd14 = "delete from zaklady where z_id <> '0'"
            Data = New SqlDataAdapter(cmd14, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Zakłady - usunięta ")

        End If

        If dlog.Checked = True Then

            cmd14 = "delete from dlogowania where nr_l <> '0'"
            Data = New SqlDataAdapter(cmd14, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            inigconnect.Close()
            glowny.wiersz2.Items.Add("Zawartość tabeli - Dziennik logowania - usunięta ")

        End If




        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
