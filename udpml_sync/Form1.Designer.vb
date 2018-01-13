<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxRecvMuticastIP = New System.Windows.Forms.TextBox()
        Me.tbxRecvRemotePort = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRecv = New System.Windows.Forms.Button()
        Me.tbxRecvLocalPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbxSendText = New System.Windows.Forms.TextBox()
        Me.tbxSendLocalPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxSendMuticastIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxSendRemotePort = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxRecvMuticastIP)
        Me.GroupBox1.Controls.Add(Me.tbxRecvRemotePort)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnRecv)
        Me.GroupBox1.Controls.Add(Me.tbxRecvLocalPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "recv"
        '
        'tbxRecvMuticastIP
        '
        Me.tbxRecvMuticastIP.Location = New System.Drawing.Point(76, 68)
        Me.tbxRecvMuticastIP.Name = "tbxRecvMuticastIP"
        Me.tbxRecvMuticastIP.Size = New System.Drawing.Size(100, 19)
        Me.tbxRecvMuticastIP.TabIndex = 6
        Me.tbxRecvMuticastIP.Text = "239.0.0.0"
        '
        'tbxRecvRemotePort
        '
        Me.tbxRecvRemotePort.Location = New System.Drawing.Point(76, 43)
        Me.tbxRecvRemotePort.Name = "tbxRecvRemotePort"
        Me.tbxRecvRemotePort.Size = New System.Drawing.Size(100, 19)
        Me.tbxRecvRemotePort.TabIndex = 5
        Me.tbxRecvRemotePort.Text = "50000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "multicast ip"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 12)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "remote port"
        '
        'btnRecv
        '
        Me.btnRecv.Location = New System.Drawing.Point(182, 41)
        Me.btnRecv.Name = "btnRecv"
        Me.btnRecv.Size = New System.Drawing.Size(75, 23)
        Me.btnRecv.TabIndex = 2
        Me.btnRecv.Text = "recv"
        Me.btnRecv.UseVisualStyleBackColor = True
        '
        'tbxRecvLocalPort
        '
        Me.tbxRecvLocalPort.Location = New System.Drawing.Point(76, 18)
        Me.tbxRecvLocalPort.Name = "tbxRecvLocalPort"
        Me.tbxRecvLocalPort.Size = New System.Drawing.Size(100, 19)
        Me.tbxRecvLocalPort.TabIndex = 1
        Me.tbxRecvLocalPort.Text = "50000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "local port"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxSendText)
        Me.GroupBox2.Controls.Add(Me.tbxSendLocalPort)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbxSendMuticastIP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbxSendRemotePort)
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "send"
        '
        'tbxSendText
        '
        Me.tbxSendText.Location = New System.Drawing.Point(76, 93)
        Me.tbxSendText.Name = "tbxSendText"
        Me.tbxSendText.Size = New System.Drawing.Size(100, 19)
        Me.tbxSendText.TabIndex = 8
        Me.tbxSendText.Text = "exit"
        '
        'tbxSendLocalPort
        '
        Me.tbxSendLocalPort.Location = New System.Drawing.Point(76, 18)
        Me.tbxSendLocalPort.Name = "tbxSendLocalPort"
        Me.tbxSendLocalPort.Size = New System.Drawing.Size(100, 19)
        Me.tbxSendLocalPort.TabIndex = 7
        Me.tbxSendLocalPort.Text = "50000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "send text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "local port"
        '
        'tbxSendMuticastIP
        '
        Me.tbxSendMuticastIP.Location = New System.Drawing.Point(76, 68)
        Me.tbxSendMuticastIP.Name = "tbxSendMuticastIP"
        Me.tbxSendMuticastIP.Size = New System.Drawing.Size(100, 19)
        Me.tbxSendMuticastIP.TabIndex = 4
        Me.tbxSendMuticastIP.Text = "239.0.0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "multicast ip"
        '
        'tbxSendRemotePort
        '
        Me.tbxSendRemotePort.Location = New System.Drawing.Point(76, 43)
        Me.tbxSendRemotePort.Name = "tbxSendRemotePort"
        Me.tbxSendRemotePort.Size = New System.Drawing.Size(100, 19)
        Me.tbxSendRemotePort.TabIndex = 2
        Me.tbxSendRemotePort.Text = "50000"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(182, 53)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "remote port"
        '
        'tbxLog
        '
        Me.tbxLog.Location = New System.Drawing.Point(12, 244)
        Me.tbxLog.Multiline = True
        Me.tbxLog.Name = "tbxLog"
        Me.tbxLog.ReadOnly = True
        Me.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxLog.Size = New System.Drawing.Size(268, 119)
        Me.tbxLog.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 374)
        Me.Controls.Add(Me.tbxLog)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "udpml_sync"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRecv As Button
    Friend WithEvents tbxRecvLocalPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbxSendMuticastIP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxSendRemotePort As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxLog As TextBox
    Friend WithEvents tbxSendText As TextBox
    Friend WithEvents tbxSendLocalPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxRecvMuticastIP As TextBox
    Friend WithEvents tbxRecvRemotePort As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
