Public Class Matrices
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MSecuencias.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tb As TextBox
        Randomize()

        Dim i, j As Integer
        For i = 0 To 3
            For j = 0 To 3
                tb = GetControl((String.Format("A{0}{1}", i, j)))
                tb.Text = CInt(Int((100 * Rnd()) + 1))
                tb = GetControl((String.Format("B{0}{1}", i, j)))
                tb.Text = CInt(Int((100 * Rnd()) + 1))
            Next j
        Next i
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub
    Public Function GetControl(name As String) As TextBox
        Dim tb As TextBox = Nothing
        Dim ctrl() As Control = Me.Controls.Find(name, True)

        If ctrl.Length > 0 Then
            tb = DirectCast(ctrl(0), TextBox)
        End If
        Return tb
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MatrizA = New Double(3, 3) {{A00.Text, A01.Text, A02.Text, A03.Text}, {A10.Text, A11.Text, A12.Text, A13.Text}, {A20.Text, A21.Text, A22.Text, A23.Text}, {A30.Text, A31.Text, A32.Text, A33.Text}}
        Dim MatrizB = New Double(3, 3) {{B00.Text, B01.Text, B02.Text, B03.Text}, {B10.Text, B11.Text, B12.Text, B13.Text}, {B20.Text, B21.Text, B22.Text, B23.Text}, {B30.Text, B31.Text, B32.Text, B33.Text}}
        Dim MatrizR(3, 3) As Double
        Dim tb As TextBox
        Dim i, j As Integer

        Label5.Text = "+"
        For i = 0 To 3
            For j = 0 To 3
                MatrizR(i, j) = MatrizA(i, j) + MatrizB(i, j)
                tb = GetControl((String.Format("R{0}{1}", i, j)))
                tb.Text = MatrizR(i, j)
            Next j
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MatrizA = New Double(3, 3) {{A00.Text, A01.Text, A02.Text, A03.Text}, {A10.Text, A11.Text, A12.Text, A13.Text}, {A20.Text, A21.Text, A22.Text, A23.Text}, {A30.Text, A31.Text, A32.Text, A33.Text}}
        Dim MatrizB = New Double(3, 3) {{B00.Text, B01.Text, B02.Text, B03.Text}, {B10.Text, B11.Text, B12.Text, B13.Text}, {B20.Text, B21.Text, B22.Text, B23.Text}, {B30.Text, B31.Text, B32.Text, B33.Text}}
        Dim MatrizR(3, 3) As Double
        Dim tb As TextBox
        Dim i, j As Integer

        Label5.Text = "-"
        For i = 0 To 3
            For j = 0 To 3
                MatrizR(i, j) = MatrizA(i, j) - MatrizB(i, j)
                tb = GetControl((String.Format("R{0}{1}", i, j)))
                tb.Text = MatrizR(i, j)
            Next j
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MatrizA = New Double(3, 3) {{A00.Text, A01.Text, A02.Text, A03.Text}, {A10.Text, A11.Text, A12.Text, A13.Text}, {A20.Text, A21.Text, A22.Text, A23.Text}, {A30.Text, A31.Text, A32.Text, A33.Text}}
        Dim MatrizB = New Double(3, 3) {{B00.Text, B01.Text, B02.Text, B03.Text}, {B10.Text, B11.Text, B12.Text, B13.Text}, {B20.Text, B21.Text, B22.Text, B23.Text}, {B30.Text, B31.Text, B32.Text, B33.Text}}
        Dim MatrizR(3, 3) As Double
        Dim tb As TextBox
        Dim i, j As Integer

        Label5.Text = "X"
        For i = 0 To 3
            For j = 0 To 3
                MatrizR(i, j) = (MatrizA(0, j) * MatrizB(i, 0)) + (MatrizA(1, j) * MatrizB(i, 1)) + (MatrizA(2, j) * MatrizB(i, 2)) + (MatrizA(3, j) * MatrizB(i, 3))
                tb = GetControl((String.Format("R{0}{1}", i, j)))
                tb.Text = MatrizR(i, j)
            Next j
        Next i
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Hasta luego.")
        Me.Close()
        End
    End Sub
End Class
