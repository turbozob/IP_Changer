Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation

Public Class Form1
    Public Shared NetCard As String
    Public Shared DeviceID As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When application is started put default values in textbox and select saved MAC address
        TextBox1.Text = "192.168.1.123"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
        BtnNetScan.PerformClick()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Select values for desired machine from dropdown list

        If ComboBox1.Text = "SMM TRANSPORTI" Then
            TextBox1.Text = "192.168.1.123"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.1.1"
        ElseIf ComboBox1.Text = "BALANCE" Then
            TextBox1.Text = "192.168.0.10"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.0.1"
        ElseIf ComboBox1.Text = "ASTEC" Then
            TextBox1.Text = "192.168.0.10"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.0.1"
        ElseIf ComboBox1.Text = "TOVORNI TRAK 1 IN 2" Then
            TextBox1.Text = "10.1.10.101"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "10.1.10.1"
        ElseIf ComboBox1.Text = "POLTOV. OBREZOVALNI STROJ" Then
            TextBox1.Text = "192.168.0.200"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.0.1"
        ElseIf ComboBox1.Text = "KOKUSAI 1" Then
            TextBox1.Text = "10.1.10.220"
            TextBox2.Text = "255.0.0.0"
            TextBox3.Text = "10.1.10.1"
        ElseIf ComboBox1.Text = "KOKUSAI 2" Then
            TextBox1.Text = "172.27.156.100"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "172.27.156.1"
        ElseIf ComboBox1.Text = "YXLON 1" Then
            TextBox1.Text = "192.168.6.200"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.6.1"
        ElseIf ComboBox1.Text = "YXLON 2" Then
            TextBox1.Text = "10.1.10.250"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "10.1.10.1"
        ElseIf ComboBox1.Text = "VEZNI TRANSPORTER" Then
            TextBox1.Text = "192.168.223.140"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.223.1"
        ElseIf ComboBox1.Text = "AVS 1 IN 2" Then
            TextBox1.Text = "192.168.1.10"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.1.1"
        ElseIf ComboBox1.Text = "4JET LASER ENGRAVER" Then
            TextBox1.Text = "192.168.1.101"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "192.168.1.1"
        ElseIf ComboBox1.Text = "PH BRUSILNI STROJ" Then
            TextBox1.Text = "10.10.0.250"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "10.10.0.1"
        ElseIf ComboBox1.Text = "MATTEUZZI" Then
            TextBox1.Text = "10.0.0.250"
            TextBox2.Text = "255.255.255.0"
            TextBox3.Text = "10.0.0.1"
        End If
    End Sub


    'TEXTBOX SETUP: ENTER NUMBERS ONLY
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
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
End Class
