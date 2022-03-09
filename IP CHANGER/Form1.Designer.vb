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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxDHCP = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnABOUT = New System.Windows.Forms.Button()
        Me.BtnMYIP = New System.Windows.Forms.Button()
        Me.BtnSCANMAC = New System.Windows.Forms.Button()
        Me.BtnSAVEMAC = New System.Windows.Forms.Button()
        Me.BtnCHGIP = New System.Windows.Forms.Button()
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
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(137, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(137, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "MAC Address:"
        '
        'CheckBoxDHCP
        '
        Me.CheckBoxDHCP.AutoSize = True
        Me.CheckBoxDHCP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBoxDHCP.Location = New System.Drawing.Point(4, 146)
        Me.CheckBoxDHCP.Name = "CheckBoxDHCP"
        Me.CheckBoxDHCP.Size = New System.Drawing.Size(93, 17)
        Me.CheckBoxDHCP.TabIndex = 30
        Me.CheckBoxDHCP.Text = "DHCP Enable"
        Me.CheckBoxDHCP.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SMM TRANSPORTI", "BALANCE", "ASTEC", "TOVORNI TRAK 1 IN 2", "POLTOV. OBREZOVALNI STROJ", "KOKUSAI 1", "KOKUSAI 2", "YXLON 1", "YXLON 2", "VEZNI TRANSPORTER", "AVS 1 IN 2", "4JET LASER ENGRAVER", "PH BRUSILNI STROJ", "MATTEUZZI"})
        Me.ComboBox1.Location = New System.Drawing.Point(137, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Select IP by Machine"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(137, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox2.TabIndex = 35
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BtnABOUT
        '
        Me.BtnABOUT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnABOUT.Image = Global.WindowsApplication1.My.Resources.Resources.get_info_16X16
        Me.BtnABOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnABOUT.Location = New System.Drawing.Point(258, 312)
        Me.BtnABOUT.Name = "BtnABOUT"
        Me.BtnABOUT.Size = New System.Drawing.Size(24, 21)
        Me.BtnABOUT.TabIndex = 38
        Me.BtnABOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnABOUT.UseVisualStyleBackColor = True
        '
        'BtnMYIP
        '
        Me.BtnMYIP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnMYIP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_Out
        Me.BtnMYIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMYIP.Location = New System.Drawing.Point(78, 281)
        Me.BtnMYIP.Name = "BtnMYIP"
        Me.BtnMYIP.Size = New System.Drawing.Size(145, 32)
        Me.BtnMYIP.TabIndex = 37
        Me.BtnMYIP.Text = "Retrieve IP Address"
        Me.BtnMYIP.UseVisualStyleBackColor = True
        '
        'BtnSCANMAC
        '
        Me.BtnSCANMAC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnSCANMAC.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_In
        Me.BtnSCANMAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSCANMAC.Location = New System.Drawing.Point(77, 169)
        Me.BtnSCANMAC.Name = "BtnSCANMAC"
        Me.BtnSCANMAC.Size = New System.Drawing.Size(146, 32)
        Me.BtnSCANMAC.TabIndex = 36
        Me.BtnSCANMAC.Text = "Scan Network Devices"
        Me.BtnSCANMAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSCANMAC.UseVisualStyleBackColor = True
        '
        'BtnSAVEMAC
        '
        Me.BtnSAVEMAC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnSAVEMAC.Image = Global.WindowsApplication1.My.Resources.Resources.Save
        Me.BtnSAVEMAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSAVEMAC.Location = New System.Drawing.Point(78, 207)
        Me.BtnSAVEMAC.Name = "BtnSAVEMAC"
        Me.BtnSAVEMAC.Size = New System.Drawing.Size(144, 32)
        Me.BtnSAVEMAC.TabIndex = 27
        Me.BtnSAVEMAC.Text = "Save MAC"
        Me.BtnSAVEMAC.UseVisualStyleBackColor = True
        '
        'BtnCHGIP
        '
        Me.BtnCHGIP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnCHGIP.Image = Global.WindowsApplication1.My.Resources.Resources.Arrow_In
        Me.BtnCHGIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCHGIP.Location = New System.Drawing.Point(78, 243)
        Me.BtnCHGIP.Name = "BtnCHGIP"
        Me.BtnCHGIP.Size = New System.Drawing.Size(145, 32)
        Me.BtnCHGIP.TabIndex = 0
        Me.BtnCHGIP.Text = "Change IP Address"
        Me.BtnCHGIP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 335)
        Me.Controls.Add(Me.BtnABOUT)
        Me.Controls.Add(Me.BtnMYIP)
        Me.Controls.Add(Me.BtnSCANMAC)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBoxDHCP)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnSAVEMAC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCHGIP)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP CHANGER 1.6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCHGIP As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSAVEMAC As System.Windows.Forms.Button
    Friend WithEvents CheckBoxDHCP As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSCANMAC As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnMYIP As System.Windows.Forms.Button
    Friend WithEvents BtnABOUT As System.Windows.Forms.Button

End Class
