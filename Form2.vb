Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GeneralButton_Click(sender As Object, e As EventArgs) Handles GeneralButton.Click
        ReadmeLabel.Text = "Sapphire's Android Tools is a suite of one click (Or nearly) software that is intended to root phones, or assist in rooting tasks." & vbNewLine & "Developed by Jake Jensen, 2017, as part of the CrossWired Suite. Remember to kill the ADB server before quitting to avoid any complications via the Kill ADB button."
    End Sub

    Private Sub IconsButton_Click(sender As Object, e As EventArgs) Handles IconsButton.Click
        ReadmeLabel.Text = "Red = Unavailable" & vbNewLine & "Yellow = Unknown status" & vbNewLine & "Green = Ready to run."
    End Sub

    Private Sub ButtonsButton_Click(sender As Object, e As EventArgs) Handles ButtonsButton.Click
        ReadmeLabel.Text = "Tools contain your ADB and logcat functions." & vbNewLine & "4.4 - 4.4.4 and etc all contain exploits specifically for that Android OS version."
    End Sub

    Private Sub HashButton_Click(sender As Object, e As EventArgs) Handles HashButton.Click
        ReadmeLabel.Text = "Not Yet Implemented"
    End Sub

    Private Sub NothingButton_Click(sender As Object, e As EventArgs) Handles NothingButton.Click
        ReadmeLabel.Text = ""
    End Sub
End Class