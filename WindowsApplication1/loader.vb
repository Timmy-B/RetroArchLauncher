Imports Nini.Config
Imports System.IO
Imports System.Reflection

Public Class loader
    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim source As New IniConfigSource("retroarchlauncher.ini")
        Dim strRetroPath As String
        Dim strCollection As String
        Dim strCore As String
        Dim strRomPath As String
        Dim strFullRomPath As String
        Dim strRetroArgs As String
        Dim strSettingsFile As String
        Dim strRASettingsFile As String
        Dim strMessSystem As String
        Dim strSettingsFilePath As String
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        File.Create("RetroArchLauncher.log").Dispose()
        If clArgs.Length > 1 Then
            Show()
            strCollection = clArgs(1)
            strRomPath = clArgs(2)
            strRomPath = strRomPath.Replace("/", "\")
            strFullRomPath = Path.GetFullPath(strRomPath)
            strRetroPath = source.Configs("RetroArch").GetString("Path")
            strSettingsFile = "RLsettings\" & strCollection & ".cfg"
            strRASettingsFile = strRetroPath & "retroarch.default.cfg"
            strSettingsFilePath = strRetroPath & strSettingsFile
            If (Not File.Exists(strSettingsFilePath)) Then
                File.Copy(strRASettingsFile, strSettingsFilePath)
            End If
            Me.WindowState = FormWindowState.Minimized
            strCore = source.Configs("Collections").GetString(strCollection)
            strMessSystem = source.Configs("MessMap").GetString(strCollection)
            'Path.Combine(Application.StartupPath, strRetroPath)
            If strCore = "mess_libretro.dll" Or strCore = "ume_libretro.dll" Then
                strRetroArgs = " --config " & """" & strSettingsFile & """" & " -L cores\" & strCore & " " & _
                    """" & " " & strMessSystem & " -cart \" & """" & strFullRomPath & "\" & """" & " -rp system\mess\roms" & """"
            Else
                strRetroArgs = """" & "-L" & """" & " " & """" & "cores\" & strCore & _
                    """" & " " & """" & strFullRomPath & """" & " " & "--config " & """" & strSettingsFile
            End If

            Using writer As StreamWriter = New StreamWriter("RetroArchLauncher.log")
                writer.Write(Path.GetFullPath(strRetroPath) & "RetroArch.exe" & strRetroArgs)
            End Using
            Dim launch As New ProcessStartInfo
            launch.WorkingDirectory = Path.GetFullPath(strRetroPath)
            launch.FileName = "RetroArch.exe"
            launch.Arguments = strRetroArgs
            Dim RA As Process = New Process
            RA.StartInfo = launch
            RA.Start()
            RA.WaitForExit()
            launch = Nothing

        Else
            Dim frm As New Form1
            frm.ShowDialog()
            Application.Exit()
        End If
            Application.Exit()
    End Sub



End Class