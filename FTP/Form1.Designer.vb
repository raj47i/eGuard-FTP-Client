<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.SetCredentials = New System.Windows.Forms.Button
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.password = New System.Windows.Forms.TextBox
        Me.userName = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.Download = New System.Windows.Forms.Button
        Me.downloadURI = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.Browse2 = New System.Windows.Forms.Button
        Me.DownloadFileName = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.BackColor = System.Drawing.Color.Transparent
        Me.groupBox3.Controls.Add(Me.SetCredentials)
        Me.groupBox3.Controls.Add(Me.checkBox1)
        Me.groupBox3.Controls.Add(Me.password)
        Me.groupBox3.Controls.Add(Me.userName)
        Me.groupBox3.Controls.Add(Me.label6)
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Location = New System.Drawing.Point(11, 98)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(220, 136)
        Me.groupBox3.TabIndex = 7
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Credentials"
        '
        'SetCredentials
        '
        Me.SetCredentials.Location = New System.Drawing.Point(69, 103)
        Me.SetCredentials.Name = "SetCredentials"
        Me.SetCredentials.Size = New System.Drawing.Size(75, 23)
        Me.SetCredentials.TabIndex = 7
        Me.SetCredentials.Text = "Set"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(9, 19)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(132, 17)
        Me.checkBox1.TabIndex = 6
        Me.checkBox1.Text = "Use Anonomous User:"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(69, 74)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Size = New System.Drawing.Size(137, 20)
        Me.password.TabIndex = 8
        Me.password.UseSystemPasswordChar = True
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(69, 46)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(137, 20)
        Me.userName.TabIndex = 7
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 77)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "Password:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 49)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(58, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Username:"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.Download)
        Me.groupBox2.Controls.Add(Me.downloadURI)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.Browse2)
        Me.groupBox2.Controls.Add(Me.DownloadFileName)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(11, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(312, 80)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Download"
        '
        'Download
        '
        Me.Download.Location = New System.Drawing.Point(233, 48)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(65, 23)
        Me.Download.TabIndex = 6
        Me.Download.Text = "Download"
        '
        'downloadURI
        '
        Me.downloadURI.Location = New System.Drawing.Point(46, 49)
        Me.downloadURI.Name = "downloadURI"
        Me.downloadURI.Size = New System.Drawing.Size(174, 20)
        Me.downloadURI.TabIndex = 6
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 22)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(26, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "File:"
        '
        'Browse2
        '
        Me.Browse2.Location = New System.Drawing.Point(233, 17)
        Me.Browse2.Name = "Browse2"
        Me.Browse2.Size = New System.Drawing.Size(65, 23)
        Me.Browse2.TabIndex = 6
        Me.Browse2.Text = "Browse"
        '
        'DownloadFileName
        '
        Me.DownloadFileName.Location = New System.Drawing.Point(46, 18)
        Me.DownloadFileName.Name = "DownloadFileName"
        Me.DownloadFileName.Size = New System.Drawing.Size(174, 20)
        Me.DownloadFileName.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 53)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "URL:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 136)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FTP.My.Resources.Resources.bk
        Me.ClientSize = New System.Drawing.Size(335, 246)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  eGuard FTP Client"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SetCredentials As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents userName As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Download As System.Windows.Forms.Button
    Friend WithEvents downloadURI As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents Browse2 As System.Windows.Forms.Button
    Friend WithEvents DownloadFileName As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
