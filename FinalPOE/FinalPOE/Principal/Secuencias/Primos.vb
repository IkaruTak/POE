Public Class Primos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MSecuencias.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Long
        Dim j, sw, lim As Integer
        Dim a As Single

        lim = TextBox1.Text

        ListBox1.Items.Add(1)
        For i = 2 To lim
            sw = 0
            For j = 1 To i
                a = i Mod j
                If a = 0 Then
                    sw += 1
                End If
            Next j
            If sw = 2 Then
                ListBox1.Items.Add(i)
            End If
        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Hasta luego.")
        Me.Close()
        End
    End Sub
End Class