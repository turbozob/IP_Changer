Imports System.Management
Imports System.Net

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "192.168.1.123"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
    End Sub

    'SET STATIC IP BUTTON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim IPAddress As String = TextBox1.Text
        Dim SubnetMask As String = TextBox2.Text
        Dim Gateway As String = TextBox3.Text

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()
        'Dim wiredadaptor As ManagementClass = New ManagementClass("Win32_NetworkAdapter instance")

        If CheckBoxDHCP.Checked Then
            For Each objMO As ManagementObject In objMOC
                If (Not CBool(objMO("IPEnabled"))) Then
                    Continue For
                End If

                Try
                    Dim objNewIP As ManagementBaseObject = Nothing
                    Dim objSetIP As ManagementBaseObject = Nothing
                    Dim objNewGate As ManagementBaseObject = Nothing

                    'objNewIP = objMO.GetMethodParameters("EnableStatic")
                    'objNewGate = objMO.GetMethodParameters("SetGateways")


                    objSetIP = objMO.InvokeMethod("EnableDHCP", objNewIP, Nothing)
                    'objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)

                    MessageBox.Show("DHCP IS SET!")

                Catch ex As Exception
                    MessageBox.Show("Unable to Set IP : " & ex.Message)
                End Try
            Next objMO


        Else

            For Each objMO As ManagementObject In objMOC
                If (Not CBool(objMO("IPEnabled"))) Then
                    Continue For
                End If

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

                    MessageBox.Show("Updated IPAddress, SubnetMask and Default Gateway!")

                Catch ex As Exception
                    MessageBox.Show("Unable to Set IP : " & ex.Message)
                End Try
            Next objMO
        End If

    End Sub

    'SET DHCP BUTTON
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'RETRIEVE IP ADDRESS BUTTON
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()


        'MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)
        MessageBox.Show("IP Address: " & strIPAddress)
    End Sub


    Private Sub RadioButtonSMM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSMM.CheckedChanged
        TextBox1.Text = "192.168.1.123"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
    End Sub

    Private Sub RadioButtonBALANCE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonBALANCE.CheckedChanged
        TextBox1.Text = "192.168.0.10"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.0.1"
    End Sub

    Private Sub RadioButtonASTEC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonASTEC.CheckedChanged
        TextBox1.Text = "192.168.0.10"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.0.1"
    End Sub

    Private Sub RadioButtonTOVTRAK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTOVTRAK.CheckedChanged
        TextBox1.Text = "10.1.10.101"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "10.1.10.1"
    End Sub

    Private Sub RadioButtonPOLTOVSTROJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPOLTOVSTROJ.CheckedChanged
        TextBox1.Text = "192.168.0.200"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.0.1"
    End Sub

    Private Sub RadioButtonKOKUSAI1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonKOKUSAI1.CheckedChanged
        TextBox1.Text = "10.1.10.220"
        TextBox2.Text = "255.0.0.0"
        TextBox3.Text = "10.1.10.1"
    End Sub

    Private Sub RadioButtonKOKUSAI2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonKOKUSAI2.CheckedChanged
        TextBox1.Text = "172.27.156.100"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "172.27.156.1"
    End Sub

    Private Sub RadioButtonYXLON1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonYXLON1.CheckedChanged
        TextBox1.Text = "192.168.6.200"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.6.1"
    End Sub

    Private Sub RadioButtonYXLON2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonYXLON2.CheckedChanged
        TextBox1.Text = "10.1.10.250"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "10.1.10.1"
    End Sub

    Private Sub RadioButtonVEZNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVEZNI.CheckedChanged
        TextBox1.Text = "192.168.223.140"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.223.1"
    End Sub

    Private Sub RadioButtonAVS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAVS.CheckedChanged
        TextBox1.Text = "192.168.1.10"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
    End Sub

    Private Sub RadioButton4JET_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4JET.CheckedChanged
        TextBox1.Text = "192.168.1.101"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "192.168.1.1"
    End Sub

    Private Sub RadioButtonPH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPH.CheckedChanged
        TextBox1.Text = "10.10.0.250"
        TextBox2.Text = "255.255.255.0"
        TextBox3.Text = "10.10.0.1"
    End Sub

  
    Private Sub CheckBoxDHCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDHCP.CheckedChanged
        If CheckBoxDHCP.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            RadioButtonSMM.Enabled = False
            RadioButtonBALANCE.Enabled = False
            RadioButtonASTEC.Enabled = False
            RadioButtonTOVTRAK.Enabled = False
            RadioButtonPOLTOVSTROJ.Enabled = False
            RadioButtonKOKUSAI1.Enabled = False
            RadioButtonKOKUSAI2.Enabled = False
            RadioButtonYXLON1.Enabled = False
            RadioButtonYXLON2.Enabled = False
            RadioButtonVEZNI.Enabled = False
            RadioButtonAVS.Enabled = False
            RadioButton4JET.Enabled = False
            RadioButtonPH.Enabled = False
        End If

        If CheckBoxDHCP.Checked = False Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            RadioButtonSMM.Enabled = True
            RadioButtonBALANCE.Enabled = True
            RadioButtonASTEC.Enabled = True
            RadioButtonTOVTRAK.Enabled = True
            RadioButtonPOLTOVSTROJ.Enabled = True
            RadioButtonKOKUSAI1.Enabled = True
            RadioButtonKOKUSAI2.Enabled = True
            RadioButtonYXLON1.Enabled = True
            RadioButtonYXLON2.Enabled = True
            RadioButtonVEZNI.Enabled = True
            RadioButtonAVS.Enabled = True
            RadioButton4JET.Enabled = True
            RadioButtonPH.Enabled = True
        End If
        


    End Sub
End Class
