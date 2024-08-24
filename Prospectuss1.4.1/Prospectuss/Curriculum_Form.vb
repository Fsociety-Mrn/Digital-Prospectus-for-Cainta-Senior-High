Imports System.Data.Common
Imports System.Net.Mime.MediaTypeNames

Public Class Curriculum_Form


    Private settings As New Settings()
    Private printSettings As New PrintSettings()
    Private Major As Panel
    Public Parameter As String
    Public MyLabel As String


    Private Sub Load_major()
        Select Case Parameter

            Case "ICT"
                Major = MajorICT
            Case "ELECT"
                Major = MajorElectrical

        End Select
    End Sub

    Private Sub Ict_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_major()

        Major.Location = New Point(431, 353)
        AppliedSubjects.Location = New Point(431, 353)

        Label1.Text = MyLabel

    End Sub

    '' Button to show all subjects
    Private Sub Button_Core_Click(sender As Object, e As EventArgs) Handles Button_Core.Click
        settings.Show_hide(CoreSubject, AppliedSubjects, Major, {True, False, False})
        Label17.Visible = True
        Label18.Visible = True
    End Sub

    Private Sub Button_Applied_Click(sender As Object, e As EventArgs) Handles Button_Applied.Click
        settings.Show_hide(CoreSubject, AppliedSubjects, Major, {False, True, False})
        Label17.Visible = False
        Label18.Visible = False
    End Sub

    Private Sub Button_Major_Click(sender As Object, e As EventArgs) Handles Button_Major.Click
        settings.Show_hide(CoreSubject, AppliedSubjects, Major, {False, False, True})
        Label17.Visible = False
        Label18.Visible = False
    End Sub

    '' button for close minizmize in back
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Parameter = ""
        MyLabel = ""
        STRANDS.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '' textbox filter for character and number only
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles NameBox.Enter
        settings.Cleartext(NameBox, "Type your Full Name")
    End Sub

    Private Sub Present_Enter(sender As Object, e As EventArgs) Handles present.Enter
        settings.Cleartext(present, "2016")
    End Sub

    Private Sub Future_Enter(sender As Object, e As EventArgs) Handles future.Enter
        settings.Cleartext(future, "2017")
    End Sub

    Private Sub School_Enter(sender As Object, e As EventArgs) Handles School.Enter
        settings.Cleartext(School, " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL")
    End Sub

    Private Sub NameBox_Leave(sender As Object, e As EventArgs) Handles NameBox.Leave
        settings.SetText(NameBox, "Type your Full Name")
    End Sub

    Private Sub Present_Leave(sender As Object, e As EventArgs) Handles present.Leave
        settings.SetText(present, "2016")
    End Sub
    Private Sub Future_Leave(sender As Object, e As EventArgs) Handles future.Leave
        settings.SetText(future, "2017")
    End Sub

    Private Sub School_Leave(sender As Object, e As EventArgs) Handles School.Leave
        settings.SetText(School, " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL")
    End Sub

    Private Sub NameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles School.KeyPress, NameBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox47_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox53.KeyPress, TextBox52.KeyPress, TextBox51.KeyPress, TextBox50.KeyPress, TextBox5.KeyPress, TextBox49.KeyPress, TextBox48.KeyPress, TextBox47.KeyPress, TextBox44.KeyPress, TextBox43.KeyPress, TextBox42.KeyPress, TextBox41.KeyPress, TextBox40.KeyPress, TextBox39.KeyPress, TextBox38.KeyPress, TextBox37.KeyPress, TextBox36.KeyPress, TextBox35.KeyPress, TextBox34.KeyPress, TextBox33.KeyPress, TextBox32.KeyPress, TextBox31.KeyPress, TextBox30.KeyPress, TextBox26.KeyPress, TextBox25.KeyPress, TextBox24.KeyPress, TextBox23.KeyPress, TextBox22.KeyPress, TextBox21.KeyPress, TextBox20.KeyPress, TextBox19.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, present.KeyPress, future.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox45_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox60.KeyPress, TextBox59.KeyPress, TextBox58.KeyPress, TextBox57.KeyPress, TextBox56.KeyPress, TextBox55.KeyPress, TextBox54.KeyPress, TextBox46.KeyPress, TextBox45.KeyPress, TextBox29.KeyPress, TextBox28.KeyPress, TextBox27.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    '' Handle check change in Core Subject 
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox22.CheckedChanged, CheckBox21.CheckedChanged, CheckBox20.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox17.CheckedChanged, CheckBox16.CheckedChanged, CheckBox15.CheckedChanged, CheckBox14.CheckedChanged, CheckBox13.CheckedChanged, CheckBox12.CheckedChanged, CheckBox11.CheckedChanged, CheckBox10.CheckedChanged
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name

            Case "CheckBox9"
                settings.HandleTextBoxState(checkbox, TextBox38, TextBox13)
            Case "CheckBox10"
                settings.HandleTextBoxState(checkbox, TextBox39, TextBox14)
            Case "CheckBox11"
                settings.HandleTextBoxState(checkbox, TextBox40, TextBox15)
            Case "CheckBox12"
                settings.HandleTextBoxState(checkbox, TextBox41, TextBox16)
            Case "CheckBox13"
                settings.HandleTextBoxState(checkbox, TextBox42, TextBox17)
            Case "CheckBox14"
                settings.HandleTextBoxState(checkbox, TextBox43, TextBox18)
            Case "CheckBox15"
                settings.HandleTextBoxState(checkbox, TextBox44, TextBox19)

            Case "CheckBox16"
                settings.HandleTextBoxState(checkbox, TextBox47, TextBox20)
            Case "CheckBox17"
                settings.HandleTextBoxState(checkbox, TextBox48, TextBox21)
            Case "CheckBox18"
                settings.HandleTextBoxState(checkbox, TextBox49, TextBox22)
            Case "CheckBox19"
                settings.HandleTextBoxState(checkbox, TextBox33, TextBox8)
            Case "CheckBox20"
                settings.HandleTextBoxState(checkbox, TextBox51, TextBox24)
            Case "CheckBox21"
                settings.HandleTextBoxState(checkbox, TextBox52, TextBox25)
            Case "CheckBox22"
                settings.HandleTextBoxState(checkbox, TextBox53, TextBox26)
            Case "CheckBox8"
                settings.HandleTextBoxState(checkbox, TextBox37, TextBox12)


        End Select
    End Sub

    '' Handle check change in Applied Subject 
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name

            Case "CheckBox1"
                settings.HandleTextBoxState(checkbox, TextBox30, TextBox5)
            Case "CheckBox2"
                settings.HandleTextBoxState(checkbox, TextBox31, TextBox6)
            Case "CheckBox3"
                settings.HandleTextBoxState(checkbox, TextBox32, TextBox7)
            Case "CheckBox4"
                settings.HandleTextBoxState(checkbox, TextBox50, TextBox23)
            Case "CheckBox5"
                settings.HandleTextBoxState(checkbox, TextBox34, TextBox9)
            Case "CheckBox6"
                settings.HandleTextBoxState(checkbox, TextBox35, TextBox10)
            Case "CheckBox7"
                settings.HandleTextBoxState(checkbox, TextBox36, TextBox11)

        End Select
    End Sub
    '' Handle check change in Major ICT Subject
    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged, CheckBox27.CheckedChanged, CheckBox26.CheckedChanged, CheckBox25.CheckedChanged, CheckBox24.CheckedChanged, CheckBox23.CheckedChanged
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name

            Case "CheckBox23"
                settings.HandleTextBoxState(checkbox, TextBox54, TextBox27)
            Case "CheckBox24"
                settings.HandleTextBoxState(checkbox, TextBox55, TextBox28)
            Case "CheckBox25"
                settings.HandleTextBoxState(checkbox, TextBox56, TextBox29)
            Case "CheckBox26"
                settings.HandleTextBoxState(checkbox, TextBox46, TextBox45)
            Case "CheckBox27"
                settings.HandleTextBoxState(checkbox, TextBox58, TextBox57)
            Case "CheckBox28"
                settings.HandleTextBoxState(checkbox, TextBox60, TextBox59)

        End Select
    End Sub

    '' Immersion button in Major ICT Subjects
    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then

            Do While Panel5.Height < 77
                Panel5.Height += 1
            Loop
        Else
            Do While Panel5.Height > 0
                Panel5.Height -= 1
            Loop
            TextBox63.Text = ""
            TextBox64.Text = ""
        End If
    End Sub

    '' Handle check change in Major Electrical Subject
    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged, CheckBox32.CheckedChanged, CheckBox31.CheckedChanged
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name

            Case "CheckBox31"
                settings.HandleTextBoxState(checkbox, TextBox65, TextBox61)
            Case "CheckBox33"
                settings.HandleTextBoxState(checkbox, TextBox62, TextBox4)
            Case "CheckBox32"
                settings.HandleTextBoxState(checkbox, TextBox66, TextBox3)

        End Select
    End Sub

    '' Immersion button in Major Electrical Subjects
    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox29.Checked = True Then

            Do While Panel3.Height < 77
                Panel3.Height += 1
            Loop
        Else
            Do While Panel3.Height > 0
                Panel3.Height -= 1
            Loop
            TextBox3.Text = ""
            TextBox2.Text = ""
        End If
    End Sub


    '' Print setup
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim a As Bitmap = My.Resources.even_lower_res 'Left CSHS
        Dim b As Bitmap = My.Resources.DEPED 'Right DEPED
        Dim c As Bitmap = My.Resources.SCHOOL 'Background Images
        Dim r As New Rectangle(730, 20, 60, 60) 'Left CSHS
        Dim rr As New Rectangle(80, 20, 60, 60) 'Right DEPED
        Dim rrr As New Rectangle(30, 250, 800, 800) 'Background Images

        Dim BOX As New Rectangle(51, 215, 744, 1030) 'WHOLE BOX
        Dim h1box As New Rectangle(51, 215, 744, 44) 'FIRST BOX
        Dim h2box As New Rectangle(51, 710, 744, 44) 'SECOND BOX
        Dim h3box As New Rectangle(51, 920, 744, 44) 'THIRD BOX
        Dim V1box As New Rectangle(650, 215, 145, 1030) 'first Vertical Box
        Dim VV1box As New Rectangle(695, 259, 44, 451) 'first short vertical box
        Dim VV2box As New Rectangle(695, 754, 44, 166) 'second short vertical box
        Dim VV3box As New Rectangle(695, 964, 44, 151) 'third vertical box

        e.Graphics.DrawImage(a, r) 'Left CSHS
        e.Graphics.DrawImage(b, rr)  'Right DEPED
        e.Graphics.DrawImage(c, rrr) 'Background Images


        Dim font1 As New Font("Century Gothic", 11, FontStyle.Bold)
        Dim font2 As New Font("Century Gothic", 11, FontStyle.Bold)
        Dim font3 As New Font("Century Gothic", 20, FontStyle.Bold)
        Dim font33 As New Font("Century Gothic", 10, FontStyle.Bold)
        Dim T As New Font("Century Gothic", 20, FontStyle.Regular)
        Dim ff1 As New Font("Century Gothic", 6, FontStyle.Bold)

        'Headings
        e.Graphics.DrawString("CAINTA SENIOR HIGH SCHOOL", font3, Brushes.Black, 220, 30)
        e.Graphics.DrawString("PROSPECTUS", font33, Brushes.Black, 380, 60)
        e.Graphics.DrawString("S.Y." + TextBox61.Text + "-" + TextBox62.Text, font1, Brushes.Black, 375, 75)

        Dim StudentStatus As New Dictionary(Of RadioButton, String) From {
            {RadioButton1, "Transferee  ( ✓ )"},
            {RadioButton2, "Irregular   ( ✓ )"},
            {RadioButton3, "Alternative Learning System ('ALS')   ( ✓ )"},
            {RadioButton4, "Regular   ( ✓ )"}
        }

        '' Print Selection
        printSettings.DrawRadioButtonSelection(e, StudentStatus, font1, School)

        e.Graphics.DrawString("DATE: " + Date.Now.ToString("MM/dd/yyyy") + vbNewLine + "TVL - ICT", font2, Brushes.Black, 660, 90)
        e.Graphics.DrawString("Region : " + ComboBox1.Text, font1, Brushes.Black, 70, 145)

        '' Print header Core Curriculum
        printSettings.DrawHeader(e, {BOX, h1box, V1box, VV1box}, {font1, T, ff1}, "                Core Curriculum")

        '' Print Core Subjects
        Dim courses As (CheckBox, TextBox, TextBox, String, Integer)() = {
            (CheckBox9, TextBox38, TextBox13, "  • Oral Communication", 250),
            (CheckBox10, TextBox6, TextBox31, "  • Reading And Writing", 270),
            (CheckBox11, TextBox7, TextBox32, "  • Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", 290),
            (CheckBox12, TextBox8, TextBox33, "  • Pagbasa at Pagsusuri ng imba't iba't ibang" + vbNewLine + "       Teksto Tungo sa Panaliksisk", 330),
            (CheckBox13, TextBox9, TextBox34, "  • 21st Century Literature " + vbNewLine + "       Fr. Phil to World", 370),
            (CheckBox14, TextBox10, TextBox35, "  • Contemporary Philippine Arts" + vbNewLine + "       from the Regions", 410),
            (CheckBox15, TextBox7, TextBox32, "  • Media and Information Literacy", 450),
            (CheckBox16, TextBox8, TextBox33, "  • General Math", 470),
            (CheckBox17, TextBox9, TextBox34, "  • Statistics and Probability", 490),
            (CheckBox18, TextBox10, TextBox35, "  • Earth and Life Science", 510),
            (CheckBox19, TextBox7, TextBox32, "  • Physical Science", 530),
            (CheckBox20, TextBox8, TextBox33, "  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", 570),
            (CheckBox21, TextBox9, TextBox34, "  • Personal Development", 590),
            (CheckBox22, TextBox10, TextBox35, "  • Contemporary Philippine Arts" + vbNewLine + "       from the Regions", 610),
            (CheckBox8, TextBox7, TextBox32, "  • Media and Information Literacy", 450),
            (CheckBox4, TextBox8, TextBox33, "  • General Math", 470),
            (CheckBox5, TextBox9, TextBox34, "  • Statistics and Probability", 490),
            (CheckBox6, TextBox10, TextBox35, "  • Understanding Culture, " + vbNewLine + "      Society and Politics", 650)
        }

        For Each course In courses
            printSettings.DrawCourse(e, course.Item1, course.Item2, course.Item3, course.Item4, course.Item5, font1)
        Next

    End Sub

    '' preview print
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "Type your Full Name" Or TextBox4.Enabled = True And TextBox4.Text = " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Or TextBox62.Text = "2017" And TextBox61.Text = "2016" Then
            MessageBox.Show("Please fill out your name, age,last school attended if transferee" + vbNewLine + " and  Please Select region, School Year.", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case MessageBox.Show("Please set the paper 'size from Letter' into 'Legal' ", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok

                    PageSetupDialog1.Document.DefaultPageSettings.Color = True
                    PageSetupDialog1.ShowDialog()
                    PrintPreviewDialog1.ShowDialog()
            End Select

            ''

        End If
    End Sub

    '' Irregular
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        School.Enabled = False
        School.Text = "Cainta Senior High School"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton1.CheckedChanged
        School.Enabled = True
        School.Text = " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
    End Sub
End Class