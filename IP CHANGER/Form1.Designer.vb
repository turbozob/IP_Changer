<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_IPaddress = New System.Windows.Forms.TextBox()
        Me.TB_Subnet = New System.Windows.Forms.TextBox()
        Me.TB_Gateway = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_NIC = New System.Windows.Forms.ComboBox()
        Me.lblAdapter = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSelectedAdapter = New System.Windows.Forms.Label()
        Me.lblDeviceID = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnLogs = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnNetDisable = New System.Windows.Forms.Button()
        Me.BtnGetMAC = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnOpenNetworkConnections = New System.Windows.Forms.Button()
        Me.BtnNetEnable = New System.Windows.Forms.Button()
        Me.BtnDHCP = New System.Windows.Forms.Button()
        Me.BtnGetIP = New System.Windows.Forms.Button()
        Me.BtnChangeIP = New System.Windows.Forms.Button()
        Me.BtnNetScan = New System.Windows.Forms.Button()
        Me.BtnABOUT = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subnet Mask:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Default Gateway:"
        '
        'TB_IPaddress
        '
        Me.TB_IPaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_IPaddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_IPaddress.Location = New System.Drawing.Point(137, 29)
        Me.TB_IPaddress.MaxLength = 15
        Me.TB_IPaddress.Name = "TB_IPaddress"
        Me.TB_IPaddress.Size = New System.Drawing.Size(163, 22)
        Me.TB_IPaddress.TabIndex = 6
        '
        'TB_Subnet
        '
        Me.TB_Subnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Subnet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_Subnet.Location = New System.Drawing.Point(137, 57)
        Me.TB_Subnet.MaxLength = 15
        Me.TB_Subnet.Name = "TB_Subnet"
        Me.TB_Subnet.Size = New System.Drawing.Size(163, 22)
        Me.TB_Subnet.TabIndex = 7
        '
        'TB_Gateway
        '
        Me.TB_Gateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Gateway.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_Gateway.Location = New System.Drawing.Point(137, 85)
        Me.TB_Gateway.MaxLength = 15
        Me.TB_Gateway.Name = "TB_Gateway"
        Me.TB_Gateway.Size = New System.Drawing.Size(163, 22)
        Me.TB_Gateway.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Setup Name:"
        '
        'CB_NIC
        '
        Me.CB_NIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NIC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_NIC.FormattingEnabled = True
        Me.CB_NIC.Location = New System.Drawing.Point(2, 2)
        Me.CB_NIC.Name = "CB_NIC"
        Me.CB_NIC.Size = New System.Drawing.Size(298, 21)
        Me.CB_NIC.TabIndex = 41
        '
        'lblAdapter
        '
        Me.lblAdapter.AutoSize = True
        Me.lblAdapter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAdapter.Location = New System.Drawing.Point(1, 144)
        Me.lblAdapter.Name = "lblAdapter"
        Me.lblAdapter.Size = New System.Drawing.Size(51, 13)
        Me.lblAdapter.TabIndex = 55
        Me.lblAdapter.Text = "Adapter:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Device ID:"
        '
        'lblSelectedAdapter
        '
        Me.lblSelectedAdapter.AutoSize = True
        Me.lblSelectedAdapter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSelectedAdapter.Location = New System.Drawing.Point(55, 144)
        Me.lblSelectedAdapter.Name = "lblSelectedAdapter"
        Me.lblSelectedAdapter.Size = New System.Drawing.Size(35, 13)
        Me.lblSelectedAdapter.TabIndex = 57
        Me.lblSelectedAdapter.Text = "None"
        '
        'lblDeviceID
        '
        Me.lblDeviceID.AutoSize = True
        Me.lblDeviceID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDeviceID.Location = New System.Drawing.Point(55, 161)
        Me.lblDeviceID.Name = "lblDeviceID"
        Me.lblDeviceID.Size = New System.Drawing.Size(35, 13)
        Me.lblDeviceID.TabIndex = 58
        Me.lblDeviceID.Text = "None"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(304, 22)
        Me.StatusStrip1.TabIndex = 67
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.Text = "lblStatus"
        '
        'BtnLogs
        '
        Me.BtnLogs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnLogs.Image = Global.WindowsApplication1.My.Resources.Resources.log
        Me.BtnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogs.Location = New System.Drawing.Point(246, 329)
        Me.BtnLogs.Name = "BtnLogs"
        Me.BtnLogs.Size = New System.Drawing.Size(25, 25)
        Me.BtnLogs.TabIndex = 68
        Me.BtnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogs.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnSettings.Image = Global.WindowsApplication1.My.Resources.Resources.setting
        Me.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSettings.Location = New System.Drawing.Point(153, 329)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(25, 25)
        Me.BtnSettings.TabIndex = 66
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'BtnNetDisable
        '
        Me.BtnNetDisable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnNetDisable.Image = CType(resources.GetObject("BtnNetDisable.Image"), System.Drawing.Image)
        Me.BtnNetDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNetDisable.Location = New System.Drawing.Point(4, 291)
        Me.BtnNetDisable.Name = "BtnNetDisable"
        Me.BtnNetDisable.Size = New System.Drawing.Size(145, 32)
        Me.BtnNetDisable.TabIndex = 50
        Me.BtnNetDisable.Text = "Disable Network"
        Me.BtnNetDisable.UseVisualStyleBackColor = True
        '
        'BtnGetMAC
        '
        Me.BtnGetMAC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnGetMAC.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_Out
        Me.BtnGetMAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetMAC.Location = New System.Drawing.Point(155, 291)
        Me.BtnGetMAC.Name = "BtnGetMAC"
        Me.BtnGetMAC.Size = New System.Drawing.Size(145, 32)
        Me.BtnGetMAC.TabIndex = 52
        Me.BtnGetMAC.Text = "Get MAC Address"
        Me.BtnGetMAC.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnEdit.Image = Global.WindowsApplication1.My.Resources.Resources.Edit_File
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(215, 329)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(25, 25)
        Me.BtnEdit.TabIndex = 63
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnOpen.Image = Global.WindowsApplication1.My.Resources.Resources.Open_File
        Me.BtnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpen.Location = New System.Drawing.Point(184, 329)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(25, 25)
        Me.BtnOpen.TabIndex = 60
        Me.BtnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnOpenNetworkConnections
        '
        Me.BtnOpenNetworkConnections.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnOpenNetworkConnections.Image = Global.WindowsApplication1.My.Resources.Resources.Network_16x16
        Me.BtnOpenNetworkConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpenNetworkConnections.Location = New System.Drawing.Point(4, 215)
        Me.BtnOpenNetworkConnections.Name = "BtnOpenNetworkConnections"
        Me.BtnOpenNetworkConnections.Size = New System.Drawing.Size(146, 32)
        Me.BtnOpenNetworkConnections.TabIndex = 59
        Me.BtnOpenNetworkConnections.Text = "Network Connections"
        Me.BtnOpenNetworkConnections.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOpenNetworkConnections.UseVisualStyleBackColor = True
        '
        'BtnNetEnable
        '
        Me.BtnNetEnable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnNetEnable.Image = Global.WindowsApplication1.My.Resources.Resources.enable_16x16
        Me.BtnNetEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNetEnable.Location = New System.Drawing.Point(4, 253)
        Me.BtnNetEnable.Name = "BtnNetEnable"
        Me.BtnNetEnable.Size = New System.Drawing.Size(145, 32)
        Me.BtnNetEnable.TabIndex = 51
        Me.BtnNetEnable.Text = "Enable Network"
        Me.BtnNetEnable.UseVisualStyleBackColor = True
        '
        'BtnDHCP
        '
        Me.BtnDHCP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnDHCP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_In
        Me.BtnDHCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDHCP.Location = New System.Drawing.Point(156, 215)
        Me.BtnDHCP.Name = "BtnDHCP"
        Me.BtnDHCP.Size = New System.Drawing.Size(145, 32)
        Me.BtnDHCP.TabIndex = 48
        Me.BtnDHCP.Text = "DHCP Enable"
        Me.BtnDHCP.UseVisualStyleBackColor = True
        '
        'BtnGetIP
        '
        Me.BtnGetIP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnGetIP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_Out
        Me.BtnGetIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetIP.Location = New System.Drawing.Point(155, 253)
        Me.BtnGetIP.Name = "BtnGetIP"
        Me.BtnGetIP.Size = New System.Drawing.Size(145, 32)
        Me.BtnGetIP.TabIndex = 47
        Me.BtnGetIP.Text = "Get IP Address"
        Me.BtnGetIP.UseVisualStyleBackColor = True
        '
        'BtnChangeIP
        '
        Me.BtnChangeIP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnChangeIP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_In
        Me.BtnChangeIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChangeIP.Location = New System.Drawing.Point(156, 177)
        Me.BtnChangeIP.Name = "BtnChangeIP"
        Me.BtnChangeIP.Size = New System.Drawing.Size(145, 32)
        Me.BtnChangeIP.TabIndex = 46
        Me.BtnChangeIP.Text = "Change IP Address"
        Me.BtnChangeIP.UseVisualStyleBackColor = True
        '
        'BtnNetScan
        '
        Me.BtnNetScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnNetScan.Image = Global.WindowsApplication1.My.Resources.Resources.Network_16x16
        Me.BtnNetScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNetScan.Location = New System.Drawing.Point(4, 177)
        Me.BtnNetScan.Name = "BtnNetScan"
        Me.BtnNetScan.Size = New System.Drawing.Size(146, 32)
        Me.BtnNetScan.TabIndex = 40
        Me.BtnNetScan.Text = "Scan Network Devices"
        Me.BtnNetScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNetScan.UseVisualStyleBackColor = True
        '
        'BtnABOUT
        '
        Me.BtnABOUT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnABOUT.Image = Global.WindowsApplication1.My.Resources.Resources.get_info_16X16
        Me.BtnABOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnABOUT.Location = New System.Drawing.Point(277, 329)
        Me.BtnABOUT.Name = "BtnABOUT"
        Me.BtnABOUT.Size = New System.Drawing.Size(25, 25)
        Me.BtnABOUT.TabIndex = 38
        Me.BtnABOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnABOUT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 381)
        Me.Controls.Add(Me.BtnLogs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.BtnNetDisable)
        Me.Controls.Add(Me.BtnGetMAC)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnOpenNetworkConnections)
        Me.Controls.Add(Me.lblDeviceID)
        Me.Controls.Add(Me.lblSelectedAdapter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAdapter)
        Me.Controls.Add(Me.BtnNetEnable)
        Me.Controls.Add(Me.BtnDHCP)
        Me.Controls.Add(Me.BtnGetIP)
        Me.Controls.Add(Me.BtnChangeIP)
        Me.Controls.Add(Me.CB_NIC)
        Me.Controls.Add(Me.BtnNetScan)
        Me.Controls.Add(Me.BtnABOUT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TB_Gateway)
        Me.Controls.Add(Me.TB_Subnet)
        Me.Controls.Add(Me.TB_IPaddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP Changer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_IPaddress As System.Windows.Forms.TextBox
    Friend WithEvents TB_Subnet As System.Windows.Forms.TextBox
    Friend WithEvents TB_Gateway As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnABOUT As System.Windows.Forms.Button
    Friend WithEvents BtnNetScan As System.Windows.Forms.Button
    Friend WithEvents CB_NIC As System.Windows.Forms.ComboBox
    Friend WithEvents BtnChangeIP As System.Windows.Forms.Button
    Friend WithEvents BtnGetIP As System.Windows.Forms.Button
    Friend WithEvents BtnDHCP As System.Windows.Forms.Button
    Friend WithEvents BtnNetDisable As System.Windows.Forms.Button
    Friend WithEvents BtnNetEnable As System.Windows.Forms.Button
    Friend WithEvents BtnGetMAC As System.Windows.Forms.Button
    Friend WithEvents lblAdapter As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedAdapter As System.Windows.Forms.Label
    Friend WithEvents lblDeviceID As System.Windows.Forms.Label
    Friend WithEvents BtnOpenNetworkConnections As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents BtnLogs As Button
End Class
