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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.ReadyLabel = New System.Windows.Forms.Label()
        Me.ADBStatusLabel = New System.Windows.Forms.Label()
        Me.ADBStatusButton = New System.Windows.Forms.Button()
        Me.EnforceStatLabel = New System.Windows.Forms.Label()
        Me.EnforceStatusButton = New System.Windows.Forms.Button()
        Me.DCV1StatusLabel = New System.Windows.Forms.Label()
        Me.DCV1StatusButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBox = New System.Windows.Forms.TextBox()
        Me.StartADBBackground = New System.ComponentModel.BackgroundWorker()
        Me.StopADBBackground = New System.ComponentModel.BackgroundWorker()
        Me.LogcatBackground = New System.ComponentModel.BackgroundWorker()
        Me.SEPolicyBackground = New System.ComponentModel.BackgroundWorker()
        Me.ForceResetBackground = New System.ComponentModel.BackgroundWorker()
        Me.RootShellBackground = New System.ComponentModel.BackgroundWorker()
        Me.DCV1Background = New System.ComponentModel.BackgroundWorker()
        Me.IAmGrootBackground = New System.ComponentModel.BackgroundWorker()
        Me.ChiptunesBackground = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExploitOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceholderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceholderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanCowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartADBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartADBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillADBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPermissiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogcatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpamStatusBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDBStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContributorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReadyButton
        '
        Me.ReadyButton.BackColor = System.Drawing.Color.Red
        Me.ReadyButton.Enabled = False
        Me.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadyButton.ForeColor = System.Drawing.Color.Black
        Me.ReadyButton.Location = New System.Drawing.Point(792, 17)
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
        Me.ReadyLabel.Location = New System.Drawing.Point(817, 17)
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
        'EnforceStatLabel
        '
        Me.EnforceStatLabel.AutoSize = True
        Me.EnforceStatLabel.BackColor = System.Drawing.Color.Transparent
        Me.EnforceStatLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnforceStatLabel.ForeColor = System.Drawing.Color.White
        Me.EnforceStatLabel.Location = New System.Drawing.Point(817, 55)
        Me.EnforceStatLabel.Name = "EnforceStatLabel"
        Me.EnforceStatLabel.Size = New System.Drawing.Size(52, 13)
        Me.EnforceStatLabel.TabIndex = 9
        Me.EnforceStatLabel.Text = "Enforcing"
        '
        'EnforceStatusButton
        '
        Me.EnforceStatusButton.BackColor = System.Drawing.Color.Red
        Me.EnforceStatusButton.Enabled = False
        Me.EnforceStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnforceStatusButton.ForeColor = System.Drawing.Color.Black
        Me.EnforceStatusButton.Location = New System.Drawing.Point(792, 55)
        Me.EnforceStatusButton.Name = "EnforceStatusButton"
        Me.EnforceStatusButton.Size = New System.Drawing.Size(19, 13)
        Me.EnforceStatusButton.TabIndex = 10
        Me.EnforceStatusButton.UseVisualStyleBackColor = False
        '
        'DCV1StatusLabel
        '
        Me.DCV1StatusLabel.AutoSize = True
        Me.DCV1StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.DCV1StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DCV1StatusLabel.ForeColor = System.Drawing.Color.White
        Me.DCV1StatusLabel.Location = New System.Drawing.Point(817, 75)
        Me.DCV1StatusLabel.Name = "DCV1StatusLabel"
        Me.DCV1StatusLabel.Size = New System.Drawing.Size(35, 13)
        Me.DCV1StatusLabel.TabIndex = 13
        Me.DCV1StatusLabel.Text = "DCV1"
        '
        'DCV1StatusButton
        '
        Me.DCV1StatusButton.BackColor = System.Drawing.Color.Red
        Me.DCV1StatusButton.Enabled = False
        Me.DCV1StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DCV1StatusButton.ForeColor = System.Drawing.Color.Black
        Me.DCV1StatusButton.Location = New System.Drawing.Point(792, 75)
        Me.DCV1StatusButton.Name = "DCV1StatusButton"
        Me.DCV1StatusButton.Size = New System.Drawing.Size(19, 13)
        Me.DCV1StatusButton.TabIndex = 14
        Me.DCV1StatusButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 750
        '
        'ProgressBox
        '
        Me.ProgressBox.BackColor = System.Drawing.Color.Black
        Me.ProgressBox.ForeColor = System.Drawing.Color.White
        Me.ProgressBox.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBox.MaximumSize = New System.Drawing.Size(237, 475)
        Me.ProgressBox.MinimumSize = New System.Drawing.Size(237, 475)
        Me.ProgressBox.Multiline = True
        Me.ProgressBox.Name = "ProgressBox"
        Me.ProgressBox.ReadOnly = True
        Me.ProgressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProgressBox.Size = New System.Drawing.Size(237, 475)
        Me.ProgressBox.TabIndex = 24
        '
        'StartADBBackground
        '
        '
        'StopADBBackground
        '
        '
        'LogcatBackground
        '
        '
        'SEPolicyBackground
        '
        '
        'ForceResetBackground
        '
        '
        'IAmGrootBackground
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolsToolStripMenuItem, Me.MiscToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(252, 12)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(362, 24)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(362, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExploitOnToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(69, 20)
        Me.ToolStripMenuItem1.Text = "4.4 - 4.4.4"
        '
        'ExploitOnToolStripMenuItem
        '
        Me.ExploitOnToolStripMenuItem.Name = "ExploitOnToolStripMenuItem"
        Me.ExploitOnToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExploitOnToolStripMenuItem.Text = "Placeholder"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaceholderToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(69, 20)
        Me.ToolStripMenuItem2.Text = "5.0 - 5.0.1"
        '
        'PlaceholderToolStripMenuItem
        '
        Me.PlaceholderToolStripMenuItem.Name = "PlaceholderToolStripMenuItem"
        Me.PlaceholderToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PlaceholderToolStripMenuItem.Text = "Placeholder"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaceholderToolStripMenuItem1})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(34, 20)
        Me.ToolStripMenuItem3.Text = "6.0"
        '
        'PlaceholderToolStripMenuItem1
        '
        Me.PlaceholderToolStripMenuItem1.Name = "PlaceholderToolStripMenuItem1"
        Me.PlaceholderToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.PlaceholderToolStripMenuItem1.Text = "Placeholder"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanCowToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(43, 20)
        Me.ToolStripMenuItem4.Text = "6.0.1"
        '
        'CleanCowToolStripMenuItem
        '
        Me.CleanCowToolStripMenuItem.Name = "CleanCowToolStripMenuItem"
        Me.CleanCowToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CleanCowToolStripMenuItem.Text = "Sapphire's Clean Cow"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartADBToolStripMenuItem, Me.SEPolicyToolStripMenuItem, Me.ForceResetToolStripMenuItem, Me.LogcatToolStripMenuItem, Me.DebugMenuToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'StartADBToolStripMenuItem
        '
        Me.StartADBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartADBToolStripMenuItem1, Me.KillADBToolStripMenuItem})
        Me.StartADBToolStripMenuItem.Name = "StartADBToolStripMenuItem"
        Me.StartADBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartADBToolStripMenuItem.Text = "ADB"
        '
        'StartADBToolStripMenuItem1
        '
        Me.StartADBToolStripMenuItem1.Name = "StartADBToolStripMenuItem1"
        Me.StartADBToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.StartADBToolStripMenuItem1.Text = "Start ADB"
        '
        'KillADBToolStripMenuItem
        '
        Me.KillADBToolStripMenuItem.Name = "KillADBToolStripMenuItem"
        Me.KillADBToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.KillADBToolStripMenuItem.Text = "Kill ADB"
        '
        'SEPolicyToolStripMenuItem
        '
        Me.SEPolicyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetPermissiveToolStripMenuItem})
        Me.SEPolicyToolStripMenuItem.Name = "SEPolicyToolStripMenuItem"
        Me.SEPolicyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SEPolicyToolStripMenuItem.Text = "SEPolicy"
        '
        'SetPermissiveToolStripMenuItem
        '
        Me.SetPermissiveToolStripMenuItem.Name = "SetPermissiveToolStripMenuItem"
        Me.SetPermissiveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SetPermissiveToolStripMenuItem.Text = "Set permissive"
        '
        'ForceResetToolStripMenuItem
        '
        Me.ForceResetToolStripMenuItem.Name = "ForceResetToolStripMenuItem"
        Me.ForceResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ForceResetToolStripMenuItem.Text = "Force Reset"
        '
        'LogcatToolStripMenuItem
        '
        Me.LogcatToolStripMenuItem.Name = "LogcatToolStripMenuItem"
        Me.LogcatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogcatToolStripMenuItem.Text = "Logcat"
        '
        'DebugMenuToolStripMenuItem
        '
        Me.DebugMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpamStatusBoxToolStripMenuItem, Me.CheckDBStatusToolStripMenuItem, Me.CheckResolutionToolStripMenuItem})
        Me.DebugMenuToolStripMenuItem.Name = "DebugMenuToolStripMenuItem"
        Me.DebugMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DebugMenuToolStripMenuItem.Text = "Debug Menu"
        '
        'SpamStatusBoxToolStripMenuItem
        '
        Me.SpamStatusBoxToolStripMenuItem.Name = "SpamStatusBoxToolStripMenuItem"
        Me.SpamStatusBoxToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SpamStatusBoxToolStripMenuItem.Text = "Spam status box"
        '
        'CheckDBStatusToolStripMenuItem
        '
        Me.CheckDBStatusToolStripMenuItem.Name = "CheckDBStatusToolStripMenuItem"
        Me.CheckDBStatusToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CheckDBStatusToolStripMenuItem.Text = "Check DB status"
        '
        'CheckResolutionToolStripMenuItem
        '
        Me.CheckResolutionToolStripMenuItem.Name = "CheckResolutionToolStripMenuItem"
        Me.CheckResolutionToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CheckResolutionToolStripMenuItem.Text = "Check resolution"
        '
        'MiscToolStripMenuItem
        '
        Me.MiscToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem, Me.ContributorsToolStripMenuItem, Me.ContactToolStripMenuItem, Me.ContactToolStripMenuItem1, Me.ReadMeToolStripMenuItem, Me.BackgroundToolStripMenuItem})
        Me.MiscToolStripMenuItem.Name = "MiscToolStripMenuItem"
        Me.MiscToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MiscToolStripMenuItem.Text = "Miscellaneous"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DonateToolStripMenuItem.Text = "Donate!"
        '
        'ContributorsToolStripMenuItem
        '
        Me.ContributorsToolStripMenuItem.Name = "ContributorsToolStripMenuItem"
        Me.ContributorsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ContributorsToolStripMenuItem.Text = "Contributors"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ContactToolStripMenuItem.Text = "Discord"
        '
        'ContactToolStripMenuItem1
        '
        Me.ContactToolStripMenuItem1.Name = "ContactToolStripMenuItem1"
        Me.ContactToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ContactToolStripMenuItem1.Text = "Contact"
        '
        'ReadMeToolStripMenuItem
        '
        Me.ReadMeToolStripMenuItem.Name = "ReadMeToolStripMenuItem"
        Me.ReadMeToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ReadMeToolStripMenuItem.Text = "Read me"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Sapphire_s_Android_Tools_V2.My.Resources.Resources.overwatch___blackwatch_mercy_by_animatedanarchist_dbgb21u
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(868, 499)
        Me.Controls.Add(Me.ProgressBox)
        Me.Controls.Add(Me.DCV1StatusButton)
        Me.Controls.Add(Me.DCV1StatusLabel)
        Me.Controls.Add(Me.EnforceStatusButton)
        Me.Controls.Add(Me.EnforceStatLabel)
        Me.Controls.Add(Me.ADBStatusButton)
        Me.Controls.Add(Me.ADBStatusLabel)
        Me.Controls.Add(Me.ReadyLabel)
        Me.Controls.Add(Me.ReadyButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(884, 538)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(884, 538)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Sapphire's Android Tools V2 (Binary build 0.9.3) CleanCow Edition"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadyButton As Button
    Friend WithEvents ReadyLabel As Label
    Friend WithEvents ADBStatusLabel As Label
    Friend WithEvents ADBStatusButton As Button
    Friend WithEvents EnforceStatLabel As Label
    Friend WithEvents EnforceStatusButton As Button
    Friend WithEvents DCV1StatusLabel As Label
    Friend WithEvents DCV1StatusButton As Button
    Public WithEvents Timer1 As Timer
    Friend WithEvents ProgressBox As TextBox
    Friend WithEvents StartADBBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents StopADBBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents LogcatBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents SEPolicyBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents ForceResetBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents RootShellBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents DCV1Background As System.ComponentModel.BackgroundWorker
    Friend WithEvents IAmGrootBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents ChiptunesBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExploitOnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartADBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartADBToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KillADBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEPolicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetPermissiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleanCowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForceResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaceholderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaceholderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContributorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReadMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogcatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpamStatusBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckDBStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckResolutionToolStripMenuItem As ToolStripMenuItem
End Class
