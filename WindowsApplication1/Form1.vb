Imports Microsoft.VisualBasic.FileIO
Imports Nini.Config
Imports System.IO


Public Class Form1
    Dim source As New IniConfigSource("retroarchlauncher.ini")
    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Appexepath As String = Path.Combine(Application.StartupPath, "..\collections\")
        Dim rpath As String

        rpath = source.Configs("RetroArch").GetString("Path")
        If rpath = "" Then
            tb_retroloc.Text = ""
        Else
            tb_retroloc.Text = Path.GetFullPath(rpath)
        End If
        AddFolders(Appexepath)
        AddCores()
    End Sub

    Public Shared Function MakeRelativePath(fromPath As String, toPath As String) As String
        If String.IsNullOrEmpty(fromPath) Then
            Throw New ArgumentNullException("fromPath")
        End If
        If String.IsNullOrEmpty(toPath) Then
            Throw New ArgumentNullException("toPath")
        End If

        Dim fromUri As New Uri(fromPath)
        Dim toUri As New Uri(toPath)

        If fromUri.Scheme <> toUri.Scheme Then
            Return toPath
        End If
        ' path can't be made relative.
        Dim relativeUri As Uri = fromUri.MakeRelativeUri(toUri)
        Dim relativePath As String = Uri.UnescapeDataString(relativeUri.ToString())

        If toUri.Scheme.ToUpperInvariant() = "FILE" Then
            relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        End If

        Return relativePath
    End Function

    Private Sub AddCores()
        Dim coreFolder = tb_retroloc.Text & "cores"
        cb_corelist.ResetText()
        If Directory.Exists(coreFolder) Then
                For Each file As String In System.IO.Directory.GetFiles(coreFolder)
                    cb_corelist.Items.Add(System.IO.Path.GetFileName(file))
                Next
        End If
    End Sub

    Private Sub AddFolders(collectionFolders As String)
        For Each collecDirectory As IO.DirectoryInfo In New IO.DirectoryInfo(collectionFolders).GetDirectories()
            If collecDirectory.Name <> "_manufacturer" Or collecDirectory.Name <> "Main" Then
                lb_collections.Items.Add(collecDirectory.Name)
            End If
        Next
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click

        Dim retrofpath As String
        Dim retrofpathRel As String
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select RetroArch Install Folder"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            retrofpath = dialog.SelectedPath & "\"
            tb_retroloc.Text = retrofpath
            retrofpathRel = MakeRelativePath(Application.StartupPath & "\", retrofpath)
            source.Configs("RetroArch").Set("Path", retrofpathRel)
            source.Save()
            AddCores()
        End If

    End Sub

    Private Sub lb_collections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_collections.SelectedIndexChanged
        Dim coreName As String
        Dim messName As String
        tb_collecname.Text = lb_collections.SelectedItem
        coreName = source.Configs("Collections").GetString(lb_collections.SelectedItem)
        cb_corelist.SelectedIndex = cb_corelist.FindStringExact(coreName)
        If coreName = "mess_libretro.dll" Or coreName = "ume_libretro.dll" Then
            lbl_messsysname.Visible = True
            tb_messsysname.Visible = True
            messName = source.Configs("MessMap").GetString(lb_collections.SelectedItem)
            tb_messsysname.Text = source.Configs("MessMap").GetString(lb_collections.SelectedItem)
        Else
            lbl_messsysname.Visible = False
            tb_messsysname.Visible = False
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_SaveCore_Click(sender As Object, e As EventArgs) Handles btn_SaveCore.Click
        source.Configs("Collections").Set(lb_collections.SelectedItem, cb_corelist.Text)
        source.Configs("MessMap").Set(lb_collections.SelectedItem, tb_messsysname.Text)
        source.Save()
    End Sub

    Private Sub cb_corelist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_corelist.SelectedIndexChanged
        Dim messName As String
        If cb_corelist.Text = "mess_libretro.dll" Or cb_corelist.Text = "ume_libretro.dll" Then
            lbl_messsysname.Visible = True
            tb_messsysname.Visible = True
            messName = source.Configs("MessMap").GetString(lb_collections.SelectedItem)
            tb_messsysname.Text = source.Configs("MessMap").GetString(lb_collections.SelectedItem)
        Else
            lbl_messsysname.Visible = False
            tb_messsysname.Visible = False
        End If
    End Sub


End Class









