Public Class Palindromo
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MCadenas.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hasta Luego")
        Me.Close()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Function TurnString(Cadena As String)
        Dim turnedString As String = ""
        For Each C As String In Cadena
            turnedString = C + turnedString
        Next
        Return turnedString
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim origen As String
        origen = TextBox1.Text
        origen = origen.Replace(" "c, String.Empty)
        origen = origen.ToUpper()
        origen = TurnString(origen)
        TextBox2.Text = origen
        If (TextBox1.Text.Replace(" "c, String.Empty).ToUpper = origen) Then
            TextBox2.Text = TextBox2.Text + " Es palindromo"
        Else
            TextBox2.Text = TextBox2.Text + " No es palindromo"
        End If
    End Sub
End Class