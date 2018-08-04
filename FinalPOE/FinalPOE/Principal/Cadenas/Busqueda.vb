Public Class Busqueda
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MCadenas.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Hasta Luego")
        Me.Close()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim origen, buscar As String
        Dim idi, idf As Integer
        origen = TextBox1.Text
        buscar = TextBox2.Text
        Dim existe As Boolean

        existe = origen.Contains(buscar)
        If existe Then
            idi = origen.IndexOf(buscar)
            idf = idi + (buscar.Length) - 1
            TextBox3.Text = (String.Format("Se encontra desde {0} hasta {1}.", idi, idf))
        Else
            TextBox3.Text = ("No se encontró la cadena.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class