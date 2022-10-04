
Public Class Gas
    Private MAX_PAGE_COUNT As Integer = 1
    Private pageNumber As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        STRANDS.Show()
        Me.Hide()
        Label6.Text = "Core Curriculum Subjects"

        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray
        ComboBox1.Text = "Select Region"
        ComboBox1.ForeColor = Color.Gray
        TextBox1.Text = "Type your Full Name"
        TextBox1.ForeColor = Color.Gray
        TextBox56.Text = "2016"
        TextBox56.ForeColor = Color.Gray
        TextBox29.Text = "2017"
        TextBox29.ForeColor = Color.Gray
        RadioButton2.Checked = True



        ''Hummanities
        CheckBox10.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False

        ''ABM
        CheckBox41.Checked = False
        CheckBox39.Checked = False
        CheckBox24.Checked = False
        CheckBox42.Checked = False
        CheckBox30.Checked = False
        CheckBox40.Checked = False
        CheckBox23.Checked = False
        ''STEM
        a.Checked = False
        b.Checked = False
        c.Checked = False
        d.Checked = False
        aa.Checked = False
        bb.Checked = False
        dd.Checked = False
        cc.Checked = False
        dd.Checked = False

        ''STEM
        Button17.Visible = False
        Button15.Visible = False

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = False

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

        'Subjects and Quarter
        Label17.Visible = True
        Label18.Visible = True

        'Core

        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        CheckBox7.Visible = True
        CheckBox8.Visible = True
        CheckBox9.Visible = True

        CheckBox11.Visible = True
        CheckBox12.Visible = True
        CheckBox13.Visible = True
        CheckBox14.Visible = True
        CheckBox15.Visible = True

        'enabled core

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False

        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False


        TextBox30.Visible = True
        TextBox31.Visible = True
        TextBox32.Visible = True
        TextBox33.Visible = True
        TextBox34.Visible = True
        TextBox35.Visible = True
        TextBox36.Visible = True
        TextBox37.Visible = True

        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True

        TextBox13.Visible = True
        TextBox14.Visible = True
        TextBox15.Visible = True
        TextBox16.Visible = True
        TextBox17.Visible = True
        TextBox18.Visible = True
        TextBox19.Visible = True


        TextBox38.Visible = True
        TextBox39.Visible = True
        TextBox40.Visible = True
        TextBox41.Visible = True
        TextBox42.Visible = True
        TextBox43.Visible = True
        TextBox44.Visible = True

        'Applied
        CheckBox16.Visible = False
        CheckBox17.Visible = False
        CheckBox18.Visible = False
        CheckBox19.Visible = False
        CheckBox20.Visible = False
        CheckBox21.Visible = False
        CheckBox22.Visible = False

        'enabled false applied

        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False

        TextBox47.Visible = False
        TextBox48.Visible = False
        TextBox49.Visible = False
        TextBox50.Visible = False
        TextBox51.Visible = False
        TextBox52.Visible = False
        TextBox53.Visible = False

        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False


        'Specialized
        CheckBox26.Visible = False
        CheckBox27.Visible = False
        CheckBox28.Visible = False
        CheckBox29.Visible = False

        'enbled false major/specialized Checked

        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False

      
        TextBox57.Visible = False
        TextBox58.Visible = False
        TextBox59.Visible = False
        TextBox60.Visible = False
        TextBox61.Visible = False
        TextBox62.Visible = False
        TextBox63.Visible = False
        TextBox64.Visible = False
        Panel2.Visible = False

        Button12.Visible = False
        Button12.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label6.Text = "Core Curriculum Subjects"

        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray
        ComboBox1.Text = "Select Region"
        ComboBox1.ForeColor = Color.Gray
        TextBox1.Text = "Type your Full Name"
        TextBox1.ForeColor = Color.Gray
        TextBox56.Text = "2016"
        TextBox56.ForeColor = Color.Gray
        TextBox29.Text = "2017"
        TextBox29.ForeColor = Color.Gray
        RadioButton2.Checked = True


        ''Hummanities
        CheckBox10.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False

        ''ABM
        CheckBox41.Checked = False
        CheckBox39.Checked = False
        CheckBox24.Checked = False
        CheckBox42.Checked = False
        CheckBox30.Checked = False
        CheckBox40.Checked = False
        CheckBox23.Checked = False
        ''STEM
        a.Checked = False
        b.Checked = False
        c.Checked = False
        d.Checked = False
        aa.Checked = False
        bb.Checked = False
        dd.Checked = False
        cc.Checked = False
        dd.Checked = False
       
        ''STEM
        Button17.Visible = False
        Button15.Visible = False

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = False

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

        'Subjects and Quarter
        Label17.Visible = True
        Label18.Visible = True

        'Core

        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        CheckBox7.Visible = True
        CheckBox8.Visible = True
        CheckBox9.Visible = True

        CheckBox11.Visible = True
        CheckBox12.Visible = True
        CheckBox13.Visible = True
        CheckBox14.Visible = True
        CheckBox15.Visible = True

        'enabled core

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False


        TextBox30.Visible = True
        TextBox31.Visible = True
        TextBox32.Visible = True
        TextBox33.Visible = True
        TextBox34.Visible = True
        TextBox35.Visible = True
        TextBox36.Visible = True
        TextBox37.Visible = True

        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True

        TextBox13.Visible = True
        TextBox14.Visible = True
        TextBox15.Visible = True
        TextBox16.Visible = True
        TextBox17.Visible = True
        TextBox18.Visible = True
        TextBox19.Visible = True


        TextBox38.Visible = True
        TextBox39.Visible = True
        TextBox40.Visible = True
        TextBox41.Visible = True
        TextBox42.Visible = True
        TextBox43.Visible = True
        TextBox44.Visible = True

        'Applied
        CheckBox16.Visible = False
        CheckBox17.Visible = False
        CheckBox18.Visible = False
        CheckBox19.Visible = False
        CheckBox20.Visible = False
        CheckBox21.Visible = False
        CheckBox22.Visible = False

        'enabled false applied

        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False

        TextBox47.Visible = False
        TextBox48.Visible = False
        TextBox49.Visible = False
        TextBox50.Visible = False
        TextBox51.Visible = False
        TextBox52.Visible = False
        TextBox53.Visible = False

        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False


        'Specialized
        CheckBox26.Visible = False
        CheckBox27.Visible = False
        CheckBox28.Visible = False
        CheckBox29.Visible = False

         'enbled false major/specialized Checked

        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False
        TextBox57.Visible = False
        TextBox58.Visible = False
        TextBox59.Visible = False
        TextBox60.Visible = False
        TextBox61.Visible = False
        TextBox62.Visible = False
        TextBox63.Visible = False
        TextBox64.Visible = False
        Panel2.Visible = False

        Button12.Visible = False
        Button12.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage




        If Me.pageNumber = MAX_PAGE_COUNT Then

            Dim a As Bitmap = My.Resources.even_lower_res 'Left CSHS
            Dim b As Bitmap = My.Resources.DEPED 'Right DEPED
            Dim c As Bitmap = My.Resources.SCHOOL 'Background Images
            Dim r As New Rectangle(720, 30, 70, 70) 'Left CSHS
            Dim rr As New Rectangle(80, 30, 70, 70) 'Right DEPED
            Dim rrr As New Rectangle(25, 300, 800, 800) 'Background Images

            Dim BOX As New Rectangle(51, 215, 744, 1075) 'WHOLE BOX
            Dim h1box As New Rectangle(51, 215, 744, 44) 'FIRST BOX
            Dim h2box As New Rectangle(51, 710, 744, 44) 'SECOND BOX
            Dim h3box As New Rectangle(51, 920, 744, 44) 'THIRD BOX
            Dim h3bbox As New Rectangle(51, 964, 599, 44) 'Humms I BOX

            Dim V1box As New Rectangle(650, 215, 145, 1075) 'first Vertical Box
            Dim VV1box As New Rectangle(695, 259, 44, 451) 'first short vertical box
            Dim VV2box As New Rectangle(695, 754, 44, 166) 'second short vertical box
            Dim VV3box As New Rectangle(695, 964, 44, 326) 'third short vertical box

            e.Graphics.DrawImage(a, r) 'Left CSHS
            e.Graphics.DrawImage(b, rr)  'Right DEPED
            e.Graphics.DrawImage(c, rrr) 'Background Images


            Dim font1 As New Font("Century Gothic", 11, FontStyle.Bold)
            Dim font2 As New Font("Century Gothic", 11, FontStyle.Bold)
            Dim font3 As New Font("Century Gothic", 20, FontStyle.Bold)
            Dim font33 As New Font("Century Gothic", 10, FontStyle.Bold)
            Dim T As New Font("Century Gothic", 20, FontStyle.Regular)

            'Headings
            e.Graphics.DrawString("CAINTA SENIOR HIGH SCHOOL", font3, Brushes.Black, 220, 40)
            e.Graphics.DrawString("PROSPECTUS", font33, Brushes.Black, 380, 70)
            e.Graphics.DrawString("S.Y." + TextBox56.Text + "-" + TextBox29.Text, font1, Brushes.Black, 373, 90)

            e.Graphics.DrawString("Name: " + TextBox1.Text + vbNewLine + "Region : " + ComboBox1.Text, font2, Brushes.Black, 70, 115)
            If RadioButton1.Checked = True Then
                e.Graphics.DrawString("Transferee  ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 170)
            End If
            If RadioButton2.Checked = True Then
                e.Graphics.DrawString("Irregular   ( ✓ )" + vbNewLine + "Last School Attended: " + "Cainta Senior High School", font1, Brushes.Black, 70, 170)
            End If
            If RadioButton4.Checked = True Then
                e.Graphics.DrawString("Regular  ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 170)
            End If
            If RadioButton3.Checked = True Then
                e.Graphics.DrawString("ALS Passer  ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 170)
            End If
            e.Graphics.DrawString("DATE: " + Date.Now.ToString("MM/dd/yyyy") + vbNewLine + "ACAD - GAS", font2, Brushes.Black, 660, 115)

            'Core Curriculum
            e.Graphics.DrawRectangle(Pens.Black, BOX)
            e.Graphics.DrawRectangle(Pens.Black, h1box)
            e.Graphics.DrawRectangle(Pens.Black, V1box)
            e.Graphics.DrawRectangle(Pens.Black, VV1box)
            e.Graphics.DrawString("              Senior High School " + vbNewLine +
                                  "                Core Curriculum", font1, Brushes.Black, 50, 220)
            e.Graphics.DrawString("T I M E", T, Brushes.Black, 480, 220)
            e.Graphics.DrawLine(Pens.Black, 395, 215, 395, 1290) 'Line to First Box to Third Box
            e.Graphics.DrawLine(Pens.Black, 739, 215, 739, 259) ' basta line sa time
            e.Graphics.DrawString("   Quarter       Final", font1, Brushes.Black, 650, 215)
            e.Graphics.DrawLine(Pens.Black, 695, 239, 695, 259) ' basta line din sya sa time
            e.Graphics.DrawString("  1st     2nd   Grade", font1, Brushes.Black, 650, 233)
            Dim ff1 As New Font("Century Gothic", 6, FontStyle.Bold)

            e.Graphics.DrawString(" Semester   Semester ", ff1, Brushes.Black, 650, 248)

            e.Graphics.DrawString("___________", font1, Brushes.Black, 650, 218) ' naghahati sa quarter at 1st at second


            Try

                If CheckBox1.Checked = False Then
                    e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 280)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 280)
                ElseIf TextBox5.Text = "" Then
                    e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 280)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 280)
                    e.Graphics.DrawString(TextBox30.Text, font1, Brushes.Black, 655, 280)
                ElseIf TextBox30.Text = "" Then
                    e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 280)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 280)
                    e.Graphics.DrawString(TextBox5.Text, font1, Brushes.Black, 700, 280)
                Else
                    Dim a1 As Integer = CInt(TextBox5.Text)
                    Dim b2 As Integer = CInt(TextBox30.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 280)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 280)
                    e.Graphics.DrawString(TextBox5.Text, font1, Brushes.Black, 700, 280)
                    e.Graphics.DrawString(TextBox30.Text, font1, Brushes.Black, 655, 280)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 280)
                End If

                If CheckBox2.Checked = False Then
                    e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 300)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 300)
                ElseIf TextBox6.Text = "" Then
                    e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 300)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 300)
                    e.Graphics.DrawString(TextBox31.Text, font1, Brushes.Black, 655, 300)
                ElseIf TextBox31.Text = "" Then
                    e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 300)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 300)
                    e.Graphics.DrawString(TextBox6.Text, font1, Brushes.Black, 700, 300)
                Else
                    Dim aa1 As Integer = CInt(TextBox6.Text)
                    Dim bb2 As Integer = CInt(TextBox31.Text)
                    Dim cc3 As Integer = (aa1 + bb2) / 2
                    e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 300)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 300)
                    e.Graphics.DrawString(TextBox6.Text, font1, Brushes.Black, 700, 300)
                    e.Graphics.DrawString(TextBox31.Text, font1, Brushes.Black, 655, 300)
                    e.Graphics.DrawString(cc3, font1, Brushes.Black, 750, 300)
                End If



                If CheckBox3.Checked = False Then
                    e.Graphics.DrawString("  • Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 320)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 340)
                ElseIf TextBox7.Text = "" Then
                    e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 320)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 340)
                    e.Graphics.DrawString(TextBox32.Text, font1, Brushes.Black, 655, 340)
                ElseIf TextBox32.Text = "" Then
                    e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 320)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 340)
                    e.Graphics.DrawString(TextBox7.Text, font1, Brushes.Black, 700, 340)
                Else
                    Dim a1 As Integer = CInt(TextBox7.Text)
                    Dim b2 As Integer = CInt(TextBox32.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 320)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 340)
                    e.Graphics.DrawString(TextBox7.Text, font1, Brushes.Black, 700, 340)
                    e.Graphics.DrawString(TextBox32.Text, font1, Brushes.Black, 655, 340)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 340)
                End If


                If CheckBox4.Checked = False Then
                    e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                          "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 360)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 380)
                ElseIf TextBox8.Text = "" Then
                    e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                              "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 360)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 380)
                    e.Graphics.DrawString(TextBox33.Text, font1, Brushes.Black, 655, 380)
                ElseIf TextBox33.Text = "" Then
                    e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                              "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 360)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 380)
                    e.Graphics.DrawString(TextBox8.Text, font1, Brushes.Black, 700, 380)
                Else
                    Dim a4 As Integer = CInt(TextBox8.Text)
                    Dim b4 As Integer = CInt(TextBox33.Text)
                    Dim c4 As Integer = (a4 + b4) / 2
                    e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                              "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 360)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 380)
                    e.Graphics.DrawString(TextBox8.Text, font1, Brushes.Black, 700, 380)
                    e.Graphics.DrawString(TextBox33.Text, font1, Brushes.Black, 655, 380)
                    e.Graphics.DrawString(c4, font1, Brushes.Black, 750, 380)
                End If


                If CheckBox5.Checked = False Then
                    e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                          "       Fr. Phil to World", font1, Brushes.Black, 60, 400)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 420)
                ElseIf TextBox9.Text = "" Then
                    e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                              "       Fr. Phil to World", font1, Brushes.Black, 60, 400)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 420)
                    e.Graphics.DrawString(TextBox34.Text, font1, Brushes.Black, 655, 420)
                ElseIf TextBox34.Text = "" Then
                    e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                              "       Fr. Phil to World", font1, Brushes.Black, 60, 400)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 420)
                    e.Graphics.DrawString(TextBox9.Text, font1, Brushes.Black, 700, 420)
                Else
                    Dim a5 As Integer = CInt(TextBox9.Text)
                    Dim b5 As Integer = CInt(TextBox34.Text)
                    Dim c5 As Integer = (a5 + b5) / 2
                    e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                              "       Fr. Phil to World", font1, Brushes.Black, 60, 400)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 420)
                    e.Graphics.DrawString(TextBox9.Text, font1, Brushes.Black, 700, 420)
                    e.Graphics.DrawString(TextBox34.Text, font1, Brushes.Black, 655, 420)
                    e.Graphics.DrawString(c5, font1, Brushes.Black, 750, 420)
                End If


                If CheckBox6.Checked = False Then
                    e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                          "       from the Regions", font1, Brushes.Black, 60, 440)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 460)
                ElseIf TextBox9.Text = "" Then
                    e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                              "       from the Regions", font1, Brushes.Black, 60, 440)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 460)
                    e.Graphics.DrawString(TextBox35.Text, font1, Brushes.Black, 655, 460)
                ElseIf TextBox35.Text = "" Then
                    e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                              "       from the Regions", font1, Brushes.Black, 60, 440)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 460)
                    e.Graphics.DrawString(TextBox10.Text, font1, Brushes.Black, 700, 460)
                Else
                    Dim a6 As Integer = CInt(TextBox10.Text)
                    Dim b6 As Integer = CInt(TextBox35.Text)
                    Dim c6 As Integer = (a6 + b6) / 2
                    e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                              "       from the Regions", font1, Brushes.Black, 60, 440)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 460)
                    e.Graphics.DrawString(TextBox10.Text, font1, Brushes.Black, 700, 460)
                    e.Graphics.DrawString(TextBox35.Text, font1, Brushes.Black, 655, 460)
                    e.Graphics.DrawString(c6, font1, Brushes.Black, 750, 460)
                End If


                If CheckBox7.Checked = False Then
                    e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 480)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 480)
                ElseIf TextBox11.Text = "" Then
                    e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 480)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 480)
                    e.Graphics.DrawString(TextBox36.Text, font1, Brushes.Black, 655, 480)
                ElseIf TextBox36.Text = "" Then
                    e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 480)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 480)
                    e.Graphics.DrawString(TextBox11.Text, font1, Brushes.Black, 700, 480)
                Else
                    Dim a7 As Integer = CInt(TextBox11.Text)
                    Dim b7 As Integer = CInt(TextBox36.Text)
                    Dim c7 As Integer = (a7 + b7) / 2
                    e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 480)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 480)
                    e.Graphics.DrawString(TextBox11.Text, font1, Brushes.Black, 700, 480)
                    e.Graphics.DrawString(TextBox36.Text, font1, Brushes.Black, 655, 480)
                    e.Graphics.DrawString(c7, font1, Brushes.Black, 750, 480)
                End If


                If CheckBox8.Checked = False Then
                    e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 500)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 500)
                ElseIf TextBox12.Text = "" Then
                    e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 500)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 500)
                    e.Graphics.DrawString(TextBox37.Text, font1, Brushes.Black, 655, 500)
                ElseIf TextBox37.Text = "" Then
                    e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 500)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 500)
                    e.Graphics.DrawString(TextBox12.Text, font1, Brushes.Black, 700, 500)
                Else
                    Dim a8 As Integer = CInt(TextBox12.Text)
                    Dim b8 As Integer = CInt(TextBox37.Text)
                    Dim c8 As Integer = (a8 + b8) / 2
                    e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 500)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 500)
                    e.Graphics.DrawString(TextBox12.Text, font1, Brushes.Black, 700, 500)
                    e.Graphics.DrawString(TextBox37.Text, font1, Brushes.Black, 655, 500)
                    e.Graphics.DrawString(c8, font1, Brushes.Black, 750, 500)
                End If

                If CheckBox14.Checked = False Then
                    e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 520)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 520)
                ElseIf TextBox13.Text = "" Then
                    e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 520)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 520)
                    e.Graphics.DrawString(TextBox38.Text, font1, Brushes.Black, 655, 520)
                ElseIf TextBox38.Text = "" Then
                    e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 520)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 520)
                    e.Graphics.DrawString(TextBox13.Text, font1, Brushes.Black, 700, 520)
                Else
                    Dim a9 As Integer = CInt(TextBox13.Text)
                    Dim b9 As Integer = CInt(TextBox38.Text)
                    Dim c9 As Integer = (a9 + b9) / 2
                    e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 520)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 520)
                    e.Graphics.DrawString(TextBox13.Text, font1, Brushes.Black, 700, 520)
                    e.Graphics.DrawString(TextBox38.Text, font1, Brushes.Black, 655, 520)
                    e.Graphics.DrawString(c9, font1, Brushes.Black, 750, 520)
                End If


                If CheckBox9.Checked = False Then
                    e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 540)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 540)
                ElseIf TextBox14.Text = "" Then
                    e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 540)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 540)
                    e.Graphics.DrawString(TextBox39.Text, font1, Brushes.Black, 655, 540)
                ElseIf TextBox39.Text = "" Then
                    e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 540)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 540)
                    e.Graphics.DrawString(TextBox14.Text, font1, Brushes.Black, 700, 540)
                Else
                    Dim a10 As Integer = CInt(TextBox14.Text)
                    Dim b10 As Integer = CInt(TextBox39.Text)
                    Dim c10 As Integer = (a10 + b10) / 2
                    e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 540)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 540)
                    e.Graphics.DrawString(TextBox14.Text, font1, Brushes.Black, 700, 540)
                    e.Graphics.DrawString(TextBox39.Text, font1, Brushes.Black, 655, 540)
                    e.Graphics.DrawString(c10, font1, Brushes.Black, 750, 540)
                End If


                If CheckBox11.Checked = False Then
                    e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 560)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 560)
                ElseIf TextBox15.Text = "" Then
                    e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 560)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 560)
                    e.Graphics.DrawString(TextBox40.Text, font1, Brushes.Black, 655, 560)
                ElseIf TextBox40.Text = "" Then
                    e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 560)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 560)
                    e.Graphics.DrawString(TextBox15.Text, font1, Brushes.Black, 700, 560)
                Else
                    Dim a11 As Integer = CInt(TextBox15.Text)
                    Dim b11 As Integer = CInt(TextBox40.Text)
                    Dim c11 As Integer = (a11 + b11) / 2
                    e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 560)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 560)
                    e.Graphics.DrawString(TextBox15.Text, font1, Brushes.Black, 700, 560)
                    e.Graphics.DrawString(TextBox40.Text, font1, Brushes.Black, 655, 560)
                    e.Graphics.DrawString(c11, font1, Brushes.Black, 750, 560)
                End If


                If CheckBox12.Checked = False Then
                    e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 580)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 600)
                ElseIf TextBox16.Text = "" Then
                    e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 580)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 600)
                    e.Graphics.DrawString(TextBox41.Text, font1, Brushes.Black, 655, 600)
                ElseIf TextBox41.Text = "" Then
                    e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 580)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 600)
                    e.Graphics.DrawString(TextBox16.Text, font1, Brushes.Black, 700, 600)
                Else
                    Dim a12 As Integer = CInt(TextBox16.Text)
                    Dim b12 As Integer = CInt(TextBox41.Text)
                    Dim c12 As Integer = (a12 + b12) / 2
                    e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 580)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 600)
                    e.Graphics.DrawString(TextBox16.Text, font1, Brushes.Black, 700, 600)
                    e.Graphics.DrawString(TextBox41.Text, font1, Brushes.Black, 655, 600)
                    e.Graphics.DrawString(c12, font1, Brushes.Black, 750, 600)
                End If


                If CheckBox13.Checked = False Then
                    e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 620)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 620)
                ElseIf TextBox17.Text = "" Then
                    e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 620)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 620)
                    e.Graphics.DrawString(TextBox42.Text, font1, Brushes.Black, 655, 620)
                ElseIf TextBox42.Text = "" Then
                    e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 620)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 620)
                    e.Graphics.DrawString(TextBox17.Text, font1, Brushes.Black, 700, 620)
                Else
                    Dim a13 As Integer = CInt(TextBox17.Text)
                    Dim b13 As Integer = CInt(TextBox42.Text)
                    Dim c13 As Integer = (a13 + b13) / 2
                    e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 620)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 620)
                    e.Graphics.DrawString(TextBox17.Text, font1, Brushes.Black, 700, 620)
                    e.Graphics.DrawString(TextBox42.Text, font1, Brushes.Black, 655, 620)
                    e.Graphics.DrawString(c13, font1, Brushes.Black, 750, 620)
                End If


                If CheckBox14.Checked = False Then
                    e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 640)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 640)
                ElseIf TextBox18.Text = "" Then
                    e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 640)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 640)
                    e.Graphics.DrawString(TextBox43.Text, font1, Brushes.Black, 655, 640)
                ElseIf TextBox43.Text = "" Then
                    e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 640)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 640)
                    e.Graphics.DrawString(TextBox18.Text, font1, Brushes.Black, 700, 640)
                Else
                    Dim a14 As Integer = CInt(TextBox18.Text)
                    Dim b14 As Integer = CInt(TextBox43.Text)
                    Dim c14 As Integer = (a14 + b14) / 2
                    e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 640)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 640)
                    e.Graphics.DrawString(TextBox18.Text, font1, Brushes.Black, 700, 640)
                    e.Graphics.DrawString(TextBox43.Text, font1, Brushes.Black, 655, 640)
                    e.Graphics.DrawString(c14, font1, Brushes.Black, 750, 640)
                End If


                If CheckBox15.Checked = False Then
                    e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 660)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 680)
                ElseIf TextBox19.Text = "" Then
                    e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 660)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 680)
                    e.Graphics.DrawString(TextBox44.Text, font1, Brushes.Black, 655, 680)
                ElseIf TextBox44.Text = "" Then
                    e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 660)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 680)
                    e.Graphics.DrawString(TextBox19.Text, font1, Brushes.Black, 700, 680)
                Else
                    Dim a15 As Integer = CInt(TextBox19.Text)
                    Dim b15 As Integer = CInt(TextBox44.Text)
                    Dim c15 As Integer = (a15 + b15) / 2
                    e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 660)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 680)
                    e.Graphics.DrawString(TextBox19.Text, font1, Brushes.Black, 700, 680)
                    e.Graphics.DrawString(TextBox44.Text, font1, Brushes.Black, 655, 680)
                    e.Graphics.DrawString(c15, font1, Brushes.Black, 750, 680)
                End If

                'Applied Subjectas
                e.Graphics.DrawRectangle(Pens.Black, h2box)
                e.Graphics.DrawString("              Senior High School " + vbNewLine +
                                     "                Applied Subjects ", font1, Brushes.Black, 50, 715)
                e.Graphics.DrawString("T I M E", T, Brushes.Black, 480, 715)
                e.Graphics.DrawString("   Quarter       Final", font1, Brushes.Black, 650, 711)
                e.Graphics.DrawLine(Pens.Black, 739, 680, 739, 754) 'basta line din
                e.Graphics.DrawLine(Pens.Black, 695, 732, 695, 754) 'basta line din
                e.Graphics.DrawString("___________", font1, Brushes.Black, 650, 714) 'same
                e.Graphics.DrawRectangle(Pens.Black, VV2box)
                e.Graphics.DrawString("   1st   2nd    Grade", font1, Brushes.Black, 650, 733)


                If CheckBox16.Checked = False Then
                    e.Graphics.DrawString("   • English for Academic Purposes", font1, Brushes.Black, 60, 770)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 770)
                ElseIf TextBox20.Text = "" Then
                    e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 770)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 770)
                    e.Graphics.DrawString(TextBox47.Text, font1, Brushes.Black, 655, 770)
                ElseIf TextBox47.Text = "" Then
                    e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 770)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 770)
                    e.Graphics.DrawString(TextBox20.Text, font1, Brushes.Black, 700, 770)
                Else
                    Dim a16 As Integer = CInt(TextBox20.Text)
                    Dim b16 As Integer = CInt(TextBox47.Text)
                    Dim c16 As Integer = (a16 + b16) / 2
                    e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 770)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 770)
                    e.Graphics.DrawString(TextBox20.Text, font1, Brushes.Black, 700, 770)
                    e.Graphics.DrawString(TextBox47.Text, font1, Brushes.Black, 655, 770)
                    e.Graphics.DrawString(c16, font1, Brushes.Black, 750, 770)
                End If


                If CheckBox17.Checked = False Then
                    e.Graphics.DrawString("   • Practical Research 1", font1, Brushes.Black, 60, 790)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 790)
                ElseIf TextBox21.Text = "" Then
                    e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 790)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 790)
                    e.Graphics.DrawString(TextBox48.Text, font1, Brushes.Black, 655, 790)
                ElseIf TextBox48.Text = "" Then
                    e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 790)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 790)
                    e.Graphics.DrawString(TextBox21.Text, font1, Brushes.Black, 700, 790)
                Else
                    Dim a17 As Integer = CInt(TextBox21.Text)
                    Dim b17 As Integer = CInt(TextBox48.Text)
                    Dim c17 As Integer = (a17 + b17) / 2
                    e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 790)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 790)
                    e.Graphics.DrawString(TextBox21.Text, font1, Brushes.Black, 700, 790)
                    e.Graphics.DrawString(TextBox48.Text, font1, Brushes.Black, 655, 790)
                    e.Graphics.DrawString(c17, font1, Brushes.Black, 750, 790)
                End If


                If CheckBox18.Checked = False Then
                    e.Graphics.DrawString("   • Practical Reseach 2", font1, Brushes.Black, 60, 810)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 810)
                ElseIf TextBox22.Text = "" Then
                    e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 810)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 810)
                    e.Graphics.DrawString(TextBox49.Text, font1, Brushes.Black, 655, 810)
                ElseIf TextBox49.Text = "" Then
                    e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 810)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 810)
                    e.Graphics.DrawString(TextBox22.Text, font1, Brushes.Black, 700, 810)
                Else
                    Dim a18 As Integer = CInt(TextBox22.Text)
                    Dim b18 As Integer = CInt(TextBox49.Text)
                    Dim c18 As Integer = (a18 + b18) / 2
                    e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 810)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 810)
                    e.Graphics.DrawString(TextBox22.Text, font1, Brushes.Black, 700, 810)
                    e.Graphics.DrawString(TextBox49.Text, font1, Brushes.Black, 655, 810)
                    e.Graphics.DrawString(c18, font1, Brushes.Black, 750, 810)
                End If


                If CheckBox19.Checked = False Then
                    e.Graphics.DrawString("   • Filipino sa Piling Larang", font1, Brushes.Black, 60, 830)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 830)
                ElseIf TextBox23.Text = "" Then
                    e.Graphics.DrawString("  • Filipino sa Piling Larang", font1, Brushes.Black, 60, 830)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 830)
                    e.Graphics.DrawString(TextBox50.Text, font1, Brushes.Black, 655, 830)
                ElseIf TextBox50.Text = "" Then
                    e.Graphics.DrawString("  • Filipino sa Piling Larang", font1, Brushes.Black, 60, 830)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 830)
                    e.Graphics.DrawString(TextBox23.Text, font1, Brushes.Black, 700, 830)
                Else
                    Dim a19 As Integer = CInt(TextBox23.Text)
                    Dim b19 As Integer = CInt(TextBox50.Text)
                    Dim c19 As Integer = (a19 + b19) / 2
                    e.Graphics.DrawString(TextBox23.Text, font1, Brushes.Black, 700, 830)
                    e.Graphics.DrawString("  • Filipino sa Piling Larang", font1, Brushes.Black, 60, 830)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 830)
                    e.Graphics.DrawString(TextBox50.Text, font1, Brushes.Black, 655, 830)
                    e.Graphics.DrawString(c19, font1, Brushes.Black, 750, 830)
                End If


                If CheckBox20.Checked = False Then
                    e.Graphics.DrawString("   • Empowerment Technologies", font1, Brushes.Black, 60, 850)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 850)
                ElseIf TextBox24.Text = "" Then
                    e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 850)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 850)
                    e.Graphics.DrawString(TextBox51.Text, font1, Brushes.Black, 655, 850)
                ElseIf TextBox51.Text = "" Then
                    e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 850)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 850)
                    e.Graphics.DrawString(TextBox24.Text, font1, Brushes.Black, 700, 850)
                Else
                    Dim a20 As Integer = CInt(TextBox24.Text)
                    Dim b20 As Integer = CInt(TextBox51.Text)
                    Dim c20 As Integer = (a20 + b20) / 2
                    e.Graphics.DrawString(TextBox24.Text, font1, Brushes.Black, 700, 850)
                    e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 850)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 850)
                    e.Graphics.DrawString(TextBox51.Text, font1, Brushes.Black, 655, 850)
                    e.Graphics.DrawString(c20, font1, Brushes.Black, 750, 850)
                End If


                If CheckBox21.Checked = False Then
                    e.Graphics.DrawString("   • Entrepreneurship", font1, Brushes.Black, 60, 870)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 870)
                ElseIf TextBox52.Text = "" Then
                    e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 870)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 870)
                    e.Graphics.DrawString(TextBox25.Text, font1, Brushes.Black, 655, 870)
                ElseIf TextBox25.Text = "" Then
                    e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 870)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 870)
                    e.Graphics.DrawString(TextBox52.Text, font1, Brushes.Black, 700, 870)
                Else
                    Dim a21 As Integer = CInt(TextBox25.Text)
                    Dim b21 As Integer = CInt(TextBox52.Text)
                    Dim c21 As Integer = (a21 + b21) / 2
                    e.Graphics.DrawString(TextBox52.Text, font1, Brushes.Black, 700, 870)
                    e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 870)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 870)
                    e.Graphics.DrawString(TextBox25.Text, font1, Brushes.Black, 655, 870)
                    e.Graphics.DrawString(c21, font1, Brushes.Black, 750, 870)
                End If


                If CheckBox22.Checked = False Then
                    e.Graphics.DrawString("   • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 890)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 890)
                ElseIf TextBox26.Text = "" Then
                    e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 890)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 890)
                    e.Graphics.DrawString(TextBox53.Text, font1, Brushes.Black, 655, 890)
                ElseIf TextBox53.Text = "" Then
                    e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 890)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 890)
                    e.Graphics.DrawString(TextBox26.Text, font1, Brushes.Black, 700, 890)
                Else
                    Dim a22 As Integer = CInt(TextBox26.Text)
                    Dim b22 As Integer = CInt(TextBox53.Text)
                    Dim c22 As Integer = (a22 + b22) / 2
                    e.Graphics.DrawString(TextBox26.Text, font1, Brushes.Black, 700, 890)
                    e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 890)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 890)
                    e.Graphics.DrawString(TextBox53.Text, font1, Brushes.Black, 655, 890)
                    e.Graphics.DrawString(c22, font1, Brushes.Black, 750, 890)
                End If
                Dim f1 As New Font("Arial", 8, FontStyle.Regular)
                'Major Subjects
                e.Graphics.DrawRectangle(Pens.Black, h3box)
                e.Graphics.DrawRectangle(Pens.Black, VV3box)
                e.Graphics.DrawLine(Pens.Black, 739, 890, 739, 964)
                e.Graphics.DrawLine(Pens.Black, 695, 932, 695, 964)
                e.Graphics.DrawString("___________", font1, Brushes.Black, 650, 925)
                e.Graphics.DrawString("               Major Subjects ", font1, Brushes.Black, 50, 930)
                e.Graphics.DrawString("T I M E", T, Brushes.Black, 480, 925)
                e.Graphics.DrawString("   Quarter       Final", font1, Brushes.Black, 650, 920)
                e.Graphics.DrawString("  1st     2nd   Grade", font1, Brushes.Black, 650, 942)
                e.Graphics.DrawRectangle(Pens.Black, h3bbox) ''hummms I box
                e.Graphics.DrawString(" HUMANITIES & SOCIAL SCIENCE", font1, Brushes.Black, 60, 972)
                e.Graphics.DrawString("(take atleast 3 subjects)", f1, Brushes.Black, 90, 992)


                ''HUMMANITIES I
                If CheckBox10.Checked = False Then
                    e.Graphics.DrawString("   • Creative Writing", font1, Brushes.Black, 60, 1010)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1010)
                ElseIf TextBox71.Text = "" Then
                    e.Graphics.DrawString("  • Creative Writing", font1, Brushes.Black, 60, 1010)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1010)
                    e.Graphics.DrawString(TextBox72.Text, font1, Brushes.Black, 655, 1010)
                ElseIf TextBox72.Text = "" Then
                    e.Graphics.DrawString("  • Creative Writing", font1, Brushes.Black, 60, 1010)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1010)
                    e.Graphics.DrawString(TextBox71.Text, font1, Brushes.Black, 700, 1010)
                Else
                    Dim a1 As Integer = CInt(TextBox71.Text)
                    Dim b2 As Integer = CInt(TextBox72.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox71.Text, font1, Brushes.Black, 700, 1010)
                    e.Graphics.DrawString("  • Creative Writing", font1, Brushes.Black, 60, 1010)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1010)
                    e.Graphics.DrawString(TextBox72.Text, font1, Brushes.Black, 655, 1010)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1010)
                End If
                If CheckBox32.Checked = False Then
                    e.Graphics.DrawString("   • Introduction to World Religions" + vbNewLine + "      and Belief Systems", font1, Brushes.Black, 60, 1030)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1050)
                ElseIf TextBox69.Text = "" Then
                    e.Graphics.DrawString("   • Introduction to World Religions" + vbNewLine + "      and Belief Systems", font1, Brushes.Black, 60, 1030)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1050)
                    e.Graphics.DrawString(TextBox70.Text, font1, Brushes.Black, 655, 1050)
                ElseIf TextBox70.Text = "" Then
                    e.Graphics.DrawString("   • Introduction to World Religions" + vbNewLine + "      and Belief Systems", font1, Brushes.Black, 60, 1030)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1050)
                    e.Graphics.DrawString(TextBox69.Text, font1, Brushes.Black, 700, 1050)
                Else
                    Dim a1 As Integer = CInt(TextBox69.Text)
                    Dim b2 As Integer = CInt(TextBox70.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox69.Text, font1, Brushes.Black, 700, 1050)
                    e.Graphics.DrawString("   • Introduction to World Religions" + vbNewLine + "      and Belief Systems", font1, Brushes.Black, 60, 1030)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1050)
                    e.Graphics.DrawString(TextBox70.Text, font1, Brushes.Black, 655, 1050)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1050)
                End If

                If CheckBox33.Checked = False Then
                    e.Graphics.DrawString("   • Creative Nonfiction", font1, Brushes.Black, 60, 1070)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1070)
                ElseIf TextBox67.Text = "" Then
                    e.Graphics.DrawString("  • Creative Nonfiction", font1, Brushes.Black, 60, 1070)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1070)
                    e.Graphics.DrawString(TextBox68.Text, font1, Brushes.Black, 655, 1070)
                ElseIf TextBox68.Text = "" Then
                    e.Graphics.DrawString("  • Creative Nonfiction", font1, Brushes.Black, 60, 1070)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1070)
                    e.Graphics.DrawString(TextBox67.Text, font1, Brushes.Black, 700, 1070)
                Else
                    Dim a1 As Integer = CInt(TextBox68.Text)
                    Dim b2 As Integer = CInt(TextBox67.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox67.Text, font1, Brushes.Black, 700, 1070)
                    e.Graphics.DrawString("  • Creative Nonfiction", font1, Brushes.Black, 60, 1070)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1070)
                    e.Graphics.DrawString(TextBox68.Text, font1, Brushes.Black, 655, 1070)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1070)
                End If

                If CheckBox34.Checked = False Then
                    e.Graphics.DrawString("   • Trends, Network, and Critical" + vbNewLine + "      Thinking in the 21st Century Culture", font1, Brushes.Black, 60, 1090)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1110)
                ElseIf TextBox45.Text = "" Then
                    e.Graphics.DrawString("  • Trends, Network, and Critical" + vbNewLine + "      Thinking in the 21st Century Culture", font1, Brushes.Black, 60, 1090)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1110)
                    e.Graphics.DrawString(TextBox46.Text, font1, Brushes.Black, 655, 1110)
                ElseIf TextBox46.Text = "" Then
                    e.Graphics.DrawString("  • Trends, Network, and Critical" + vbNewLine + "      Thinking in the 21st Century Culture", font1, Brushes.Black, 60, 1090)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1110)
                    e.Graphics.DrawString(TextBox45.Text, font1, Brushes.Black, 700, 1110)
                Else
                    Dim a1 As Integer = CInt(TextBox45.Text)
                    Dim b2 As Integer = CInt(TextBox46.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox45.Text, font1, Brushes.Black, 700, 1110)
                    e.Graphics.DrawString("  • Trends, Network, and Critical" + vbNewLine + "      Thinking in the 21st Century Culture", font1, Brushes.Black, 60, 1090)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1110)
                    e.Graphics.DrawString(TextBox46.Text, font1, Brushes.Black, 655, 1110)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1110)
                End If

                If CheckBox35.Checked = False Then
                    e.Graphics.DrawString("   • Philippine Politics and Governance", font1, Brushes.Black, 60, 1130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1130)
                ElseIf TextBox79.Text = "" Then
                    e.Graphics.DrawString("  • Philippine Politics and Governance", font1, Brushes.Black, 60, 1130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1130)
                    e.Graphics.DrawString(TextBox80.Text, font1, Brushes.Black, 655, 1130)
                ElseIf TextBox80.Text = "" Then
                    e.Graphics.DrawString("  • Philippine Politics and Governance", font1, Brushes.Black, 60, 1130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1130)
                    e.Graphics.DrawString(TextBox79.Text, font1, Brushes.Black, 700, 1130)
                Else
                    Dim a1 As Integer = CInt(TextBox79.Text)
                    Dim b2 As Integer = CInt(TextBox80.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox80.Text, font1, Brushes.Black, 700, 1130)
                    e.Graphics.DrawString("  • Philippine Politics and Governance", font1, Brushes.Black, 60, 1130)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1130)
                    e.Graphics.DrawString(TextBox79.Text, font1, Brushes.Black, 655, 1130)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1130)
                End If
                If CheckBox36.Checked = False Then
                    e.Graphics.DrawString("   • Community, Engagement, Solidarity " + vbNewLine + "     and Citizenship", font1, Brushes.Black, 60, 1150)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1170)
                ElseIf TextBox77.Text = "" Then
                    e.Graphics.DrawString("  • Community, Engagement, Solidarity and" + vbNewLine + "     and Citizenship", font1, Brushes.Black, 60, 1150)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1170)
                    e.Graphics.DrawString(TextBox78.Text, font1, Brushes.Black, 655, 1170)
                ElseIf TextBox78.Text = "" Then
                    e.Graphics.DrawString("  • Community, Engagement, Solidarity and" + vbNewLine + "     and Citizenship", font1, Brushes.Black, 60, 1150)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1170)
                    e.Graphics.DrawString(TextBox77.Text, font1, Brushes.Black, 700, 1170)
                Else
                    Dim a1 As Integer = CInt(TextBox77.Text)
                    Dim b2 As Integer = CInt(TextBox78.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox77.Text, font1, Brushes.Black, 700, 1170)
                    e.Graphics.DrawString("  • Community, Engagement, Solidarity and" + vbNewLine + "     and Citizenship", font1, Brushes.Black, 60, 1150)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1170)
                    e.Graphics.DrawString(TextBox78.Text, font1, Brushes.Black, 655, 1170)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1170)
                End If
                If CheckBox37.Checked = False Then
                    e.Graphics.DrawString("   • Discipline and Ideas in the" + vbNewLine + "      Social Sciences", font1, Brushes.Black, 60, 1190)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1210)
                ElseIf TextBox75.Text = "" Then
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Social Sciences", font1, Brushes.Black, 60, 1190)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1210)
                    e.Graphics.DrawString(TextBox76.Text, font1, Brushes.Black, 655, 1210)
                ElseIf TextBox76.Text = "" Then
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Social Sciences", font1, Brushes.Black, 60, 1190)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1210)
                    e.Graphics.DrawString(TextBox75.Text, font1, Brushes.Black, 700, 1210)
                Else
                    Dim a1 As Integer = CInt(TextBox76.Text)
                    Dim b2 As Integer = CInt(TextBox75.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox76.Text, font1, Brushes.Black, 700, 1210)
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Social Sciences", font1, Brushes.Black, 60, 1190)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1210)
                    e.Graphics.DrawString(TextBox75.Text, font1, Brushes.Black, 655, 1210)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1210)
                End If
                If CheckBox38.Checked = False Then
                    e.Graphics.DrawString("   • Discipline and Ideas in the" + vbNewLine + "      Applied Social Sciences", font1, Brushes.Black, 60, 1230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1250)
                ElseIf TextBox73.Text = "" Then
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Applied Social Sciences", font1, Brushes.Black, 60, 1230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1250)
                    e.Graphics.DrawString(TextBox74.Text, font1, Brushes.Black, 655, 1250)
                ElseIf TextBox74.Text = "" Then
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Applied Social Sciences", font1, Brushes.Black, 60, 1230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 1250)
                    e.Graphics.DrawString(TextBox73.Text, font1, Brushes.Black, 700, 1250)
                Else
                    Dim a1 As Integer = CInt(TextBox73.Text)
                    Dim b2 As Integer = CInt(TextBox74.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox73.Text, font1, Brushes.Black, 700, 1250)
                    e.Graphics.DrawString("  • Discipline and Ideas in the" + vbNewLine + "      Applied Social Sciences", font1, Brushes.Black, 60, 1230)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 1250)
                    e.Graphics.DrawString(TextBox74.Text, font1, Brushes.Black, 655, 1250)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 1250)
                End If

            Catch
                MessageBox.Show("Invalid Input.", "Digital Prospectus in Cainta Senior High School", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            e.HasMorePages = True
            Me.pageNumber = 1

            Dim cr As Bitmap = My.Resources.SCHOOL 'Background Images

            Dim rrr As New Rectangle(25, 100, 800, 800) 'Background Images

            e.Graphics.DrawImage(cr, rrr) 'Background Images
            e.Graphics.DrawLine(Pens.Black, 51, 90, 648, 90) ' basta line sa time


            Dim font1 As New Font("Century Gothic", 11, FontStyle.Bold)
            Dim f1 As New Font("Arial", 8, FontStyle.Regular)

            Dim BOX As New Rectangle(51, 50, 744, 630) 'WHOLE BOX 735
            e.Graphics.DrawRectangle(Pens.Black, BOX)
            Dim VV1box As New Rectangle(695, 50, 44, 630) 'short Box
            Dim V1box As New Rectangle(650, 50, 145, 750) 'first Vertical Box
            e.Graphics.DrawLine(Pens.Black, 395, 50, 395, 800) 'Longest Line
            e.Graphics.DrawRectangle(Pens.Black, V1box)
            e.Graphics.DrawRectangle(Pens.Black, VV1box)
            ''IMMERSION BOX
            e.Graphics.DrawString("Date: mm/dd/yyyy ", font1, Brushes.Black, 450, 685)
            e.Graphics.DrawString("No. of " + vbNewLine + "Hours", font1, Brushes.Black, 660, 680)
            e.Graphics.DrawString("Final " + vbNewLine + "Grade", font1, Brushes.Black, 730, 680)
            e.Graphics.DrawLine(Pens.Black, 395, 720, 795, 720) 'horizontal Line
            e.Graphics.DrawLine(Pens.Black, 720, 680, 720, 800) 'vertical Line


            Try
                ''ABM MAJOR

                e.Graphics.DrawString("ABM MAJOR SUBJECTS", font1, Brushes.Black, 60, 60)
                e.Graphics.DrawString("(take atleast 3 subjects)", f1, Brushes.Black, 225, 64)


                If CheckBox41.Checked = False Then
                    e.Graphics.DrawString("  • Business Ethics And Social Responsibility", font1, Brushes.Black, 60, 110)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 110)
                ElseIf TextBox87.Text = "" Then
                    e.Graphics.DrawString("  • Business Ethics And Social Responsibility", font1, Brushes.Black, 60, 110)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 110)
                    e.Graphics.DrawString(TextBox88.Text, font1, Brushes.Black, 655, 110)
                ElseIf TextBox88.Text = "" Then
                    e.Graphics.DrawString("  • Business Ethics And Social Responsibility", font1, Brushes.Black, 60, 110)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 110)
                    e.Graphics.DrawString(TextBox87.Text, font1, Brushes.Black, 700, 110)
                Else
                    Dim a1 As Integer = CInt(TextBox87.Text)
                    Dim b2 As Integer = CInt(TextBox88.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox87.Text, font1, Brushes.Black, 700, 110)
                    e.Graphics.DrawString("  • Business Ethics And Social Responsibility", font1, Brushes.Black, 60, 110)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 110)
                    e.Graphics.DrawString(TextBox88.Text, font1, Brushes.Black, 655, 110)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 110)
                End If
                If CheckBox39.Checked = False Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management I", font1, Brushes.Black, 60, 130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 150)
                ElseIf TextBox85.Text = "" Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management I", font1, Brushes.Black, 60, 130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 150)
                    e.Graphics.DrawString(TextBox86.Text, font1, Brushes.Black, 655, 150)
                ElseIf TextBox86.Text = "" Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management I", font1, Brushes.Black, 60, 130)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 150)
                    e.Graphics.DrawString(TextBox85.Text, font1, Brushes.Black, 700, 150)
                Else
                    Dim a1 As Integer = CInt(TextBox86.Text)
                    Dim b2 As Integer = CInt(TextBox85.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox85.Text, font1, Brushes.Black, 700, 150)
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management II", font1, Brushes.Black, 60, 130)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 150)
                    e.Graphics.DrawString(TextBox86.Text, font1, Brushes.Black, 655, 150)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 150)
                End If

                If CheckBox24.Checked = False Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management II", font1, Brushes.Black, 60, 170)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 190)
                ElseIf TextBox83.Text = "" Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management II", font1, Brushes.Black, 60, 170)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 190)
                    e.Graphics.DrawString(TextBox84.Text, font1, Brushes.Black, 655, 190)
                ElseIf TextBox84.Text = "" Then
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management II", font1, Brushes.Black, 60, 170)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 190)
                    e.Graphics.DrawString(TextBox83.Text, font1, Brushes.Black, 700, 190)
                Else
                    Dim a1 As Integer = CInt(TextBox84.Text)
                    Dim b2 As Integer = CInt(TextBox83.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox83.Text, font1, Brushes.Black, 700, 190)
                    e.Graphics.DrawString("  • Fundamentals of Accountancy," + vbNewLine + "      Business and Management II", font1, Brushes.Black, 60, 170)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 190)
                    e.Graphics.DrawString(TextBox84.Text, font1, Brushes.Black, 655, 190)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 190)
                End If

                If CheckBox42.Checked = False Then
                    e.Graphics.DrawString("  • Business Math", font1, Brushes.Black, 60, 210)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 210)
                ElseIf TextBox81.Text = "" Then
                    e.Graphics.DrawString("  • Business Math", font1, Brushes.Black, 60, 210)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 210)
                    e.Graphics.DrawString(TextBox82.Text, font1, Brushes.Black, 655, 210)
                ElseIf TextBox82.Text = "" Then
                    e.Graphics.DrawString("  • Business Math", font1, Brushes.Black, 60, 210)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 210)
                    e.Graphics.DrawString(TextBox81.Text, font1, Brushes.Black, 700, 210)
                Else
                    Dim a1 As Integer = CInt(TextBox81.Text)
                    Dim b2 As Integer = CInt(TextBox82.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox81.Text, font1, Brushes.Black, 700, 210)
                    e.Graphics.DrawString("  • Business Math", font1, Brushes.Black, 60, 210)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 210)
                    e.Graphics.DrawString(TextBox82.Text, font1, Brushes.Black, 655, 210)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 210)
                End If

                If CheckBox30.Checked = False Then
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 230)
                ElseIf TextBox54.Text = "" Then
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 230)
                    e.Graphics.DrawString(TextBox55.Text, font1, Brushes.Black, 655, 230)
                ElseIf TextBox55.Text = "" Then
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 230)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 230)
                    e.Graphics.DrawString(TextBox54.Text, font1, Brushes.Black, 700, 230)
                Else
                    Dim a1 As Integer = CInt(TextBox55.Text)
                    Dim b2 As Integer = CInt(TextBox54.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox54.Text, font1, Brushes.Black, 700, 230)
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 230)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 230)
                    e.Graphics.DrawString(TextBox55.Text, font1, Brushes.Black, 655, 230)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 230)
                End If

                If CheckBox40.Checked = False Then
                    e.Graphics.DrawString("  • Business Finance", font1, Brushes.Black, 60, 250)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                ElseIf TextBox65.Text = "" Then
                    e.Graphics.DrawString("  • Business Finance", font1, Brushes.Black, 60, 250)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                    e.Graphics.DrawString(TextBox66.Text, font1, Brushes.Black, 655, 250)
                ElseIf TextBox66.Text = "" Then
                    e.Graphics.DrawString("  • Business Finance", font1, Brushes.Black, 60, 250)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                    e.Graphics.DrawString(TextBox65.Text, font1, Brushes.Black, 700, 250)
                Else
                    Dim a1 As Integer = CInt(TextBox65.Text)
                    Dim b2 As Integer = CInt(TextBox66.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox65.Text, font1, Brushes.Black, 700, 250)
                    e.Graphics.DrawString("  • Business Finance", font1, Brushes.Black, 60, 250)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 250)
                    e.Graphics.DrawString(TextBox66.Text, font1, Brushes.Black, 655, 250)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 250)
                End If
                If CheckBox23.Checked = False Then
                    e.Graphics.DrawString("  • Principles of Marketing", font1, Brushes.Black, 60, 270)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
                ElseIf TextBox27.Text = "" Then
                    e.Graphics.DrawString("  • Principles of Marketing", font1, Brushes.Black, 60, 270)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
                    e.Graphics.DrawString(TextBox28.Text, font1, Brushes.Black, 655, 270)
                ElseIf TextBox28.Text = "" Then
                    e.Graphics.DrawString("  • Principles of Marketing", font1, Brushes.Black, 60, 270)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
                    e.Graphics.DrawString(TextBox27.Text, font1, Brushes.Black, 700, 270)
                Else
                    Dim a1 As Integer = CInt(TextBox27.Text)
                    Dim b2 As Integer = CInt(TextBox28.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox27.Text, font1, Brushes.Black, 700, 270)
                    e.Graphics.DrawString("  • Principles of Marketing", font1, Brushes.Black, 60, 270)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 270)
                    e.Graphics.DrawString(TextBox28.Text, font1, Brushes.Black, 655, 270)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 270)
                End If

                e.Graphics.DrawLine(Pens.Black, 51, 310, 795, 310) ' basta line sa time
                e.Graphics.DrawString("STEM MAJOR SUBJECTS", font1, Brushes.Black, 60, 320)
                e.Graphics.DrawString("(take atleast 3 subjects)", f1, Brushes.Black, 230, 324)
                e.Graphics.DrawLine(Pens.Black, 51, 350, 648, 350) ' basta line sa time


                ''STEM MAJOR
                e.Graphics.DrawString("NOTE: CAINTA SENIOR HIGH SCHOOL " + vbNewLine + "DOES NOT OFFER THIS STRAND", f1, Brushes.Tomato, 80, 355)


                If a.Checked = False Then
                    e.Graphics.DrawString("  • Pre - Calculus", font1, Brushes.Black, 60, 390)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
                ElseIf a22.Text = "" Then
                    e.Graphics.DrawString("  • Pre - Calculus", font1, Brushes.Black, 60, 390)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
                    e.Graphics.DrawString(a11.Text, font1, Brushes.Black, 655, 390)
                ElseIf a11.Text = "" Then
                    e.Graphics.DrawString("  • Pre - Calculus", font1, Brushes.Black, 60, 390)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
                    e.Graphics.DrawString(a22.Text, font1, Brushes.Black, 700, 390)
                Else
                    Dim a1 As Integer = CInt(a11.Text)
                    Dim b2 As Integer = CInt(a22.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(a22.Text, font1, Brushes.Black, 700, 390)
                    e.Graphics.DrawString("  • Pre - Calculus", font1, Brushes.Black, 60, 390)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 390)
                    e.Graphics.DrawString(a11.Text, font1, Brushes.Black, 655, 390)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 390)
                End If
                If b.Checked = False Then
                    e.Graphics.DrawString("  • Basic Calculus", font1, Brushes.Black, 60, 410)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 410)
                ElseIf b22.Text = "" Then
                    e.Graphics.DrawString("  • Basic Calculus", font1, Brushes.Black, 60, 410)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 410)
                    e.Graphics.DrawString(b1.Text, font1, Brushes.Black, 655, 410)
                ElseIf b1.Text = "" Then
                    e.Graphics.DrawString("  • Basic Calculus", font1, Brushes.Black, 60, 410)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 410)
                    e.Graphics.DrawString(b22.Text, font1, Brushes.Black, 700, 410)
                Else
                    Dim a1 As Integer = CInt(b1.Text)
                    Dim b2 As Integer = CInt(b22.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(b22.Text, font1, Brushes.Black, 700, 410)
                    e.Graphics.DrawString("  • Basic Calculus", font1, Brushes.Black, 60, 410)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 410)
                    e.Graphics.DrawString(b1.Text, font1, Brushes.Black, 655, 410)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 410)
                End If
                If c.Checked = False Then
                    e.Graphics.DrawString("  • General Biology I", font1, Brushes.Black, 60, 430)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
                ElseIf c2.Text = "" Then
                    e.Graphics.DrawString("  • General Biology I", font1, Brushes.Black, 60, 430)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
                    e.Graphics.DrawString(c1.Text, font1, Brushes.Black, 655, 430)
                ElseIf c1.Text = "" Then
                    e.Graphics.DrawString("  • General Biology I font1", font1, Brushes.Black, 60, 430)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
                    e.Graphics.DrawString(c2.Text, font1, Brushes.Black, 700, 430)
                Else
                    Dim a1 As Integer = CInt(c1.Text)
                    Dim b2 As Integer = CInt(c2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(c2.Text, font1, Brushes.Black, 700, 430)
                    e.Graphics.DrawString("  • General Biology I", font1, Brushes.Black, 60, 430)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 430)
                    e.Graphics.DrawString(c1.Text, font1, Brushes.Black, 655, 430)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 430)
                End If
                If d.Checked = False Then
                    e.Graphics.DrawString("  • General Biology II", font1, Brushes.Black, 60, 450)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
                ElseIf d2.Text = "" Then
                    e.Graphics.DrawString("  • General Biology II", font1, Brushes.Black, 60, 450)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
                    e.Graphics.DrawString(d1.Text, font1, Brushes.Black, 655, 450)
                ElseIf d1.Text = "" Then
                    e.Graphics.DrawString("  • General Biology II", font1, Brushes.Black, 60, 450)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
                    e.Graphics.DrawString(d2.Text, font1, Brushes.Black, 700, 450)
                Else
                    Dim a1 As Integer = CInt(d1.Text)
                    Dim b2 As Integer = CInt(d2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(d2.Text, font1, Brushes.Black, 700, 450)
                    e.Graphics.DrawString("  • General Biology II", font1, Brushes.Black, 60, 450)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 450)
                    e.Graphics.DrawString(d1.Text, font1, Brushes.Black, 655, 450)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 450)
                End If
                If aa.Checked = False Then
                    e.Graphics.DrawString("  • General Physics I", font1, Brushes.Black, 60, 470)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
                ElseIf aa2.Text = "" Then
                    e.Graphics.DrawString("  • General Physics I", font1, Brushes.Black, 60, 470)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
                    e.Graphics.DrawString(aa1.Text, font1, Brushes.Black, 655, 470)
                ElseIf aa1.Text = "" Then
                    e.Graphics.DrawString("  • General Physics I", font1, Brushes.Black, 60, 470)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
                    e.Graphics.DrawString(aa2.Text, font1, Brushes.Black, 700, 470)
                Else
                    Dim a1 As Integer = CInt(aa1.Text)
                    Dim b2 As Integer = CInt(aa2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(aa2.Text, font1, Brushes.Black, 700, 470)
                    e.Graphics.DrawString("  • General Physics I", font1, Brushes.Black, 60, 470)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 470)
                    e.Graphics.DrawString(aa1.Text, font1, Brushes.Black, 655, 470)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 470)
                End If
                If bb.Checked = False Then
                    e.Graphics.DrawString("  • General Physics II", font1, Brushes.Black, 60, 490)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
                ElseIf bb2.Text = "" Then
                    e.Graphics.DrawString("  • General Physics II", font1, Brushes.Black, 60, 490)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
                    e.Graphics.DrawString(bb1.Text, font1, Brushes.Black, 655, 490)
                ElseIf bb1.Text = "" Then
                    e.Graphics.DrawString("  • General Physics II", font1, Brushes.Black, 60, 490)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
                    e.Graphics.DrawString(bb2.Text, font1, Brushes.Black, 700, 490)
                Else
                    Dim a1 As Integer = CInt(bb1.Text)
                    Dim b2 As Integer = CInt(bb2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(bb2.Text, font1, Brushes.Black, 700, 490)
                    e.Graphics.DrawString("  • General Physics II", font1, Brushes.Black, 60, 490)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 490)
                    e.Graphics.DrawString(bb1.Text, font1, Brushes.Black, 655, 490)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 490)
                End If
                If cc.Checked = False Then
                    e.Graphics.DrawString("  • General Chemistry I", font1, Brushes.Black, 60, 510)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
                ElseIf cc2.Text = "" Then
                    e.Graphics.DrawString("  • General Chemistry I", font1, Brushes.Black, 60, 510)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
                    e.Graphics.DrawString(cc1.Text, font1, Brushes.Black, 655, 510)
                ElseIf cc1.Text = "" Then
                    e.Graphics.DrawString("  • General Chemistry I", font1, Brushes.Black, 60, 510)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
                    e.Graphics.DrawString(cc2.Text, font1, Brushes.Black, 700, 510)
                Else
                    Dim a1 As Integer = CInt(cc1.Text)
                    Dim b2 As Integer = CInt(cc2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(cc2.Text, font1, Brushes.Black, 700, 510)
                    e.Graphics.DrawString("  • General Chemistry I", font1, Brushes.Black, 60, 510)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 510)
                    e.Graphics.DrawString(cc1.Text, font1, Brushes.Black, 655, 510)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 510)
                End If
                If dd.Checked = False Then
                    e.Graphics.DrawString("  • General Chemistry II", font1, Brushes.Black, 60, 530)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
                ElseIf dd2.Text = "" Then
                    e.Graphics.DrawString("  • General Chemistry II", font1, Brushes.Black, 60, 530)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
                    e.Graphics.DrawString(dd1.Text, font1, Brushes.Black, 655, 530)
                ElseIf dd1.Text = "" Then
                    e.Graphics.DrawString("  • General Chemistry II", font1, Brushes.Black, 60, 530)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
                    e.Graphics.DrawString(dd2.Text, font1, Brushes.Black, 700, 530)
                Else
                    Dim a1 As Integer = CInt(dd1.Text)
                    Dim b2 As Integer = CInt(dd2.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(dd2.Text, font1, Brushes.Black, 700, 530)
                    e.Graphics.DrawString("  • General Chemistry II", font1, Brushes.Black, 60, 530)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 530)
                    e.Graphics.DrawString(dd1.Text, font1, Brushes.Black, 655, 530)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 530)
                End If
                ''GAS other MAJOR

                e.Graphics.DrawLine(Pens.Black, 51, 565, 795, 565) ' basta line sa time



                If CheckBox26.Checked = False Then
                    e.Graphics.DrawString("   • Applied Economics", font1, Brushes.Black, 60, 590)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
                ElseIf TextBox58.Text = "" Then
                    e.Graphics.DrawString("  • Applied Economics", font1, Brushes.Black, 60, 590)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
                    e.Graphics.DrawString(TextBox57.Text, font1, Brushes.Black, 655, 590)
                ElseIf TextBox57.Text = "" Then
                    e.Graphics.DrawString("  • Applied Economics", font1, Brushes.Black, 60, 590)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
                    e.Graphics.DrawString(TextBox58.Text, font1, Brushes.Black, 700, 590)
                Else
                    Dim a1 As Integer = CInt(TextBox58.Text)
                    Dim b2 As Integer = CInt(TextBox57.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox58.Text, font1, Brushes.Black, 700, 590)
                    e.Graphics.DrawString("  • Applied Economics", font1, Brushes.Black, 60, 590)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 590)
                    e.Graphics.DrawString(TextBox57.Text, font1, Brushes.Black, 655, 590)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 590)
                End If

                If CheckBox27.Checked = False Then
                    e.Graphics.DrawString("   • Organization and Management", font1, Brushes.Black, 60, 610)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
                ElseIf TextBox60.Text = "" Then
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 610)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
                    e.Graphics.DrawString(TextBox59.Text, font1, Brushes.Black, 655, 610)
                ElseIf TextBox59.Text = "" Then
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 610)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
                    e.Graphics.DrawString(TextBox60.Text, font1, Brushes.Black, 700, 610)
                Else
                    Dim a1 As Integer = CInt(TextBox60.Text)
                    Dim b2 As Integer = CInt(TextBox59.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox60.Text, font1, Brushes.Black, 700, 610)
                    e.Graphics.DrawString("  • Organization and Management", font1, Brushes.Black, 60, 610)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 610)
                    e.Graphics.DrawString(TextBox59.Text, font1, Brushes.Black, 655, 610)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 610)
                End If

                If CheckBox28.Checked = False Then
                    e.Graphics.DrawString("   • Disaster Readiness and Risk Reduction", font1, Brushes.Black, 60, 630)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 630)
                ElseIf TextBox62.Text = "" Then
                    e.Graphics.DrawString("  • Disaster Readiness and Risk Reduction", font1, Brushes.Black, 60, 630)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 630)
                    e.Graphics.DrawString(TextBox61.Text, font1, Brushes.Black, 655, 630)
                ElseIf TextBox61.Text = "" Then
                    e.Graphics.DrawString("  • Disaster Readiness and Risk Reduction", font1, Brushes.Black, 60, 630)
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 630)
                    e.Graphics.DrawString(TextBox62.Text, font1, Brushes.Black, 700, 630)
                Else
                    Dim a1 As Integer = CInt(TextBox62.Text)
                    Dim b2 As Integer = CInt(TextBox61.Text)
                    Dim c3 As Integer = (a1 + b2) / 2
                    e.Graphics.DrawString(TextBox62.Text, font1, Brushes.Black, 700, 630)
                    e.Graphics.DrawString("  • Disaster Readiness and Risk Reduction", font1, Brushes.Black, 60, 630)
                    e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 630)
                    e.Graphics.DrawString(TextBox61.Text, font1, Brushes.Black, 655, 630)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 750, 630)
                End If
                ''   e.Graphics.DrawLine(Pens.Black, 51, 1200, 795, 1200) ' basta line sa time

                Dim h1box As New Rectangle(51, 680, 744, 120) 'FIRST BOX
                e.Graphics.DrawRectangle(Pens.Black, h1box)
                '' Dim smol As New Rectangle(51, 700, 744, 80) 'rect BOX
                ''e.Graphics.DrawRectangle(Pens.Black, h1box)


                If CheckBox29.Checked = False Then
                    e.Graphics.DrawString("   • WORK IMMERSION", font1, Brushes.Black, 60, 740)
                    e.Graphics.DrawString("Start :" + " _____________________", font1, Brushes.Black, 405, 730)
                    e.Graphics.DrawString(" End : " + "_____________________", font1, Brushes.Black, 405, 760)
                Else
                    e.Graphics.DrawString("   • WORK IMMERSION", font1, Brushes.Black, 60, 740)
                    e.Graphics.DrawString("Start : " + DateTimePicker1.Text, font1, Brushes.Black, 450, 730)
                    e.Graphics.DrawString(" End : " + DateTimePicker1.Text, font1, Brushes.Black, 450, 760)
                    e.Graphics.DrawString(TextBox63.Text, font1, Brushes.Black, 655, 740)
                    e.Graphics.DrawString(TextBox64.Text, font1, Brushes.Black, 750, 740)

                End If
                e.Graphics.DrawString("Note: If you laredy catch up 3 major subjects in your previous school, you no longer allowed to ", font1, Brushes.Black, 60, 830)
                e.Graphics.DrawString("take extra curriculum", font1, Brushes.Black, 60, 850)







            Catch
                MessageBox.Show("Invalid Input.", "Digital Prospectus in Cainta Senior High School", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
       If TextBox1.Text = "Type your Full Name" Or TextBox4.Enabled = True And TextBox4.Text = " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Or TextBox62.Text = "2017" And TextBox61.Text = "2016" Then
            MessageBox.Show("Please fill out your name, age,last school attended if transferee" + vbNewLine + " and  Please Select region, School Year.", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case MessageBox.Show("Please set the paper 'size from Letter' into 'Legal' ", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok
                    '' PageSetupDialog1.Document.DefaultPageSettings.Color = True
                    PageSetupDialog1.ShowDialog()
                    Me.PrintDocument1.Print()

                    '' PrintPreviewDialog1.ShowDialog()


            End Select

        End If
    End Sub
   
    Private Sub Button10_Click(sender As Object, e As EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox5.Visible = False Then
            TextBox5.Visible = True

        Else
            TextBox5.Text = ""

            TextBox5.Visible = False

        End If
        If TextBox30.Visible = False Then
            TextBox30.Visible = True
        Else
            TextBox30.Text = ""
            TextBox30.Visible = False

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox6.Visible = False Then
            TextBox6.Visible = True
        Else
            TextBox6.Text = ""
            TextBox6.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox7.Visible = False Then
            TextBox7.Visible = True
        Else
            TextBox7.Text = ""
            TextBox7.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox8.Visible = False Then
            TextBox8.Visible = True
        Else
            TextBox8.Text = ""
            TextBox8.Visible = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox9.Visible = False Then
            TextBox9.Visible = True
        Else
            TextBox9.Text = ""
            TextBox9.Visible = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox10.Visible = False Then
            TextBox10.Visible = True
        Else
            TextBox10.Text = ""
            TextBox10.Visible = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox11.Visible = False Then
            TextBox11.Visible = True
        Else
            TextBox11.Text = ""
            TextBox11.Visible = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox12.Visible = False Then
            TextBox12.Visible = True
        Else
            TextBox12.Text = ""
            TextBox12.Visible = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox13.Visible = False Then
            TextBox13.Visible = True
        Else
            TextBox13.Text = ""
            TextBox13.Visible = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox14.Visible = False Then
            TextBox14.Visible = True
        Else
            TextBox14.Text = ""
            TextBox14.Visible = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox15.Visible = False Then
            TextBox15.Visible = True
        Else
            TextBox15.Text = ""
            TextBox15.Visible = False
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox16.Visible = False Then
            TextBox16.Visible = True
        Else
            TextBox16.Text = ""
            TextBox16.Visible = False
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox17.Visible = False Then
            TextBox17.Visible = True
        Else
            TextBox17.Text = ""
            TextBox17.Visible = False
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox18.Visible = False Then
            TextBox18.Visible = True
        Else
            TextBox18.Text = ""
            TextBox18.Visible = False
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox19.Visible = False Then
            TextBox19.Visible = True
        Else
            TextBox19.Text = ""
            TextBox19.Visible = False
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox20.Visible = False Then
            TextBox20.Visible = True
        Else
            TextBox20.Text = ""
            TextBox20.Visible = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox21.Visible = False Then
            TextBox21.Visible = True
        Else
            TextBox21.Text = ""
            TextBox21.Visible = False
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox22.Visible = False Then
            TextBox22.Visible = True
        Else
            TextBox22.Text = ""
            TextBox22.Visible = False
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox23.Visible = False Then
            TextBox23.Visible = True
        Else
            TextBox23.Text = ""
            TextBox23.Visible = False
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox24.Visible = False Then
            TextBox24.Visible = True
        Else
            TextBox24.Text = ""
            TextBox24.Visible = False
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox25.Visible = False Then
            TextBox25.Visible = True
        Else
            TextBox25.Text = ""
            TextBox19.Visible = False
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox26.Visible = False Then
            TextBox26.Visible = True
        Else
            TextBox26.Text = ""
            TextBox26.Visible = False
        End If
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox4.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox4.Enabled = False
        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "Type your Full Name" Or TextBox4.Enabled = True And TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Or TextBox62.Text = "2017" And TextBox61.Text = "2016" Then
            MessageBox.Show("Please fill out your name, age,last school attended if transferee" + vbNewLine + " and  Please Select region, School Year.", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case MessageBox.Show("Please set the paper 'size from Letter' into 'Legal' ", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok

                    PageSetupDialog1.Document = PrintDocument1
                    PageSetupDialog1.Document.DefaultPageSettings.Color = True
                    PageSetupDialog1.ShowDialog()
                    PrintPreviewDialog1.ShowDialog()
            End Select
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Text = "Core Curriculum Subjects"


        ''STEM
        Button17.Visible = False
        Button15.Visible = False

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = False

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

        'Subjects and Quarter
        Label17.Visible = True
        Label18.Visible = True

        'Core
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        CheckBox7.Visible = True
        CheckBox8.Visible = True
        CheckBox9.Visible = True

        CheckBox11.Visible = True
        CheckBox12.Visible = True
        CheckBox13.Visible = True
        CheckBox14.Visible = True
        CheckBox15.Visible = True
        CheckBox31.Visible = True

        TextBox30.Visible = True
        TextBox31.Visible = True
        TextBox32.Visible = True
        TextBox33.Visible = True
        TextBox34.Visible = True
        TextBox35.Visible = True
        TextBox36.Visible = True
        TextBox37.Visible = True

        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True

        TextBox13.Visible = True
        TextBox14.Visible = True
        TextBox15.Visible = True
        TextBox16.Visible = True
        TextBox17.Visible = True
        TextBox18.Visible = True
        TextBox19.Visible = True


        TextBox38.Visible = True
        TextBox39.Visible = True
        TextBox40.Visible = True
        TextBox41.Visible = True
        TextBox42.Visible = True
        TextBox43.Visible = True
        TextBox44.Visible = True

        'Applied
        CheckBox16.Visible = False
        CheckBox17.Visible = False
        CheckBox18.Visible = False
        CheckBox19.Visible = False
        CheckBox20.Visible = False
        CheckBox21.Visible = False
        CheckBox22.Visible = False

        TextBox47.Visible = False
        TextBox48.Visible = False
        TextBox49.Visible = False
        TextBox50.Visible = False
        TextBox51.Visible = False
        TextBox52.Visible = False
        TextBox53.Visible = False

        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False

        'Specialized
        CheckBox26.Visible = False
        CheckBox27.Visible = False
        CheckBox28.Visible = False
        CheckBox29.Visible = False
        TextBox57.Visible = False
        TextBox58.Visible = False
        TextBox59.Visible = False
        TextBox60.Visible = False
        TextBox61.Visible = False
        TextBox62.Visible = False
        TextBox63.Visible = False
        TextBox64.Visible = False
        Panel2.Visible = False
        Panel5.Visible = False

        Button11.Visible = False
        Button12.Visible = False


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label6.Text = "Applied Track Subjects"

        ''STEM
        Button17.Visible = False
        Button15.Visible = False

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = False

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

        'Subjects and Quarter
        Label17.Visible = False
        Label18.Visible = False

        'Applied
        CheckBox16.Visible = True
        CheckBox17.Visible = True
        CheckBox18.Visible = True
        CheckBox19.Visible = True
        CheckBox20.Visible = True
        CheckBox21.Visible = True
        CheckBox22.Visible = True

        TextBox47.Visible = True
        TextBox48.Visible = True
        TextBox49.Visible = True
        TextBox50.Visible = True
        TextBox51.Visible = True
        TextBox52.Visible = True
        TextBox53.Visible = True

        TextBox20.Visible = True
        TextBox21.Visible = True
        TextBox22.Visible = True
        TextBox23.Visible = True
        TextBox24.Visible = True
        TextBox25.Visible = True
        TextBox26.Visible = True



        'Core
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False

        CheckBox11.Visible = False
        CheckBox12.Visible = False
        CheckBox13.Visible = False
        CheckBox14.Visible = False
        CheckBox15.Visible = False

        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False

        TextBox30.Visible = False
        TextBox31.Visible = False
        TextBox32.Visible = False
        TextBox33.Visible = False
        TextBox34.Visible = False
        TextBox35.Visible = False
        TextBox36.Visible = False
        TextBox37.Visible = False

        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False

        TextBox38.Visible = False
        TextBox39.Visible = False
        TextBox40.Visible = False
        TextBox41.Visible = False
        TextBox42.Visible = False
        TextBox43.Visible = False
        TextBox44.Visible = False

        'Specialized
        CheckBox26.Visible = False
        CheckBox27.Visible = False
        CheckBox28.Visible = False
        CheckBox29.Visible = False
        CheckBox31.Visible = False
        TextBox57.Visible = False
        TextBox58.Visible = False
        TextBox59.Visible = False
        TextBox60.Visible = False
        TextBox61.Visible = False
        TextBox62.Visible = False
        TextBox63.Visible = False
        TextBox64.Visible = False
        Panel2.Visible = False
        Panel5.Visible = False

        Button11.Visible = False
        Button12.Visible = False

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Label6.Text = "Specialized Subjects"

        'Subjects and Quarter
        Label17.Visible = False
        Label18.Visible = False

        'Specialized
        CheckBox26.Visible = True
        CheckBox27.Visible = True
        CheckBox28.Visible = True
        CheckBox29.Visible = True
        Panel5.Visible = True
        TextBox57.Visible = True
        TextBox58.Visible = True
        TextBox59.Visible = True
        TextBox60.Visible = True
        TextBox61.Visible = True
        TextBox62.Visible = True
        TextBox63.Visible = True
        TextBox64.Visible = True
        Panel2.Visible = True

        ''STEM
       Button17.Visible = False
        Button15.Visible = True

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = True

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = True

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
        'Core
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False

        CheckBox11.Visible = False
        CheckBox12.Visible = False
        CheckBox13.Visible = False
        CheckBox14.Visible = False
        CheckBox15.Visible = False
        CheckBox31.Visible = False

        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False

        TextBox30.Visible = False
        TextBox31.Visible = False
        TextBox32.Visible = False
        TextBox33.Visible = False
        TextBox34.Visible = False
        TextBox35.Visible = False
        TextBox36.Visible = False
        TextBox37.Visible = False

        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False

        TextBox38.Visible = False
        TextBox39.Visible = False
        TextBox40.Visible = False
        TextBox41.Visible = False
        TextBox42.Visible = False
        TextBox43.Visible = False
        TextBox44.Visible = False

        'Applied
        CheckBox16.Visible = False
        CheckBox17.Visible = False
        CheckBox18.Visible = False
        CheckBox19.Visible = False
        CheckBox20.Visible = False
        CheckBox21.Visible = False
        CheckBox22.Visible = False

        TextBox47.Visible = False
        TextBox48.Visible = False
        TextBox49.Visible = False
        TextBox50.Visible = False
        TextBox51.Visible = False
        TextBox52.Visible = False
        TextBox53.Visible = False

        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox64.KeyPress, TextBox63.KeyPress, TextBox62.KeyPress, TextBox61.KeyPress, TextBox60.KeyPress, TextBox6.KeyPress, TextBox59.KeyPress, TextBox58.KeyPress, TextBox57.KeyPress, TextBox53.KeyPress, TextBox52.KeyPress, TextBox51.KeyPress, TextBox50.KeyPress, TextBox5.KeyPress, TextBox49.KeyPress, TextBox48.KeyPress, TextBox47.KeyPress, TextBox44.KeyPress, TextBox43.KeyPress, TextBox42.KeyPress, TextBox41.KeyPress, TextBox40.KeyPress, TextBox39.KeyPress, TextBox38.KeyPress, TextBox37.KeyPress, TextBox36.KeyPress, TextBox35.KeyPress, TextBox34.KeyPress, TextBox33.KeyPress, TextBox32.KeyPress, TextBox31.KeyPress, TextBox30.KeyPress, TextBox26.KeyPress, TextBox25.KeyPress, TextBox24.KeyPress, TextBox23.KeyPress, TextBox22.KeyPress, TextBox21.KeyPress, TextBox20.KeyPress, TextBox19.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox30.Enabled = True
            TextBox5.Enabled = True
        Else
            TextBox30.Enabled = False
            TextBox5.Enabled = False
            TextBox30.Text = ""
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox6.Enabled = True
            TextBox31.Enabled = True
        Else
            TextBox31.Enabled = False
            TextBox6.Enabled = False
            TextBox31.Text = ""
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox32.Enabled = True
            TextBox7.Enabled = True
        Else
            TextBox32.Enabled = False
            TextBox7.Enabled = False
            TextBox32.Text = ""
            TextBox7.Text = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox33.Enabled = True
            TextBox8.Enabled = True
        Else
            TextBox33.Enabled = False
            TextBox8.Enabled = False
            TextBox33.Text = ""
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox34.Enabled = True
            TextBox9.Enabled = True
        Else
            TextBox34.Enabled = False
            TextBox9.Enabled = False
            TextBox34.Text = ""
            TextBox9.Text = ""
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox35.Enabled = True
            TextBox10.Enabled = True
        Else
            TextBox35.Enabled = False
            TextBox10.Enabled = False
            TextBox35.Text = ""
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox36.Enabled = True
            TextBox11.Enabled = True
        Else
            TextBox36.Enabled = False
            TextBox11.Enabled = False
            TextBox36.Text = ""
            TextBox11.Text = ""
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox37.Enabled = True
            TextBox12.Enabled = True
        Else
            TextBox37.Enabled = False
            TextBox12.Enabled = False
            TextBox37.Text = ""
            TextBox12.Text = ""
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            TextBox38.Enabled = True
            TextBox13.Enabled = True
        Else
            TextBox38.Enabled = False
            TextBox13.Enabled = False
            TextBox38.Text = ""
            TextBox13.Text = ""
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            TextBox39.Enabled = True
            TextBox14.Enabled = True
        Else
            TextBox39.Enabled = False
            TextBox14.Enabled = False
            TextBox39.Text = ""
            TextBox14.Text = ""
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            TextBox40.Enabled = True
            TextBox15.Enabled = True
        Else
            TextBox40.Enabled = False
            TextBox15.Enabled = False
            TextBox40.Text = ""
            TextBox15.Text = ""
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            TextBox41.Enabled = True
            TextBox16.Enabled = True
        Else
            TextBox41.Enabled = False
            TextBox16.Enabled = False
            TextBox41.Text = ""
            TextBox16.Text = ""
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            TextBox42.Enabled = True
            TextBox17.Enabled = True
        Else
            TextBox42.Enabled = False
            TextBox17.Enabled = False
            TextBox42.Text = ""
            TextBox17.Text = ""
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            TextBox43.Enabled = True
            TextBox18.Enabled = True
        Else
            TextBox43.Enabled = False
            TextBox18.Enabled = False
            TextBox43.Text = ""
            TextBox18.Text = ""
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked = True Then
            TextBox44.Enabled = True
            TextBox19.Enabled = True
        Else
            TextBox44.Enabled = False
            TextBox19.Enabled = False
            TextBox44.Text = ""
            TextBox19.Text = ""
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            TextBox47.Enabled = True
            TextBox20.Enabled = True
        Else
            TextBox47.Enabled = False
            TextBox20.Enabled = False
            TextBox47.Text = ""
            TextBox20.Text = ""
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            TextBox48.Enabled = True
            TextBox21.Enabled = True
        Else
            TextBox48.Enabled = False
            TextBox21.Enabled = False
            TextBox48.Text = ""
            TextBox21.Text = ""
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            TextBox49.Enabled = True
            TextBox22.Enabled = True
        Else
            TextBox49.Enabled = False
            TextBox22.Enabled = False
            TextBox49.Text = ""
            TextBox22.Text = ""
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            TextBox50.Enabled = True
            TextBox23.Enabled = True
        Else
            TextBox50.Enabled = False
            TextBox23.Enabled = False
            TextBox50.Text = ""
            TextBox23.Text = ""
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            TextBox51.Enabled = True
            TextBox24.Enabled = True
        Else
            TextBox51.Enabled = False
            TextBox24.Enabled = False
            TextBox51.Text = ""
            TextBox24.Text = ""
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            TextBox52.Enabled = True
            TextBox25.Enabled = True
        Else
            TextBox52.Enabled = False
            TextBox25.Enabled = False
            TextBox52.Text = ""
            TextBox25.Text = ""
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            TextBox53.Enabled = True
            TextBox26.Enabled = True
        Else
            TextBox53.Enabled = False
            TextBox26.Enabled = False
            TextBox53.Text = ""
            TextBox26.Text = ""
        End If
    End Sub




    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            TextBox59.Enabled = True
            TextBox60.Enabled = True
        Else
            TextBox59.Enabled = False
            TextBox60.Enabled = False
            TextBox59.Text = ""
            TextBox60.Text = ""
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            TextBox61.Enabled = True
            TextBox62.Enabled = True
        Else
            TextBox61.Enabled = False
            TextBox62.Enabled = False
            TextBox61.Text = ""
            TextBox62.Text = ""
        End If
    End Sub

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


   


    Private Sub Button11_Click_1(sender As Object, e As EventArgs)
        Button12.Visible = False
        Button12.Visible = True

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
    End Sub



    Private Sub CheckBox38_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            TextBox74.Enabled = True
            TextBox73.Enabled = True
        Else
            TextBox74.Enabled = False
            TextBox73.Enabled = False
            TextBox74.Text = ""
            TextBox73.Text = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged_2(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox72.Enabled = True
            TextBox71.Enabled = True
        Else
            TextBox72.Enabled = False
            TextBox71.Enabled = False
            TextBox72.Text = ""
            TextBox71.Text = ""
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            TextBox77.Enabled = True
            TextBox78.Enabled = True
        Else
            TextBox77.Enabled = False
            TextBox78.Enabled = False
            TextBox77.Text = ""
            TextBox78.Text = ""
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            TextBox80.Enabled = True
            TextBox79.Enabled = True
        Else
            TextBox80.Enabled = False
            TextBox79.Enabled = False
            TextBox80.Text = ""
            TextBox79.Text = ""
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            TextBox46.Enabled = True
            TextBox45.Enabled = True
        Else
            TextBox46.Enabled = False
            TextBox45.Enabled = False
            TextBox46.Text = ""
            TextBox45.Text = ""
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked = True Then
            TextBox68.Enabled = True
            TextBox67.Enabled = True
        Else
            TextBox68.Enabled = False
            TextBox67.Enabled = False
            TextBox68.Text = ""
            TextBox67.Text = ""
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked = True Then
            TextBox70.Enabled = True
            TextBox69.Enabled = True
        Else
            TextBox70.Enabled = False
            TextBox69.Enabled = False
            TextBox70.Text = ""
            TextBox69.Text = ""
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            TextBox76.Enabled = True
            TextBox75.Enabled = True
        Else
            TextBox76.Enabled = False
            TextBox75.Enabled = False
            TextBox76.Text = ""
            TextBox75.Text = ""
        End If
    End Sub

    Private Sub TextBox45_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox80.KeyPress, TextBox79.KeyPress, TextBox78.KeyPress, TextBox77.KeyPress, TextBox76.KeyPress, TextBox75.KeyPress, TextBox74.KeyPress, TextBox73.KeyPress, TextBox72.KeyPress, TextBox71.KeyPress, TextBox70.KeyPress, TextBox69.KeyPress, TextBox68.KeyPress, TextBox67.KeyPress, TextBox46.KeyPress, TextBox45.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'ANY NUMBERRR ONLY
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then    'BACKSPACE
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then 'SPACEBAR
            e.Handled = False
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button12.Visible = False
        Button11.Visible = True

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button12.Visible = True
        Button11.Visible = False

        Do While Panel2.Height < 181
            Panel2.Height += 1
        Loop
        ''STEM
        Button17.Visible = False
        Button15.Visible = True

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = True

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
    End Sub


    Private Sub a_CheckedChanged(sender As Object, e As EventArgs) Handles a.CheckedChanged
        If a.Checked = True Then
            a11.Enabled = True
            a22.Enabled = True
        Else
            a11.Enabled = False
            a22.Enabled = False
            a11.Text = ""
            a22.Text = ""
        End If
    End Sub

    Private Sub b_CheckedChanged(sender As Object, e As EventArgs) Handles b.CheckedChanged
        If b.Checked = True Then
            b1.Enabled = True
            b22.Enabled = True
        Else
            b1.Enabled = False
            b22.Enabled = False
            b1.Text = ""
            b22.Text = ""
        End If
    End Sub
   
    Private Sub aa_CheckedChanged(sender As Object, e As EventArgs) Handles aa.CheckedChanged
        If aa.Checked = True Then
            aa1.Enabled = True
            aa2.Enabled = True
        Else
            aa1.Enabled = False
            aa2.Enabled = False
            aa1.Text = ""
            aa2.Text = ""
        End If
    End Sub

    Private Sub bb_CheckedChanged(sender As Object, e As EventArgs) Handles bb.CheckedChanged
        If bb.Checked = True Then
            bb1.Enabled = True
            bb2.Enabled = True
        Else
            bb1.Enabled = False
            bb2.Enabled = False
            bb1.Text = ""
            bb2.Text = ""
        End If
    End Sub
    Private Sub cc_CheckedChanged(sender As Object, e As EventArgs) Handles cc.CheckedChanged
        If cc.Checked = True Then
            cc1.Enabled = True
            cc2.Enabled = True
        Else
            cc1.Enabled = False
            cc2.Enabled = False
            cc1.Text = ""
            cc2.Text = ""
        End If
    End Sub

    Private Sub dd_CheckedChanged(sender As Object, e As EventArgs) Handles dd.CheckedChanged
        If dd.Checked = True Then
            dd1.Enabled = True
            dd2.Enabled = True
        Else
            dd1.Enabled = False
            dd2.Enabled = False
            dd1.Text = ""
            dd2.Text = ""
        End If
    End Sub
   

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button17.Visible = True
        Button15.Visible = False

        Do While Panel4.Height < 181
            Panel4.Height += 1
        Loop
        ''ABM
        Button14.Visible = False
        Button13.Visible = True

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = True

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Button14.Visible = True
        Button13.Visible = False

        Do While Panel3.Height < 181
            Panel3.Height += 1
        Loop

        ''HUMMANITIES
        Button12.Visible = False
        Button11.Visible = True

        Do While Panel2.Height > 0
            Panel2.Height -= 1
        Loop
        ''STEM
        Button17.Visible = False
        Button15.Visible = True

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Visible = False
        Button13.Visible = True

        Do While Panel3.Height > 0
            Panel3.Height -= 1
        Loop
    End Sub
    Private Sub c_CheckedChanged(sender As Object, e As EventArgs) Handles c.CheckedChanged
        If c.Checked = True Then
            c1.Enabled = True
            c2.Enabled = True
        Else
            c1.Enabled = False
            c2.Enabled = False
            c1.Text = ""
            c2.Text = ""
        End If
    End Sub

    Private Sub d_CheckedChanged(sender As Object, e As EventArgs) Handles d.CheckedChanged
        If d.Checked = True Then
            d1.Enabled = True
            d2.Enabled = True
        Else
            d1.Enabled = False
            d2.Enabled = False
            d1.Text = ""
            d2.Text = ""
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked = True Then
            TextBox88.Enabled = True
            TextBox87.Enabled = True
        Else
            TextBox88.Enabled = False
            TextBox87.Enabled = False
            TextBox87.Text = ""
            TextBox88.Text = ""
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked = True Then
            TextBox86.Enabled = True
            TextBox85.Enabled = True
        Else
            TextBox86.Enabled = False
            TextBox85.Enabled = False
            TextBox85.Text = ""
            TextBox86.Text = ""
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            TextBox84.Enabled = True
            TextBox83.Enabled = True
        Else
            TextBox84.Enabled = False
            TextBox83.Enabled = False
            TextBox84.Text = ""
            TextBox83.Text = ""
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked = True Then
            TextBox82.Enabled = True
            TextBox81.Enabled = True
        Else
            TextBox81.Enabled = False
            TextBox82.Enabled = False
            TextBox81.Text = ""
            TextBox82.Text = ""
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            TextBox54.Enabled = True
            TextBox55.Enabled = True
        Else
            TextBox54.Enabled = False
            TextBox55.Enabled = False
            TextBox54.Text = ""
            TextBox55.Text = ""
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked = True Then
            TextBox66.Enabled = True
            TextBox65.Enabled = True
        Else
            TextBox66.Enabled = False
            TextBox65.Enabled = False
            TextBox65.Text = ""
            TextBox66.Text = ""
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            TextBox28.Enabled = True
            TextBox27.Enabled = True
        Else
            TextBox28.Enabled = False
            TextBox27.Enabled = False
            TextBox28.Text = ""
            TextBox27.Text = ""
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.Visible = False
        Button15.Visible = True

        Do While Panel4.Height > 0
            Panel4.Height -= 1
        Loop
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            TextBox57.Enabled = True
            TextBox58.Enabled = True
        Else
            TextBox57.Enabled = False
            TextBox58.Enabled = False
            TextBox58.Text = ""
            TextBox57.Text = ""
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Do While Panel5.Height < 77
            Panel5.Height += 1
        Loop
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Do While Panel5.Height > 0
            Panel5.Height -= 1
        Loop
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub TextBox48_TextChanged(sender As Object, e As EventArgs) Handles TextBox48.TextChanged

    End Sub

    Private Sub TextBox49_TextChanged(sender As Object, e As EventArgs) Handles TextBox49.TextChanged

    End Sub

    Private Sub TextBox50_TextChanged(sender As Object, e As EventArgs) Handles TextBox50.TextChanged

    End Sub

    Private Sub TextBox51_TextChanged(sender As Object, e As EventArgs) Handles TextBox51.TextChanged

    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub TextBox52_TextChanged(sender As Object, e As EventArgs) Handles TextBox52.TextChanged

    End Sub

    Private Sub TextBox47_TextChanged(sender As Object, e As EventArgs) Handles TextBox47.TextChanged

    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub TextBox53_TextChanged(sender As Object, e As EventArgs) Handles TextBox53.TextChanged

    End Sub

  

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox4.Enabled = True
        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray


    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Type your Full Name" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Type your Full Name"
            TextBox1.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Select Region" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "Select Region"
            ComboBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox56_Enter(sender As Object, e As EventArgs) Handles TextBox56.Enter
        If TextBox56.Text = "2016" Then
            TextBox56.Text = ""
            TextBox56.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox56_Leave(sender As Object, e As EventArgs) Handles TextBox56.Leave
        If TextBox56.Text = "" Then
            TextBox56.Text = "2016"
            TextBox56.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox29_Enter(sender As Object, e As EventArgs) Handles TextBox29.Enter
        If TextBox29.Text = "2017" Then
            TextBox29.Text = ""
            TextBox29.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox29_Leave(sender As Object, e As EventArgs) Handles TextBox29.Leave
        If TextBox29.Text = "" Then
            TextBox29.Text = "2017"
            TextBox29.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        If TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then
            TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
            TextBox4.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox4.Enabled = False
        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray
    End Sub
End Class