
Imports System.Drawing.Printing



Public Class test
    Private WithEvents dokument As PrintDocument
    Private strona As Integer = 0
    Private i As Integer
    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub drukuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drukuj.Click

        dokument = New PrintDocument
        dokument.DefaultPageSettings.Landscape = True
        'dokument.Print()
        glowny.podglad.Document() = dokument
        glowny.podglad.ShowDialog()

    End Sub

    Private Sub dokument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles dokument.PrintPage

        Dim x As Single
        Dim y As Single
        Dim z As Single = 300
        Dim g As Single = 30
        Dim font As New Font("Arial", 8)
        Dim brush As New SolidBrush(Color.Black)
        Dim k As Integer
        Dim licznik As Integer

        k = 0
        x = 0
        y = 200
        licznik = glowny.Baza.RowCount

        e.Graphics.DrawString(glowny.Baza.Columns(0).HeaderText, font, brush, x, y)
        e.Graphics.DrawString(glowny.Baza.Columns(1).HeaderText, font, brush, x + 45, y)


        Do While i < licznik And k < 31
            y = y + 30
            e.Graphics.DrawString(glowny.Baza.Item(0, i).Value, font, brush, x, y)
            e.Graphics.DrawString(glowny.Baza.Item(1, i).Value, font, brush, x + 45, y)
            'e.Graphics.DrawString(glowny.Baza.Item(2, i).Value, font, brush, x + 220, y)
            i = i + 1
            k = k + 1
        Loop
        If i < licznik Then

            e.HasMorePages = True
            y = 200
        Else
            e.HasMorePages = False
            i = 0
        End If

        'Using tpen As New Pen(Color.Black, 2)
        'e.Graphics.DrawRectangle(tpen, x, y, z, g)
        'e.Graphics.DrawString("coś", font:="Arial", Brushes:="BLACK")
        'End Using

    End Sub
End Class