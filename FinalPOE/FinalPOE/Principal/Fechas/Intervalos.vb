Public Class Intervalos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hasta luego.")
        Me.Close()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MFechas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d As Date
        d = DateTimePicker1.Value
        If ComboBox1.Text = "Día" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(TextBox1.Text)
        ElseIf ComboBox1.Text = "Mes" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(TextBox1.Text)
        ElseIf ComboBox1.Text = "Trimestre" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(TextBox1.Text * 3)
        ElseIf ComboBox1.Text = "Año" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddYears(TextBox1.Text)
        End If
    End Sub
End Class