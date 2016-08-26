<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tRandom = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Gold
        Me.OK.Location = New System.Drawing.Point(186, 377)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(120, 60)
        Me.OK.TabIndex = 0
        Me.OK.Text = "Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Gold
        Me.Cancel.Location = New System.Drawing.Point(489, 377)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(120, 60)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Exit"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.password.Location = New System.Drawing.Point(324, 116)
        Me.password.MaxLength = 4
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.ReadOnly = True
        Me.password.Size = New System.Drawing.Size(144, 47)
        Me.password.TabIndex = 2
        Me.password.UseSystemPasswordChar = True
        Me.password.UseWaitCursor = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(317, 74)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(134, 39)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Emoji Pin"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button20, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button19, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button18, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button17, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button16, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button15, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button14, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button13, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button12, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button10, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button9, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button8, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 183)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(750, 169)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Button20
        '
        Me.Button20.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.person_raising_both_hands_in_celebration
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button20.Location = New System.Drawing.Point(678, 85)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(69, 75)
        Me.Button20.TabIndex = 19
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.shit1
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button19.Location = New System.Drawing.Point(603, 85)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(69, 75)
        Me.Button19.TabIndex = 18
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.beer
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button18.Location = New System.Drawing.Point(528, 85)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(69, 75)
        Me.Button18.TabIndex = 17
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.objects_0207
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button17.Location = New System.Drawing.Point(453, 85)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(69, 75)
        Me.Button17.TabIndex = 16
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.trophy
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button16.Location = New System.Drawing.Point(379, 85)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(68, 75)
        Me.Button16.TabIndex = 15
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.EMOvictory
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button15.Location = New System.Drawing.Point(303, 85)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(69, 75)
        Me.Button15.TabIndex = 14
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.tumblr_static_95p88l86si88ks4w4wws04wk8
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button14.Location = New System.Drawing.Point(228, 85)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(69, 75)
        Me.Button14.TabIndex = 13
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.persons_0008
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button13.Location = New System.Drawing.Point(153, 85)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(69, 75)
        Me.Button13.TabIndex = 12
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button12.Location = New System.Drawing.Point(78, 85)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(69, 75)
        Me.Button12.TabIndex = 11
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__7_
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button11.Location = New System.Drawing.Point(3, 85)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(69, 75)
        Me.Button11.TabIndex = 10
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__6_
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Location = New System.Drawing.Point(678, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(69, 75)
        Me.Button10.TabIndex = 9
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__5_
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Location = New System.Drawing.Point(603, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 75)
        Me.Button9.TabIndex = 8
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__4_
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.Location = New System.Drawing.Point(528, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 75)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__3_
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Location = New System.Drawing.Point(453, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 75)
        Me.Button7.TabIndex = 6
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__2_
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Location = New System.Drawing.Point(379, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 75)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.download
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(228, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 75)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.Heart_eyes_emoji
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(153, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.download__2_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(78, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 75)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.download__1_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.EmojiPins2.My.Resources.Resources.images__1_
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(303, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 75)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Location = New System.Drawing.Point(339, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 60)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome : "
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(798, 452)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "login"
        Me.Text = "Login"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents password As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents tRandom As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
End Class
