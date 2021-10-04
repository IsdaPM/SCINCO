<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WELCOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WELCOME))
        Me.user1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.psw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lgi = New System.Windows.Forms.Button()
        Me.sp = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user1
        '
        Me.user1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user1.Location = New System.Drawing.Point(233, 111)
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(149, 30)
        Me.user1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(167, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(127, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD:"
        '
        'psw
        '
        Me.psw.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psw.Location = New System.Drawing.Point(233, 147)
        Me.psw.Name = "psw"
        Me.psw.Size = New System.Drawing.Size(149, 30)
        Me.psw.TabIndex = 3
        Me.psw.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(55, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 63)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Log in to your SCINCO account to preview the console logs in real time"
        '
        'lgi
        '
        Me.lgi.BackColor = System.Drawing.Color.LightBlue
        Me.lgi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lgi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lgi.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lgi.Location = New System.Drawing.Point(267, 183)
        Me.lgi.Name = "lgi"
        Me.lgi.Size = New System.Drawing.Size(103, 31)
        Me.lgi.TabIndex = 5
        Me.lgi.Text = "LOG IN"
        Me.lgi.UseVisualStyleBackColor = False
        '
        'sp
        '
        Me.sp.BackColor = System.Drawing.Color.LightBlue
        Me.sp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sp.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sp.Location = New System.Drawing.Point(346, 260)
        Me.sp.Name = "sp"
        Me.sp.Size = New System.Drawing.Size(106, 42)
        Me.sp.TabIndex = 6
        Me.sp.Text = "SING UP"
        Me.sp.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(66, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 65)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "If you do not have an account you can create one by clicking the sign up button"
        '
        'WELCOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(562, 347)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sp)
        Me.Controls.Add(Me.lgi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.psw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WELCOME"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents psw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lgi As Button
    Friend WithEvents sp As Button
    Friend WithEvents Label4 As Label
End Class
