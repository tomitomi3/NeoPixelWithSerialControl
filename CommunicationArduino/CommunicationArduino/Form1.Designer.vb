<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnOpenClose = New System.Windows.Forms.Button()
        Me.tbxSendMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnColorPick = New System.Windows.Forms.Button()
        Me.trkBar = New System.Windows.Forms.TrackBar()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.trkR = New System.Windows.Forms.TrackBar()
        Me.trkG = New System.Windows.Forms.TrackBar()
        Me.trkB = New System.Windows.Forms.TrackBar()
        Me.cbxPort = New System.Windows.Forms.ComboBox()
        CType(Me.trkBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenClose
        '
        Me.btnOpenClose.Location = New System.Drawing.Point(197, 10)
        Me.btnOpenClose.Name = "btnOpenClose"
        Me.btnOpenClose.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenClose.TabIndex = 0
        Me.btnOpenClose.Text = "Open"
        Me.btnOpenClose.UseVisualStyleBackColor = True
        '
        'tbxSendMessage
        '
        Me.tbxSendMessage.Location = New System.Drawing.Point(12, 49)
        Me.tbxSendMessage.Name = "tbxSendMessage"
        Me.tbxSendMessage.Size = New System.Drawing.Size(179, 19)
        Me.tbxSendMessage.TabIndex = 2
        Me.tbxSendMessage.Text = "32,0,0,64,0,1,0,0,32"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(197, 47)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnColorPick
        '
        Me.btnColorPick.Location = New System.Drawing.Point(278, 47)
        Me.btnColorPick.Name = "btnColorPick"
        Me.btnColorPick.Size = New System.Drawing.Size(75, 23)
        Me.btnColorPick.TabIndex = 5
        Me.btnColorPick.Text = "Color"
        Me.btnColorPick.UseVisualStyleBackColor = True
        '
        'trkBar
        '
        Me.trkBar.Location = New System.Drawing.Point(12, 86)
        Me.trkBar.Maximum = 255
        Me.trkBar.Name = "trkBar"
        Me.trkBar.Size = New System.Drawing.Size(341, 45)
        Me.trkBar.TabIndex = 6
        Me.trkBar.Value = 128
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(359, 47)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 7
        Me.btnTest.Text = "test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'trkR
        '
        Me.trkR.Location = New System.Drawing.Point(12, 137)
        Me.trkR.Maximum = 255
        Me.trkR.Name = "trkR"
        Me.trkR.Size = New System.Drawing.Size(341, 45)
        Me.trkR.TabIndex = 6
        Me.trkR.Value = 128
        '
        'trkG
        '
        Me.trkG.Location = New System.Drawing.Point(12, 188)
        Me.trkG.Maximum = 255
        Me.trkG.Name = "trkG"
        Me.trkG.Size = New System.Drawing.Size(341, 45)
        Me.trkG.TabIndex = 6
        Me.trkG.Value = 128
        '
        'trkB
        '
        Me.trkB.Location = New System.Drawing.Point(12, 239)
        Me.trkB.Maximum = 255
        Me.trkB.Name = "trkB"
        Me.trkB.Size = New System.Drawing.Size(341, 45)
        Me.trkB.TabIndex = 6
        Me.trkB.Value = 128
        '
        'cbxPort
        '
        Me.cbxPort.FormattingEnabled = True
        Me.cbxPort.Location = New System.Drawing.Point(12, 12)
        Me.cbxPort.Name = "cbxPort"
        Me.cbxPort.Size = New System.Drawing.Size(179, 20)
        Me.cbxPort.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 299)
        Me.Controls.Add(Me.cbxPort)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.trkB)
        Me.Controls.Add(Me.trkG)
        Me.Controls.Add(Me.trkR)
        Me.Controls.Add(Me.trkBar)
        Me.Controls.Add(Me.btnColorPick)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tbxSendMessage)
        Me.Controls.Add(Me.btnOpenClose)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.trkBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenClose As Button
    Friend WithEvents tbxSendMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnColorPick As Button
    Friend WithEvents trkBar As TrackBar
    Friend WithEvents btnTest As Button
    Friend WithEvents trkR As TrackBar
    Friend WithEvents trkG As TrackBar
    Friend WithEvents trkB As TrackBar
    Friend WithEvents cbxPort As ComboBox
End Class
