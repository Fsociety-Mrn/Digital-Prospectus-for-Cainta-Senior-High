

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
    Public Sub DrawHeader(e As Printing.PrintPageEventArgs, BOX As Rectangle(), font As Font(), currciculum As String, Optional yPos As Integer() = Nothing)
        ' Check if yPos is Nothing (not provided)
        If yPos Is Nothing Then
            ' Initialize with default values
            yPos = New Integer() {220, 215, 233, 218}
        End If

        e.Graphics.DrawRectangle(Pens.Black, BOX(0))
        e.Graphics.DrawRectangle(Pens.Black, BOX(1))
        e.Graphics.DrawRectangle(Pens.Black, BOX(2))
        e.Graphics.DrawRectangle(Pens.Black, BOX(3))
        e.Graphics.DrawString("              Senior High School " + vbNewLine + currciculum, font(0), Brushes.Black, 60, yPos(0))
        e.Graphics.DrawString("T I M E", font(1), Brushes.Black, 480, yPos(0))
        e.Graphics.DrawString("   Quarter       Final", font(0), Brushes.Black, 650, yPos(1))
        e.Graphics.DrawString("  1st     2nd   Grade", font(0), Brushes.Black, 650, yPos(2))
        e.Graphics.DrawString("___________", font(0), Brushes.Black, 650, yPos(3)) ' naghahati sa quarter at 1st at second


    End Sub
    Public Sub DrawCourse(e As Printing.PrintPageEventArgs, checkBox As CheckBox, textBox1 As TextBox, textBox2 As TextBox, label As String, yPos As Integer, font1 As Font, plus As Integer)
        Dim values As String() = {textBox1.Text, textBox2.Text}
        Dim positions As Integer() = {700, 655}
        Dim xPos As Integer = 60


        e.Graphics.DrawString(label, font1, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, yPos + plus)

        If checkBox.Checked Then
            For i As Integer = 0 To 1
                If Not String.IsNullOrEmpty(values(i)) Then
                    e.Graphics.DrawString(values(i), font1, Brushes.Black, positions(i), yPos)
                End If
            Next

            If Not String.IsNullOrEmpty(textBox1.Text) AndAlso Not String.IsNullOrEmpty(textBox2.Text) Then
                Dim avg As Integer = (CInt(textBox1.Text) + CInt(textBox2.Text)) / 2
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, yPos + plus)
                e.Graphics.DrawString(avg, font1, Brushes.Black, 755, yPos)
            End If
        End If
    End Sub

End Class