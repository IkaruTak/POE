Public Class Saturno
    Private Sub A0_TextChanged(sender As Object, e As EventArgs) Handles A0.TextChanged
        C1.Text = Val(A0.Text) + Val(A1.Text) + Val(A2.Text)
        F1.Text = Val(A0.Text) + Val(B0.Text) + Val(C0.Text)
        D2.Text = Val(A0.Text) + Val(B1.Text) + Val(CZ.Text)
        If C1.Text = "15" Then
            C1.ForeColor = Color.Green
        Else
            C1.ForeColor = SystemColors.Highlight
        End If
        If F1.Text = "15" Then
            F1.ForeColor = Color.Green
        Else
            F1.ForeColor = SystemColors.Highlight
        End If
        If D2.Text = "15" Then
            D2.ForeColor = Color.Green
        Else
            D2.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub B0_TextChanged(sender As Object, e As EventArgs) Handles B0.TextChanged
        C2.Text = Val(B0.Text) + Val(B1.Text) + Val(B2.Text)
        F1.Text = Val(A0.Text) + Val(B0.Text) + Val(C0.Text)
        If C2.Text = "15" Then
            C2.ForeColor = Color.Green
        Else
            C2.ForeColor = SystemColors.Highlight
        End If
        If F1.Text = "15" Then
            F1.ForeColor = Color.Green
        Else
            F1.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub C0_TextChanged(sender As Object, e As EventArgs) Handles C0.TextChanged
        C3.Text = Val(C0.Text) + Val(CI.Text) + Val(CZ.Text)
        F1.Text = Val(A0.Text) + Val(B0.Text) + Val(C0.Text)
        D1.Text = Val(A2.Text) + Val(B1.Text) + Val(C0.Text)
        If C3.Text = "15" Then
            C3.ForeColor = Color.Green
        Else
            C3.ForeColor = SystemColors.Highlight
        End If
        If F1.Text = "15" Then
            F1.ForeColor = Color.Green
        Else
            F1.ForeColor = SystemColors.Highlight
        End If
        If D1.Text = "15" Then
            D1.ForeColor = Color.Green
        Else
            D1.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub A1_TextChanged(sender As Object, e As EventArgs) Handles A1.TextChanged
        C1.Text = Val(A0.Text) + Val(A1.Text) + Val(A2.Text)
        F2.Text = Val(A1.Text) + Val(B1.Text) + Val(CI.Text)
        If C1.Text = "15" Then
            C1.ForeColor = Color.Green
        Else
            C1.ForeColor = SystemColors.Highlight
        End If
        If F2.Text = "15" Then
            F2.ForeColor = Color.Green
        Else
            F2.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub B1_TextChanged(sender As Object, e As EventArgs) Handles B1.TextChanged
        C2.Text = Val(B0.Text) + Val(B1.Text) + Val(B2.Text)
        F2.Text = Val(A1.Text) + Val(B1.Text) + Val(CI.Text)
        D2.Text = Val(A0.Text) + Val(B1.Text) + Val(CZ.Text)
        D1.Text = Val(A2.Text) + Val(B1.Text) + Val(C0.Text)
        If C2.Text = "15" Then
            C2.ForeColor = Color.Green
        Else
            C2.ForeColor = SystemColors.Highlight
        End If
        If F2.Text = "15" Then
            F2.ForeColor = Color.Green
        Else
            F2.ForeColor = SystemColors.Highlight
        End If
        If D2.Text = "15" Then
            D2.ForeColor = Color.Green
        Else
            D2.ForeColor = SystemColors.Highlight
        End If
        If D1.Text = "15" Then
            D1.ForeColor = Color.Green
        Else
            D1.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub CI_TextChanged(sender As Object, e As EventArgs) Handles CI.TextChanged
        C3.Text = Val(C0.Text) + Val(CI.Text) + Val(CZ.Text)
        F2.Text = Val(A1.Text) + Val(B1.Text) + Val(CI.Text)
        If C3.Text = "15" Then
            C3.ForeColor = Color.Green
        Else
            C3.ForeColor = SystemColors.Highlight
        End If
        If F2.Text = "15" Then
            F2.ForeColor = Color.Green
        Else
            F2.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub A2_TextChanged(sender As Object, e As EventArgs) Handles A2.TextChanged
        C1.Text = Val(A0.Text) + Val(A1.Text) + Val(A2.Text)
        F3.Text = Val(A2.Text) + Val(B2.Text) + Val(CZ.Text)
        D1.Text = Val(A2.Text) + Val(B1.Text) + Val(C0.Text)
        If C1.Text = "15" Then
            C1.ForeColor = Color.Green
        Else
            C1.ForeColor = SystemColors.Highlight
        End If
        If F3.Text = "15" Then
            F3.ForeColor = Color.Green
        Else
            F3.ForeColor = SystemColors.Highlight
        End If
        If D1.Text = "15" Then
            D1.ForeColor = Color.Green
        Else
            D1.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub B2_TextChanged(sender As Object, e As EventArgs) Handles B2.TextChanged
        C2.Text = Val(B0.Text) + Val(B1.Text) + Val(B2.Text)
        F3.Text = Val(A2.Text) + Val(B2.Text) + Val(CZ.Text)
        If C2.Text = "15" Then
            C2.ForeColor = Color.Green
        Else
            C2.ForeColor = SystemColors.Highlight
        End If
        If F3.Text = "15" Then
            F3.ForeColor = Color.Green
        Else
            F3.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub CZ_TextChanged(sender As Object, e As EventArgs) Handles CZ.TextChanged
        C3.Text = Val(C0.Text) + Val(CI.Text) + Val(CZ.Text)
        F3.Text = Val(A2.Text) + Val(B2.Text) + Val(CZ.Text)
        D2.Text = Val(A0.Text) + Val(B1.Text) + Val(CZ.Text)
        If C3.Text = "15" Then
            C3.ForeColor = Color.Green
        Else
            C3.ForeColor = SystemColors.Highlight
        End If
        If F3.Text = "15" Then
            F3.ForeColor = Color.Green
        Else
            F3.ForeColor = SystemColors.Highlight
        End If
        If D2.Text = "15" Then
            D2.ForeColor = Color.Green
        Else
            D2.ForeColor = SystemColors.Highlight
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hasta luego.")
        Me.Close()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MSecuencias.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A0.Clear()
        A1.Clear()
        A2.Clear()
        B0.Clear()
        B1.Clear()
        B2.Clear()
        C0.Clear()
        CI.Clear()
        CZ.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        A0.Text = 4
        A1.Text = 9
        A2.Text = 2
        B0.Text = 3
        B1.Text = 5
        B2.Text = 7
        C0.Text = 8
        CI.Text = 1
        CZ.Text = 6
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now(), ("dddd" & Chr(10) & "dd 'de' MMMM 'del' yyyy") & Chr(10) & Format(Now(), ("hh:mm:ss")))
    End Sub
End Class