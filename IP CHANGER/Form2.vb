Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Threading
Imports System.Threading.Thread
Imports System.EventArgs
Imports System.ComponentModel
Public Class Form2

    ' NOTE: All settings are "ApplicationSetting" property binded, so they are changed, updated automaticaly
    Public Shared logger As log4net.ILog
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logger = log4net.LogManager.GetLogger("IP_CHANGER_ON_LF")
        logger.Info("Form loaded.")
        logger.Debug(My.Settings.ProfilesFilePath)
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub

    Private Sub CB_AutoLoadCfg_Click(sender As Object, e As EventArgs) Handles CB_AutoLoadCfg.Click
        logger.Info("State Checked: " & CB_AutoLoadCfg.Checked)
        If CB_AutoLoadCfg.Checked Then
            My.Settings.ProfilesFilePath = Form1.FilePath
        End If
    End Sub

    Private Sub CB_LastUsedNIC_Click(sender As Object, e As EventArgs) Handles CB_LastUsedNIC.Click
        logger.Info("State Checked: " & CB_LastUsedNIC.Checked)
        If CB_LastUsedNIC.Checked Then
            My.Settings.LastNetworkAdapterUsed = Form1.CB_NIC.SelectedItem
        End If

    End Sub

    Private Sub CB_CheckIPused_Click(sender As Object, e As EventArgs) Handles CB_CheckIPused.Click
        logger.Info("State Checked: " & CB_CheckIPused.Checked)
    End Sub

    Private Sub CB_CheckNetConnected_Click(sender As Object, e As EventArgs) Handles CB_CheckNetConnected.Click
        logger.Info("State Checked: " & CB_CheckNetConnected.Checked)
    End Sub

    Private Sub CB_CheckForIPv6_Click(sender As Object, e As EventArgs) Handles CB_CheckForIPv6.Click
        logger.Info("State Checked: " & CB_CheckForIPv6.Checked)
    End Sub

    Private Sub CB_VerifyIPchange_Click(sender As Object, e As EventArgs) Handles CB_VerifyIPchange.Click
        logger.Info("State Checked: " & CB_VerifyIPchange.Checked)
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        logger.Info("Form closed.")
    End Sub

End Class