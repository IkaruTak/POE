Public Class Menu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim portada As New Portada
        portada.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim secuencias As New MSecuencias
        secuencias.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cadenas As New MCadenas
        cadenas.Show()
        Me.Hide()
    End Sub
End Class