﻿Imports System.ComponentModel
Imports System.Windows.Forms

Imports MediaPortal.Configuration
Imports MediaPortal.GUI.Library

Namespace MPCleaner

    <PluginIcons("MPCleaner.MPCleaner_enabled.png", "MPCleaner.MPCleaner_disabled.png")>
    Public Class MPCleaner
        Implements IPlugin
        Implements ISetupForm
        Implements IShowPlugin

        Public Sub New()
            MyBase.new()
        End Sub

#Region "IPlugin members"

        ' This method will be called by mediaportal to start our process plugin
        Public Sub Start() Implements MediaPortal.GUI.Library.IPlugin.Start

            Dim bw As BackgroundWorker = New BackgroundWorker

            bw.WorkerSupportsCancellation = False
            bw.WorkerReportsProgress = False
            AddHandler bw.DoWork, AddressOf Worker

            bw.RunWorkerAsync()

        End Sub

        Private Sub Worker()

            Dim mcp As New MPCleanerProcess
            mcp.MPCleanerProcess()

        End Sub

        ' This method will be called by mediaportal to stop the process plugin
        Public Sub [Stop]() Implements MediaPortal.GUI.Library.IPlugin.Stop

        End Sub

#End Region

#Region "ISetupForm members"

        ' Returns the author of the plugin which is shown in the plugin menu
        Public Function Author() As String Implements ISetupForm.Author
            Return "m3rcury"
        End Function

        ' Indicates whether plugin can be enabled/disabled
        Public Function CanEnable() As Boolean Implements ISetupForm.CanEnable
            Return True
        End Function

        ' Indicates if plugin is enabled by default
        Public Function DefaultEnabled() As Boolean Implements ISetupForm.DefaultEnabled
            Return True
        End Function

        ' Returns the description of the plugin is shown in the plugin menu
        Public Function Description() As String Implements ISetupForm.Description
            Return "MPCleaner removes unused thumbs, backdrops, banners and fanart from your drive, freeing up space."
        End Function

        ''' <summary>
        ''' If the plugin should have it's own button on the main menu of MediaPortal then it
        ''' should return true to this method, otherwise if it should not be on home
        ''' it should return false
        ''' </summary>
        ''' <param name="strButtonText">text the button should have</param>
        ''' <param name="strButtonImage">image for the button, or empty for default</param>
        ''' <param name="strButtonImageFocus">image for the button, or empty for default</param>
        ''' <param name="strPictureImage">subpicture for the button or empty for none</param>
        ''' <returns>true : plugin needs it's own button on home
        ''' false : plugin does not need it's own button on home</returns>

        Public Function GetHome(ByRef strButtonText As String, ByRef strButtonImage As String, ByRef strButtonImageFocus As String, ByRef strPictureImage As String) As Boolean Implements ISetupForm.GetHome
            strButtonText = String.Empty
            strButtonImage = String.Empty
            strButtonImageFocus = String.Empty
            strPictureImage = String.Empty
            Return False
        End Function

        ' Get Windows-ID
        Public Function GetWindowId() As Integer Implements MediaPortal.GUI.Library.ISetupForm.GetWindowId
            ' WindowID of windowplugin belonging to this setup
            ' enter your own unique code
            Return -1
        End Function

        ' indicates if a plugin has it's own setup screen
        Public Function HasSetup() As Boolean Implements MediaPortal.GUI.Library.ISetupForm.HasSetup
            Return True
        End Function

        ' Returns the name of the plugin which is shown in the plugin menu
        Public Function PluginName() As String Implements MediaPortal.GUI.Library.ISetupForm.PluginName
            Return "MPCleaner"
        End Function

        ' show the setup dialog
        Public Sub ShowPlugin() Implements MediaPortal.GUI.Library.ISetupForm.ShowPlugin

            'Using MPCleanerForm As Form = New Global.MPCleaner.MPCleanerForm(_database, _thumbs, _chkbox)
            Using MPCleanerForm As Form = New Global.MPCleaner.MPCleanerForm()
                MPCleanerForm.ShowDialog()
            End Using

        End Sub

#End Region

#Region "IShowPlugin members"

        Public Function ShowDefaultHome() As Boolean Implements MediaPortal.GUI.Library.IShowPlugin.ShowDefaultHome
            Return False
        End Function

#End Region

 
    End Class

End Namespace