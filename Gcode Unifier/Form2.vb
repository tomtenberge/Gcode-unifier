Public Class Form2
    Private Sub Ok_Btn_Click(sender As Object, e As EventArgs) Handles ok_Btn.Click
        Form1.x_offset = X_Offset.Text
        Form1.y_offset = Y_offset.Text
        Form1.z_offset = Z_offset.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        Me.Close()
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles X_Offset.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles X_Offset.TextChanged
        Dim digitsOnly As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d,]")
        X_Offset.Text = digitsOnly.Replace(X_Offset.Text, "")
    End Sub
    Private Sub TextBox_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Y_offset.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged2(ByVal sender As Object, ByVal e As System.EventArgs) Handles Y_offset.TextChanged
        Dim digitsOnly As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d,]")
        Y_offset.Text = digitsOnly.Replace(Y_offset.Text, "")
    End Sub
    Private Sub TextBox_KeyPress3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Z_offset.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged3(ByVal sender As Object, ByVal e As System.EventArgs) Handles Z_offset.TextChanged
        Dim digitsOnly As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d,]")
        Z_offset.Text = digitsOnly.Replace(Z_offset.Text, "")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        X_Offset.Text = Form1.x_offset
        Y_offset.Text = Form1.y_offset
        Z_offset.Text = Form1.z_offset
    End Sub
End Class