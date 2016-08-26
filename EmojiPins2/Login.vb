Imports System.Data
Imports System.Data.SqlClient
Public Class login
    Public count As Int16
    Public key As Byte() = {113, 221, 234, 64, 218, 83, 171, 8, 206, 134, 118, 208, 236, 67, 111, 10, 125, 134, 50, 53, 117, 26, 142, 196, 177, 193, 86, 112, 239, 91, 93, 254}
    Public ive As Byte() = {250, 85, 28, 112, 97, 218, 112, 13, 251, 126, 251, 222, 221, 227, 18, 33}
    Public encrypted As Byte()
    Dim card As Byte()
    ' Number of rows in the Grid (Default)
    Dim nRows As Integer = 2

    ' Number of Columns in the Grid (Default)
    Dim nCols As Integer = 10

    ' rand variable is used in shuffling
    ' the tiles
    Dim rand As Random
    Dim timerCountdown As Integer  ' the timers total time
    Dim c1 As Control()
    Dim Rx As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ''login
        If Label1.Text = "Welcome : " Then
            MessageBox.Show("Kindly Insert the card in the system")
        Else
            Dim connetionString As String
            Dim connection As SqlConnection
            Dim command As SqlCommand
            Dim sql As String
            encrypted = aes.EncryptStringToBytes_Aes(password.Text, key, ive)
            connetionString = "Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973"
            sql = "SELECT Atm_pin FROM user1 WHERE Atm_pin = @ID AND cardno = @card"
            connection = New SqlConnection(connetionString)
            Try
                connection.Open()

                command = New SqlCommand(sql, connection)
                command.Parameters.Add("@ID", SqlDbType.VarBinary)
                command.Parameters("@ID").Value = encrypted
                command.Parameters.Add("@card", SqlDbType.VarBinary)
                command.Parameters("@card").Value = card
                Dim sqlReader As SqlDataReader = command.ExecuteReader()
                While sqlReader.Read()
                    If sqlReader.HasRows = True Then
                        MessageBox.Show("Login Accepted", "Login message")
                        Me.Hide()
                        Task_manager.Show()
                    Else
                        MessageBox.Show("Invalid Login!", "Login message")
                    End If
                    'transfer pin
                    Dim TextBoxContents As String
                    TextBoxContents = Me.password.Text
                End While
                sqlReader.Close()
                command.Dispose()
                connection.Close()
            Catch ex As Exception
                MsgBox("Cannot open connection ! ")
            End Try
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        password.Text = ""
        count = 0
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
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
        If password.Text = "" Then
            password.Text = character
            count = count + 1
        Else
            If count < 4 Then
                password.Text = password.Text & character
                count = count + 1
            End If
        End If
        Return Nothing
    End Function

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Me.ScrambleButtons()
    End Sub
    Private Sub ScrambleButtons()

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Rx = SerialPort1.ReadExisting 'or SerialPort1.ReadLine  
        Me.Invoke(New EventHandler(AddressOf DoUpdate))
    End Sub

    Public Sub DoUpdate()
        Label1.Text = "Welcome : "
        Dim SwsmsDBConn As SqlConnection = NewConnection()
        ' create a new command objet
        Dim cmd As SqlCommand = New SqlCommand(("select fullname FROM user1 where cardno = @ID "), SwsmsDBConn)
        SwsmsDBConn.Open()
        card = aes.EncryptStringToBytes_Aes(Rx, key, ive)
        cmd.Parameters.Add("@ID", SqlDbType.VarBinary)
        cmd.Parameters("@ID").Value = card
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Dim data As Byte() = sdr(0)
            Dim roundtrip As String = aes.DecryptStringFromBytes_Aes(data, key, ive)
            Label1.Text = Label1.Text & roundtrip
        End While
        sdr.Close()
        SwsmsDBConn = Nothing
    End Sub

    Private Function NewConnection() As SqlConnection
        Dim connectionstring As String = ("Data Source=PARTH;Initial Catalog=ATM;User ID=sa;Password=1973")
        Dim SwsmsDBConn As New SqlConnection(connectionstring)
        Return SwsmsDBConn
    End Function

End Class
