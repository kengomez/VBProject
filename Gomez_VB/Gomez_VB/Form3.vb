Public Class Form3

    Dim y As String = Form2.txtboxname.Text.ToLower
    Dim l As Integer
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowProfile(y)
    End Sub

    Private Sub ShowProfile(ByRef x As String)
        If x.StartsWith("a") Then
            lbl1.Text = "Adique, Jeadalyn P."
            lbl2.Text = "Asuncion, Harold"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09056251256"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09481382562"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("b") Then
            lbl1.Text = "Belen, Eljun"
            lbl2.Text = "Borres, Grace Loraine M."
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09353106774"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09359926208"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("c") Then
            lbl1.Text = "Castro, Liezel E."
            lbl2.Text = "Clemente, Gilbert"
            lblprof1.Text = "Age: 20" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09158354064"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09477899129"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("d") Then
            lbl1.Text = "Dacanay, Julius"
            lbl2.Text = "Dela Cruz, Patricia"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09266297389"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09228805436"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("e") Then
            lbl1.Text = "Eleria, Veron Emil"
            lbl2.Text = "Eresuela, Michael Joshua G."
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09363200383"
            lblprof2.Text = "Age: 20" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09277138796"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("f") Then
            lbl1.Text = "Fabay, Nia Bernise"
            lbl2.Text = "Flores, Jhon Jourel"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09278782064"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09297872388"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("g") Then
            lbl1.Text = "Gener, Angela C."
            lbl2.Text = "Gomez, Kenneth Uriel M."
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09266796704"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09063395577"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("l") Then
            lbl1.Text = "Largo, Jeff Ray L."
            lbl2.Text = "Logmao, John Franz"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09155148490"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09063638587"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("m") Then
            lbl1.Text = "Magura, Edsel Roldan"
            lbl2.Text = "Montales, Christelle"
            lblprof1.Text = "Age: 19" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09481382562"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09481382562"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("n") Then
            lbl1.Text = "Natanawan, Michael"
            lbl2.Text = "Nera, Joey Aries A."
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09265767082"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09153898895"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("o") Then
            lbl1.Text = "Obmerga, Gladys"
            lbl2.Text = "Orpiada, Renzo"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09773951688"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gener: Male" & vbNewLine & "Contact No.: 09065078374"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("p") Then
            lbl1.Text = "Pal-lingayan, Pinky S."
            lbl2.Text = "Prianes, Gerome M."
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09066720034"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09353045214"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
             Verify(low, low1)

        ElseIf x.StartsWith("s") Then
            lbl1.Text = "Salvador, Jehrliten"
            lbl2.Text = "Son, Yrick Storme"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09151847402"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09101282200"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("u") Then
            lbl1.Text = "Umali, Emmanuel Daryl"
            lbl2.Text = "Umayam, Ynah"
            lblprof1.Text = "Age: 21" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09235981055"
            lblprof2.Text = "Age: 20" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09163339624"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        ElseIf x.StartsWith("v") Then
            lbl1.Text = "Varias, Ervin Miguel L."
            lbl2.Text = "Venus, Sunshine B."
            lblprof1.Text = "Age: 20" & vbNewLine & "Gender: Male" & vbNewLine & "Contact No.: 09265024344"
            lblprof2.Text = "Age: 21" & vbNewLine & "Gender: Female" & vbNewLine & "Contact No.: 09068014574"
            Dim low = lbl1.Text.ToLower
            Dim low1 = lbl2.Text.ToLower
            Verify(low, low1)

        Else
            MessageBox.Show("Missing Profile. Try another.")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Verify(ByRef low As String, ByRef low1 As String)
        Dim l = y.Length
        Dim a = low.Substring(0, l)
        Dim b = low1.Substring(0, l)
        If (y.Substring(0) = a) Or (y.Substring(0) = b) Then
            MessageBox.Show("Profile of " + y + " has found.")
        Else
            MessageBox.Show("Profile not found")
        End If
    End Sub
End Class