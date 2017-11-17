Public Class Form1
    'Black magic ahead
    'Check program status
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\adb.exe") Then

            If My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\exploit") Then
                ReadyButton.BackColor = Color.Green
                ReadyButton.ForeColor = Color.Green
                GV.ProgStatus = 1
            Else
                FileFail()
            End If
        Else
            FileFail()
        End If

        'Check ADB status
        If GV.ProgStatus = 1 Then
            adb("/c adb kill-server")
            adb("/c adb start-server")
            Dim ADBProcess() As Process
            ADBProcess = Process.GetProcessesByName("adb")
            If ADBProcess.Count > 0 Then
                ADBStatusButton.BackColor = Color.Green
                ADBStatusButton.ForeColor = Color.Green
            Else
                MsgBox("ADB failed for an unknown reason. Restart the program and try again.")
            End If
        End If
    End Sub

    Private Class GV
        Public Shared ProgStatus As Integer = 0
        Public Shared ADBStatus As Integer = 0
    End Class



    Private Sub FileFail()
        MsgBox("Required files not found." & vbNewLine & "Extract the included archive specifically to 'C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools'" & vbNewLine & "Once it is extracted, close this dialogue.")
        If My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\adb.exe") Then
            If My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\exploit") Then
                ReadyButton.BackColor = Color.Green
                ReadyButton.ForeColor = Color.Green
            Else
                FileFail()
            End If
        End If
    End Sub

    Function adb(ByVal Arguments As String) As String
        Try

            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()

            My_Process_Info.FileName = "cmd.exe"
            My_Process_Info.Arguments = Arguments
            My_Process_Info.WorkingDirectory = "C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools"
            My_Process_Info.CreateNoWindow = True
            My_Process_Info.UseShellExecute = False
            My_Process_Info.RedirectStandardOutput = True
            My_Process_Info.RedirectStandardError = True

            My_Process.EnableRaisingEvents = True
            My_Process.StartInfo = My_Process_Info
            My_Process.Start()

            Dim Process_ErrorOutput As String = My_Process.StandardOutput.ReadToEnd()
            Dim Process_StandardOutput As String = My_Process.StandardOutput.ReadToEnd()


            If Process_ErrorOutput IsNot Nothing Then Return Process_ErrorOutput
            If Process_StandardOutput IsNot Nothing Then Return Process_StandardOutput

        Catch ex As Exception
            Return ex.Message
        End Try

        Return "OK"

    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        adb("""/c adb shell logcat -d > ""C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\Logcat\Logcat.txt")
        System.Diagnostics.Process.Start("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\Logcat")
    End Sub

    Private Sub ExploitButton_Click(sender As Object, e As EventArgs) Handles ExploitButton.Click
        MsgBox("1. Connect phone over USB to computer" & vbNewLine & "2. Open terminal emulator, and type 'busybox nc localhost:5555. Do NOT press enter yet." & vbNewLine & "3. Close this dialogue, wait 10 seconds, then press enter on terminal emulator." & vbNewLine & "If you don't get a shell, reboot your phone and try again. The shell WILL NOT read back messages. It's one way. Don't expect a $ or # either. Just start typing." & vbNewLine & "To resume program after exploit, disconnect your phone. This will also disconnect the root shell.")
        adb("/c adb push exploit /data/local/tmp")
        adb("/c adb shell chmod 777 /data/local/tmp/exploit")
        adb("/c adb shell ./data/local/tmp/exploit 5555")
    End Sub
End Class
