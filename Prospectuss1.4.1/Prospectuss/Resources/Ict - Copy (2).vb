Imports System.Drawing.Printing

Public Class Ict

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        STRANDS.Show()
        Me.Hide()

        Label6.Text = "Core Curriculum Subjects"
        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray
        ComboBox1.Text = "Select Your Region"
        ComboBox1.ForeColor = Color.Gray
        TextBox1.Text = "Type your Full Name"
        TextBox1.ForeColor = Color.Gray
        TextBox61.Text = "2016"
        TextBox61.ForeColor = Color.Gray
        TextBox62.Text = "2017"
        TextBox62.ForeColor = Color.Gray
        RadioButton2.Checked = True
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
        CheckBox10.Visible = True
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
        CheckBox10.Checked = False
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

        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False

        Panel2.Hide()
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
        TextBox61.Text = "2016"
        TextBox61.ForeColor = Color.Gray
        TextBox62.Text = "2017"
        TextBox62.ForeColor = Color.Gray
        RadioButton2.Checked = True
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
        CheckBox10.Visible = True
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
        CheckBox10.Checked = False
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

        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False

        Panel2.Hide()
    End Sub




    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "Type your Full Name" Or TextBox4.Enabled = True And TextBox4.Text = " PLEASE  DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Or TextBox62.Text = "2017" And TextBox61.Text = "2016" Then
            MessageBox.Show("Please fill out your name, age,last school attended if transferee" + vbNewLine + " and  Please Select region, School Year.", "Digital Prospectus in Cainta Senior High Schol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            ''  PageSetupDialog1.Document = PrintDocument1

            PageSetupDialog1.ShowDialog()
            Me.PrintDocument1.Print()
            '' PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Legal", 850, 1100)

        End If


    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs)
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False

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

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox27.Visible = False Then
            TextBox27.Visible = True
        Else
            TextBox27.Text = ""
            TextBox27.Visible = False
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

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox28.Visible = False Then
            TextBox28.Visible = True
        Else
            TextBox28.Text = ""
            TextBox28.Visible = False
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs)
        If TextBox29.Visible = False Then
            TextBox29.Visible = True
        Else
            TextBox29.Text = ""
            TextBox29.Visible = False
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
        If TextBox1.Text = "Type your Full Name" Or TextBox4.Enabled = True And TextBox4.Text = " PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Or TextBox62.Text = "2017" And TextBox61.Text = "2016" Then
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



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
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
            TextBox5.Enabled = True
            TextBox30.Enabled = True
        Else
            TextBox5.Enabled = False
            TextBox30.Enabled = False
            TextBox5.Text = ""
            TextBox30.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox6.Enabled = True
            TextBox31.Enabled = True
        Else
            TextBox6.Enabled = False
            TextBox31.Enabled = False
            TextBox6.Text = ""
            TextBox31.Text = ""
        End If
    End Sub


    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox7.Enabled = True
            TextBox32.Enabled = True
        Else
            TextBox7.Enabled = False
            TextBox32.Enabled = False
            TextBox7.Text = ""
            TextBox32.Text = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox8.Enabled = True
            TextBox33.Enabled = True
        Else
            TextBox8.Enabled = False
            TextBox33.Enabled = False
            TextBox8.Text = ""
            TextBox33.Text = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox9.Enabled = True
            TextBox34.Enabled = True
        Else
            TextBox9.Enabled = False
            TextBox34.Enabled = False
            TextBox9.Text = ""
            TextBox34.Text = ""
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox10.Enabled = True
            TextBox35.Enabled = True
        Else
            TextBox10.Enabled = False
            TextBox35.Enabled = False
            TextBox10.Text = ""
            TextBox35.Text = ""
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox11.Enabled = True
            TextBox36.Enabled = True
        Else
            TextBox11.Enabled = False
            TextBox36.Enabled = False
            TextBox11.Text = ""
            TextBox36.Text = ""
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox12.Enabled = True
            TextBox37.Enabled = True
        Else
            TextBox12.Enabled = False
            TextBox37.Enabled = False
            TextBox12.Text = ""
            TextBox37.Text = ""
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            TextBox13.Enabled = True
            TextBox38.Enabled = True
        Else
            TextBox13.Enabled = False
            TextBox38.Enabled = False
            TextBox13.Text = ""
            TextBox38.Text = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox14.Enabled = True
            TextBox39.Enabled = True
        Else
            TextBox14.Enabled = False
            TextBox39.Enabled = False
            TextBox14.Text = ""
            TextBox39.Text = ""
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            TextBox15.Enabled = True
            TextBox40.Enabled = True
        Else
            TextBox15.Enabled = False
            TextBox40.Enabled = False
            TextBox15.Text = ""
            TextBox40.Text = ""
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            TextBox16.Enabled = True
            TextBox41.Enabled = True
        Else
            TextBox16.Enabled = False
            TextBox41.Enabled = False
            TextBox16.Text = ""
            TextBox41.Text = ""
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            TextBox17.Enabled = True
            TextBox42.Enabled = True
        Else
            TextBox17.Enabled = False
            TextBox42.Enabled = False
            TextBox17.Text = ""
            TextBox42.Text = ""
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            TextBox18.Enabled = True
            TextBox43.Enabled = True
        Else
            TextBox18.Enabled = False
            TextBox43.Enabled = False
            TextBox18.Text = ""
            TextBox43.Text = ""
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            TextBox19.Enabled = True
            TextBox44.Enabled = True
        Else
            TextBox19.Enabled = False
            TextBox44.Enabled = False
            TextBox19.Text = ""
            TextBox44.Text = ""
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            TextBox20.Enabled = True
            TextBox47.Enabled = True
        Else
            TextBox20.Enabled = False
            TextBox47.Enabled = False
            TextBox20.Text = ""
            TextBox47.Text = ""
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            TextBox21.Enabled = True
            TextBox48.Enabled = True
        Else
            TextBox21.Enabled = False
            TextBox48.Enabled = False
            TextBox21.Text = ""
            TextBox48.Text = ""
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            TextBox22.Enabled = True
            TextBox49.Enabled = True
        Else
            TextBox22.Enabled = False
            TextBox49.Enabled = False
            TextBox22.Text = ""
            TextBox49.Text = ""
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged_1(sender As Object, e As EventArgs)
        If CheckBox19.Checked = True Then
            TextBox23.Enabled = True
            TextBox50.Enabled = True
        Else
            TextBox23.Enabled = False
            TextBox50.Enabled = False
            TextBox23.Text = ""
            TextBox50.Text = ""
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            TextBox24.Enabled = True
            TextBox51.Enabled = True
        Else
            TextBox24.Enabled = False
            TextBox51.Enabled = False
            TextBox24.Text = ""
            TextBox51.Text = ""
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            TextBox25.Enabled = True
            TextBox52.Enabled = True
        Else
            TextBox25.Enabled = False
            TextBox52.Enabled = False
            TextBox25.Text = ""
            TextBox52.Text = ""
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            TextBox26.Enabled = True
            TextBox53.Enabled = True
        Else
            TextBox26.Enabled = False
            TextBox53.Enabled = False
            TextBox26.Text = ""
            TextBox53.Text = ""
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            TextBox27.Enabled = True
            TextBox54.Enabled = True
        Else
            TextBox27.Enabled = False
            TextBox54.Enabled = False
            TextBox27.Text = ""
            TextBox54.Text = ""
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            TextBox28.Enabled = True
            TextBox55.Enabled = True
        Else
            TextBox28.Enabled = False
            TextBox55.Enabled = False
            TextBox28.Text = ""
            TextBox55.Text = ""
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            TextBox29.Enabled = True
            TextBox56.Enabled = True
        Else
            TextBox29.Enabled = False
            TextBox56.Enabled = False
            TextBox29.Text = ""
            TextBox56.Text = ""
        End If
    End Sub

    Private Sub TextBox54_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox54.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox22.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox23.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox28.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox29_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox29.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox30_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox30.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox31_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox31.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox32.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox33_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox34_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox34.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox35_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox35.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox36_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox36.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox37_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox37.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox38_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox38.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox39_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox39.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox40_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox40.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox41_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox41.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox42_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox42.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox43_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox43.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox44_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox44.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox47_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox47.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox48_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox48.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox49_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox49.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox50.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox51_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox51.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox52_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox52.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox53_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox53.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox55_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox55.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox56_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox56.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Text = "Core Curriculum Subjects"

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
        CheckBox10.Visible = True
        CheckBox11.Visible = True
        CheckBox12.Visible = True
        CheckBox13.Visible = True
        CheckBox14.Visible = True
        CheckBox15.Visible = True

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

        Panel2.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label6.Text = "Applied Track Subjects"
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
        CheckBox10.Visible = False
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

        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False

        TextBox30.Visible = False
        TextBox31.Visible = False
        TextBox32.Visible = False
        TextBox33.Visible = False
        TextBox34.Visible = False
        TextBox35.Visible = False
        TextBox36.Visible = False
        TextBox37.Visible = False

        TextBox38.Visible = False
        TextBox39.Visible = False
        TextBox40.Visible = False
        TextBox41.Visible = False
        TextBox42.Visible = False
        TextBox43.Visible = False
        TextBox44.Visible = False


        'Specialized

        Panel2.Hide()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Label6.Text = "Specialized Subjects"

        'Specialized
        Panel2.Show()
      

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
        CheckBox10.Visible = False
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim a As Bitmap = My.Resources.even_lower_res 'Left CSHS
        Dim b As Bitmap = My.Resources.DEPED 'Right DEPED
        Dim c As Bitmap = My.Resources.SCHOOL 'Background Images
        Dim r As New Rectangle(730, 20, 60, 60) 'Left CSHS
        Dim rr As New Rectangle(80, 20, 60, 60) 'Right DEPED
        Dim rrr As New Rectangle(30, 250, 800, 800) 'Background Images


        Dim BOX As New Rectangle(51, 165, 744, 840) 'WHOLE BOX
        Dim h1box As New Rectangle(51, 165, 744, 44) 'FIRST BOX
        Dim h2box As New Rectangle(51, 660, 744, 44) 'SECOND BOX
        Dim h3box As New Rectangle(51, 870, 744, 44) 'THIRD BOX
        Dim V1box As New Rectangle(650, 165, 145, 1095) 'first Vertical Box
        Dim VV1box As New Rectangle(695, 209, 44, 451) 'first short vertical box
        Dim VV2box As New Rectangle(695, 704, 44, 166) 'second short vertical box
        Dim VV3box As New Rectangle(695, 914, 44, 226) 'third vertical box

        ''-20
        e.Graphics.DrawImage(a, r) 'Left CSHS
        e.Graphics.DrawImage(b, rr)  'Right DEPED
        e.Graphics.DrawImage(c, rrr) 'Background Images


        Dim font1 As New Font("Calibri", 11, FontStyle.Bold)
        Dim font2 As New Font("Calibri ", 11, FontStyle.Bold)
        Dim font3 As New Font("Cambria", 20, FontStyle.Bold)
        Dim font33 As New Font("Calibri ", 10, FontStyle.Bold)
        Dim T As New Font("Calibri ", 20, FontStyle.Regular)

        'Headings
        e.Graphics.DrawString("CAINTA SENIOR HIGH SCHOOL", font3, Brushes.Black, 220, 30)
        e.Graphics.DrawString("PROSPECTUS", font33, Brushes.Black, 380, 60)
        e.Graphics.DrawString("S.Y." + TextBox61.Text + "-" + TextBox62.Text, font1, Brushes.Black, 375, 75)

        e.Graphics.DrawString("Name: " + TextBox1.Text, font1, Brushes.Black, 70, 90)
        If RadioButton1.Checked = True Then
            e.Graphics.DrawString("Transferee  ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 110)
        End If
        If RadioButton2.Checked = True Then
            e.Graphics.DrawString("Irregular   ( ✓ )" + vbNewLine + "Last School Attended: " + "Cainta Senior High School", font1, Brushes.Black, 70, 110)
        End If
        If RadioButton3.Checked = True Then
            e.Graphics.DrawString("Alternative Learning System ('ALS')   ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 110)
        End If
        If RadioButton4.Checked = True Then
            e.Graphics.DrawString("Regular   ( ✓ )" + vbNewLine + "Last School Attended: " + TextBox4.Text, font1, Brushes.Black, 70, 110)
        End If
        e.Graphics.DrawString("DATE: " + Date.Now.ToString("MM/dd/yyyy") + vbNewLine + "TVL - ICT", font2, Brushes.Black, 660, 90)
        e.Graphics.DrawString("Region : " + ComboBox1.Text, font1, Brushes.Black, 70, 145)

        'Core Curriculum
        e.Graphics.DrawRectangle(Pens.Black, BOX)
        e.Graphics.DrawRectangle(Pens.Black, h1box)
        e.Graphics.DrawRectangle(Pens.Black, V1box)
        e.Graphics.DrawRectangle(Pens.Black, VV1box)
        e.Graphics.DrawString("              Senior High School " + vbNewLine +
                              "                Core Curriculum", font1, Brushes.Black, 60, 190)
        e.Graphics.DrawString("T I M E", T, Brushes.Black, 480, 190)
        e.Graphics.DrawLine(Pens.Black, 395, 185, 395, 1280) 'Line to First Box to Third Box
        e.Graphics.DrawLine(Pens.Black, 739, 185, 739, 229) ' basta line sa time
        e.Graphics.DrawString("   Quarter       Final", font1, Brushes.Black, 650, 185)
        e.Graphics.DrawLine(Pens.Black, 695, 209, 695, 229) ' basta line din sya sa lien sa time
        e.Graphics.DrawString("  1st     2nd   Grade", font1, Brushes.Black, 650, 205)
        Dim ff1 As New Font("Century Gothic", 6, FontStyle.Bold)

        e.Graphics.DrawString(" Semester   Semester ", ff1, Brushes.Black, 650, 218)

      

        e.Graphics.DrawString("___________", font1, Brushes.Black, 648, 188) ' naghahati sa quarter at 1wst at second
        Try
            If CheckBox1.Checked = False Then
                e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 250)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
            ElseIf TextBox5.Text = "" Then
                e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 250)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                ''//////
                If TextBox30.Text <= 74 Then
                    e.Graphics.DrawString(TextBox30.Text, font1, Brushes.Red, 655, 250)
                Else
                    e.Graphics.DrawString(TextBox30.Text, font1, Brushes.Black, 655, 250)
                End If
                ''//////
                   ElseIf TextBox30.Text = "" Then
                e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 250)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                If TextBox5.Text <= 74 Then
                    e.Graphics.DrawString(TextBox5.Text, font1, Brushes.Red, 700, 250)
                Else
                    e.Graphics.DrawString(TextBox5.Text, font1, Brushes.Black, 700, 250)
                End If

            Else

                Dim a1 As Integer = CInt(TextBox5.Text)
                Dim b2 As Integer = CInt(TextBox30.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString("  • Oral Communication", font1, Brushes.Black, 60, 250)
                e.Graphics.DrawString(TextBox5.Text, font1, Brushes.Black, 700, 250)
                e.Graphics.DrawString(TextBox30.Text, font1, Brushes.Black, 655, 250)
                If c3 <= 74 Then
                    e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 250)
                    e.Graphics.DrawString(c3, font1, Brushes.Red, 755, 250)
                Else
                    e.Graphics.DrawString("               P   A    S    S    ", font1, Brushes.Black, 405, 250)
                    e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 250)
                End If
                End If

            If CheckBox2.Checked = False Then
                e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 270)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
            ElseIf TextBox6.Text = "" Then
                e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 270)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
                e.Graphics.DrawString(TextBox31.Text, font1, Brushes.Black, 655, 270)
            ElseIf TextBox31.Text = "" Then
                e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 270)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 270)
                e.Graphics.DrawString(TextBox6.Text, font1, Brushes.Black, 700, 270)
            Else
                Dim aa1 As Integer = CInt(TextBox6.Text)
                Dim bb2 As Integer = CInt(TextBox31.Text)
                Dim cc3 As Integer = (aa1 + bb2) / 2
                e.Graphics.DrawString("  • Reading And Writing", font1, Brushes.Black, 60, 270)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 270)
                e.Graphics.DrawString(TextBox6.Text, font1, Brushes.Black, 700, 270)
                e.Graphics.DrawString(TextBox31.Text, font1, Brushes.Black, 655, 270)
                e.Graphics.DrawString(cc3, font1, Brushes.Black, 755, 270)
            End If



            If CheckBox3.Checked = False Then
                e.Graphics.DrawString("  • Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 290)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 310)
            ElseIf TextBox7.Text = "" Then
                e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 290)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 310)
                e.Graphics.DrawString(TextBox32.Text, font1, Brushes.Black, 655, 310)
            ElseIf TextBox32.Text = "" Then
                e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 290)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 310)
                e.Graphics.DrawString(TextBox7.Text, font1, Brushes.Black, 700, 310)
            Else
                Dim a1 As Integer = CInt(TextBox5.Text)
                Dim b2 As Integer = CInt(TextBox30.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString("  •  Komunikasyon at Pananaliksik sa" + vbNewLine + "      Wika at  Kulturang Pilipino", font1, Brushes.Black, 60, 290)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 310)
                e.Graphics.DrawString(TextBox7.Text, font1, Brushes.Black, 700, 310)
                e.Graphics.DrawString(TextBox32.Text, font1, Brushes.Black, 655, 310)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 310)
            End If


            If CheckBox4.Checked = False Then
                e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                      "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 330)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 350)
            ElseIf TextBox8.Text = "" Then
                e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                          "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 330)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 350)
                e.Graphics.DrawString(TextBox33.Text, font1, Brushes.Black, 655, 350)
            ElseIf TextBox33.Text = "" Then
                e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                          "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 330)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 350)
                e.Graphics.DrawString(TextBox8.Text, font1, Brushes.Black, 700, 350)
            Else
                Dim a4 As Integer = CInt(TextBox8.Text)
                Dim b4 As Integer = CInt(TextBox33.Text)
                Dim c4 As Integer = (a4 + b4) / 2
                e.Graphics.DrawString("  • Pagbasa at Pagsusuri ng imba't ibang" + vbNewLine +
                                          "       Teksto Tungo sa Panaliksisk", font1, Brushes.Black, 60, 330)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 350)
                e.Graphics.DrawString(TextBox8.Text, font1, Brushes.Black, 700, 350)
                e.Graphics.DrawString(TextBox33.Text, font1, Brushes.Black, 655, 350)
                e.Graphics.DrawString(c4, font1, Brushes.Black, 755, 350)
            End If


            If CheckBox5.Checked = False Then
                e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                      "       Fr. Phil to World", font1, Brushes.Black, 60, 370)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
            ElseIf TextBox9.Text = "" Then
                e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                          "       Fr. Phil to World", font1, Brushes.Black, 60, 370)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
                e.Graphics.DrawString(TextBox34.Text, font1, Brushes.Black, 655, 390)
            ElseIf TextBox34.Text = "" Then
                e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                          "       Fr. Phil to World", font1, Brushes.Black, 60, 370)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 390)
                e.Graphics.DrawString(TextBox9.Text, font1, Brushes.Black, 700, 390)
            Else
                Dim a5 As Integer = CInt(TextBox9.Text)
                Dim b5 As Integer = CInt(TextBox34.Text)
                Dim c5 As Integer = (a5 + b5) / 2
                e.Graphics.DrawString("  • 21st Century Literature " + vbNewLine +
                                          "       Fr. Phil to World", font1, Brushes.Black, 60, 370)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 390)
                e.Graphics.DrawString(TextBox9.Text, font1, Brushes.Black, 700, 390)
                e.Graphics.DrawString(TextBox34.Text, font1, Brushes.Black, 655, 390)
                e.Graphics.DrawString(c5, font1, Brushes.Black, 755, 390)
            End If


            If CheckBox6.Checked = False Then
                e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                      "       from the Regions", font1, Brushes.Black, 60, 410)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
            ElseIf TextBox10.Text = "" Then
                e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                          "       from the Regions", font1, Brushes.Black, 60, 410)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
                e.Graphics.DrawString(TextBox35.Text, font1, Brushes.Black, 655, 430)
            ElseIf TextBox35.Text = "" Then
                e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                          "       from the Regions", font1, Brushes.Black, 60, 410)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 430)
                e.Graphics.DrawString(TextBox10.Text, font1, Brushes.Black, 700, 430)
            Else
                Dim a6 As Integer = CInt(TextBox10.Text)
                Dim b6 As Integer = CInt(TextBox35.Text)
                Dim c6 As Integer = (a6 + b6) / 2
                e.Graphics.DrawString("  • Contemporary Phillipine Arts" + vbNewLine +
                                          "       from the Regions", font1, Brushes.Black, 60, 410)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 430)
                e.Graphics.DrawString(TextBox10.Text, font1, Brushes.Black, 700, 430)
                e.Graphics.DrawString(TextBox35.Text, font1, Brushes.Black, 655, 430)
                e.Graphics.DrawString(c6, font1, Brushes.Black, 755, 430)
            End If


            If CheckBox7.Checked = False Then
                e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 450)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
            ElseIf TextBox11.Text = "" Then
                e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 450)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
                e.Graphics.DrawString(TextBox36.Text, font1, Brushes.Black, 655, 450)
            ElseIf TextBox36.Text = "" Then
                e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 450)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 450)
                e.Graphics.DrawString(TextBox11.Text, font1, Brushes.Black, 700, 450)
            Else
                Dim a7 As Integer = CInt(TextBox11.Text)
                Dim b7 As Integer = CInt(TextBox36.Text)
                Dim c7 As Integer = (a7 + b7) / 2
                e.Graphics.DrawString("  • Media and Information Literacy", font1, Brushes.Black, 60, 450)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 450)
                e.Graphics.DrawString(TextBox11.Text, font1, Brushes.Black, 700, 450)
                e.Graphics.DrawString(TextBox36.Text, font1, Brushes.Black, 655, 450)
                e.Graphics.DrawString(c7, font1, Brushes.Black, 755, 450)
            End If


            If CheckBox8.Checked = False Then
                e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 470)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
            ElseIf TextBox12.Text = "" Then
                e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 470)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
                e.Graphics.DrawString(TextBox37.Text, font1, Brushes.Black, 655, 470)
            ElseIf TextBox37.Text = "" Then
                e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 470)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 470)
                e.Graphics.DrawString(TextBox12.Text, font1, Brushes.Black, 700, 470)
            Else
                Dim a8 As Integer = CInt(TextBox12.Text)
                Dim b8 As Integer = CInt(TextBox37.Text)
                Dim c8 As Integer = (a8 + b8) / 2
                e.Graphics.DrawString("  • General Math", font1, Brushes.Black, 60, 470)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 470)
                e.Graphics.DrawString(TextBox12.Text, font1, Brushes.Black, 700, 470)
                e.Graphics.DrawString(TextBox37.Text, font1, Brushes.Black, 655, 470)
                e.Graphics.DrawString(c8, font1, Brushes.Black, 755, 470)
            End If

            If CheckBox9.Checked = False Then
                e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 490)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
            ElseIf TextBox13.Text = "" Then
                e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 490)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
                e.Graphics.DrawString(TextBox38.Text, font1, Brushes.Black, 655, 490)
            ElseIf TextBox38.Text = "" Then
                e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 490)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 490)
                e.Graphics.DrawString(TextBox13.Text, font1, Brushes.Black, 700, 490)
            Else
                Dim a9 As Integer = CInt(TextBox13.Text)
                Dim b9 As Integer = CInt(TextBox38.Text)
                Dim c9 As Integer = (a9 + b9) / 2
                e.Graphics.DrawString("  • Statistics and Probability", font1, Brushes.Black, 60, 490)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 490)
                e.Graphics.DrawString(TextBox13.Text, font1, Brushes.Black, 700, 490)
                e.Graphics.DrawString(TextBox38.Text, font1, Brushes.Black, 655, 490)
                e.Graphics.DrawString(c9, font1, Brushes.Black, 755, 490)
            End If


            If CheckBox10.Checked = False Then
                e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 510)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
            ElseIf TextBox14.Text = "" Then
                e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 510)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
                e.Graphics.DrawString(TextBox39.Text, font1, Brushes.Black, 655, 510)
            ElseIf TextBox39.Text = "" Then
                e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 510)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 510)
                e.Graphics.DrawString(TextBox14.Text, font1, Brushes.Black, 700, 510)
            Else
                Dim a10 As Integer = CInt(TextBox14.Text)
                Dim b10 As Integer = CInt(TextBox39.Text)
                Dim c10 As Integer = (a10 + b10) / 2
                e.Graphics.DrawString("  • Earth and Life Science", font1, Brushes.Black, 60, 510)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 510)
                e.Graphics.DrawString(TextBox14.Text, font1, Brushes.Black, 700, 510)
                e.Graphics.DrawString(TextBox39.Text, font1, Brushes.Black, 655, 510)
                e.Graphics.DrawString(c10, font1, Brushes.Black, 755, 510)
            End If


            If CheckBox11.Checked = False Then
                e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 530)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
            ElseIf TextBox15.Text = "" Then
                e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 530)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
                e.Graphics.DrawString(TextBox40.Text, font1, Brushes.Black, 655, 530)
            ElseIf TextBox40.Text = "" Then
                e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 530)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 530)
                e.Graphics.DrawString(TextBox15.Text, font1, Brushes.Black, 700, 530)
            Else
                Dim a11 As Integer = CInt(TextBox15.Text)
                Dim b11 As Integer = CInt(TextBox40.Text)
                Dim c11 As Integer = (a11 + b11) / 2
                e.Graphics.DrawString("  • Physical Science", font1, Brushes.Black, 60, 530)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 530)
                e.Graphics.DrawString(TextBox15.Text, font1, Brushes.Black, 700, 530)
                e.Graphics.DrawString(TextBox40.Text, font1, Brushes.Black, 655, 530)
                e.Graphics.DrawString(c11, font1, Brushes.Black, 755, 530)
            End If


            If CheckBox12.Checked = False Then
                e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 550)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 570)
            ElseIf TextBox16.Text = "" Then
                e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 550)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 570)
                e.Graphics.DrawString(TextBox41.Text, font1, Brushes.Black, 655, 570)
            ElseIf TextBox41.Text = "" Then
                e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 550)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 570)
                e.Graphics.DrawString(TextBox16.Text, font1, Brushes.Black, 700, 570)
            Else
                Dim a12 As Integer = CInt(TextBox16.Text)
                Dim b12 As Integer = CInt(TextBox41.Text)
                Dim c12 As Integer = (a12 + b12) / 2
                e.Graphics.DrawString("  • Introduction to Philosopy" + vbNewLine + "      of the Human Person", font1, Brushes.Black, 60, 550)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 570)
                e.Graphics.DrawString(TextBox16.Text, font1, Brushes.Black, 700, 570)
                e.Graphics.DrawString(TextBox41.Text, font1, Brushes.Black, 655, 570)
                e.Graphics.DrawString(c12, font1, Brushes.Black, 755, 570)
            End If


            If CheckBox13.Checked = False Then
                e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 590)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
            ElseIf TextBox17.Text = "" Then
                e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 590)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
                e.Graphics.DrawString(TextBox42.Text, font1, Brushes.Black, 655, 590)
            ElseIf TextBox42.Text = "" Then
                e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 590)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 590)
                e.Graphics.DrawString(TextBox17.Text, font1, Brushes.Black, 700, 590)
            Else
                Dim a13 As Integer = CInt(TextBox17.Text)
                Dim b13 As Integer = CInt(TextBox42.Text)
                Dim c13 As Integer = (a13 + b13) / 2
                e.Graphics.DrawString("  • Physical Education and Health", font1, Brushes.Black, 60, 590)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 590)
                e.Graphics.DrawString(TextBox17.Text, font1, Brushes.Black, 700, 590)
                e.Graphics.DrawString(TextBox42.Text, font1, Brushes.Black, 655, 590)
                e.Graphics.DrawString(c13, font1, Brushes.Black, 755, 590)
            End If


            If CheckBox14.Checked = False Then
                e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 610)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
            ElseIf TextBox18.Text = "" Then
                e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 610)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
                e.Graphics.DrawString(TextBox43.Text, font1, Brushes.Black, 655, 610)
            ElseIf TextBox43.Text = "" Then
                e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 610)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 610)
                e.Graphics.DrawString(TextBox18.Text, font1, Brushes.Black, 700, 610)
            Else
                Dim a14 As Integer = CInt(TextBox18.Text)
                Dim b14 As Integer = CInt(TextBox43.Text)
                Dim c14 As Integer = (a14 + b14) / 2
                e.Graphics.DrawString("  • Personal Development", font1, Brushes.Black, 60, 610)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 610)
                e.Graphics.DrawString(TextBox18.Text, font1, Brushes.Black, 700, 610)
                e.Graphics.DrawString(TextBox43.Text, font1, Brushes.Black, 655, 610)
                e.Graphics.DrawString(c14, font1, Brushes.Black, 755, 610)
            End If


            If CheckBox15.Checked = False Then
                e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 630)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 650)
            ElseIf TextBox19.Text = "" Then
                e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 630)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 650)
                e.Graphics.DrawString(TextBox44.Text, font1, Brushes.Black, 655, 650)
            ElseIf TextBox44.Text = "" Then
                e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 630)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 650)
                e.Graphics.DrawString(TextBox19.Text, font1, Brushes.Black, 700, 650)
            Else
                Dim a15 As Integer = CInt(TextBox19.Text)
                Dim b15 As Integer = CInt(TextBox44.Text)
                Dim c15 As Integer = (a15 + b15) / 2
                e.Graphics.DrawString("  • Understanding Culture, " + vbNewLine + "      Society and Politics", font1, Brushes.Black, 60, 630)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 650)
                e.Graphics.DrawString(TextBox19.Text, font1, Brushes.Black, 700, 650)
                e.Graphics.DrawString(TextBox44.Text, font1, Brushes.Black, 655, 650)
                e.Graphics.DrawString(c15, font1, Brushes.Black, 755, 650)
            End If

            'Applied Subjectas
            e.Graphics.DrawRectangle(Pens.Black, h2box)
            e.Graphics.DrawString("              Senior High School " + vbNewLine +
                                 "                Applied Subjects ", font1, Brushes.Black, 50, 685)
            e.Graphics.DrawString("T I M E", T, Brushes.Black, 480, 685)
            e.Graphics.DrawString("   Quarter      Final", font1, Brushes.Black, 650, 681)
            e.Graphics.DrawLine(Pens.Black, 739, 680, 739, 724) 'basta line din
            e.Graphics.DrawLine(Pens.Black, 695, 702, 695, 724) 'basta line din
            e.Graphics.DrawString("___________", font1, Brushes.Black, 650, 684) 'same
            e.Graphics.DrawRectangle(Pens.Black, VV2box)
            e.Graphics.DrawString("   1st   2nd    Grade", font1, Brushes.Black, 650, 703)


            If CheckBox16.Checked = False Then
                e.Graphics.DrawString("   • English for Academic Purposes", font1, Brushes.Black, 60, 740)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 740)
            ElseIf TextBox20.Text = "" Then
                e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 740)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 740)
                e.Graphics.DrawString(TextBox47.Text, font1, Brushes.Black, 655, 740)
            ElseIf TextBox47.Text = "" Then
                e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 740)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 740)
                e.Graphics.DrawString(TextBox20.Text, font1, Brushes.Black, 700, 740)
            Else
                Dim a16 As Integer = CInt(TextBox20.Text)
                Dim b16 As Integer = CInt(TextBox47.Text)
                Dim c16 As Integer = (a16 + b16) / 2
                e.Graphics.DrawString("  • English for Academic Purposes", font1, Brushes.Black, 60, 740)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 740)
                e.Graphics.DrawString(TextBox20.Text, font1, Brushes.Black, 700, 740)
                e.Graphics.DrawString(TextBox47.Text, font1, Brushes.Black, 655, 740)
                e.Graphics.DrawString(c16, font1, Brushes.Black, 755, 740)
            End If


            If CheckBox17.Checked = False Then
                e.Graphics.DrawString("   • Practical Research 1", font1, Brushes.Black, 60, 760)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 760)
            ElseIf TextBox21.Text = "" Then
                e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 760)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 760)
                e.Graphics.DrawString(TextBox48.Text, font1, Brushes.Black, 655, 760)
            ElseIf TextBox48.Text = "" Then
                e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 760)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 760)
                e.Graphics.DrawString(TextBox21.Text, font1, Brushes.Black, 700, 760)
            Else
                Dim a17 As Integer = CInt(TextBox21.Text)
                Dim b17 As Integer = CInt(TextBox48.Text)
                Dim c17 As Integer = (a17 + b17) / 2
                e.Graphics.DrawString("  • Practical Research 1", font1, Brushes.Black, 60, 760)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 760)
                e.Graphics.DrawString(TextBox21.Text, font1, Brushes.Black, 700, 760)
                e.Graphics.DrawString(TextBox48.Text, font1, Brushes.Black, 655, 760)
                e.Graphics.DrawString(c17, font1, Brushes.Black, 755, 760)
            End If


            If CheckBox18.Checked = False Then
                e.Graphics.DrawString("   • Practical Reseach 2", font1, Brushes.Black, 60, 780)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 780)
            ElseIf TextBox22.Text = "" Then
                e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 780)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 780)
                e.Graphics.DrawString(TextBox49.Text, font1, Brushes.Black, 655, 780)
            ElseIf TextBox49.Text = "" Then
                e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 780)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 780)
                e.Graphics.DrawString(TextBox22.Text, font1, Brushes.Black, 700, 780)
            Else
                Dim a18 As Integer = CInt(TextBox22.Text)
                Dim b18 As Integer = CInt(TextBox49.Text)
                Dim c18 As Integer = (a18 + b18) / 2
                e.Graphics.DrawString("  • Practical Reseach 2", font1, Brushes.Black, 60, 780)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 780)
                e.Graphics.DrawString(TextBox22.Text, font1, Brushes.Black, 700, 780)
                e.Graphics.DrawString(TextBox49.Text, font1, Brushes.Black, 655, 780)
                e.Graphics.DrawString(c18, font1, Brushes.Black, 755, 780)
            End If


            If CheckBox19.Checked = False Then
                e.Graphics.DrawString("   • Filipino sa Piling Larang", font1, Brushes.Black, 60, 800)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 800)
            ElseIf TextBox23.Text = "" Then
                e.Graphics.DrawString("   • Filipino sa Piling Larang", font1, Brushes.Black, 60, 800)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 800)
                e.Graphics.DrawString(TextBox50.Text, font1, Brushes.Black, 655, 800)
            ElseIf TextBox50.Text = "" Then
                e.Graphics.DrawString("   • Filipino sa Piling Larang", font1, Brushes.Black, 60, 800)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 800)
                e.Graphics.DrawString(TextBox23.Text, font1, Brushes.Black, 700, 800)
            Else
                Dim a19 As Integer = CInt(TextBox23.Text)
                Dim b19 As Integer = CInt(TextBox50.Text)
                Dim c19 As Integer = (a19 + b19) / 2
                e.Graphics.DrawString(TextBox23.Text, font1, Brushes.Black, 700, 800)
                e.Graphics.DrawString("   • Filipino sa Piling Larang", font1, Brushes.Black, 60, 800)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 800)
                e.Graphics.DrawString(TextBox50.Text, font1, Brushes.Black, 655, 800)
                e.Graphics.DrawString(c19, font1, Brushes.Black, 755, 800)
            End If


            If CheckBox20.Checked = False Then
                e.Graphics.DrawString("   • Empowerment Technologies", font1, Brushes.Black, 60, 820)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 820)
            ElseIf TextBox24.Text = "" Then
                e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 820)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 820)
                e.Graphics.DrawString(TextBox51.Text, font1, Brushes.Black, 655, 820)
            ElseIf TextBox51.Text = "" Then
                e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 820)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 820)
                e.Graphics.DrawString(TextBox24.Text, font1, Brushes.Black, 700, 820)
            Else
                Dim a20 As Integer = CInt(TextBox24.Text)
                Dim b20 As Integer = CInt(TextBox51.Text)
                Dim c20 As Integer = (a20 + b20) / 2
                e.Graphics.DrawString(TextBox24.Text, font1, Brushes.Black, 700, 820)
                e.Graphics.DrawString("  • Empowerment Technologies", font1, Brushes.Black, 60, 820)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 820)
                e.Graphics.DrawString(TextBox51.Text, font1, Brushes.Black, 655, 820)
                e.Graphics.DrawString(c20, font1, Brushes.Black, 755, 820)
            End If


            If CheckBox21.Checked = False Then
                e.Graphics.DrawString("   • Entrepreneurship", font1, Brushes.Black, 60, 840)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 840)
            ElseIf TextBox25.Text = "" Then
                e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 840)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 840)
                e.Graphics.DrawString(TextBox52.Text, font1, Brushes.Black, 655, 840)
            ElseIf TextBox52.Text = "" Then
                e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 840)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 840)
                e.Graphics.DrawString(TextBox25.Text, font1, Brushes.Black, 700, 840)
            Else
                Dim a21 As Integer = CInt(TextBox25.Text)
                Dim b21 As Integer = CInt(TextBox52.Text)
                Dim c21 As Integer = (a21 + b21) / 2
                e.Graphics.DrawString(TextBox25.Text, font1, Brushes.Black, 700, 840)
                e.Graphics.DrawString("  • Entrepreneurship", font1, Brushes.Black, 60, 840)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 840)
                e.Graphics.DrawString(TextBox52.Text, font1, Brushes.Black, 655, 840)
                e.Graphics.DrawString(c21, font1, Brushes.Black, 755, 840)
            End If


            If CheckBox22.Checked = False Then
                e.Graphics.DrawString("   • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 860)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 860)
            ElseIf TextBox26.Text = "" Then
                e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 860)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 860)
                e.Graphics.DrawString(TextBox53.Text, font1, Brushes.Black, 655, 860)
            ElseIf TextBox53.Text = "" Then
                e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 860)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 860)
                e.Graphics.DrawString(TextBox26.Text, font1, Brushes.Black, 700, 860)
            Else
                Dim a22 As Integer = CInt(TextBox26.Text)
                Dim b22 As Integer = CInt(TextBox53.Text)
                Dim c22 As Integer = (a22 + b22) / 2
                e.Graphics.DrawString(TextBox26.Text, font1, Brushes.Black, 700, 860)
                e.Graphics.DrawString("  • Inquiries, Investigations and Immersion", font1, Brushes.Black, 60, 860)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 860)
                e.Graphics.DrawString(TextBox53.Text, font1, Brushes.Black, 655, 860)
                e.Graphics.DrawString(c22, font1, Brushes.Black, 755, 860)
            End If

            'Major Subjects
            e.Graphics.DrawRectangle(Pens.Black, h3box)
            e.Graphics.DrawRectangle(Pens.Black, VV3box)
            e.Graphics.DrawLine(Pens.Black, 739, 890, 739, 934)
            e.Graphics.DrawLine(Pens.Black, 695, 912, 695, 934)
            e.Graphics.DrawString("___________", font1, Brushes.Black, 650, 895)
            e.Graphics.DrawString("               Major Subjects ", font1, Brushes.Black, 60, 900)
            e.Graphics.DrawString("T I M E", T, Brushes.Black, 490, 895)
            e.Graphics.DrawString("   Quarter     Final", font1, Brushes.Black, 650, 890)
            e.Graphics.DrawString("   1st   2nd   Grade", font1, Brushes.Black, 650, 912)

            If CheckBox23.Checked = False Then
                e.Graphics.DrawString("   • Computer Programming (Oracle)", font1, Brushes.Black, 60, 950)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 950)
            ElseIf TextBox27.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (Oracle)", font1, Brushes.Black, 60, 950)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 950)
                e.Graphics.DrawString(TextBox54.Text, font1, Brushes.Black, 655, 950)
            ElseIf TextBox54.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (Oracle)", font1, Brushes.Black, 60, 950)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 950)
                e.Graphics.DrawString(TextBox27.Text, font1, Brushes.Black, 700, 950)
            Else
                Dim a1 As Integer = CInt(TextBox27.Text)
                Dim b2 As Integer = CInt(TextBox54.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(TextBox27.Text, font1, Brushes.Black, 700, 950)
                e.Graphics.DrawString("  • Computer Programming (Oracle)", font1, Brushes.Black, 60, 950)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 950)
                e.Graphics.DrawString(TextBox54.Text, font1, Brushes.Black, 655, 950)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 950)
            End If

            If CheckBox24.Checked = False Then
                e.Graphics.DrawString("   • Computer Programming (.Net)", font1, Brushes.Black, 60, 970)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 970)
            ElseIf TextBox28.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (.Net)", font1, Brushes.Black, 60, 970)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 970)
                e.Graphics.DrawString(TextBox55.Text, font1, Brushes.Black, 655, 970)
            ElseIf TextBox55.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (.Net)", font1, Brushes.Black, 60, 970)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 970)
                e.Graphics.DrawString(TextBox28.Text, font1, Brushes.Black, 700, 970)
            Else
                Dim a1 As Integer = CInt(TextBox28.Text)
                Dim b2 As Integer = CInt(TextBox55.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(TextBox28.Text, font1, Brushes.Black, 700, 970)
                e.Graphics.DrawString("  • Computer Programming (.Net)", font1, Brushes.Black, 60, 970)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 970)
                e.Graphics.DrawString(TextBox55.Text, font1, Brushes.Black, 655, 970)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 970)
            End If

            If CheckBox25.Checked = False Then
                e.Graphics.DrawString("   • Computer Programming (Java)", font1, Brushes.Black, 60, 990)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 990)
            ElseIf TextBox29.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (Java)", font1, Brushes.Black, 60, 990)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 990)
                e.Graphics.DrawString(TextBox56.Text, font1, Brushes.Black, 655, 990)
            ElseIf TextBox56.Text = "" Then
                e.Graphics.DrawString("  • Computer Programming (Java)", font1, Brushes.Black, 60, 990)
                e.Graphics.DrawString("_____________  |  _____________", font1, Brushes.Black, 405, 990)
                e.Graphics.DrawString(TextBox29.Text, font1, Brushes.Black, 700, 990)
            Else
                Dim a1 As Integer = CInt(TextBox29.Text)
                Dim b2 As Integer = CInt(TextBox56.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(TextBox29.Text, font1, Brushes.Black, 700, 990)
                e.Graphics.DrawString("  • Computer Programming (Java)", font1, Brushes.Black, 60, 990)
                e.Graphics.DrawString("               T   A    K    E    N", font1, Brushes.Black, 405, 990)
                e.Graphics.DrawString(TextBox56.Text, font1, Brushes.Black, 655, 990)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 990)

            End If

            Dim booox As New Rectangle(51, 1025, 744, 255) 'LAST BOX
            e.Graphics.DrawRectangle(Pens.Black, booox) 'LAST BOX 
            Dim f1 As New Font("Century Gothic", 8, FontStyle.Bold)
            e.Graphics.DrawString("NOTE: Cainta Senior High School" + vbNewLine + "does not offer this subjects", f1, Brushes.Red, 80, 1030)

            If CheckBox26.Checked = False Then
                e.Graphics.DrawString(vbNewLine + "   • Animation", font1, Brushes.Black, 60, 1050)
                e.Graphics.DrawString(vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1050)
            ElseIf TextBox45.Text = "" Then
                e.Graphics.DrawString(vbNewLine + "   • Animation", font1, Brushes.Black, 60, 1050)
                e.Graphics.DrawString(vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1050)
                e.Graphics.DrawString(vbNewLine + TextBox46.Text, font1, Brushes.Black, 655, 1050)
            ElseIf TextBox46.Text = "" Then
                e.Graphics.DrawString(vbNewLine + "   • Animation", font1, Brushes.Black, 60, 1050)
                e.Graphics.DrawString(vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1050)
                e.Graphics.DrawString(vbNewLine + TextBox45.Text, font1, Brushes.Black, 700, 1050)
            Else
                Dim a1 As Integer = CInt(TextBox45.Text)
                Dim b2 As Integer = CInt(TextBox46.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(vbNewLine + TextBox45.Text, font1, Brushes.Black, 700, 1050)
                e.Graphics.DrawString(vbNewLine + "   • Animation", font1, Brushes.Black, 60, 1050)
                e.Graphics.DrawString(vbNewLine + "               T   A    K    E    N", font1, Brushes.Black, 405, 1050)
                e.Graphics.DrawString(vbNewLine + TextBox46.Text, font1, Brushes.Black, 655, 1050)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 1070)

            End If

            If CheckBox27.Checked = False Then
                e.Graphics.DrawString(vbNewLine + "   • Broadband Installation" + vbNewLine + "     (Fixed Wireless Systems)", font1, Brushes.Black, 60, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1070)
            ElseIf TextBox57.Text = "" Then
                e.Graphics.DrawString(vbNewLine + "   • Broadband Installation" + vbNewLine + "     (Fixed Wireless Systems)", font1, Brushes.Black, 60, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox58.Text, font1, Brushes.Black, 655, 1070)
            ElseIf TextBox58.Text = "" Then
                e.Graphics.DrawString(vbNewLine + "   • Broadband Installation" + vbNewLine + "     (Fixed Wireless Systems)", font1, Brushes.Black, 60, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox57.Text, font1, Brushes.Black, 700, 1070)
            Else
                Dim a1 As Integer = CInt(TextBox58.Text)
                Dim b2 As Integer = CInt(TextBox57.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox57.Text, font1, Brushes.Black, 700, 1070)
                e.Graphics.DrawString(vbNewLine + "   • Broadband Installation" + vbNewLine + "     (Fixed Wireless Systems)", font1, Brushes.Black, 60, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "               T   A    K    E    N", font1, Brushes.Black, 405, 1070)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox58.Text, font1, Brushes.Black, 655, 1070)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 1110)
            End If

            If CheckBox28.Checked = False Then
                e.Graphics.DrawString(vbNewLine + vbNewLine + "   • Computer Systems Servicing", font1, Brushes.Black, 60, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1090)
            ElseIf TextBox59.Text = "" Then
                e.Graphics.DrawString(vbNewLine + vbNewLine + "   • Computer Systems Servicing", font1, Brushes.Black, 60, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox60.Text, font1, Brushes.Black, 655, 1090)
            ElseIf TextBox60.Text = "" Then
                e.Graphics.DrawString(vbNewLine + vbNewLine + "   • Computer Systems Servicing", font1, Brushes.Black, 60, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "_____________  |  _____________", font1, Brushes.Black, 405, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox59.Text, font1, Brushes.Black, 700, 1090)
            Else
                Dim a1 As Integer = CInt(TextBox60.Text)
                Dim b2 As Integer = CInt(TextBox59.Text)
                Dim c3 As Integer = (a1 + b2) / 2
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox59.Text, font1, Brushes.Black, 700, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "   • Computer Systems Servicing", font1, Brushes.Black, 60, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + "               T   A    K    E    N", font1, Brushes.Black, 405, 1090)
                e.Graphics.DrawString(vbNewLine + vbNewLine + TextBox60.Text, font1, Brushes.Black, 655, 1090)
                e.Graphics.DrawString(c3, font1, Brushes.Black, 755, 1130)

            End If

            ''IMMERSION BOXX
            e.Graphics.DrawLine(Pens.Black, 51, 1160, 795, 1160) ''immersion box
            e.Graphics.DrawString("Date: mm/dd/yyyy ", font1, Brushes.Black, 450, 1180)
            e.Graphics.DrawString("No. of " + vbNewLine + "Hours", font1, Brushes.Black, 660, 1170)
            e.Graphics.DrawString("Final " + vbNewLine + "Grade", font1, Brushes.Black, 730, 1170)
            e.Graphics.DrawLine(Pens.Black, 395, 1210, 795, 1210)
            e.Graphics.DrawLine(Pens.Black, 720, 1160, 720, 1280) 'vertical Line

            If CheckBox29.Checked = False Then
                e.Graphics.DrawString("   • WORK IMMERSION", font1, Brushes.Black, 60, 1220)
                e.Graphics.DrawString("Start :" + " _____________________", font1, Brushes.Black, 405, 1230)
                e.Graphics.DrawString(" End : " + "_____________________", font1, Brushes.Black, 405, 1250)
            Else
                e.Graphics.DrawString("   • WORK IMMERSION", font1, Brushes.Black, 60, 1220)
                e.Graphics.DrawString("Start : " + DateTimePicker1.Text, font1, Brushes.Black, 450, 1230)
                e.Graphics.DrawString(" End : " + DateTimePicker1.Text, font1, Brushes.Black, 450, 1250)
                e.Graphics.DrawString(TextBox63.Text, font1, Brushes.Black, 655, 1240)
                e.Graphics.DrawString(TextBox64.Text, font1, Brushes.Black, 750, 1240)

            End If
        Catch
            MessageBox.Show("Invalid Input.", "Digital Prospectus in Cainta Senior High School", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            TextBox45.Enabled = True
            TextBox46.Enabled = True
        Else
            TextBox45.Enabled = False
            TextBox46.Enabled = False
            TextBox45.Text = ""
            TextBox46.Text = ""
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            TextBox58.Enabled = True
            TextBox57.Enabled = True
        Else
            TextBox58.Enabled = False
            TextBox57.Enabled = False
            TextBox58.Text = ""
            TextBox57.Text = ""
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            TextBox60.Enabled = True
            TextBox59.Enabled = True
        Else
            TextBox59.Enabled = False
            TextBox60.Enabled = False
            TextBox59.Text = ""
            TextBox60.Text = ""
        End If
    End Sub

   
    Private Sub CheckBox19_CheckedChanged_2(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            TextBox23.Enabled = True
            TextBox50.Enabled = True
        Else
            TextBox23.Enabled = False
            TextBox50.Enabled = False
            TextBox23.Text = ""
            TextBox50.Text = ""
        End If
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox4.Enabled = True
    End Sub

    Private Sub TextBox61_Leave(sender As Object, e As EventArgs) Handles TextBox61.Leave
        If TextBox61.Text = "" Then
            TextBox61.Text = "2016"
            TextBox61.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox61_Enter(sender As Object, e As EventArgs) Handles TextBox61.Enter
        If TextBox61.Text = "2016" Then
            TextBox61.Text = ""
            TextBox61.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Type your Full Name"
            TextBox1.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Type your Full Name" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "Select Region"
            ComboBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Select Region" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then
            TextBox4.Text = " PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
            TextBox4.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        If TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox4.Enabled = False
        TextBox4.Text = "PLEASE DO NOT ABBREVIATE THE NAME OF YOUR SCHOOL"
        TextBox4.ForeColor = Color.Gray

    End Sub

    Private Sub TextBox62_Enter(sender As Object, e As EventArgs) Handles TextBox62.Enter
        If TextBox62.Text = "2017" Then
            TextBox62.Text = ""
            TextBox62.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox62_Leave(sender As Object, e As EventArgs) Handles TextBox62.Leave
        If TextBox62.Text = "" Then
            TextBox62.Text = "2017"
            TextBox62.ForeColor = Color.Gray
        End If
    End Sub
End Class