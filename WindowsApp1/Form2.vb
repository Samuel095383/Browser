Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Motore_di_ricerca = TextBox1.Text
        My.Settings.Save()
        MsgBox("Inpostazioni salvate")



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Motore_di_ricerca

    End Sub
End Class