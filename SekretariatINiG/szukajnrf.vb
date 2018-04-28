Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajnrf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        'tabela(pracowników)
        glowny.Baza.DataSource = Nothing
        cmd = "select nr_id, nazwaf+', '+Miasto+', ul.: '+ulica as firma, nr_fax from faxy where nazwaf like '%" & nazwaf.Text & "%'"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fax")
        tabelad = ds.Tables("fax")

        glowny.Baza.DataSource = tabelad
        inigconnect.Close()

        Call tabelanrfax()


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
