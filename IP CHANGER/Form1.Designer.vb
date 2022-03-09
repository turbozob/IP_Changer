<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLNetCard = New System.Windows.Forms.Label()
        Me.LBLDeviceID = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnOpenNetworkConnections = New System.Windows.Forms.Button()
        Me.BtnGetMAC = New System.Windows.Forms.Button()
        Me.BtnNetEnable = New System.Windows.Forms.Button()
        Me.BtnNetDisable = New System.Windows.Forms.Button()
        Me.BtnDHCP = New System.Windows.Forms.Button()
        Me.BtnGetIP = New System.Windows.Forms.Button()
        Me.BtnChangeIP = New System.Windows.Forms.Button()
        Me.BtnNetScan = New System.Windows.Forms.Button()
        Me.BtnABOUT = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subnet Mask:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Default Gateway:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(137, 29)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(137, 57)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(137, 85)
        Me.TextBox3.MaxLength = 15
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(163, 22)
        Me.TextBox3.TabIndex = 8
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
        Me.Label6.Location = New System.Drawing.Point(1, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Setup Name:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(2, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(298, 21)
        Me.ComboBox3.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "NetCard:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "DeviceID:"
        '
        'LBLNetCard
        '
        Me.LBLNetCard.AutoSize = True
        Me.LBLNetCard.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBLNetCard.Location = New System.Drawing.Point(53, 139)
        Me.LBLNetCard.Name = "LBLNetCard"
        Me.LBLNetCard.Size = New System.Drawing.Size(35, 13)
        Me.LBLNetCard.TabIndex = 57
        Me.LBLNetCard.Text = "None"
        '
        'LBLDeviceID
        '
        Me.LBLDeviceID.AutoSize = True
        Me.LBLDeviceID.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBLDeviceID.Location = New System.Drawing.Point(52, 154)
        Me.LBLDeviceID.Name = "LBLDeviceID"
        Me.LBLDeviceID.Size = New System.Drawing.Size(35, 13)
        Me.LBLDeviceID.TabIndex = 58
        Me.LBLDeviceID.Text = "None"
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnEdit.Image = Global.WindowsApplication1.My.Resources.Resources.Edit_File
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(28, 322)
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
        Me.BtnOpen.Location = New System.Drawing.Point(4, 322)
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
        Me.BtnOpenNetworkConnections.Location = New System.Drawing.Point(4, 208)
        Me.BtnOpenNetworkConnections.Name = "BtnOpenNetworkConnections"
        Me.BtnOpenNetworkConnections.Size = New System.Drawing.Size(146, 32)
        Me.BtnOpenNetworkConnections.TabIndex = 59
        Me.BtnOpenNetworkConnections.Text = "Open Network"
        Me.BtnOpenNetworkConnections.UseVisualStyleBackColor = True
        '
        'BtnGetMAC
        '
        Me.BtnGetMAC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnGetMAC.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_Out
        Me.BtnGetMAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetMAC.Location = New System.Drawing.Point(155, 284)
        Me.BtnGetMAC.Name = "BtnGetMAC"
        Me.BtnGetMAC.Size = New System.Drawing.Size(145, 32)
        Me.BtnGetMAC.TabIndex = 52
        Me.BtnGetMAC.Text = "Get MAC Address"
        Me.BtnGetMAC.UseVisualStyleBackColor = True
        '
        'BtnNetEnable
        '
        Me.BtnNetEnable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnNetEnable.Image = Global.WindowsApplication1.My.Resources.Resources.enable_16x16
        Me.BtnNetEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNetEnable.Location = New System.Drawing.Point(4, 246)
        Me.BtnNetEnable.Name = "BtnNetEnable"
        Me.BtnNetEnable.Size = New System.Drawing.Size(145, 32)
        Me.BtnNetEnable.TabIndex = 51
        Me.BtnNetEnable.Text = "Enable Network"
        Me.BtnNetEnable.UseVisualStyleBackColor = True
        '
        'BtnNetDisable
        '
        Me.BtnNetDisable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnNetDisable.Image = CType(resources.GetObject("BtnNetDisable.Image"), System.Drawing.Image)
        Me.BtnNetDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNetDisable.Location = New System.Drawing.Point(4, 284)
        Me.BtnNetDisable.Name = "BtnNetDisable"
        Me.BtnNetDisable.Size = New System.Drawing.Size(145, 32)
        Me.BtnNetDisable.TabIndex = 50
        Me.BtnNetDisable.Text = "Disable Network"
        Me.BtnNetDisable.UseVisualStyleBackColor = True
        '
        'BtnDHCP
        '
        Me.BtnDHCP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnDHCP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_In
        Me.BtnDHCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDHCP.Location = New System.Drawing.Point(156, 208)
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
        Me.BtnGetIP.Location = New System.Drawing.Point(155, 246)
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
        Me.BtnChangeIP.Location = New System.Drawing.Point(156, 170)
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
        Me.BtnNetScan.Location = New System.Drawing.Point(4, 170)
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
        Me.BtnABOUT.Location = New System.Drawing.Point(277, 322)
        Me.BtnABOUT.Name = "BtnABOUT"
        Me.BtnABOUT.Size = New System.Drawing.Size(25, 25)
        Me.BtnABOUT.TabIndex = 38
        Me.BtnABOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnABOUT.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.WindowsApplication1.My.MySettings.Default.AutoLoadNic
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "AutoLoadNic", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(83, 334)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox2.TabIndex = 65
        Me.CheckBox2.Text = "Auto Save Last Used NIC"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.WindowsApplication1.My.MySettings.Default.AutoLoadConfigFile
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "AutoLoadConfigFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(83, 319)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 64
        Me.CheckBox1.Text = "Auto Load Config File"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 353)
        Me.Controls.Add(Me.BtnNetDisable)
        Me.Controls.Add(Me.BtnGetMAC)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnOpenNetworkConnections)
        Me.Controls.Add(Me.LBLDeviceID)
        Me.Controls.Add(Me.LBLNetCard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnNetEnable)
        Me.Controls.Add(Me.BtnDHCP)
        Me.Controls.Add(Me.BtnGetIP)
        Me.Controls.Add(Me.BtnChangeIP)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.BtnNetScan)
        Me.Controls.Add(Me.BtnABOUT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnABOUT As System.Windows.Forms.Button
    Friend WithEvents BtnNetScan As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnChangeIP As System.Windows.Forms.Button
    Friend WithEvents BtnGetIP As System.Windows.Forms.Button
    Friend WithEvents BtnDHCP As System.Windows.Forms.Button
    Friend WithEvents BtnNetDisable As System.Windows.Forms.Button
    Friend WithEvents BtnNetEnable As System.Windows.Forms.Button
    Friend WithEvents BtnGetMAC As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLNetCard As System.Windows.Forms.Label
    Friend WithEvents LBLDeviceID As System.Windows.Forms.Label
    Friend WithEvents BtnOpenNetworkConnections As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

End Class
