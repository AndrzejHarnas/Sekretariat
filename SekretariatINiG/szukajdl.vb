Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class szukajdl

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim cmd As String
        Dim Data As New SqlDataAdapter
        Dim ds As DataSet
        Dim tabelaf As DataTable

        Call polacz()
        'tabela(firmy)
        users.usbaza.DataSource = Nothing
        cmd = "select * from vlogowania where data like '" & datal.Text & "%' order by nr_l desc"
        Data = New SqlDataAdapter(cmd, inigconnect)
        ds = New DataSet
        Data.Fill(ds, "fir")
        tabelaf = ds.Tables("fir")

        dzlogin.usbaza.DataSource = tabelaf
        inigconnect.Close()

        Call tabelalogo()


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub szukajdl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
