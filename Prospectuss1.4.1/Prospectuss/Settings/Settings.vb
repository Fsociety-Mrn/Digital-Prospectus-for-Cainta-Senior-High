

Public Class Settings

    '' Show the Major,
    Public Sub Show_hide(Core As Panel, Applied As Panel, Major As Panel, bool As Boolean())
        Core.Visible = bool(0)
        Applied.Visible = bool(1)
        Major.Visible = bool(2)
    End Sub

    '' handle set text
    Public Sub Cleartext(textbox As TextBox, Optional placeholdertext As String = "type your full name")

        If textbox.Text = placeholdertext Then
            textbox.Text = ""
            textbox.ForeColor = Color.Black

        End If
    End Sub

    Public Sub SetText(textbox As TextBox, Optional placeholdertext As String = "type your full name")

        If String.IsNullOrEmpty(textbox.Text) Then
            textbox.Text = placeholdertext
            textbox.ForeColor = Color.Gray

        End If
    End Sub

    '' Checkbox text
    Public Sub HandleTextBoxState(checkbox As CheckBox, ParamArray textBoxes() As TextBox)
        Dim isChecked As Boolean = checkbox.Checked

        For Each textBox As TextBox In textBoxes
            textBox.Enabled = isChecked
            If Not isChecked Then textBox.Text = ""
        Next
    End Sub

End Class
