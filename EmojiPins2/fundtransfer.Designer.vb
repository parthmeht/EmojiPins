<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fundtransfer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clr = New System.Windows.Forms.Button()
        Me.ext = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transfer Money to Account no.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(508, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(508, 190)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fund Transfer"
        '
        'clr
        '
        Me.clr.BackColor = System.Drawing.Color.Gold
        Me.clr.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.Location = New System.Drawing.Point(254, 280)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(118, 47)
        Me.clr.TabIndex = 12
        Me.clr.Text = "Clear"
        Me.clr.UseVisualStyleBackColor = False
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.Gold
        Me.ext.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ext.Location = New System.Drawing.Point(404, 280)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(100, 47)
        Me.ext.TabIndex = 11
        Me.ext.Text = "Exit"
        Me.ext.UseVisualStyleBackColor = False
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.Gold
        Me.submit.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(101, 280)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(118, 47)
        Me.submit.TabIndex = 10
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'fundtransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(713, 390)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fundtransfer"
        Me.Text = "fundtransfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clr As Button
    Friend WithEvents ext As Button
    Friend WithEvents submit As Button
End Class
