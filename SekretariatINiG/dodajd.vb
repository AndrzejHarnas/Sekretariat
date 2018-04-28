Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class dodajd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim tabelap As DataTable



        surname.DisplayMember = "p_id"

        If nrd.Text = "" Or surname.Text = "" Or nrzlec.Text = "" Or miejsce.Text = "" Or trans.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from delegacje where d_id ='" & nrd.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then





                cmd = "insert into delegacje values('" & nrd.Text & "','" & surname.Text & "','" & miejsce.Text & "','" & trans.Text & "','" & odkiedy.Value & "','" & DoKiedy.Value & "','" & nrzlec.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()


                Call wyjazdy()
                glowny.naglowek.Text = "Wyjazdy służbowe"
                glowny.dodajdel.Visible = False



                Me.Close()
            Else

                MsgBox("Delegacja o podanym numerze istnieje już w bazie danych")



            End If

        End If









    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nrd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrd.TextChanged

    End Sub

    Private Sub surname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surname.SelectedIndexChanged


    End Sub

    Private Sub names_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub zp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub odkiedy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odkiedy.ValueChanged

    End Sub

    Private Sub DoKiedy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoKiedy.ValueChanged

    End Sub

    Private Sub nrzlec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrzlec.TextChanged

    End Sub

    Private Sub dodajd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub surname2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub nastepny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastepny.Click

        Dim cmd As String
        Dim ds As DataSet
        Dim data As SqlDataAdapter
        Dim tabelad As DataTable
        Dim cmd2 As String
        Dim data2 As SqlDataAdapter
        Dim tabelap As DataTable



        surname.DisplayMember = "p_id"

        If nrd.Text = "" Or surname.Text = "" Or nrzlec.Text = "" Or miejsce.Text = "" Or trans.Text = "" Then

            MsgBox("Wypełnij wszystkie pola formularza!")

        Else

            cmd2 = "select * from delegacje where d_id ='" & nrd.Text & "';"
            data2 = New SqlDataAdapter(cmd2, inigconnect)
            ds = New DataSet
            data2.Fill(ds, "prac")
            tabelap = ds.Tables("prac")

            'MsgBox(tabelap.Rows.Count)

            If tabelap.Rows.Count = 0 Then





                cmd = "insert into delegacje values('" & nrd.Text & "','" & surname.Text & "','" & miejsce.Text & "','" & trans.Text & "','" & odkiedy.Value & "','" & DoKiedy.Value & "','" & nrzlec.Text & "');"
                data = New SqlDataAdapter(cmd, inigconnect)
                ds = New DataSet
                data.Fill(ds, "dele")
                tabelad = ds.Tables("dele")


                inigconnect.Close()


                Call wyjazdy()


                Me.Close()

                Call jeszcze()
            Else

                MsgBox("Delegacja o podanym numerze istnieje już w bazie danych")



            End If

        End If



    End Sub
End Class
