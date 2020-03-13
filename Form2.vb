Public Class Form2
    'Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'Me.Show()
    '    'Form1.Hide()
    'End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpass.Text = "" Then
            MsgBox("Username and password cannot be blank")
        ElseIf txtusername.Text = "Admin" Or txtpass.Text = "Admin" Then
            txtusername.Text = ""
            txtpass.Text = ""
            MsgBox("Login Successful")
            Me.Hide()
            Form1.Show()
        Else
            txtusername.Text = ""
            txtpass.Text = ""
            MsgBox("Login Failed")
        End If
    End Sub
End Class