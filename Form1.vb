Public Class Form1

    Private NUM_OF_CANS As Integer = 6
    Dim rd As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Return
        End If

        If CInt(TextBox2.Text) > 100 Then
            TextBox2.Text = "100"
        End If

        If CInt(TextBox1.Text) > 15 Then
            TextBox1.Text = "15"
        End If

        Dim nums As New List(Of UInteger)

        Dim v = CInt(TextBox1.Text)

        ListView1.Items.Clear()

        For k = 0 To CInt(TextBox2.Text) * NUM_OF_CANS - 1
            Dim j As String = ""
            For i As Integer = 0 To v - 1
                Dim l = rd.Next(10)
                j = j & l
            Next
            ListView1.Items.Add(j)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        RichTextBox1.
            Text = ""

        Dim v = 0

        For k = 0 To ListView1.Items.Count - 1
            RichTextBox1.Text = RichTextBox1.Text & ListView1.Items(k).ToString & Environment.NewLine
            v = v + 1
            If v Mod 6 = 0 Then
                RichTextBox1.Text = RichTextBox1.Text & Environment.NewLine
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
