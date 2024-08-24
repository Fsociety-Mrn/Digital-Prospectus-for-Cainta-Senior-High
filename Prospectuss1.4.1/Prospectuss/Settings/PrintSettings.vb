

Public Class PrintSettings
    '' Show Student Status
    Public Sub DrawRadioButtonSelection(e As Printing.PrintPageEventArgs, radioTextMap As Dictionary(Of RadioButton, String), font1 As Font, textbox As TextBox)

        Dim selectedText As String = ""
        For Each kvp As KeyValuePair(Of RadioButton, String) In radioTextMap
            If kvp.Key.Checked Then
                selectedText = kvp.Value
                Exit For
            End If
        Next
        If Not String.IsNullOrEmpty(selectedText) Then
            e.Graphics.DrawString($"{selectedText}{vbNewLine}Last School Attended: {textbox.Text}", font1, Brushes.Black, 70, 110)
        End If
    End Sub

    '' Show Header
    Public Sub DrawHeader(e As Printing.PrintPageEventArgs, BOX As Rectangle(), font As Font(), currciculum As String)

        e.Graphics.DrawRectangle(Pens.Black, BOX(0))
        e.Graphics.DrawRectangle(Pens.Black, BOX(1))
        e.Graphics.DrawRectangle(Pens.Black, BOX(2))
        e.Graphics.DrawRectangle(Pens.Black, BOX(3))
        e.Graphics.DrawString("              Senior High School " + vbNewLine + currciculum, font(0), Brushes.Black, 60, 220)
        e.Graphics.DrawString("T I M E", font(1), Brushes.Black, 480, 220)
        e.Graphics.DrawLine(Pens.Black, 395, 215, 395, 1245) 'Line to First Box to Third Box
        e.Graphics.DrawLine(Pens.Black, 739, 215, 739, 259) ' basta line sa time
        e.Graphics.DrawString("   Quarter       Final", font(0), Brushes.Black, 650, 215)
        e.Graphics.DrawLine(Pens.Black, 695, 239, 695, 259) ' basta line din sya sa lien sa time
        e.Graphics.DrawString("  1st     2nd   Grade", font(0), Brushes.Black, 650, 233)
        e.Graphics.DrawString(" Semester   Semester ", font(2), Brushes.Black, 650, 248)
        e.Graphics.DrawString("___________", font(0), Brushes.Black, 650, 218) ' naghahati sa quarter at 1st at second


    End Sub
    Public Sub DrawCourse(e As Printing.PrintPageEventArgs, checkBox As CheckBox, textBox1 As TextBox, textBox2 As TextBox, label As String, yPos As Integer, font1 As Font)
        Dim values As String() = {textBox1.Text, textBox2.Text}
        Dim positions As Integer() = {700, 655}
        Dim xPos As Integer = 60

        e.Graphics.DrawString(label, font1, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, yPos)

        If checkBox.Checked Then
            For i As Integer = 0 To 1
                If Not String.IsNullOrEmpty(values(i)) Then
                    e.Graphics.DrawString(values(i), font1, Brushes.Black, positions(i), yPos)
                End If
            Next

            If Not String.IsNullOrEmpty(textBox1.Text) AndAlso Not String.IsNullOrEmpty(textBox2.Text) Then
                Dim avg As Integer = (CInt(textBox1.Text) + CInt(textBox2.Text)) / 2
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, yPos)
                e.Graphics.DrawString(avg, font1, Brushes.Black, 755, yPos)
            End If
        End If
    End Sub

End Class
