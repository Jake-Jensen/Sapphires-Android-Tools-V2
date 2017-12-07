Imports System.IO
Imports System.IO.Compression
Imports System.Timers

Public Class Form1

    Private Class GV
        'Debug mode------------------------------
        Public Shared Debug_Mode As Integer = 1
        Public Shared SpamTextBox As Integer = 0
        Public Shared ResolutionW As String
        Public Shared ResolitionH As String
        'Debug mode------------------------------
        Public Shared ProgStatus As Integer = 0
        Public Shared ADBStatus As Integer = 0
        Public Shared Registered As Integer = 0
        Public Shared LogInAttempts As Integer = 0
        Public Shared Is32Bit As Integer = 0
        Public Shared Core_Count As String
        Public Shared Processor_Name As String
        Public Shared RAM_Size As ULong = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024

        'Audio variables
        Public Shared IsMusicPlaying As Integer = 0
        Public Shared TrackList As Integer = 0

        'Optional audio shit
        Public Shared HasMusic As Integer = 0
        Public Shared FirstMusicRun As Integer = 0
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\Program Files\SplitSecond\adb.exe") Then
            GV.Is32Bit = 1
            ProgressBox.Text = ProgressBox.Text & "Seriously? 32bit mode? Damn."
        Else
            ProgressBox.Text = ProgressBox.Text & "64bit mode engaged."
        End If

        If GV.Debug_Mode = 0 Then

            ProgressBox.Text = ProgressBox.Text & vbNewLine & "Debug mode engaged."
            ProgressBox.Text = ProgressBox.Text & vbNewLine & "Debug Menu enabled in Tools tab."
        End If

        GV.ProgStatus = 1
        Call FileCheck()
        Call ADBProcessSub()
        Call GetComputerInfo()
    End Sub
    Private Sub Debug_Menu()
        DebugMenuToolStripMenuItem.Visible = True
    End Sub


    Private Sub GetComputerInfo()
        GV.Core_Count = System.Environment.ProcessorCount.ToString
        GV.Processor_Name = CreateObject("WScript.Shell").RegRead("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0\ProcessorNameString")
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Core count:  " & GV.Core_Count & vbNewLine & "CPU name: " & GV.Processor_Name
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "CPU information fetched."
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Total RAM: " & GV.RAM_Size & " MB"
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "RAM information fetched."
    End Sub

    Private Sub FileCheck()
        If My.Computer.FileSystem.FileExists("C:\Program Files\SplitSecond\adb.exe") Or My.Computer.FileSystem.FileExists("C:\Program Files (x86)\SplitSecond\adb.exe") Then
            ReadyButton.BackColor = Color.Green
            ReadyButton.ForeColor = Color.Green
            GV.ProgStatus = 1
        Else
            FileFail()
        End If

    End Sub

    Private Sub Timer1_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 'Part of the Timer set. Once the timer fully ticks down, call the status checker.
        Call ADBProcessSub()
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
        MsgBox("Something went wrong. Please run the installer again.")
        If My.Computer.FileSystem.FileExists("C:\Program Files\SplitSecond\adb.exe") Or My.Computer.FileSystem.FileExists("C:\Program Files (x86)\SplitSecond\adb.exe") Then
            ReadyButton.BackColor = Color.Green
            ReadyButton.ForeColor = Color.Green
        Else
            FileFail()
        End If

    End Sub

    ' Bunch of black magic here.
    Function adb64(ByVal Arguments As String) As String
        Try

            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()

            My_Process_Info.FileName = "cmd.exe"
            My_Process_Info.Arguments = Arguments
            My_Process_Info.WorkingDirectory = "C:\Program Files (x86)\SplitSecond"
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

    Function adb32(ByVal Arguments As String) As String
        Try

            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()

            My_Process_Info.FileName = "cmd.exe"
            My_Process_Info.Arguments = Arguments
            My_Process_Info.WorkingDirectory = "C:\Program Files\SplitSecond"
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles StartADBBackground.DoWork
        If GV.Is32Bit = 0 Then
            adb64("/c adb start-server")
        End If

        If GV.Is32Bit = 1 Then
            adb32("/c adb start-server")
        End If

    End Sub

    Private Sub StopADBBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles StopADBBackground.DoWork


        If GV.Is32Bit = 0 Then
            adb64("/c adb kill-server")
            Shell("TASKKILL /im adb.exe /f")
        End If

        If GV.Is32Bit = 1 Then
            adb32("/c adb kill-server")
            Shell("TASKKILL /im adb.exe /f")
        End If

    End Sub

    Private Sub LogcatBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LogcatBackground.DoWork
        If GV.Is32Bit = 1 Then
            If Not My.Computer.FileSystem.DirectoryExists("C:\Program Files\SplitSecond\Logcat") Then
                My.Computer.FileSystem.CreateDirectory("C:\Program Files\SplitSecond\Logcat")
            End If
        End If

        If GV.Is32Bit = 0 Then
            If Not My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)\SplitSecond\Logcat") Then
                My.Computer.FileSystem.CreateDirectory("C:\Program Files (x86)\SplitSecond\Logcat")
            End If
        End If

        If GV.Is32Bit = 1 Then
            adb32("""/c adb shell logcat -d > ""C:\Program Files\SplitSecond\Logcat\Logcat.txt")
            System.Diagnostics.Process.Start("C:\Program Files\SplitSecond\Logcat")
        End If


        If GV.Is32Bit = 0 Then
            adb64("""/c adb shell logcat -d > ""C:\Program Files (x86)\SplitSecond\Logcat\Logcat.txt")
            System.Diagnostics.Process.Start("C:\Program Files (x86)\SplitSecond\Logcat")
        End If
    End Sub

    Private Sub SEPolicyBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SEPolicyBackground.DoWork
        If GV.Is32Bit = 0 Then
            adb64("/c adb shell SETENFORCE 0")
            'EnforceStatusButton.BackColor = Color.Yellow
            'EnforceStatusButton.ForeColor = Color.Yellow
        End If

        If GV.Is32Bit = 1 Then
            adb32("/c adb shell SETENFORCE 0")
            'EnforceStatusButton.BackColor = Color.Yellow
            'EnforceStatusButton.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub ForceResetBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ForceResetBackground.DoWork
        If GV.Is32Bit = 1 Then
            adb32("/c adb shell rm /data/local/tmp/*")
        End If

        If GV.Is32Bit = 0 Then
            adb64("/c adb shell rm /data/local/tmp/*")
        End If
    End Sub

    Private Sub IAmGrootBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles IAmGrootBackground.DoWork
        If GV.Is32Bit = 0 Then
            adb64("""/c adb push ""C:\Program Files (x86)\SplitSecond\Sapphires_Clean_Cow /data/local/tmp")
            adb64("""/c adb push ""C:\Program Files (x86)\SplitSecond\Sapphires_Run_As /data/local/tmp")
            adb64("/c adb shell chmod 0777 /data/local/tmp/*")
            adb64("/c adb shell /data/local/tmp/Sapphires_Clean_Cow /system/bin/run-as /data/local/tmp/Sapphires_Run_As")
            adb64("/c adb shell /data/local/tmp/Sapphires_Clean_Cow /system/bin/applypatch /data/local/tmp/Sapphires_Clean_Cow")
            System.Diagnostics.Process.Start("C:\Program Files (x86)\SplitSecond\RunShell.bat")
        End If

        If GV.Is32Bit = 1 Then
            adb32("""/c adb push ""C:\Program Files\SplitSecond\Sapphires_Clean_Cow /data/local/tmp")
            adb32("""/c adb push ""C:\Program Files\SplitSecond\Sapphires_Run_As /data/local/tmp")
            adb32("/c adb shell chmod 0777 /data/local/tmp/*")
            adb32("/c adb shell /data/local/tmp/Sapphires_Clean_Cow /system/bin/run-as /data/local/tmp/Sapphires_Run_As")
            adb32("/c adb shell /data/local/tmp/Sapphires_Clean_Cow /system/bin/applypatch /data/local/tmp/Sapphires_Clean_Cow")
            System.Diagnostics.Process.Start("C:\Program Files\SplitSecond\RunShell.bat")
        End If

    End Sub

    Private Sub StartADBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartADBToolStripMenuItem1.Click
        StartADBBackground.RunWorkerAsync()
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "We can haz ADB?"
    End Sub

    Private Sub KillADBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillADBToolStripMenuItem.Click
        StopADBBackground.RunWorkerAsync()
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Killing ADB. You monster."
    End Sub

    Private Sub SetPermissiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPermissiveToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "SELinux exploit started..."
        SEPolicyBackground.RunWorkerAsync()
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Exploit finished."
    End Sub

    Private Sub CleanCowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanCowToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Starting exploit..."
        IAmGrootBackground.RunWorkerAsync()
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Exploit is running. Wait for a shell to open."
    End Sub

    Private Sub ForceResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForceResetToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Wiping and uninstalling all exploits from the phone."
        ForceResetBackground.RunWorkerAsync()
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Wiped."
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Donate button clicked. Buy me a pizza?"
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=BYNFMCABCDNNG&lc=US&item_name=Sapphire&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
    End Sub

    Private Sub ContributorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContributorsToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Buy me a pizza and get your name here."
        MsgBox("Current list of donators" & vbNewLine & vbNewLine & "Zeth")
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://discord.gg/CAndxUc")
    End Sub

    Private Sub ContactToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem1.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Contact info provided."
        MsgBox("For general inquiries, email me at SapphireExOne@gmail.com" & vbNewLine & "For all other inquirires, email me at SoHzAssassinSteam@gmail.com")
    End Sub

    Private Sub ReadMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadMeToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Readme opened."
        Form2.Show()
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "You like da backgrounds boss?"
        BackgroundChanger1.Show()
    End Sub

    Private Sub LogcatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogcatToolStripMenuItem.Click
        Try
            Dim ADBProcess() As Process
            ADBProcess = Process.GetProcessesByName("adb")
            If ADBProcess.Count > 0 Then
                ProgressBox.Text = ProgressBox.Text & vbNewLine & "Starting Logcat..."
                LogcatBackground.RunWorkerAsync()
                ProgressBox.Text = ProgressBox.Text & vbNewLine & "Logcat finished."
            Else
                ProgressBox.Text = ProgressBox.Text & vbNewLine & "ADB server not running. Starting it now."
                StartADBBackground.RunWorkerAsync()
                ProgressBox.Text = ProgressBox.Text & vbNewLine & "We can haz ADB?"
                ProgressBox.Text = ProgressBox.Text & vbNewLine & "Reuse logcat now."
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SpamStatusBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpamStatusBoxToolStripMenuItem.Click
        If GV.SpamTextBox < 50 Then
            ProgressBox.Text = ProgressBox.Text & vbNewLine & "Cycle run iteration = " & GV.SpamTextBox
            GV.SpamTextBox = GV.SpamTextBox + 1
            Call SpamStatusBoxToolStripMenuItem_Click(sender, e)
        End If

        If GV.SpamTextBox = 50 Then
            ProgressBox.Text = ProgressBox.Text & vbNewLine & "Run ended."
            GV.SpamTextBox = 0
            Exit Sub
        End If

    End Sub

    Private Sub CheckDBStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckDBStatusToolStripMenuItem.Click
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Could not connect. Reason: Server not running."
    End Sub

    Private Sub CheckResolutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckResolutionToolStripMenuItem.Click
        GV.ResolitionH = Screen.PrimaryScreen.Bounds.Height
        GV.ResolutionW = Screen.PrimaryScreen.Bounds.Width
        ProgressBox.Text = ProgressBox.Text & vbNewLine & "Resolution is: " & GV.ResolutionW & "x" & GV.ResolitionH
    End Sub
End Class
