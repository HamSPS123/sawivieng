﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ເພີ່ມຂໍ້ມູນພະນັກງານ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtGender)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtTel)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 784)
        Me.Panel2.TabIndex = 1
        '
        'txtGender
        '
        Me.txtGender.DisplayMember = "ຊາຍ,ຍິງ"
        Me.txtGender.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"ຊາຍ", "ຍິງ"})
        Me.txtGender.Location = New System.Drawing.Point(31, 236)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(398, 40)
        Me.txtGender.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(31, 153)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(398, 42)
        Me.txtDate.TabIndex = 1
        Me.txtDate.Value = New Date(2022, 5, 14, 0, 0, 0, 0)
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(31, 645)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(398, 42)
        Me.txtPassword.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 615)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 27)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(31, 559)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(398, 42)
        Me.txtUsername.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Username"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtTel.Location = New System.Drawing.Point(31, 474)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(398, 42)
        Me.txtTel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(26, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ເບີໂທ"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtAddress.Location = New System.Drawing.Point(31, 319)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(398, 109)
        Me.txtAddress.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ທີ່ຢູ່"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ເພດ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ວັນເດືອນປີເກີດ"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(31, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(398, 42)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ຊື່ ແລະ ນາມສະກຸນ"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 774)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(464, 65)
        Me.Panel3.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(311, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(118, 47)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "ຍົກເລີກ"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(157, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 47)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 839)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmployee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents txtDate As DateTimePicker
End Class
