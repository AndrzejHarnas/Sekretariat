Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class edytujp

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim nr As Integer
        Dim ds As DataSet
        Dim Data As SqlDataAdapter
        Dim tabla As DataTable


        If (stn.Text = "" Or names.Text = "" Or surname.Text = "" Or dtur.Text = "" Or stp.Text = "" Or zp.Text = "" Or city.Text = "" Or street.Text = "" Or kot.Text = "" Or nrid.Text = 0 Or stat.Text = "") Then

            MsgBox("Wypełnij wszystkie pola formularza!")
        Else


            stp.DisplayMember = "s_id"
            zp.DisplayMember = "z_id"
            stat.DisplayMember = "st_id"

            nr = Val(nrid.Text)
            cmd = "Update pracownicy set p_id ='" & nr & "', s_id='" & stp.Text & "', imie='" & names.Text & "', nazwisko='" & surname.Text & "', data_ur='" & dtur.Text & "', miasto='" & city.Text & "', ulica='" & street.Text & "', kod_poczt='" & kot.Text & "', z_id='" & zp.Text & "', tytul='" & stn.Text & "', st_id='" & stat.Text & "' where p_id='" & nr & "';"
            Data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            Data.Fill(ds, "stano")
            tabla = ds.Tables("stano")


            inigconnect.Close()

            stp.DisplayMember = "nazwas"
            zp.DisplayMember = "symbol"
            stat.DisplayMember = "stan"

            Me.Close()

            Call kadra()


            Dim x As Integer
            x = nr - 1
            On Error Resume Next
            glowny.Baza.Item(1, x).Selected = True




        End If
















    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub stn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stn.TextChanged

    End Sub

    Private Sub names_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles names.TextChanged

    End Sub

    Private Sub surname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surname.TextChanged

    End Sub

    Private Sub dtur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtur.TextChanged

    End Sub

    Private Sub stp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stp.SelectedIndexChanged

    End Sub

    Private Sub zp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zp.SelectedIndexChanged

    End Sub

    Private Sub city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles city.TextChanged

    End Sub

    Private Sub street_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles street.TextChanged

    End Sub

    Private Sub kot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kot.TextChanged

    End Sub

    Private Sub nrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrid.TextChanged

    End Sub

    Private Sub edytujp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub stat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stat.SelectedIndexChanged

    End Sub
End Class
