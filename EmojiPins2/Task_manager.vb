Public Class Task_manager
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As Form = Application.OpenForms.Item("pin")
        If f Is Nothing Then
            Dim set_pin As New pin
            With set_pin
                ' .MdiParent = Me
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
        Else
            f.Show()
            f.BringToFront()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk.Click
        Dim f As Form = Application.OpenForms.Item("main_form")
        If f Is Nothing Then
            Dim withdraw As New main_form
            With withdraw
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
            main_form.dis.Text = "Pin Number : " + login.password.Text
        Else
            f.Show()
            f.BringToFront()
            main_form.dis.Text = "Pin Number : " + login.password.Text
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
    Private Sub withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw.Click
        Dim f As Form = Application.OpenForms.Item("main_form")
        If f Is Nothing Then
            Dim withdraw As New main_form
            With withdraw
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
            main_form.dis.Text = "Pin Number : " + login.password.Text
        Else
            f.Show()
            f.BringToFront()
            main_form.dis.Text = "Pin Number : " + login.password.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f As Form = Application.OpenForms.Item("Statement")
        If f Is Nothing Then
            Dim set_pin As New Statement
            With set_pin
                ' .MdiParent = Me
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
        Else
            f.Show()
            f.BringToFront()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As Form = Application.OpenForms.Item("fundtransfer")
        If f Is Nothing Then
            Dim set_pin As New fundtransfer
            With set_pin
                ' .MdiParent = Me
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
        Else
            f.Show()
            f.BringToFront()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f As Form = Application.OpenForms.Item("currencyexchange")
        If f Is Nothing Then
            Dim set_pin As New currencyexchange
            With set_pin
                ' .MdiParent = Me
                Me.StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With
        Else
            f.Show()
            f.BringToFront()
        End If
    End Sub
End Class