Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Speech
Imports System.Speech.Synthesis
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class main_form
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Dim withdraw, balance, newbalance As Integer
    Dim speaker As New SpeechSynthesizer()

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        btndisplay.Text += Btn9.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn9.Text)
    End Sub
    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        btndisplay.Text += Btn8.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn8.Text)
    End Sub
    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        btndisplay.Text += Btn7.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn7.Text)
    End Sub
    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        btndisplay.Text += Btn6.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn6.Text)
    End Sub
    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        btndisplay.Text += Btn5.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn5.Text)
    End Sub
    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        btndisplay.Text += Btn4.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn4.Text)
    End Sub
    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        btndisplay.Text += Btn3.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn3.Text)
    End Sub
    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        btndisplay.Text += Btn2.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn2.Text)
    End Sub
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        btndisplay.Text += Btn1.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn1.Text)
    End Sub
    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        btndisplay.Text += Btn0.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn0.Text)
    End Sub
    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        Try
            Dim loc As Integer
            'Get the length of the string
            loc = btndisplay.Text.Length
            'Remove the last character, incrementing by 1
            btndisplay.Text = btndisplay.Text.Remove(loc - 1)
            If btndisplay.Text = "" Then
                speaker.Rate = Convert.ToInt32(txtspeed.Value)
                speaker.Volume = Convert.ToInt32(txtvol.Value)
                speaker.SpeakAsync("screen is empty")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wait.Visible = False
        'pixloading.Visible = False
        take_money.Visible = False
        'pixmoney.Visible = False
        Timer1.Interval = 4500
        Timer1.Enabled = False
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Your balance is" & " " & btndisplay.Text & "  " & "Rupees")
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchk.Click
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Check your balance")

        'check balance using select statement
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command object
        Dim cmd As SqlCommand = New SqlCommand(("select bal FROM user1 where Atm_pin = @ID"), SwsmsDBConn)
        SwsmsDBConn.Open()
        cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd.Parameters("@ID").Value = login.encrypted
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Dim data As Byte() = sdr(0)
            btndisplay.Text = aes.DecryptStringFromBytes_Aes(data, key, ive)
        End While
        sdr.Close()
        SwsmsDBConn = Nothing
    End Sub
    Private Sub btnwithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwithdraw.Click
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("withdraw your money")
        wait.Visible = True
        'pixloading.Visible = True
        'MessageBox.Show("Please wait while transaction is being performed")
        Timer1.Enabled = True
        'withdraw cash
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command objet
        Dim cmd As SqlCommand = New SqlCommand(("select bal FROM user1 where Atm_pin = @ID "), SwsmsDBConn)
        SwsmsDBConn.Open()
        cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd.Parameters("@ID").Value = login.encrypted
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Dim data As Byte() = sdr(0)
            Dim roundtrip As String = aes.DecryptStringFromBytes_Aes(data, key, ive)
            balance = roundtrip
        End While
        sdr.Close()
        SwsmsDBConn = Nothing
        'litle calculation
        If btndisplay.Text = "" Then
            speaker.SpeakAsync("Enter Correct Amount to withdrawn ")
        Else
            withdraw = btndisplay.Text
            If withdraw >= balance Then
                speaker.SpeakAsync("Insufficient Amount in the account ")
            Else
                newbalance = (balance) - (withdraw)
                speaker.SpeakAsync("Balance withdrawn is " + btndisplay.Text)
                btndisplay.Text = newbalance
                speaker.SpeakAsync("Balance Left is " + btndisplay.Text)
            End If
        End If
        Dim bal As Byte() = aes.EncryptStringToBytes_Aes(btndisplay.Text, key, ive)
        'update account
        Dim Conn As SqlConnection = NewConnection()
        'Dim conn As New MySqlConnection("Database=atm;server=localhost;user id=root; password= ;port=3306; charset=utf8")
        Dim cmd2 As New SqlCommand("UPDATE user1 SET bal = @bal  WHERE Atm_pin = @ID ", Conn)
        Dim rdr As SqlDataReader
        Conn.Open()
        cmd2.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd2.Parameters("@ID").Value = login.encrypted
        cmd2.Parameters.AddWithValue("@bal", bal)
        rdr = cmd2.ExecuteReader()
        rdr.Read()
        Conn.Close()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        btndisplay.Text = ""
    End Sub

    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'pixmoney.Visible = True
        'MessageBox.Show("Transaction Complete")
        take_money.Visible = True
        wait.Visible = False
        'pixloading.Visible = False
    End Sub

End Class
