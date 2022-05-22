Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("ເຈົ້າຕ້ອງການປິດໂປຣແກຣມບໍ່", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Login()
        Dim dt As New DataTable

        dt = loadingData("SELECT * FROM employee WHERE emp_username='" + txtusername.Text + "' AND emp_password='" + txtpassword.Text + "'")


        If dt.Rows.Count <> 0 Then
            userID = dt.Rows(0)(0)
            userName = dt.Rows(0)(1)
            MessageBox.Show("Welcome " + dt.Rows(0)(1), "Result")

            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username or Password Incorrect!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()

            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If
    End Sub
End Class
