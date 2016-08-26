Imports System.Data
Imports System.Data.SqlClient
Public Class pin
    Public count As Int16
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        count = 0
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loop1("A")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loop1("B")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Loop1("C")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Loop1("D")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Loop1("E")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Loop1("F")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Loop1("G")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Loop1("H")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Loop1("I")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Loop1("J")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Loop1("K")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Loop1("L")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Loop1("M")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Loop1("N")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Loop1("O")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Loop1("P")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Loop1("Q")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Loop1("R")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Loop1("S")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Loop1("T")
    End Sub
    Function Loop1(ByVal character As String) As String
        If TextBox1.Text = "" Then
            TextBox1.Text = character
            count = count + 1
        Else
            If count < 4 Then
                TextBox1.Text = TextBox1.Text & character
                count = count + 1
            ElseIf count < 8 Then
                TextBox2.Text = TextBox2.Text & character
                count = count + 1
            ElseIf count < 12 Then
                TextBox3.Text = TextBox3.Text & character
                count = count + 1
            End If
        End If
        Return Nothing
    End Function

    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If TextBox2.Text = TextBox3.Text And TextBox1.Text = login.password.Text Then
            'update account
            Dim Conn As SqlConnection = NewConnection()
            'Dim conn As New MySqlConnection("Database=atm;server=localhost;user id=root; password= ;port=3306; charset=utf8")
            Dim cmd2 As New SqlCommand("UPDATE user1 SET Atm_pin = @pin  WHERE Atm_pin = @ID ", Conn)
            Dim rdr As SqlDataReader
            Conn.Open()
            cmd2.Parameters.Add("@ID", SqlDbType.VarBinary)
            cmd2.Parameters("@ID").Value = login.encrypted
            cmd2.Parameters.AddWithValue("@pin", aes.EncryptStringToBytes_Aes(TextBox2.Text, key, ive))
            rdr = cmd2.ExecuteReader()
            rdr.Read()
            Conn.Close()
            MessageBox.Show("Your Pin has been updated", "Change Pin message")
        ElseIf TextBox1.Text = login.password.Text Then
            MessageBox.Show("Invalid New Pin", "Change Pin message")
        Else
            MessageBox.Show("Wrong Old Pin", "Change Pin message")
        End If
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Application.Exit()
    End Sub
End Class