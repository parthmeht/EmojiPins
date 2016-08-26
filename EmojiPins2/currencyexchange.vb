Imports System.Data.SqlClient
Public Class currencyexchange
    Dim arr As String()
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Dim bal As Double
    Dim exchange As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command object
        Dim cmd As SqlCommand = New SqlCommand(("select bal FROM user1 where Atm_pin = @ID"), SwsmsDBConn)
        SwsmsDBConn.Open()
        cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd.Parameters("@ID").Value = login.encrypted
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Dim data As Byte() = sdr(0)
            bal = aes.DecryptStringFromBytes_Aes(data, key, ive)
            Label5.Text = Label5.Text & bal
        End While
        sdr.Close()
        SwsmsDBConn = Nothing
    End Sub

    ' Gets current exchange rate for Canadian dollar
    '
    ' Code Source: http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=689249&SiteID=1
    ' Data Source: http://finance.yahoo.com/q?s=USDCAD=X
    '
    Function getExchangeRate1() As String
        Dim HttpReq As New MSXML2.XMLHTTP60
        Dim url, delim, resp As String
        delim = ","
        url = "http://download.finance.yahoo.com/d/quotes.csv?s=USDINR=X&f=sl1d1t1c1ohgv&e=.csv"
        HttpReq.open("GET", url, False)
        HttpReq.send()
        resp = HttpReq.responseText
        arr = Split(resp, delim)
        getExchangeRate1 = arr(1)
    End Function

    Function getExchangeRate2() As String
        Dim HttpReq As New MSXML2.XMLHTTP60
        Dim url, delim, resp As String
        delim = ","
        url = "http://download.finance.yahoo.com/d/quotes.csv?s=GBPINR=X&f=sl1d1t1c1ohgv&e=.csv"
        HttpReq.open("GET", url, False)
        HttpReq.send()
        resp = HttpReq.responseText
        arr = Split(resp, delim)
        getExchangeRate2 = arr(1)
    End Function

    Function getExchangeRate3() As String
        Dim HttpReq As New MSXML2.XMLHTTP60
        Dim url, delim, resp As String
        delim = ","
        url = "http://download.finance.yahoo.com/d/quotes.csv?s=EURINR=X&f=sl1d1t1c1ohgv&e=.csv"
        HttpReq.open("GET", url, False)
        HttpReq.send()
        resp = HttpReq.responseText
        arr = Split(resp, delim)
        getExchangeRate3 = arr(1)
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "1 Dollar = Rs." & getExchangeRate1()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "1 Pound = Rs." & getExchangeRate2()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "1 Euro = Rs." & getExchangeRate3()
        End If
    End Sub

    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        exchange = 0
        If TextBox2.Text = "" Then
            MessageBox.Show("Enter Some Amount ")
        ElseIf Convert.ToDouble(TextBox2.Text) > bal Then
            MessageBox.Show("Insufficient Amount in the Account")
        Else
            bal = bal - Convert.ToDouble(TextBox2.Text)
            If ComboBox1.SelectedIndex = 0 Then
                exchange = Convert.ToDouble(TextBox2.Text) / Convert.ToDouble(getExchangeRate1())
                MsgBox("Exchanged Amount = $ " & exchange, MsgBoxStyle.Information, "Exchanged !!")
            ElseIf ComboBox1.SelectedIndex = 1 Then
                exchange = Convert.ToDouble(TextBox2.Text) / Convert.ToDouble(getExchangeRate2())
                MsgBox("Exchanged Amount = Pounds " & exchange, MsgBoxStyle.Information, "Exchanged !!")
            ElseIf ComboBox1.SelectedIndex = 2 Then
                exchange = Convert.ToDouble(TextBox2.Text) / Convert.ToDouble(getExchangeRate3())
                MsgBox("Exchanged Amount = Euros " & exchange, MsgBoxStyle.Information, "Exchanged !!")
            End If
            MsgBox("Balance Amount Left in the Account = Rs. " & bal, MsgBoxStyle.Information, "Amount Remaining !! ")
            Dim balance As Byte() = aes.EncryptStringToBytes_Aes(bal, key, ive)
            'update account
            Dim Conn As SqlConnection = NewConnection()
            'Dim conn As New MySqlConnection("Database=atm;server=localhost;user id=root; password= ;port=3306; charset=utf8")
            Dim cmd2 As New SqlCommand("UPDATE user1 SET bal = @bal  WHERE Atm_pin = @ID ", Conn)
            Dim rdr As SqlDataReader
            Conn.Open()
            cmd2.Parameters.Add("@ID", SqlDbType.VarBinary)
            cmd2.Parameters("@ID").Value = login.encrypted
            cmd2.Parameters.AddWithValue("@bal", balance)
            rdr = cmd2.ExecuteReader()
            rdr.Read()
            Conn.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class
