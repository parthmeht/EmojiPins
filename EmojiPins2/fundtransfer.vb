Imports System.Data
Imports System.Data.SqlClient
Public Class fundtransfer
    Public balance1 As Integer
    Public balance2 As Integer
    Public account As Integer
    Public acc As Byte()
    Public bal2 As Byte()
    Public bal1 As Byte()
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command object
        Dim cmd4 As SqlCommand = New SqlCommand(("SELECT account_num FROM user1 WHERE account_num = @acc "), SwsmsDBConn)
        SwsmsDBConn.Open()
        cmd4.Parameters.Add("@acc", SqlDbType.VarBinary)
        cmd4.Parameters("@acc").Value = aes.EncryptStringToBytes_Aes(TextBox1.Text, key, ive)
        Dim sqlReader As SqlDataReader = cmd4.ExecuteReader()
            While sqlReader.Read()
            acc = sqlReader(0)
            account = aes.DecryptStringFromBytes_Aes(acc, key, ive)
            If account = Trim(TextBox1.Text) Then
                    Dim Conn As SqlConnection = NewConnection()
                Dim cmd As SqlCommand = New SqlCommand(("select bal FROM user1 where Atm_pin = @ID "), Conn)
                Conn.Open()
                cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
                cmd.Parameters("@ID").Value = login.encrypted
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                    While sdr.Read = True
                    bal1 = sdr(0)
                    balance1 = aes.DecryptStringFromBytes_Aes(bal1, key, ive)
                End While
                    sdr.Close()
                    Conn.Close()
                    If balance1 > 0 Then
                        Dim Conn1 As SqlConnection = NewConnection()
                    Dim cmd1 As SqlCommand = New SqlCommand(("select bal FROM user1 where account_num = @acc"), Conn1)
                    Conn1.Open()
                    cmd1.Parameters.Add("@acc", SqlDbType.VarBinary)
                    cmd1.Parameters("@acc").Value = aes.EncryptStringToBytes_Aes(TextBox1.Text, key, ive)
                    Dim sdr1 As SqlDataReader = cmd1.ExecuteReader()
                    While sdr1.Read = True
                        bal2 = sdr1(0)
                        balance2 = aes.DecryptStringFromBytes_Aes(bal2, key, ive)
                    End While
                        sdr1.Close()
                        Conn1.Close()
                        balance2 = balance2 + TextBox2.Text
                        balance1 = balance1 - TextBox2.Text
                        'update account
                        Dim Conn3 As SqlConnection = NewConnection()
                    Dim cmd2 As New SqlCommand("UPDATE user1 SET bal = @bal1  WHERE Atm_pin = @ID ", Conn3)
                    Dim rdr As SqlDataReader
                    Conn3.Open()
                    cmd2.Parameters.Add("@ID", SqlDbType.VarBinary)
                    cmd2.Parameters("@ID").Value = login.encrypted
                    cmd2.Parameters.AddWithValue("@bal1", aes.EncryptStringToBytes_Aes(balance1, key, ive))
                    rdr = cmd2.ExecuteReader()
                    rdr.Read()
                    Conn3.Close()
                    Dim Conn4 As SqlConnection = NewConnection()
                    Dim cmd3 As New SqlCommand("UPDATE user1 SET bal = @bal2  WHERE account_num = @acc ", Conn4)
                    Dim rdr1 As SqlDataReader
                    Conn4.Open()
                    cmd3.Parameters.Add("@acc", SqlDbType.VarBinary)
                    cmd3.Parameters("@acc").Value = aes.EncryptStringToBytes_Aes(TextBox1.Text, key, ive)
                    cmd3.Parameters.AddWithValue("@bal2", aes.EncryptStringToBytes_Aes(balance2, key, ive))
                    rdr1 = cmd3.ExecuteReader()
                    rdr1.Read()
                    Conn4.Close()
                    MessageBox.Show("Transaction Successfull", "Notice")
                    Else
                        MessageBox.Show("Insufficient Balance Present in the account. Transaction cannot occur", "Notice")
                    End If
                Else
                    MessageBox.Show("Invalid Account No.!", "Login message")
                End If
            End While
            sqlReader.Close()
        SwsmsDBConn.Close()
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Application.Exit()
    End Sub
End Class