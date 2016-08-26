<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task_manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chk = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.withdraw = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(71, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Change Pin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chk
        '
        Me.chk.BackColor = System.Drawing.Color.Gold
        Me.chk.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk.Location = New System.Drawing.Point(418, 95)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(130, 60)
        Me.chk.TabIndex = 2
        Me.chk.Text = "Check Balance"
        Me.chk.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gold
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(71, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 60)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Account Details"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gold
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(418, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 60)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Currency Exchange"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'withdraw
        '
        Me.withdraw.BackColor = System.Drawing.Color.Gold
        Me.withdraw.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw.Location = New System.Drawing.Point(71, 254)
        Me.withdraw.Name = "withdraw"
        Me.withdraw.Size = New System.Drawing.Size(130, 60)
        Me.withdraw.TabIndex = 5
        Me.withdraw.Text = "Withdraw"
        Me.withdraw.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gold
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(418, 254)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 60)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Fund Transfer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gold
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(253, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 60)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Task_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(635, 379)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.withdraw)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.chk)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Task_manager"
        Me.Text = "Task_manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents chk As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents withdraw As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
