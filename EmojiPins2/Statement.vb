Imports System.Data
Imports System.Data.SqlClient
Public Class Statement
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

    Private Sub Statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check balance using select statement
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command object
        Dim cmd As SqlCommand = New SqlCommand(("select * FROM user1 where Atm_pin = @ID "), SwsmsDBConn)
        SwsmsDBConn.Open()
        cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd.Parameters("@ID").Value = login.encrypted
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Label3.Text = aes.DecryptStringFromBytes_Aes(sdr(0), key, ive)
            Label5.Text = aes.DecryptStringFromBytes_Aes(sdr(1), key, ive)
            Label7.Text = aes.DecryptStringFromBytes_Aes(sdr(2), key, ive)
            Label9.Text = aes.DecryptStringFromBytes_Aes(sdr(3), key, ive)
            Label11.Text = aes.DecryptStringFromBytes_Aes(sdr(4), key, ive)
            Label13.Text = aes.DecryptStringFromBytes_Aes(sdr(5), key, ive)
            Label15.Text = aes.DecryptStringFromBytes_Aes(sdr(6), key, ive)
            Label17.Text = "Rs. " & aes.DecryptStringFromBytes_Aes(sdr(9), key, ive)
            Label19.Text = aes.DecryptStringFromBytes_Aes(sdr(8), key, ive)
        End While
        sdr.Close()
        SwsmsDBConn = Nothing
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Try
            PrintForm1.Print()
        Catch es As Exception
            MsgBox("Cannot Print ! ")
        End Try
    End Sub
End Class