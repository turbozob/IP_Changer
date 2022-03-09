Imports System
Imports System.Management
Imports System.Net
Imports System.Windows.Forms
Imports System.Net.NetworkInformation

Public Class Form1
    Public Shared MACAddress As String = My.Settings.Setting_String_1 'Create Public String, can be used anywhere

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When application is started put default values in textbox and select saved MAC address
        TextBox1.Text = "192.168.1.123"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
        ComboBox2.Items.Add(MACAddress)
        Me.ComboBox2.SelectedIndex = 0
    End Sub


    Private Sub BtnCHGIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCHGIP.Click
        'SET STATIC IP BUTTON
        Dim IPAddress As String = TextBox1.Text
        Dim SubnetMask As String = TextBox2.Text
        Dim Gateway As String = TextBox3.Text

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()


        If MACAddress <> "" Then 'If desired MAC Address is not equal to nothing then do something else exit

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



    Private Sub BtnSAVEMAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSAVEMAC.Click
        ' Save settings for MAC Address
        My.Settings.Setting_String_1 = ComboBox2.Text
        My.Settings.Save()
        MACAddress = My.Settings.Setting_String_1
        MessageBox.Show("MACAddress is saved and will be used as default.." & vbCrLf & MACAddress, "SAVE",
    MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub CheckBoxDHCP_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDHCP.CheckedChanged
        If CheckBoxDHCP.Checked = True Then ' Disable/Enable functions if DHCP is checked
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


    Private Sub BtnSCANMAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSCANMAC.Click
        ' SCAN MAC NETWORKS ADDRESS AND ADD THEM TO DROPDOWN LIST

        ComboBox2.Items.Clear()
        ComboBox2.Text = ""

        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration")
            For Each queryObj As ManagementObject In searcher.Get() 'FOR EACH NETWORK DEVICE DO BELOW
                If queryObj("MACAddress") <> "" Then        ' If MACAddress is not equal to nothing then add it to the drop list
                    ComboBox2.Items.Add(queryObj("MACAddress"))
                End If
            Next
            ComboBox2.Sorted = True
        Catch err As ManagementException 'Catch error doing above code
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'If selected from dropdown list clear MACAddress and copy value from Combobox to MACAddress String

        MACAddress = ""
        MACAddress = ComboBox2.Text
    End Sub

    Private Sub BtnMYIP_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMYIP.Click
        'RETRIEVE IP ADDRESS BUTTON
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True") 'Check only networks which are connected IPEnabled = True

            For Each queryObj As ManagementObject In searcher.Get()

                If queryObj("MACAddress") = MACAddress Then 'Check only netowork which has same MACaddress which was selected from dropdown list
                    Dim arrIPAddress As String()
                    arrIPAddress = queryObj("IPAddress")
                    For Each arrValue As String In arrIPAddress
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

    
    
    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnABOUT.Click
        'About
        AboutBox1.Show()
    End Sub


End Class
