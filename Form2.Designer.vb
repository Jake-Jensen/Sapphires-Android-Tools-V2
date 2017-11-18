<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GeneralButton = New System.Windows.Forms.Button()
        Me.NothingButton = New System.Windows.Forms.Button()
        Me.HashButton = New System.Windows.Forms.Button()
        Me.ButtonsButton = New System.Windows.Forms.Button()
        Me.IconsButton = New System.Windows.Forms.Button()
        Me.ReadmeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GeneralButton
        '
        Me.GeneralButton.Location = New System.Drawing.Point(13, 13)
        Me.GeneralButton.Name = "GeneralButton"
        Me.GeneralButton.Size = New System.Drawing.Size(75, 23)
        Me.GeneralButton.TabIndex = 0
        Me.GeneralButton.Text = "General"
        Me.GeneralButton.UseVisualStyleBackColor = True
        '
        'NothingButton
        '
        Me.NothingButton.Location = New System.Drawing.Point(13, 129)
        Me.NothingButton.Name = "NothingButton"
        Me.NothingButton.Size = New System.Drawing.Size(75, 23)
        Me.NothingButton.TabIndex = 1
        Me.NothingButton.Text = "Nothing"
        Me.NothingButton.UseVisualStyleBackColor = True
        '
        'HashButton
        '
        Me.HashButton.Location = New System.Drawing.Point(13, 100)
        Me.HashButton.Name = "HashButton"
        Me.HashButton.Size = New System.Drawing.Size(75, 23)
        Me.HashButton.TabIndex = 2
        Me.HashButton.Text = "Official Hash"
        Me.HashButton.UseVisualStyleBackColor = True
        '
        'ButtonsButton
        '
        Me.ButtonsButton.Location = New System.Drawing.Point(13, 71)
        Me.ButtonsButton.Name = "ButtonsButton"
        Me.ButtonsButton.Size = New System.Drawing.Size(75, 23)
        Me.ButtonsButton.TabIndex = 3
        Me.ButtonsButton.Text = "Buttons"
        Me.ButtonsButton.UseVisualStyleBackColor = True
        '
        'IconsButton
        '
        Me.IconsButton.Location = New System.Drawing.Point(13, 42)
        Me.IconsButton.Name = "IconsButton"
        Me.IconsButton.Size = New System.Drawing.Size(75, 23)
        Me.IconsButton.TabIndex = 4
        Me.IconsButton.Text = "Icons"
        Me.IconsButton.UseVisualStyleBackColor = True
        '
        'ReadmeLabel
        '
        Me.ReadmeLabel.ForeColor = System.Drawing.Color.White
        Me.ReadmeLabel.Location = New System.Drawing.Point(95, 13)
        Me.ReadmeLabel.Name = "ReadmeLabel"
        Me.ReadmeLabel.Size = New System.Drawing.Size(373, 557)
        Me.ReadmeLabel.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(480, 579)
        Me.Controls.Add(Me.ReadmeLabel)
        Me.Controls.Add(Me.IconsButton)
        Me.Controls.Add(Me.ButtonsButton)
        Me.Controls.Add(Me.HashButton)
        Me.Controls.Add(Me.NothingButton)
        Me.Controls.Add(Me.GeneralButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "Readme"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralButton As Button
    Friend WithEvents NothingButton As Button
    Friend WithEvents HashButton As Button
    Friend WithEvents ButtonsButton As Button
    Friend WithEvents IconsButton As Button
    Friend WithEvents ReadmeLabel As Label
End Class
