Public Class Form2

    Dim surname As String
    Dim y As Boolean

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        surname = txtboxname.Text.ToLower
        ProfileCheck()
        If y = True Then
            Form3.Show()
            Me.Close()
        Else
            MessageBox.Show("No Matches.")
        End If
        txtboxname.Text = ""
    End Sub

    Private Sub ProfileCheck()
        If surname.StartsWith("a") = True Or surname.StartsWith("b") = True Or surname.StartsWith("c") = True Or surname.StartsWith("d") = True Or surname.StartsWith("e") = True Or surname.StartsWith("f") = True Or surname.StartsWith("g") = True Or surname.StartsWith("l") = True Or surname.StartsWith("m") = True Or surname.StartsWith("n") = True Or surname.StartsWith("o") = True Or surname.StartsWith("p") = True Or surname.StartsWith("s") = True Or surname.StartsWith("u") = True Or surname.StartsWith("v") = True Then
            y = True
            Return
        End If
    End Sub

End Class
