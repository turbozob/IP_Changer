﻿Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Threading
Imports System.Threading.Thread
Imports System.EventArgs
Imports System.ComponentModel

Public Class Form1
    Public Shared selectedAdapter As String
    Public Shared DeviceID As String
    Public Shared FilePath As String
    Public Shared LogPath As String
    Public Shared ExternalEditor As String
    Public Shared DefaultEditor As String = "C:\Windows\System32\notepad.exe"
    Public Shared TimeFull As DateTime = DateTime.Now
    Public Shared NumberOfLinesProfile As Integer
    Public Shared ProfileNameFull(1000) As String
    Public Shared IPAddress(1000) As String
    Public Shared IPAddressGet As String
    Public Shared Subnet(1000) As String
    Public Shared Gateway(1000) As String
    Public Shared NetworkAdaptersCaption(20) As String
    Public Shared NetworkAdaptersName(20) As String
    Public Shared NetworkConnected As Boolean
    Public Shared NetworkDisconnected As Boolean
    Public Shared logger As log4net.ILog
    Public Shared loggerNoLf As log4net.ILog
    Public Shared logger1stLine As log4net.ILog
    Private objMutex As System.Threading.Mutex

    Public Structure naslov
        Dim IpAddress As String
        Dim Subnet As String
        Dim Gateway As String
        Dim Active As Boolean


        Function ALL() As String
            Return IpAddress & "," & Subnet & "," & Gateway
        End Function
    End Structure


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Check to prevent running twice
        objMutex = New System.Threading.Mutex(False, "MyApplicationName")
        If objMutex.WaitOne(0, False) = False Then
            objMutex.Close()
            objMutex = Nothing
            MessageBox.Show("Another instance is already running!")
            End
        End If

        'If you get to this point it's frist instance
        'init logger
        Try
            'Get the logger as named in the configuration file.
            logger = log4net.LogManager.GetLogger("IP_CHANGER_ON_LF")
            loggerNoLf = log4net.LogManager.GetLogger("IP_CHANGER_OFF_LF")
            logger1stLine = log4net.LogManager.GetLogger("IP_CHANGER_1ST_LINE")

            logger1stLine.Info("")
            logger.Info(My.Application.Info.ProductName & " " & String.Format("Version {0}", My.Application.Info.Version.ToString))
            logger.Info("Reloading My.Settings")
            logger.Info("My.Settings.ConfigFilePath = " & My.Settings.ProfilesFilePath)
            logger.Info("My.Settings.AutoLoadConfigFile = " & My.Settings.AutoLoadProfilesFile)
            logger.Info("My.Settings.AutoLoadNic = " & My.Settings.AutoLoadLastNetworkAdapter)
            logger.Info("My.Settings.LastNICUsed = " & My.Settings.LastNetworkAdapterUsed)
            logger.Info("My.Settings.CheckForUsedIP = " & My.Settings.CheckForUsedIP)
            logger.Info("My.Settings.CheckForEnabledNIC = " & My.Settings.CheckForNetworkAdapterEnabled)
            logger.Info("My.Settings.CheckForIPv6 = " & My.Settings.CheckForIPv6)
            logger.Info("My.Settings.VerifyIPaddress = " & My.Settings.VerifyIpAddress)


        Catch ex As Exception
            logger.Error(ex.Message)
        Finally
            logger.Info("Form load Finished")
        End Try

        'Dim test As String = My.Settings.PropertyValues
        'When application is started put default values in textbox and select saved MAC address
        BtnNetScan.PerformClick() ' FIRST PERFORM NETWORK SCAN

        ' Disable auto save last used network card
        Form2.CB_LastUsedNIC.Enabled = False

        ' External Editor location
        ExternalEditor = My.Settings.ExternalEditor



        ' Is auto save last used network card selected?
        If My.Settings.AutoLoadLastNetworkAdapter Then
            FC_AutoLoadLastNicUsed()
        End If

        ' Disable autoloadfile checkbox at startup
        Form2.CB_AutoLoadCfg.Enabled = False

        ' Is autoloadfile selected?
        logger.Info("Auto loading profile file")
        If My.Settings.AutoLoadProfilesFile Then
            logger.Info("Checking if profile file exists at path: " & My.Settings.ProfilesFilePath)
            If My.Computer.FileSystem.FileExists(My.Settings.ProfilesFilePath) Then
                logger.Info("profile file exists")
                FilePath = My.Settings.ProfilesFilePath
                logger.Info("Setting profile file path as: " & FilePath)

                LoadProfileFile(FilePath)             '// call function load profile file update v2.5.0.0

                ' Enable autoloadfile checkbox once profile file exists
                Form2.CB_AutoLoadCfg.Enabled = True
                logger.Info("CB_AutoLoadCfg enabled: " & Form2.CB_AutoLoadCfg.Enabled)

            Else
                logger.Warn("profile file Not Found. Auto Load File Is Disabled. profile file location: " & My.Settings.ProfilesFilePath)
                MessageBox.Show("profile file Not Found. Auto Load File Is Disabled.", "Open profile file At Startup",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                ' Disable autoloadfile checkbox if profile file is not found
                Form2.CB_AutoLoadCfg.Checked = False
                My.Settings.AutoLoadProfilesFile = False
                Form2.CB_AutoLoadCfg.Enabled = False
            End If


        Else
            logger.Info("Setting default addresses...")
            TB_IPaddress.Text = "192.168.1.123"
            TB_Subnet.Text = "255.255.255.0"
            TB_Gateway.Text = "192.168.1.1"
        End If
        lblStatus.Text = "Ready"
        logger.Debug("Finished.")


    End Sub
    Sub DisableButtons()
        ' Disable buttons
        BtnChangeIP.Enabled = False
        BtnDHCP.Enabled = False
        BtnGetIP.Enabled = False
        BtnGetMAC.Enabled = False
        BtnNetDisable.Enabled = False
        BtnNetEnable.Enabled = False
        Form2.CB_LastUsedNIC.Enabled = False
    End Sub
    Sub EnableButtons()
        BtnChangeIP.Enabled = True
        BtnDHCP.Enabled = True
        BtnGetIP.Enabled = True
        BtnGetMAC.Enabled = True
        BtnNetDisable.Enabled = True
        BtnNetEnable.Enabled = True
    End Sub
    ' Function Read Text File Line by Line
    Public Function ReadALine(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String

        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return "No Such Line"
        End If
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line

    End Function
    Public Function GetNumberOfLines(ByVal file_path As String) As Integer

        Dim sr As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While sr.Peek >= 0
            sr.ReadLine()
            NumberOfLines += 1
        Loop
        sr.Close()
        sr.Dispose()
        NumberOfLinesProfile = NumberOfLines
        Return NumberOfLines

    End Function

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        logger.Info("Start")
        Try
            Dim SelectSetupNo As Integer
            SelectSetupNo = ComboBox1.SelectedIndex + 1
            logger.Debug("Selecting setup index: " & SelectSetupNo)
            TB_IPaddress.Text = IPAddress(SelectSetupNo)
            TB_Subnet.Text = Subnet(SelectSetupNo)
            TB_Gateway.Text = Gateway(SelectSetupNo)

        Catch ex As Exception
            logger.Error(ex.Message)
        End Try
        logger.Info("Finished")
    End Sub


    'TEXTBOX SETUP: ENTER NUMBERS ONLY
    Private Sub TB_IPaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_IPaddress.KeyPress
        'If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        'e.Handled = True
        'End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TB_Subnet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_Subnet.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TB_Gateway_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_Gateway.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub


    ' About Window  
    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnABOUT.Click
        'About
        AboutBox1.StartPosition = FormStartPosition.Manual
        AboutBox1.Location = Me.Location
        AboutBox1.Show()
    End Sub




    Private Sub BtnNetScan_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetScan.Click
        logger.Info("Scanning for network adapters...")
        lblStatus.Text = "Scanning for network adapters..."
        CB_NIC.Items.Clear()
        DisableButtons()
        Dim i As Integer = 0

        Dim Result As String
        Dim adapterName As String = ""
        Try
            logger.Info("Selecting query filter Win32_NetworkAdapter ")
            ' search for all adapters which are not Microsoft as manufacturer
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_NetworkAdapter WHERE Manufacturer <> 'Microsoft'")

            For Each queryObj As ManagementObject In searcher.Get()

                Result = (queryObj("Caption")) ' Result is the Caption of network card 
                adapterName = (queryObj("Name")) ' Result is the Caption of network card 
                logger.Info("Found network device: " & Result)

                ' update v2.5.0.1 beta 2A , no need to double query, just paste result
                ' replace 0 zeros from caption names for better overview
                Dim ResultStrTrim As String
                ResultStrTrim = Result.Replace("0", "")
                ' _prev CB_NIC.Items.Add(queryObj("Caption"))

                ' fill array of adapter devices
                NetworkAdaptersCaption(i) = Result
                NetworkAdaptersName(i) = adapterName

                ' add items to combobox adapter selection
                CB_NIC.Items.Add(adapterName)

                i += 1
            Next
        Catch err As ManagementException
            logger.Error("An error occurred while querying for NetworkCardCaption data: " & err.Message)
            MessageBox.Show("An error occurred while querying for NetworkCardCaption data: " & err.Message)
        End Try
        logger.Info("Scan finished")
        lblStatus.Text = "Ready"
    End Sub


    Private Sub CB_Nic_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_NIC.SelectedIndexChanged
        logger.Debug("Start")
        lblStatus.Text = "Selecting network adapter..."
        Call EnableButtons()
        Form2.CB_LastUsedNIC.Enabled = True
        '' update v2.5.0.1 beta 2A
        ' prev selectedAdapter = CB_NIC.Text
        '// 
        selectedAdapter = NetworkAdaptersCaption(CB_NIC.SelectedIndex)

        Try                                                     ' moved try here in ver 2.5.0.0
            logger.Info("Processing DEVICE ID number...")
            Dim NetCard_Split1() As String = selectedAdapter.Split("]") ' Split string Result based on char "]"
            logger.Info("DEVICE ID process finished.")
            AdapterSelected_TextBox.Text = NetCard_Split1(1).Trim()  ' trim remove spaces

            logger.Info("Selecting query filter Win32_NetworkAdapterConfiguration for:  " & selectedAdapter)
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Caption ='" & selectedAdapter & "'") ' declare which NETWORK INDEX = from combobox index


            For Each queryObj As ManagementObject In searcher.Get()
                logger.Info("Getting NetworkAdapter device ID...")
                DeviceID = (queryObj("Index"))
                logger.Info("Device ID is: " & DeviceID)
                NetEnabled()

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for NetworkCardIndex data: " & err.Message)
        End Try
        If My.Settings.AutoLoadLastNetworkAdapter Then
            logger.Info("Saving AutoLoad last NIC used")
            My.Settings.LastNetworkAdapterUsed = CB_NIC.SelectedItem
            ' 'My.Settings.Save() '// not used since save my settings on shutdown is active '// not used since save my settings on shutdown is active
            logger.Info("AutoLoadNic SAVED")

        End If
        logger.Info("Completed.")
        DeviceIdSelected_Textbox.Text = DeviceID
        lblStatus.Text = "Ready"
        logger.Debug("Finished")
    End Sub

    Sub NetEnabled()
        logger.Debug("Start")
        lblStatus.Text = "Checking for network adapter enabled..."
        Try

            logger.Info("Searching Win32_NetworkAdapter WHERE Index = : " & DeviceID)
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_NetworkAdapter WHERE Index = " & DeviceID) ' declare which NETWORK INDEX = from combobox index

            For Each queryObj As ManagementObject In searcher.Get()
                logger.Info("Querying NetworkAdapter parameter NetEnabled")
                If queryObj("NetEnabled") Is Nothing Then
                    logger.Warn("NetEnabled is Nothing")
                    DeviceStatus_Textbox.Text = "Network not available"
                    'MessageBox.Show("Network not available. Please establish connection.")
                    NetworkConnected = False
                ElseIf queryObj("NetEnabled") = "True" Then
                    logger.Info("NetEnabled is True")
                    DeviceStatus_Textbox.Text = "Connected"
                    'MessageBox.Show("Network is connected.")
                    NetworkConnected = True
                ElseIf queryObj("NetEnabled") = "False" Then
                    logger.Info("NetEnabled is False")
                    DeviceStatus_Textbox.Text = "Disconnected"
                    'MessageBox.Show("Network is disconnected")
                    NetworkConnected = False
                Else
                    logger.Info("NetEnabled is not available")
                    DeviceStatus_Textbox.Text = "Disconnected"
                    'MessageBox.Show("Network is disconnected")
                    NetworkConnected = False
                End If
            Next
        Catch err As ManagementException
            logger.Error("An error occurred while querying for NetEnabled data: " & err.Message)
            MessageBox.Show("An error occurred while querying for NetEnabled data: " & err.Message)
            NetworkConnected = False
        End Try
        lblStatus.Text = "Ready"
        logger.Debug("Finished")
    End Sub
    ' CHANGE IP, SUBNET AND GATEWAY
    Private Sub BtnChangeIP_Click(sender As System.Object, e As System.EventArgs) Handles BtnChangeIP.Click
        logger.Debug("Start")
        lblStatus.Text = "Changing IP address ..."
        Dim IPAddress As String = TB_IPaddress.Text
        Dim SubnetMask As String = TB_Subnet.Text
        Dim Gateway As String = TB_Gateway.Text


        ' Is network enabled and connected?
        If My.Settings.CheckForNetworkAdapterEnabled Then
            logger.Info("Checking if network adapter is connected...")
            Call NetEnabled()
            If NetworkConnected = True Then
                logger.Info("Network is connected.")
                lblStatus.Text = "Network is connected."
            Else
                logger.Info("Network is disconnected.")
                lblStatus.Text = "Network is disconnected."
                MessageBox.Show("Please connect cable or enable network card.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                logger.Info("Exiting sub...")
                Exit Sub
            End If
        End If '// end CheckForEnabledNIC

        logger.Info("Checking if IP address fields are valid...")
        ' Are IP address field empty?
        If IPAddress = "" Or SubnetMask = "" Then ' Gateway removed as check
            logger.Warn("One or more fields are empty...")
            MessageBox.Show("Please fill out empty fields", "Note",
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            logger.Info("Exiting sub...")
            Exit Sub
        End If


        ' CHECK IF IP ADDRESS IS USED
        If My.Settings.CheckForUsedIP Then
            logger.Info("Checking if set IP address is already used in network... ")
            Try
                logger.Info("Pinging IP address = " & IPAddress)
                If My.Computer.Network.Ping(IPAddress, 100) Then
                    logger.Warn("Response from IP address = " & IPAddress)
                    MessageBox.Show("The IP address " & IPAddress & " is already used." & vbNewLine & "Select different IP address and try again", "Warning",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    logger.Info(IPAddress & " already exists in network")
                    logger.Info("Exiting sub...")
                    ' IF IP IS USED THEN ABORT & EXIT SUB 
                    Exit Sub
                Else
                    logger.Warn("No response from IP address:  " & IPAddress)
                    logger.Info(IPAddress & " can be used.")
                End If

            Catch ex As Exception

                logger.Error("Error pinging IP address: " & IPAddress & " Error: " & ex.Message)
                Dim result As DialogResult = MessageBox.Show("Cannot ping IP address " & IPAddress & vbNewLine & ex.Message & vbNewLine & vbNewLine & "Continue changing IP address?", "Ping", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    logger.Info("User selected NO, exiting sub...")
                    Exit Sub
                ElseIf result = DialogResult.Yes Then
                    ' Continue changing IP
                    logger.Info("User selected YES, continue changing IP")
                End If

            End Try
        End If '// end if CheckForUsedIP

        ' IF IP IS NOT USED THEN CONTINUE 
        Try

            Dim classInstance As New ManagementObject(
                "root\CIMV2",
               "Win32_NetworkAdapterConfiguration.Index='" & DeviceID & "'",
                Nothing)

            ' Obtain [in] parameters for the method
            Dim inParamsIP As ManagementBaseObject =
                classInstance.GetMethodParameters("EnableStatic")

            Dim inParamsGate As ManagementBaseObject =
                 classInstance.GetMethodParameters("SetGateways")


            ' Add the IP and Subnet input parameters.
            inParamsIP("IPAddress") = New String() {IPAddress}
            inParamsIP("SubnetMask") = New String() {SubnetMask}

            ' Add Gateway input parameters.
            inParamsGate("DefaultIPGateway") = New String() {Gateway}
            inParamsGate("GatewayCostMetric") = New Integer() {1}

            ' Set IP and Subnet
            Dim outParamsIP As ManagementBaseObject =
                classInstance.InvokeMethod("EnableStatic", inParamsIP, Nothing)

            ' Set Gateway
            Dim outParamsGate As ManagementBaseObject =
                classInstance.InvokeMethod("SetGateways", inParamsGate, Nothing)

            ' CHECK IF IP ADDRESS IS USED                                           // v2.5.0.0 feature
            If My.Settings.VerifyIpAddress Then
                IPAddressGet = FC_getIPaddress()
                Select Case IPAddress
                    Case IPAddressGet
                        ' List outParams
                        lblStatus.Text = "IP change success."
                        MessageBox.Show("The IP address has been changed to " & IPAddress, "Success",
                 MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Case Else
                        ' List outParams
                        lblStatus.Text = "IP could not be changed."
                        MessageBox.Show("The IP address could not be changed to " & IPAddress, "Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select

            Else
                ' List outParams
                lblStatus.Text = "IP change success."
                MessageBox.Show("The IP address has been changed to " & IPAddress, "Success",
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If


        Catch err As ManagementException

            MessageBox.Show("An error occurred while trying to execute the IPChange method: " & err.Message)
            lblStatus.Text = "IP change error."
        End Try



    End Sub

    ' GET IP ADDRESS

    Private Sub BtnGetIP_Click(sender As System.Object, e As System.EventArgs) Handles BtnGetIP.Click
        logger.Info("Start")
        IPAddressGet = FC_getIPaddress()

        ' update v2.5.0.1 beta 2A , added Or "" 
        If IPAddressGet IsNot Nothing And IPAddressGet IsNot "" Then
            MessageBox.Show("IP Address: " & IPAddressGet) 'returned IPAddress is valid
        End If
        logger.Info("Finished")

    End Sub

    Public Function FC_getIPaddress() As String
        logger.Info("Start")
        lblStatus.Text = "Getting IP address..."

        Try
            logger.Info("Searching NetworkAdapterConfiguration for DEVICE ID: " & DeviceID)
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Index = " & DeviceID) ' declare which NETWORK INDEX = from combobox index


            For Each queryObj As ManagementObject In searcher.Get()
                logger.Info("Querying IP address for DEVICE ID: " & DeviceID)
                If queryObj("IPAddress") Is Nothing Then
                    'MessageBox.Show("IP Address: " & queryObj("IPAddress"))
                    logger.Info("IP Address not available for DEVICE ID: " & DeviceID)
                    lblStatus.Text = "IP Address not available."
                    MessageBox.Show("IP Address not available. Please establish connection.")
                Else
                    Dim arrIPAddress As String()
                    arrIPAddress = queryObj("IPAddress")
                    For Each arrValue As String In arrIPAddress
                        logger.Info("IP Address found: DEVICE ID: " & DeviceID & " IP Address: " & arrValue)
                        lblStatus.Text = "IP Address found."
                        Return (arrValue)
                        'MessageBox.Show("IP Address: " & arrValue)
                        'Console.WriteLine("IPAddress: {0}", arrValue)
                        If My.Settings.CheckForIPv6 Then
                            '// continue
                        Else
                            '// 1st array should be IPv4 when displayed exit the for loop
                            Exit For
                        End If
                    Next
                End If
            Next
        Catch err As ManagementException
            logger.Error("An error occurred while querying for IPAddress data on DEVICE ID: " & DeviceID & " Error: " & err.Message)
            lblStatus.Text = "Error getting IP address"
            MessageBox.Show("An error occurred while querying for IPAddress data: " & err.Message)
            Return ("")
        End Try
        'lblStatus.Text = "Ready"
        logger.Info("Finished")
        Return ("")
    End Function




    Private Sub BtnDHCP_Click(sender As System.Object, e As System.EventArgs) Handles BtnDHCP.Click
        logger.Info("Start")
        lblStatus.Text = "Changing to DHCP..."
        Try
            logger.Info("Select Win32_NetworkAdapterConfiguration.Index by device id: " & DeviceID)
            Dim classInstance As New ManagementObject(
                "root\CIMV2",
                "Win32_NetworkAdapterConfiguration.Index='" & DeviceID & "'",
                Nothing)

            ' no method [in] parameters to define

            logger.Info("Execute method EnableDHCP")
            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject =
                classInstance.InvokeMethod("EnableDHCP", Nothing, Nothing)
            logger.Info("Success! Method EnableDHCP executed")
            ' List outParams
            lblStatus.Text = "DHCP change success."
            MessageBox.Show("DHCP Enabled", "Notification",
      MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException
            logger.Error("An error occurred while trying to execute the EnableDHCP method: " & err.Message)
            lblStatus.Text = "DHCP change error."
            MessageBox.Show("An error occurred while trying to execute the EnableDHCP method: " & err.Message)

        End Try

        logger.Info("Finished")
    End Sub

    Private Sub BtnNetDisable_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetDisable.Click
        logger.Info("Disabling network adapter...")
        lblStatus.Text = "Disabling network adapter..."
        Try
            logger.Info("Selecting device id: " & DeviceID)
            Dim classInstance As New ManagementObject(
                "root\CIMV2",
                "Win32_NetworkAdapter.DeviceID='" & DeviceID & "'",
                Nothing)

            ' no method [in] parameters to define

            logger.Info("Execute method: Disable network device")
            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject =
                classInstance.InvokeMethod("Disable", Nothing, Nothing)
            logger.Info("Execute method success.")
            ' List outParams
            ' MessageBox.Show("Network Disabled", "Notification",
            'MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException
            logger.Error("An error occurred while trying to execute the NetworkDisable method: " & err.Message)
            MessageBox.Show("An error occurred while trying to execute the NetworkDisable method: " & err.Message)
        End Try
        logger.Info("Finished")
        lblStatus.Text = "Ready"
    End Sub

    Private Sub BtnNetEnable_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetEnable.Click

        logger.Info("Enabling network adapter...")
        lblStatus.Text = "Enabling network adapter..."
        Try
            logger.Info("Selecting device id: " & DeviceID)
            Dim classInstance As New ManagementObject(
                "root\CIMV2",
                "Win32_NetworkAdapter.DeviceID='" & DeviceID & "'",
                Nothing)

            ' no method [in] parameters to define

            logger.Info("Execute method: Enable network device")
            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject =
                classInstance.InvokeMethod("Enable", Nothing, Nothing)
            logger.Info("Execute method success.")
            ' List outParams
            ' MessageBox.Show("Network Enabled", "Notification",
            'MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException
            logger.Error("An error occurred while trying to execute the NetworkEnable method: " & err.Message)
            MessageBox.Show("An error occurred while trying to execute the NetworkEnable method: " & err.Message)
        End Try
        logger.Info("Finished")
        lblStatus.Text = "Ready"
    End Sub



    Private Sub BtnGetMAC_Click(sender As System.Object, e As System.EventArgs) Handles BtnGetMAC.Click
        logger.Info("Started")
        lblStatus.Text = "Getting MAC address..."
        Try
            logger.Info("Searching query Win32_NetworkAdapterConfiguration Index for device id: " & DeviceID)
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Index = " & DeviceID) ' declare which NETWORK INDEX = from combobox index
            logger.Info("Search found.")

            logger.Info("Get MACAddress object...")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim Result As String
                Result = (queryObj("MACAddress")) ' Result is MAC address of selected Index
                logger.Info("Success! MAC Address: " & Result)
                lblStatus.Text = "MAC Address found."
                MessageBox.Show("MAC Address: " & Result)

            Next
        Catch err As ManagementException
            logger.Error("An error occurred while querying for MAC Address data: " & err.Message)
            lblStatus.Text = "Mac address error."
            MessageBox.Show("An error occurred while querying for MAC Address data: " & err.Message)
        End Try

        logger.Info("Finished")
    End Sub


    Private Sub BtnOpenNetworkConnections_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpenNetworkConnections.Click
        Try
            logger.Info("Executing win shell to access control panel network connections...")
            Shell("C:\Windows\System32\control.exe" & " ncpa.cpl", 1)
            logger.Info("Shell executed.")
        Catch ex As Exception
            logger.Error("Shell execute error: " & ex.Message)
        End Try



    End Sub

    Private Sub BtnOpen_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpen.Click
        Try
            logger.Info("OpenFileDialog started")

            ' Open dialog browse
            Dim fd As OpenFileDialog = New OpenFileDialog()

            fd.Title = "Open File"
            fd.InitialDirectory = Application.StartupPath
            'fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fd.Filter = "Profile Files (*.ini)|*.ini" ' Search only for .ini files
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
                logger.Info("OpenFileDialog Result OK")
                ComboBox1.Items.Clear() '// clear items list if user selects new file, pressed OK ver 2.5.0.0 fix
                logger.Info("Profile name list cleared")
                FilePath = fd.FileName
                logger.Info("File name selected at location: " & FilePath)

                ' execute command
                If LoadProfileFile(FilePath) Then   '// call function load profile file update v2.5.0.0
                    ExtractProfilesFromFile(FilePath)
                End If


            Else
                logger.Info("OpenFileDialog Result CANCEL")
                Form2.CB_AutoLoadCfg.Enabled = False
            End If


        Catch ex As Exception
            logger.Error("Shell execute error: " & ex.Message)
        End Try
        logger.Info("OpenFileDialog finished")
    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click

        Try
            ' // updated in v2.5.0.1
            logger.Debug("ExternalEditor started")
            ExternalEditor = My.Settings.ExternalEditor
            FilePath = My.Settings.ProfilesFilePath
            logger.Debug("Editor: " & ExternalEditor & " File: " & FilePath)
            System.Diagnostics.Process.Start(ExternalEditor, """" & FilePath & """")

        Catch ex As Exception
            logger.Error("ExternalEditor error: " & ex.Message)
            MessageBox.Show("Error opening profile file. Please check external editor and config location." & vbLf & vbLf & ex.Message, "Error",
MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
        logger.Debug("ExternalEditor finished")

    End Sub

    '// Update v2.5.0.0
    '// Function update to pass string of profile file location

    Public Function LoadProfileFile(ByVal filename As String) As Boolean
        logger.Info("Loading profile file ...")
        lblStatus.Text = "Loading profile file ..."
        ' execute command
        'Dim filename As String = My.Settings.ConfigFilePath
        Dim ValidFile As String = ""
        Dim FileVersion As String = ""
        Dim ReadProfileLine As String = ""
        Dim ProfileName As String = ""
        Dim IPLine As String = ""
        Dim SubnetLine As String = ""
        Dim GatewayLine As String = ""
        Dim Count As Integer = 4
        Dim Number As Integer = 0
        Try

            'Load File and check 1st line to validate MDRIVE file
            logger.Debug("Reading 1st line of the file...")
            logger.Debug("Validating file...")
            ValidFile = (ReadALine(filename, GetNumberOfLines(filename), 1))
            If ValidFile = "Name=IPChangerConfig" Or ValidFile = "Name=IPChangerProfiles" Then '// both names are left as valid for compatibility
                logger.Info("File Valid")
                Return True
            Else
                MessageBox.Show("Profile file is either not valid or corrupted.", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception
            logger.Error("Error reading profile file on line " & Count & " Error: " & ex.Message)
            MessageBox.Show("Profile file is either not valid or corrupted.", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End Try

        Return False
        logger.Info("Finished")
    End Function

    Public Function ExtractProfilesFromFile(ByVal filename As String) As Boolean
        logger.Info("Extracting profiles  ...")
        lblStatus.Text = "Extracting profiles  ..."
        ' execute command
        'Dim filename As String = My.Settings.ConfigFilePath
        Dim ValidFile As String = ""
        Dim FileVersion As String = ""
        Dim ReadProfileLine As String = ""
        Dim ProfileName As String = ""
        Dim IPLine As String = ""
        Dim SubnetLine As String = ""
        Dim GatewayLine As String = ""
        Dim Count As Integer = 4
        Dim Number As Integer = 0
        Try

            'Load File and check 1st line to validate MDRIVE file

            logger.Debug("Reading 2nd line of the file...")
            FileVersion = (ReadALine(filename, GetNumberOfLines(filename), 2))
            logger.Debug("File Version is: " & FileVersion)
            logger.Debug("Start extracting data from the file")
            Do While Count <= NumberOfLinesProfile
                logger.Debug("Reading line " & Count & " of " & NumberOfLinesProfile)
                ReadProfileLine = (ReadALine(filename, GetNumberOfLines(filename), Count))

                If ReadProfileLine.Contains("[") Then
                    Dim ProfileNameArr1() As String = ReadProfileLine.Split("[")
                    Dim ProfileNameArr2() = ProfileNameArr1(1).Split("]")
                    ProfileName = ProfileNameArr2(0)
                    ComboBox1.Items.Add(ProfileName)
                    Number += 1
                    logger.Debug("Found profile name: " & ProfileName & " Index: " & Number) ' mora biti tu zaradi loga pravega index-a
                    'ProfileNameFull(Number) = ProfileName
                End If

                If ReadProfileLine.Contains("IP") Then
                    Dim IPLineArr1() As String = ReadProfileLine.Split("=")
                    IPLine = IPLineArr1(1)

                    IPAddress(Number) = IPLine
                    logger.Debug("Found IP string on line" & " - " & Count & " - " & "Value: " & IPLine)
                End If

                If ReadProfileLine.Contains("SUBNET") Then

                    Dim SubnetLineArr1() As String = ReadProfileLine.Split("=")
                    SubnetLine = SubnetLineArr1(1)

                    Subnet(Number) = SubnetLine
                    logger.Debug("Found SUBNET string on line" & " - " & Count & " - " & "Value: " & SubnetLine)
                End If

                If ReadProfileLine.Contains("GATEWAY") Then

                    Dim GatewayLineArr1() As String = ReadProfileLine.Split("=")
                    GatewayLine = GatewayLineArr1(1)

                    Gateway(Number) = GatewayLine
                    logger.Debug("Found GATEWAY string on line" & " - " & Count & " - " & "Value: " & GatewayLine)
                End If

                Count += 1
            Loop
            lblStatus.Text = "Ready. profile file loaded : " & FileVersion
            logger.Info("Saving filepath to My.Settings.ProfilesFilePath")
            My.Settings.ProfilesFilePath = FilePath
            MessageBox.Show(" File loaded successfully.", "Open File",
          MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' If file is loaded successfully then enable auto load file checkbox, else disable
            Form2.CB_AutoLoadCfg.Enabled = True
            Return True

        Catch ex As Exception
            logger.Error("Error reading profile file on line " & Count)
            MessageBox.Show("Error reading profile file " & vbLf & vbLf & "Line: " & Count & vbLf & "Profile:" & ProfileName & vbLf & vbLf & "Manually open profile file and check if data format is correct.", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End Try

        Return True
        logger.Info("Finished")
    End Function
    Public Sub FC_AutoLoadLastNicUsed() '//FUNCTION CHANGE BUTTON STATE
        logger.Info("Selecting last used NIC for combobox = " & My.Settings.LastNetworkAdapterUsed)
        CB_NIC.SelectedItem = My.Settings.LastNetworkAdapterUsed
        logger.Info("Success")
    End Sub


    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        logger.Info("Start")
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Show()
        logger.Info("Finished")


    End Sub

    Private Sub TB_IPaddress_TextChanged(sender As Object, e As EventArgs) Handles TB_IPaddress.TextChanged
        logger.Info("Start")
        If TB_IPaddress.Text IsNot Nothing Then

            Select Case FC_TB_Entry_Valid(TB_IPaddress.Text)
                Case True

                Case False
                    logger.Warn("Data entry for IP address is invalid " & TB_IPaddress.Text)
                    MessageBox.Show(" Data entry for IP address is invalid" & vbLf & TB_IPaddress.Text, "Warning",
MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TB_IPaddress.Text = ""
                Case Else
                    logger.Error("Data entry for IP address is invalid " & TB_IPaddress.Text)
                    MessageBox.Show(" Data entry for IP address is invalid", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TB_IPaddress.Text = ""


            End Select
        End If
        logger.Info("Finished")
    End Sub

    Private Sub TB_Subnet_TextChanged(sender As Object, e As EventArgs) Handles TB_Subnet.TextChanged
        logger.Info("Start")
        ' subnet is usually same address so textchange does not occur.
        If TB_Subnet.Text IsNot Nothing Then

            Select Case FC_TB_Entry_Valid(TB_Subnet.Text)
                Case True

                Case False
                    MessageBox.Show(" Data entry for Subnet is invalid" & vbLf & TB_Subnet.Text, "Warning",
MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TB_Subnet.Text = ""
                Case Else
                    MessageBox.Show(" Data entry for Subnet is invalid", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TB_Subnet.Text = ""

            End Select
        End If
        logger.Info("Finished")
    End Sub

    Private Sub TB_Gateway_TextChanged(sender As Object, e As EventArgs) Handles TB_Gateway.TextChanged
        logger.Info("Start")
        If TB_Gateway.Text IsNot Nothing Then

            Select Case FC_TB_Entry_Valid(TB_Gateway.Text)
                Case True

                Case False
                    MessageBox.Show(" Data entry for Gateway is invalid" & vbLf & TB_Gateway.Text, "Warning",
MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TB_Gateway.Text = ""
                Case Else
                    MessageBox.Show(" Data entry for Gateway is invalid", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TB_Gateway.Text = ""

            End Select
        End If
        logger.Info("Finished")
    End Sub

    Public Function FC_TB_Entry_Valid(ByVal TB As String) As Boolean
        logger.Debug("Checking data valid entry: " & TB)

        '// split textbox.text to characters
        Dim chars() As Char = TB

        '// check each character
        For Each c As Char In chars

            '// is char number or . which matches the data entry?
            If Not IsNumeric(c) And Not c = "." Then

                logger.Warn("Data invalid: " & TB)
                Return False     'data is not valid
                Exit For

            End If

        Next            ' next char loop

        Return True     'data is not valid
        logger.Debug("Data is valid: " & TB)

    End Function

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        logger.Info("Form closed.")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
        logger.Info("Saving settings done")
        logger.Info("Application shutdown")
    End Sub

    Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles BtnLogs.Click
        Dim EditFileApp As String = "notepad.exe"
        Dim rootDir As String = System.Windows.Forms.Application.StartupPath
        LogPath = rootDir & "/Logs"

        'System.Diagnostics.Process.Start(EditFileApp, LogPath)
        Process.Start(LogPath)
    End Sub


    Public Sub errCatchTest() '// use only for testing
        ' THIS SUB WILL CAUSE EXCEPTION
        Dim i As Integer = 1
        i /= 0
    End Sub

End Class
