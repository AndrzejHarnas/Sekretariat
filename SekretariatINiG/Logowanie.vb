Imports System.Data.SqlClient

Public Class Logowanie


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim cmd As String
        Dim data As SqlDataAdapter
        Dim ds As DataSet
        Dim tabelad As DataTable

        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim ds2 As DataSet
        Dim tabelad2 As DataTable
        Dim str As String
        Dim nrl As Integer
        Dim nrl2 As Integer


        If uzytkownik.Text = "admin" And haslo.Text = "admin" Then

            Me.Close()
            glowny.Enabled = True
            glowny.cosik2.Visible = True
            glowny.Baza.Visible = False
            glowny.tolmenu.Visible = False
            glowny.bck.Visible = True
            glowny.rst.Visible = True
            glowny.usunb.Visible = True
            glowny.uzytkownicy.Visible = True
            glowny.wiersz2.Visible = True
            glowny.userl.Visible = True
            glowny.mplik.Visible = False
            glowny.mszukaj.Visible = False
            glowny.mzestawienia.Visible = False
            glowny.mdodaj.Visible = False

        Else

            nrl = 0
            cmd = "select * from users where u_name = '" & uzytkownik.Text & "' and pasw ='" & haslo.Text & "';"
            Call polacz()
            data = New SqlDataAdapter(cmd, inigconnect)
            ds = New DataSet
            data.Fill(ds, "dele")
            tabelad = ds.Tables("dele")


            inigconnect.Close()

            If tabelad.Rows.Count = 0 Then

               

                MsgBox("Błędna nazwa użytkownika lub błędne hasło!")



            Else

                cmd2 = "select u_id from users where u_name = '" & uzytkownik.Text & "' and pasw ='" & haslo.Text & "';"
                Call polacz()
                data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds2 = New DataSet
                data2.Fill(ds2, "dele")
                tabelad2 = ds2.Tables("dele")

                inigconnect.Close()
                str = tabelad2.Rows(0).Item(0).ToString()

                cmd2 = "select max(nr_l)as cos from dlogowania;"
                Call polacz()
                data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds2 = New DataSet
                data2.Fill(ds2, "cos")
                tabelad2 = ds2.Tables("cos")
                inigconnect.Close()

                nrl = Val(tabelad2.Rows(0).Item(0).ToString)
                nrl2 = nrl + 1


                cmd2 = "insert into dlogowania  values ( '" & nrl2 & "','" & str & "','" & Now() & "');"
                Call polacz()
                data2 = New SqlDataAdapter(cmd2, inigconnect)
                ds2 = New DataSet
                data2.Fill(ds2, "dele")
                tabelad2 = ds2.Tables("dele")

                inigconnect.Close()


                Me.Close()

                glowny.Enabled = True
                glowny.cosik2.Visible = True

            End If

        End If



    End Sub


    Private Sub haslo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles haslo.TextChanged

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub BackgroundWorker5_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker4_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker9_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker8_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker7_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker6_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker11_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker10_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker4_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork

    End Sub

    Private Sub BackgroundWorker3_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork

    End Sub

    Private Sub BackgroundWorker2_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub

    Private Sub BackgroundWorker1_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub BackgroundWorker8_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork

    End Sub

    Private Sub BackgroundWorker6_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork

    End Sub

    Private Sub BackgroundWorker5_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork

    End Sub

    Private Sub BackgroundWorker9_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker9.DoWork

    End Sub
End Class
