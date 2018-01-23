<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplicationIntro
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.textBoxVersion = New System.Windows.Forms.TextBox
        Me.textBoxCustomMessage = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.AscensionAnalytics.My.Resources.Resources.NewAscensionAnalytics
        Me.PictureBox1.InitialImage = Global.AscensionAnalytics.My.Resources.Resources.Sum1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ascension Student Analytics"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(192, 45)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(385, 16)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Tools for analysis at Ascension"
        '
        'textBoxVersion
        '
        Me.textBoxVersion.BackColor = System.Drawing.Color.White
        Me.textBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxVersion.Enabled = False
        Me.textBoxVersion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxVersion.Location = New System.Drawing.Point(416, 169)
        Me.textBoxVersion.Multiline = True
        Me.textBoxVersion.Name = "textBoxVersion"
        Me.textBoxVersion.Size = New System.Drawing.Size(161, 20)
        Me.textBoxVersion.TabIndex = 2
        Me.textBoxVersion.Text = "Version: 2.0"
        Me.textBoxVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textBoxCustomMessage
        '
        Me.textBoxCustomMessage.BackColor = System.Drawing.SystemColors.Window
        Me.textBoxCustomMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxCustomMessage.Enabled = False
        Me.textBoxCustomMessage.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxCustomMessage.Location = New System.Drawing.Point(192, 67)
        Me.textBoxCustomMessage.Multiline = True
        Me.textBoxCustomMessage.Name = "textBoxCustomMessage"
        Me.textBoxCustomMessage.ReadOnly = True
        Me.textBoxCustomMessage.Size = New System.Drawing.Size(385, 96)
        Me.textBoxCustomMessage.TabIndex = 3
        '
        'frmApplicationIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.textBoxCustomMessage)
        Me.Controls.Add(Me.textBoxVersion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "frmApplicationIntro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Ascension Analytics"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents textBoxVersion As System.Windows.Forms.TextBox
    Friend WithEvents textBoxCustomMessage As System.Windows.Forms.TextBox
End Class
