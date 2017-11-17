<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.ReadyLabel = New System.Windows.Forms.Label()
        Me.ADBStatusLabel = New System.Windows.Forms.Label()
        Me.ADBStatusButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExploitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReadyButton
        '
        Me.ReadyButton.BackColor = System.Drawing.Color.Red
        Me.ReadyButton.Enabled = False
        Me.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadyButton.ForeColor = System.Drawing.Color.Black
        Me.ReadyButton.Location = New System.Drawing.Point(792, 13)
        Me.ReadyButton.Name = "ReadyButton"
        Me.ReadyButton.Size = New System.Drawing.Size(19, 13)
        Me.ReadyButton.TabIndex = 0
        Me.ReadyButton.UseVisualStyleBackColor = False
        '
        'ReadyLabel
        '
        Me.ReadyLabel.AutoSize = True
        Me.ReadyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReadyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadyLabel.ForeColor = System.Drawing.Color.White
        Me.ReadyLabel.Location = New System.Drawing.Point(817, 13)
        Me.ReadyLabel.Name = "ReadyLabel"
        Me.ReadyLabel.Size = New System.Drawing.Size(38, 13)
        Me.ReadyLabel.TabIndex = 1
        Me.ReadyLabel.Text = "Ready"
        '
        'ADBStatusLabel
        '
        Me.ADBStatusLabel.AutoSize = True
        Me.ADBStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ADBStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADBStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ADBStatusLabel.Location = New System.Drawing.Point(817, 36)
        Me.ADBStatusLabel.Name = "ADBStatusLabel"
        Me.ADBStatusLabel.Size = New System.Drawing.Size(29, 13)
        Me.ADBStatusLabel.TabIndex = 2
        Me.ADBStatusLabel.Text = "ADB"
        '
        'ADBStatusButton
        '
        Me.ADBStatusButton.BackColor = System.Drawing.Color.Red
        Me.ADBStatusButton.Enabled = False
        Me.ADBStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADBStatusButton.ForeColor = System.Drawing.Color.Black
        Me.ADBStatusButton.Location = New System.Drawing.Point(792, 36)
        Me.ADBStatusButton.Name = "ADBStatusButton"
        Me.ADBStatusButton.Size = New System.Drawing.Size(19, 13)
        Me.ADBStatusButton.TabIndex = 3
        Me.ADBStatusButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Logcat"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ExploitButton
        '
        Me.ExploitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExploitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExploitButton.ForeColor = System.Drawing.Color.White
        Me.ExploitButton.Location = New System.Drawing.Point(12, 41)
        Me.ExploitButton.Name = "ExploitButton"
        Me.ExploitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExploitButton.TabIndex = 5
        Me.ExploitButton.Text = "Root Shell"
        Me.ExploitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Sapphire_s_Android_Tools_V2.My.Resources.Resources.overwatch___blackwatch_mercy_by_animatedanarchist_dbgb21u
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(868, 499)
        Me.Controls.Add(Me.ExploitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ADBStatusButton)
        Me.Controls.Add(Me.ADBStatusLabel)
        Me.Controls.Add(Me.ReadyLabel)
        Me.Controls.Add(Me.ReadyButton)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(884, 538)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(884, 538)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Sapphire's Android Tools V2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadyButton As Button
    Friend WithEvents ReadyLabel As Label
    Friend WithEvents ADBStatusLabel As Label
    Friend WithEvents ADBStatusButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ExploitButton As Button
End Class
