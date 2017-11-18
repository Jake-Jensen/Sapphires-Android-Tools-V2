Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GeneralButton_Click(sender As Object, e As EventArgs) Handles GeneralButton.Click
        ReadmeLabel.Text = "Sapphire's Android Tools is a suite of one click (Or nearly) software that is intended to root phones, or assist in rooting tasks." & vbNewLine & "Developed by Jake Jensen, 2017, as part of the CrossWired Suite."
    End Sub

    Private Sub IconsButton_Click(sender As Object, e As EventArgs) Handles IconsButton.Click
        ReadmeLabel.Text = "There are currently 3 status icons in the app. Red means something isn't functioning. For 'Ready', it means you are missing some required files. For 'ADB', it means you are missing ADB, or the server isn't running. While the program will automatically start an ADB server on load, it sometimes fails. Running 'adb start-server' manually will resolve it. For 'Enforcing', it checks the status of SELinux on your phone. Red means you are enforcing, or the app hasn't checked yet. Yellow means it doesn't know if you are enforcing or not. Green means you are permissive."
    End Sub

    Private Sub ButtonsButton_Click(sender As Object, e As EventArgs) Handles ButtonsButton.Click
        ReadmeLabel.Text = "There are numerous buttons in the application, and are generally self explained. 'Logcat' will logcat your phone, pulling the most recent logs, and saving them. 'Root Shell' will attempt root via various methods, which range from a simple 'su' to a full exploit injection. 'SEPolicy' will attempt to set SELinux to permissive. Be aware, you require root for this."
    End Sub

    Private Sub HashButton_Click(sender As Object, e As EventArgs) Handles HashButton.Click
        ReadmeLabel.Text = "Not Yet Implemented"
    End Sub

    Private Sub NothingButton_Click(sender As Object, e As EventArgs) Handles NothingButton.Click
        ReadmeLabel.Text = ""
    End Sub
End Class