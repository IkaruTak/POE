Public Class Vencimiento
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
        Dim Hoy As Date = Date.Now.Date
        Dim x As Integer

        If ComboBox1.Text = "Dias" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(TextBox2.Text)
        ElseIf ComboBox1.Text = "Meses" Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(TextBox2.Text)
        End If

        If DateTimePicker2.Value.DayOfWeek = DayOfWeek.Saturday Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(2)
        ElseIf DateTimePicker2.Value.DayOfWeek = DayOfWeek.Sunday Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(2)
        End If

        If DateTimePicker2.Value.DayOfWeek = DayOfWeek.Saturday And DateTimePicker2.Value.AddDays(2) >= Date.Now.Date Then
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(2)
            x = DateDiff(DateInterval.Day, Date.Now.Date, DateTimePicker2.Value.Date)
            TextBox1.Text = "Faltan " & x & " días para que venza el plazo"
        ElseIf DateTimePicker2.Value.DayOfWeek = DayOfWeek.Sunday And DateTimePicker2.Value.AddDays(1) >= Date.Now.Date Then
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1)
            x = DateDiff(DateInterval.Day, Date.Now.Date, DateTimePicker2.Value.Date)
            TextBox1.Text = "Faltan " & x & " días para que venza el plazo"
        ElseIf DateTimePicker2.Value > Date.Now.Date Then
            x = DateDiff(DateInterval.Day, Date.Now.Date, DateTimePicker2.Value.Date)
            TextBox1.Text = "Faltan " & x & " días para que venza el plazo"
        Else
            x = DateDiff(DateInterval.Day, DateTimePicker2.Value.Date, Date.Now.Date)
            TextBox1.Text = "El plazo se venció hace " & x & " días"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class