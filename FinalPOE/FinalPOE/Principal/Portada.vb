﻿Public Class Portada
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu As New MMenu
        menu.Show()
        Me.Hide()
    End Sub
End Class
