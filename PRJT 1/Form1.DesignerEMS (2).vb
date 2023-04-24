Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim note1 As Double
        Dim note2 As Double
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim moy As Double
        Const ce As Double = 3.0
        Const co As Double = 2.0
        ' note1 = InputBox(note1, "entrer la note d'ecrit")
        ' note2 = InputBox(note2, "entrer la note d'oral")


        moy = ((note1 * ce + note2 * co) / 5.0)
        MsgBox("la moyenne est " & moy)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        note1 = Val(TextBox1.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        note2 = Val(TextBox2.Text)
    End Sub
End Class
