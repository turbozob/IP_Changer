Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation

Public Class Form1
    Public Shared MACAddress As String = My.Settings.Setting_String_1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "192.168.1.123"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
        Label4.Text = MACAddress
        ComboBox2.Items.Add(MACAddress)
        Me.ComboBox2.SelectedIndex = 0
    End Sub

    'SET STATIC IP BUTTON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim IPAddress As String = TextBox1.Text
        Dim SubnetMask As String = TextBox2.Text
        Dim Gateway As String = TextBox3.Text

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()


        If MACAddress <> "" Then

            If CheckBoxDHCP.Checked Then

                For Each objMO As ManagementObject In objMOC
                    If objMO("MACAddress") = MACAddress Then


                        Try

                            Dim objNewIP As ManagementBaseObject = Nothing
                            Dim objSetIP As ManagementBaseObject = Nothing
                            Dim objNewGate As ManagementBaseObject = Nothing
                            Dim objRlsDHCPLes As ManagementBaseObject = Nothing
                            Dim objNewDHCPLes As ManagementBaseObject = Nothing


                            objSetIP = objMO.InvokeMethod("EnableDHCP", objNewIP, Nothing)

                            'objRlsDHCPLes = objMO.InvokeMethod("ReleaseDHCPLease", objRlsDHCPLes, Nothing)
                            'objNewDHCPLes = objMO.InvokeMethod("RenewDHCPLease", objNewDHCPLes, Nothing)
                            'MessageBox.Show("DHCP IS SET!")
                            MessageBox.Show("The IP address is set as DHCP", "Notification",
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


                        Catch ex As Exception
                            'MessageBox.Show("Unable to Set IP : " & ex.Message)
                            MessageBox.Show("Unable to Set DHCP", "Error",
        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        End Try
                    Else
                        Continue For
                    End If
                Next objMO


            Else

                For Each objMO As ManagementObject In objMOC
                    If objMO("MACAddress") = MACAddress Then


                        Try

                            Dim objNewIP As ManagementBaseObject = Nothing
                            Dim objSetIP As ManagementBaseObject = Nothing
                            Dim objNewGate As ManagementBaseObject = Nothing


                            objNewIP = objMO.GetMethodParameters("EnableStatic")
                            objNewGate = objMO.GetMethodParameters("SetGateways")

                            'Set DefaultGateway
                            objNewGate("DefaultIPGateway") = New String() {Gateway}
                            objNewGate("GatewayCostMetric") = New Integer() {1}

                            'Set IPAddress and Subnet Mask
                            objNewIP("IPAddress") = New String() {IPAddress}
                            objNewIP("SubnetMask") = New String() {SubnetMask}

                            objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                            objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)

                            MessageBox.Show("The IP address has been changed", "Notification",
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            'MessageBox.Show("Done!")

                        Catch ex As Exception
                            MessageBox.Show("Unable to Set IP : " & ex.Message)
                        End Try
                        Continue For
                    End If
                Next objMO
            End If
        End If




    End Sub


 


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapter WHERE AdapterType = 'Ethernet 802.3'")

            For Each queryObj As ManagementObject In searcher.Get()

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try

    End Sub


  

    Private Sub Button4SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4SAVE.Click

        My.Settings.Setting_String_1 = ComboBox2.Text
        My.Settings.Save()
        MACAddress = My.Settings.Setting_String_1
        Label4.Text = MACAddress
        MessageBox.Show("MACAddress Saved: " & MACAddress, "SAVE",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

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

    Private Sub CheckBoxDHCP_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDHCP.CheckedChanged
        If CheckBoxDHCP.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            ComboBox1.Enabled = False


        End If

        If CheckBoxDHCP.Checked = False Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True


        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim nic As NetworkInterface = Nothing
            Dim mac_Address As String = ""
            Dim mac_Address1 As String = ""

            For Each nic In NetworkInterface.GetAllNetworkInterfaces

                mac_Address = nic.GetPhysicalAddress().ToString
                If mac_Address <> "" Then
                    ComboBox2.Items.Add(mac_Address)
                    'Label7.Text = mac_Address
                    'mac_Address = mac_Address.Replace(":", "")
                    'Label8.Text = mac_Address
                End If
                ' For Each COMString As String In My.Computer.Ports.SerialPortNames ' Load all available COM ports.
                'COMPortsBox.Items.Add(COMString)
                'Next
                'COMPortsBox.Sorted = True


            Next
            ComboBox2.Sorted = True
            nic = Nothing


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""

        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("MACAddress") <> "" Then
                    ComboBox2.Items.Add(queryObj("MACAddress"))
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        MACAddress = ""
        MACAddress = ComboBox2.Text
        Label4.Text = MACAddress
    End Sub
    'RETRIEVE IP ADDRESS BUTTON
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        Try

            strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(ComboBox2.SelectedIndex).ToString()
            MessageBox.Show("IP Address: " & strIPAddress)
        Catch ex As Exception
            MessageBox.Show("Please select Network Device first! : " & ex.Message)
        End Try


    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")

            For Each queryObj As ManagementObject In searcher.Get()

                If queryObj("MACAddress") = MACAddress Then
                    'Console.WriteLine("IPAddress: {0}", queryObj("IPAddress"))
                    'MessageBox.Show("IP Address: Empty")

                    Dim arrIPAddress As String()
                    arrIPAddress = queryObj("IPAddress")
                    For Each arrValue As String In arrIPAddress
                        'Console.WriteLine("IPAddress: {0}", arrValue)
                        MessageBox.Show("IP Address: " & arrValue)
                    Next

                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
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

    
End Class
