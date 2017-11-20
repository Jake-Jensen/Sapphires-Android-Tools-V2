Imports System.IO
Imports System.IO.Compression
Imports System.Timers

Module Module1
    Sub ExploitZipExtraction()
        Dim zipPath As String = Environment.ExpandEnvironmentVariables("%userprofile%\Downloads\Exploit.zip")
        Dim extractPath As String = "c:\Documents and Settings\All Users\Documents\Sapphire's Android Tools"

        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub
End Module

Public Class Form1

    Private Class GV
        Public Shared ProgStatus As Integer = 0
        Public Shared ADBStatus As Integer = 0
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\11-19-2017.txt") Then
            Call ADBProcessSub()
        End If
        ' ' Basic file verification, and changes the color of the status buttons to green if they are ready. 
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



        If Not My.Computer.FileSystem.FileExists("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\11-19-2017.txt") Then
            Call DeleteFilesFromFolder("c:\Documents and Settings\All Users\Documents\Sapphire's Android Tools")
            Call ExploitZipExtraction()
        End If

    End Sub

    Private Sub Timer1_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 'Part of the Timer set. Once the timer fully ticks down, call the status checker.
        Call ADBProcessSub()
    End Sub


    Private Sub DeleteShit()
        Call DeleteFilesFromFolder("c:\Documents and Settings\All Users\Documents\Sapphire's Android Tools")
        Call ExploitZipExtraction()
    End Sub

    Sub DeleteFilesFromFolder(Folder As String)
        If Directory.Exists(Folder) Then
            For Each _file As String In Directory.GetFiles(Folder)
                File.Delete(_file)
            Next
            For Each _folder As String In Directory.GetDirectories(Folder)

                DeleteFilesFromFolder(_folder)
            Next

        End If

    End Sub

    Private Sub ADBProcessSub()
        ' Debug message
        'MsgBox("Timer is ticking")
        'Check ADB status
        Dim ADBProcess() As Process
        ADBProcess = Process.GetProcessesByName("adb")
        If ADBProcess.Count > 0 Then
            ADBStatusButton.BackColor = Color.Green
            ADBStatusButton.ForeColor = Color.Green
        End If
        If ADBProcess.Count = 0 Then
            ADBStatusButton.BackColor = Color.Red
            ADBStatusButton.ForeColor = Color.Red
        End If
        Timer1.Stop()
        Timer1.Start()
    End Sub

    ' Basic file verification, and changes the color of the status buttons to green if they are ready. 
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

    ' Bunch of black magic here.
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

    ' Opens adb with the logcat option, then passes all output to a file. Then opens the directory of the file.
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        adb("""/c adb shell logcat -d > ""C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\Logcat\Logcat.txt")
        System.Diagnostics.Process.Start("C:\Documents and Settings\All Users\Documents\Sapphire's Android Tools\Logcat")
    End Sub

    ' Pushes the exploit, gives it the proper permissions, then executes it on the phone.
    Private Sub ExploitButton_Click(sender As Object, e As EventArgs) Handles ExploitButton.Click
        MsgBox("1. Connect phone over USB to computer" & vbNewLine & "2. Open terminal emulator, and type 'busybox nc localhost:5555. Do NOT press enter yet." & vbNewLine & "3. Close this dialogue, wait 10 seconds, then press enter on terminal emulator." & vbNewLine & "If you don't get a shell, reboot your phone and try again. The shell WILL NOT read back messages. It's one way. Don't expect a $ or # either. Just start typing." & vbNewLine & "To resume program after exploit, disconnect your phone. This will also disconnect the root shell.")
        adb("/c adb push exploit /data/local/tmp")
        adb("/c adb shell chmod 777 /data/local/tmp/exploit")
        adb("/c adb shell ./data/local/tmp/exploit 5555")
    End Sub

    ' Discord invite button
    Private Sub DiscordButton_Click(sender As Object, e As EventArgs) Handles DiscordButton.Click
        System.Diagnostics.Process.Start("https://discord.gg/CAndxUc")
    End Sub

    ' Email contacts
    Private Sub ContactButton_Click(sender As Object, e As EventArgs) Handles ContactButton.Click
        MsgBox("For general inquiries, email me at SapphireExOne@gmail.com" & vbNewLine & "For all other inquirires, email me at SoHzAssassinSteam@gmail.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("This will attempt to disable SELinux. Connect phone via USB now. Works best when ran after root shell.")
        adb("/c adb shell SETENFORCE 0")
        EnforceStatusButton.BackColor = Color.Yellow
        EnforceStatusButton.ForeColor = Color.Yellow
    End Sub

    Private Sub ReadmeButton_Click(sender As Object, e As EventArgs) Handles ReadmeButton.Click
        Form2.Show()
    End Sub

    Private Sub DCV1Button_Click(sender As Object, e As EventArgs) Handles DCV1Button.Click
        adb("/c adb push DC01.sh /data/local/tmp")
        adb("/c adb push run-as-dirtycow /data/local/tmp")
        adb("/c adb push run-as-dirtycow64 /data/local/tmp")
        adb("/c adb push supolicy /data/local/tmp")
        adb("/c adb push su.img /data/local/tmp")
        adb("/c adb push patch-init /data/local/tmp")
        adb("/c adb push busybox /data/local/tmp")
        adb("/c adb push readelf /data/local/tmp")
        adb("/c adb push libsupol.so /data/local/tmp")
        adb("/c adb shell chmod 777 /data/local/tmp/*")
        adb("/c adb shell ./data/local/tmp/DC01.sh run-as-dirtycow /system/bin/run-as")
        ' Unable to grep output yet. Default to yellow.
        DCV1StatusButton.BackColor = Color.Yellow
        DCV1StatusButton.ForeColor = Color.Yellow
        EnforceStatusButton.BackColor = Color.Yellow
        EnforceStatusButton.ForeColor = Color.Yellow
    End Sub

    Private Sub DonateButton_Click(sender As Object, e As EventArgs) Handles DonateButton.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=BYNFMCABCDNNG&lc=US&item_name=Sapphire&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
    End Sub

    Private Sub ADBServerButton_Click(sender As Object, e As EventArgs) Handles ADBServerButton.Click
        adb("/c adb kill server")
        Shell("taskkill /F /IM adb.exe /T", 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles StartADBButton.Click
        adb("/c adb start-server")
    End Sub
End Class
