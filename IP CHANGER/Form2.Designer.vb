<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExternalEditor = New System.Windows.Forms.Label()
        Me.txtExternalEditor = New System.Windows.Forms.TextBox()
        Me.CB_VerifyIPchange = New System.Windows.Forms.CheckBox()
        Me.CB_CheckForIPv6 = New System.Windows.Forms.CheckBox()
        Me.CB_CheckNetConnected = New System.Windows.Forms.CheckBox()
        Me.CB_CheckIPused = New System.Windows.Forms.CheckBox()
        Me.CB_LastUsedNIC = New System.Windows.Forms.CheckBox()
        Me.CB_AutoLoadCfg = New System.Windows.Forms.CheckBox()
        Me.txtCfgFilePath = New System.Windows.Forms.TextBox()
        Me.lblCfgFileLocation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(116, 376)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(235, 23)
        Me.BtnOK.TabIndex = 70
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = ">>> All changes are saved automatically <<<"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExternalEditor
        '
        Me.lblExternalEditor.AutoSize = True
        Me.lblExternalEditor.Location = New System.Drawing.Point(12, 151)
        Me.lblExternalEditor.Name = "lblExternalEditor"
        Me.lblExternalEditor.Size = New System.Drawing.Size(228, 13)
        Me.lblExternalEditor.TabIndex = 74
        Me.lblExternalEditor.Text = "External editor (enter only editor exe name)"
        '
        'txtExternalEditor
        '
        Me.txtExternalEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExternalEditor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "ExternalEditor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtExternalEditor.Location = New System.Drawing.Point(12, 168)
        Me.txtExternalEditor.Name = "txtExternalEditor"
        Me.txtExternalEditor.Size = New System.Drawing.Size(440, 22)
        Me.txtExternalEditor.TabIndex = 75
        Me.txtExternalEditor.Text = Global.WindowsApplication1.My.MySettings.Default.ExternalEditor
        '
        'CB_VerifyIPchange
        '
        Me.CB_VerifyIPchange.AutoSize = True
        Me.CB_VerifyIPchange.Checked = Global.WindowsApplication1.My.MySettings.Default.VerifyIPaddress
        Me.CB_VerifyIPchange.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_VerifyIPchange.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "VerifyIPaddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_VerifyIPchange.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_VerifyIPchange.Location = New System.Drawing.Point(12, 127)
        Me.CB_VerifyIPchange.Name = "CB_VerifyIPchange"
        Me.CB_VerifyIPchange.Size = New System.Drawing.Size(167, 17)
        Me.CB_VerifyIPchange.TabIndex = 73
        Me.CB_VerifyIPchange.Text = "Verify IP address on change"
        Me.CB_VerifyIPchange.UseVisualStyleBackColor = True
        '
        'CB_CheckForIPv6
        '
        Me.CB_CheckForIPv6.AutoSize = True
        Me.CB_CheckForIPv6.Checked = Global.WindowsApplication1.My.MySettings.Default.CheckForIPv6
        Me.CB_CheckForIPv6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "CheckForIPv6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_CheckForIPv6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_CheckForIPv6.Location = New System.Drawing.Point(12, 104)
        Me.CB_CheckForIPv6.Name = "CB_CheckForIPv6"
        Me.CB_CheckForIPv6.Size = New System.Drawing.Size(141, 17)
        Me.CB_CheckForIPv6.TabIndex = 72
        Me.CB_CheckForIPv6.Text = "Check for IPv6 address"
        Me.CB_CheckForIPv6.UseVisualStyleBackColor = True
        '
        'CB_CheckNetConnected
        '
        Me.CB_CheckNetConnected.AutoSize = True
        Me.CB_CheckNetConnected.Checked = Global.WindowsApplication1.My.MySettings.Default.CheckForEnabledNIC
        Me.CB_CheckNetConnected.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "CheckForEnabledNIC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_CheckNetConnected.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_CheckNetConnected.Location = New System.Drawing.Point(12, 81)
        Me.CB_CheckNetConnected.Name = "CB_CheckNetConnected"
        Me.CB_CheckNetConnected.Size = New System.Drawing.Size(213, 17)
        Me.CB_CheckNetConnected.TabIndex = 69
        Me.CB_CheckNetConnected.Text = "Check for network device connected"
        Me.CB_CheckNetConnected.UseVisualStyleBackColor = True
        '
        'CB_CheckIPused
        '
        Me.CB_CheckIPused.AutoSize = True
        Me.CB_CheckIPused.Checked = Global.WindowsApplication1.My.MySettings.Default.CheckForUsedIP
        Me.CB_CheckIPused.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "CheckForUsedIP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_CheckIPused.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_CheckIPused.Location = New System.Drawing.Point(12, 58)
        Me.CB_CheckIPused.Name = "CB_CheckIPused"
        Me.CB_CheckIPused.Size = New System.Drawing.Size(218, 17)
        Me.CB_CheckIPused.TabIndex = 68
        Me.CB_CheckIPused.Text = "Check for IP already used on network"
        Me.CB_CheckIPused.UseVisualStyleBackColor = True
        '
        'CB_LastUsedNIC
        '
        Me.CB_LastUsedNIC.AutoSize = True
        Me.CB_LastUsedNIC.Checked = Global.WindowsApplication1.My.MySettings.Default.AutoLoadNic
        Me.CB_LastUsedNIC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_LastUsedNIC.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "AutoLoadNic", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_LastUsedNIC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_LastUsedNIC.Location = New System.Drawing.Point(12, 35)
        Me.CB_LastUsedNIC.Name = "CB_LastUsedNIC"
        Me.CB_LastUsedNIC.Size = New System.Drawing.Size(243, 17)
        Me.CB_LastUsedNIC.TabIndex = 67
        Me.CB_LastUsedNIC.Text = "Select last used network device on startup"
        Me.CB_LastUsedNIC.UseVisualStyleBackColor = True
        '
        'CB_AutoLoadCfg
        '
        Me.CB_AutoLoadCfg.AutoSize = True
        Me.CB_AutoLoadCfg.Checked = Global.WindowsApplication1.My.MySettings.Default.AutoLoadConfigFile
        Me.CB_AutoLoadCfg.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApplication1.My.MySettings.Default, "AutoLoadConfigFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CB_AutoLoadCfg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_AutoLoadCfg.Location = New System.Drawing.Point(12, 12)
        Me.CB_AutoLoadCfg.Name = "CB_AutoLoadCfg"
        Me.CB_AutoLoadCfg.Size = New System.Drawing.Size(227, 17)
        Me.CB_AutoLoadCfg.TabIndex = 66
        Me.CB_AutoLoadCfg.Text = "Auto load configuration file on startup"
        Me.CB_AutoLoadCfg.UseVisualStyleBackColor = True
        '
        'txtCfgFilePath
        '
        Me.txtCfgFilePath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCfgFilePath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "ConfigFilePath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCfgFilePath.Location = New System.Drawing.Point(12, 210)
        Me.txtCfgFilePath.Name = "txtCfgFilePath"
        Me.txtCfgFilePath.Size = New System.Drawing.Size(440, 22)
        Me.txtCfgFilePath.TabIndex = 77
        Me.txtCfgFilePath.Text = Global.WindowsApplication1.My.MySettings.Default.ConfigFilePath
        '
        'lblCfgFileLocation
        '
        Me.lblCfgFileLocation.AutoSize = True
        Me.lblCfgFileLocation.Location = New System.Drawing.Point(12, 193)
        Me.lblCfgFileLocation.Name = "lblCfgFileLocation"
        Me.lblCfgFileLocation.Size = New System.Drawing.Size(156, 13)
        Me.lblCfgFileLocation.TabIndex = 76
        Me.lblCfgFileLocation.Text = "Config file location (fullpath)"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 441)
        Me.Controls.Add(Me.txtCfgFilePath)
        Me.Controls.Add(Me.lblCfgFileLocation)
        Me.Controls.Add(Me.txtExternalEditor)
        Me.Controls.Add(Me.lblExternalEditor)
        Me.Controls.Add(Me.CB_VerifyIPchange)
        Me.Controls.Add(Me.CB_CheckForIPv6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.CB_CheckNetConnected)
        Me.Controls.Add(Me.CB_CheckIPused)
        Me.Controls.Add(Me.CB_LastUsedNIC)
        Me.Controls.Add(Me.CB_AutoLoadCfg)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_LastUsedNIC As CheckBox
    Friend WithEvents CB_AutoLoadCfg As CheckBox
    Friend WithEvents CB_CheckIPused As CheckBox
    Friend WithEvents CB_CheckNetConnected As CheckBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_CheckForIPv6 As CheckBox
    Friend WithEvents CB_VerifyIPchange As CheckBox
    Friend WithEvents lblExternalEditor As Label
    Friend WithEvents txtExternalEditor As TextBox
    Friend WithEvents txtCfgFilePath As TextBox
    Friend WithEvents lblCfgFileLocation As Label
End Class
