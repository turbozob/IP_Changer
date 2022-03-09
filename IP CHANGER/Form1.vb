Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Threading
Imports System.Threading.Thread
Imports System.EventArgs

Public Class Form1
    Public Shared NetCard As String
    Public Shared DeviceID As String
    Public Shared FilePath As String
    Public Shared TimeFull As DateTime = DateTime.Now
    Public Shared NumberOfLinesConfig As Integer
    Public Shared SetupNameFull(100) As String
    Public Shared IPAddress(100) As String
    Public Shared Subnet(100) As String
    Public Shared Gateway(100) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When application is started put default values in textbox and select saved MAC address
        BtnNetScan.PerformClick() ' FIRST PERFORM NETWORK SCAN

        If CheckBox2.Checked Then
            FunctionAutoLoadLastNicUsed(1)
        End If

        If CheckBox1.Checked Then

            If My.Computer.FileSystem.FileExists(My.Settings.ConfigFilePath) Then
                FunctionAutoLoadConfigFile(1)
            Else
                MessageBox.Show("Config File Not Found. Auto Load File is Disabled.", "Open Config File At Startup",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                CheckBox1.Checked = False
            End If

        Else
            TextBox1.Text = "192.168.1.123"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.1.1"
        End If
        

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
        NumberOfLinesConfig = NumberOfLines
        Return NumberOfLines

    End Function

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SelectSetupNo As Integer
        SelectSetupNo = ComboBox1.SelectedIndex + 1

        TextBox1.Text = IPAddress(SelectSetupNo)
        TextBox2.Text = Subnet(SelectSetupNo)
        TextBox3.Text = Gateway(SelectSetupNo)
    End Sub


    'TEXTBOX SETUP: ENTER NUMBERS ONLY
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        'e.Handled = True
        'End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    
    ' About Window  
    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnABOUT.Click
        'About
        AboutBox1.Show()
    End Sub


    

    Private Sub BtnNetScan_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetScan.Click
        ComboBox3.Items.Clear()

        Dim Result As String
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapter WHERE Manufacturer <> 'Microsoft'")

            For Each queryObj As ManagementObject In searcher.Get()

                Result = (queryObj("Caption")) ' Result is the name of network card
                'Dim CB_Split1() As String = Result.Split("]") ' Split string Result based on char "]"
                'Dim CB_Split2() As String = CB_Split1(0).Split("00000")
                'ComboBox3.Items.Add(CB_Split1(1)) ' Add splitted string to combobox
                ComboBox3.Items.Add(queryObj("Caption"))

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try

    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged



        NetCard = ComboBox3.Text

        Dim NetCard_Split1() As String = NetCard.Split("]") ' Split string Result based on char "]"

        LBLNetCard.Text = NetCard_Split1(1)

        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Caption ='" & NetCard & "'") ' declare which NETWORK INDEX = from combobox index


            For Each queryObj As ManagementObject In searcher.Get()

                DeviceID = (queryObj("Index"))

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try

        LBLDeviceID.Text = DeviceID

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        ComboBox3.Items.Clear()

        Try
            Dim searcher As New ManagementObjectSearcher( _
                 "root\CIMV2", _
                    "SELECT * FROM Win32_NetworkAdapter WHERE Manufacturer <> 'Microsoft'")


            For Each queryObj As ManagementObject In searcher.Get()


                Dim DeviceID As String
                DeviceID = queryObj("DeviceID")
                Dim ProductName As String
                ProductName = queryObj("ProductName")
                ComboBox3.Items.Add(DeviceID & ProductName)

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try


    End Sub ' Not used: Scan only MicroSoft Network Devices (Ethernet only, not Bluetooth etc...)

    ' CHANGE IP, SUBNET AND GATEWAY
    Private Sub BtnChangeIP_Click(sender As System.Object, e As System.EventArgs) Handles BtnChangeIP.Click
        Dim IPAddress As String = TextBox1.Text
        Dim SubnetMask As String = TextBox2.Text
        Dim Gateway As String = TextBox3.Text

        Try

            Dim classInstance As New ManagementObject( _
                "root\CIMV2", _
               "Win32_NetworkAdapterConfiguration.Index='" & DeviceId & "'", _
                Nothing)

            ' Obtain [in] parameters for the method
            Dim inParamsIP As ManagementBaseObject = _
                classInstance.GetMethodParameters("EnableStatic")

            Dim inParamsGate As ManagementBaseObject = _
                 classInstance.GetMethodParameters("SetGateways")


            ' Add the IP and Subnet input parameters.
            inParamsIP("IPAddress") = New String() {IPAddress}
            inParamsIP("SubnetMask") = New String() {SubnetMask}

            ' Add Gateway input parameters.
            inParamsGate("DefaultIPGateway") = New String() {Gateway}
            inParamsGate("GatewayCostMetric") = New Integer() {1}

            ' Set IP and Subnet
            Dim outParamsIP As ManagementBaseObject = _
                classInstance.InvokeMethod("EnableStatic", inParamsIP, Nothing)

            ' Set Gateway
            Dim outParamsGate As ManagementBaseObject = _
                classInstance.InvokeMethod("SetGateways", inParamsGate, Nothing)


            ' List outParams
            MessageBox.Show("The IP address has been changed", "Notification",
     MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException

            MessageBox.Show("An error occurred while trying to execute the WMI method: " & err.Message)
        End Try
    End Sub

    ' GET IP ADDRESS
    Private Sub BtnGetIP_Click(sender As System.Object, e As System.EventArgs) Handles BtnGetIP.Click
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Index = " & DeviceID) ' declare which NETWORK INDEX = from combobox index


            For Each queryObj As ManagementObject In searcher.Get()

                If queryObj("IPAddress") Is Nothing Then                    
                    'MessageBox.Show("IP Address: " & queryObj("IPAddress"))
                    MessageBox.Show("IP Address not available. Please establish connection.")
                Else
                    Dim arrIPAddress As String()
                    arrIPAddress = queryObj("IPAddress")
                    For Each arrValue As String In arrIPAddress
                        MessageBox.Show("IP Address: " & arrValue)
                        'Console.WriteLine("IPAddress: {0}", arrValue)
                    Next
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Sub

    Private Sub BtnDHCP_Click(sender As System.Object, e As System.EventArgs) Handles BtnDHCP.Click

        Try

            Dim classInstance As New ManagementObject( _
                "root\CIMV2", _
                "Win32_NetworkAdapterConfiguration.Index='" & DeviceID & "'", _
                Nothing)

            ' no method [in] parameters to define


            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject = _
                classInstance.InvokeMethod("EnableDHCP", Nothing, Nothing)

            ' List outParams
            MessageBox.Show("DHCP Enabled", "Notification",
      MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException

            MessageBox.Show("An error occurred while trying to execute the WMI method: " & err.Message)
        End Try
    End Sub

    Private Sub BtnNetDisable_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetDisable.Click
        Try

            Dim classInstance As New ManagementObject( _
                "root\CIMV2", _
                "Win32_NetworkAdapter.DeviceID='" & DeviceID & "'", _
                Nothing)

            ' no method [in] parameters to define


            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject = _
                classInstance.InvokeMethod("Disable", Nothing, Nothing)

            ' List outParams
            ' MessageBox.Show("Network Disabled", "Notification",
            'MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException

            MessageBox.Show("An error occurred while trying to execute the WMI method: " & err.Message)
        End Try

    End Sub

    Private Sub BtnNetEnable_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetEnable.Click
        Try

            Dim classInstance As New ManagementObject( _
                "root\CIMV2", _
                "Win32_NetworkAdapter.DeviceID='" & DeviceID & "'", _
                Nothing)

            ' no method [in] parameters to define


            ' Execute the method and obtain the return values.
            Dim outParams As ManagementBaseObject = _
                classInstance.InvokeMethod("Enable", Nothing, Nothing)

            ' List outParams
            ' MessageBox.Show("Network Enabled", "Notification",
            'MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch err As ManagementException

            MessageBox.Show("An error occurred while trying to execute the WMI method: " & err.Message)
        End Try
    End Sub

 

    Private Sub BtnGetMAC_Click(sender As System.Object, e As System.EventArgs) Handles BtnGetMAC.Click
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Index = " & DeviceID) ' declare which NETWORK INDEX = from combobox index


            For Each queryObj As ManagementObject In searcher.Get()
                Dim Result As String
                Result = (queryObj("MACAddress")) ' Result is MAC address of selected Index
                MessageBox.Show("MAC Address: " & Result)

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Sub

   
    Private Sub BtnOpenNetworkConnections_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpenNetworkConnections.Click
        Shell("C:\Windows\System32\control.exe" & " ncpa.cpl", 1)
    End Sub

    Private Sub BtnOpen_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpen.Click

        ComboBox1.Items.Clear()

        ' Open dialog browse
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File"
        fd.InitialDirectory = Application.StartupPath
        'fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.Filter = "Config Files (*.ini)|*.ini" ' Search only for .ini files
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FilePath = fd.FileName
            CheckBox1.Checked = False
        
        ' execute command
        Dim filename As String = FilePath
        Dim ValidFile As String
        Dim ReadConfigLine As String
        Dim SetupName As String
        Dim IPLine As String
        Dim SubnetLine As String
        Dim GatewayLine As String
        Dim Count As Integer = 4
        Dim Number As Integer = 0

        'Load File and check 1st line to validate MDRIVE file

        ValidFile = (ReadALine(filename, GetNumberOfLines(filename), 1))
        If ValidFile = "Name=IPChangerConfig" Then
            Do While Count <= NumberOfLinesConfig
                ReadConfigLine = (ReadALine(filename, GetNumberOfLines(filename), Count))

                If ReadConfigLine.Contains("[") Then
                    Dim SetupNameArr1() As String = ReadConfigLine.Split("[")
                    Dim SetupNameArr2() = SetupNameArr1(1).Split("]")
                    SetupName = SetupNameArr2(0)
                    ComboBox1.Items.Add(SetupName)
                    Number += 1
                    'SetupNameFull(Number) = SetupName
                End If

                If ReadConfigLine.Contains("IP") Then
                    Dim IPLineArr1() As String = ReadConfigLine.Split("=")
                    IPLine = IPLineArr1(1)

                    IPAddress(Number) = IPLine
                End If

                If ReadConfigLine.Contains("SUBNET") Then
                    Dim SubnetLineArr1() As String = ReadConfigLine.Split("=")
                    SubnetLine = SubnetLineArr1(1)

                    Subnet(Number) = SubnetLine
                End If

                If ReadConfigLine.Contains("GATEWAY") Then
                    Dim GatewayLineArr1() As String = ReadConfigLine.Split("=")
                    GatewayLine = GatewayLineArr1(1)

                    Gateway(Number) = GatewayLine
                End If

                Count += 1
                Loop
            Else
                MessageBox.Show(" Config File is either not valid or corrupted.", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            MessageBox.Show(" File loaded successfully.", "Open File",
      MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If

    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        Dim EditFileApp As String = "notepad.exe"
        System.Diagnostics.Process.Start(EditFileApp, FilePath)
    End Sub

  

    Public Sub FunctionAutoLoadConfigFile(ByVal AutoLoad As String) '//FUNCTION CHANGE BUTTON STATE
        ' execute command
        Dim filename As String = My.Settings.ConfigFilePath
        Dim ValidFile As String
        Dim ReadConfigLine As String
        Dim SetupName As String
        Dim IPLine As String
        Dim SubnetLine As String
        Dim GatewayLine As String
        Dim Count As Integer = 4
        Dim Number As Integer = 0

        'Load File and check 1st line to validate MDRIVE file

        ValidFile = (ReadALine(filename, GetNumberOfLines(filename), 1))
        If ValidFile = "Name=IPChangerConfig" Then
            Do While Count <= NumberOfLinesConfig
                ReadConfigLine = (ReadALine(filename, GetNumberOfLines(filename), Count))

                If ReadConfigLine.Contains("[") Then
                    Dim SetupNameArr1() As String = ReadConfigLine.Split("[")
                    Dim SetupNameArr2() = SetupNameArr1(1).Split("]")
                    SetupName = SetupNameArr2(0)
                    ComboBox1.Items.Add(SetupName)
                    Number += 1
                    'SetupNameFull(Number) = SetupName
                End If

                If ReadConfigLine.Contains("IP") Then
                    Dim IPLineArr1() As String = ReadConfigLine.Split("=")
                    IPLine = IPLineArr1(1)

                    IPAddress(Number) = IPLine
                End If

                If ReadConfigLine.Contains("SUBNET") Then
                    Dim SubnetLineArr1() As String = ReadConfigLine.Split("=")
                    SubnetLine = SubnetLineArr1(1)

                    Subnet(Number) = SubnetLine
                End If

                If ReadConfigLine.Contains("GATEWAY") Then
                    Dim GatewayLineArr1() As String = ReadConfigLine.Split("=")
                    GatewayLine = GatewayLineArr1(1)

                    Gateway(Number) = GatewayLine
                End If

                Count += 1
            Loop
 
        Else
            MessageBox.Show(" Config File is either not valid or corrupted.", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub
    Public Sub FunctionAutoLoadLastNicUsed(ByVal AutoLoadNIC As String) '//FUNCTION CHANGE BUTTON STATE
        ComboBox3.SelectedItem = My.Settings.LastNICUsed
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            My.Settings.ConfigFilePath = FilePath
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            My.Settings.LastNICUsed = ComboBox3.SelectedItem
            My.Settings.Save()
        End If
    End Sub

   
End Class
