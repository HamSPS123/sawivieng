<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMedicine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMedicine))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtUnit = New System.Windows.Forms.ComboBox()
        Me.txtExpired = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStock = New System.Windows.Forms.NumericUpDown()
        Me.txtType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 726)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(464, 65)
        Me.Panel3.TabIndex = 5
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
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "ຍົກເລີກ"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtUnit
        '
        Me.txtUnit.DisplayMember = "ຊາຍ,ຍິງ"
        Me.txtUnit.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtUnit.FormattingEnabled = True
        Me.txtUnit.Location = New System.Drawing.Point(31, 212)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(398, 40)
        Me.txtUnit.TabIndex = 2
        '
        'txtExpired
        '
        Me.txtExpired.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtExpired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtExpired.Location = New System.Drawing.Point(31, 369)
        Me.txtExpired.Name = "txtExpired"
        Me.txtExpired.Size = New System.Drawing.Size(398, 42)
        Me.txtExpired.TabIndex = 4
        Me.txtExpired.Value = New Date(2022, 5, 14, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 27)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ລາຍລະອຽດ"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtPrice.Location = New System.Drawing.Point(31, 448)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(398, 42)
        Me.txtPrice.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ລາຄາ"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ເພີ່ມຂໍ້ມູນຢາ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(26, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ວັນໝົດອາຍຸ"
        '
        'txtDetail
        '
        Me.txtDetail.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtDetail.Location = New System.Drawing.Point(31, 534)
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(398, 109)
        Me.txtDetail.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ຈຳນວນ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ຫົວໜ່ວຍ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ປະເພດຢາ"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(31, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(398, 42)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ຊື່ຢາ"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtStock)
        Me.Panel2.Controls.Add(Me.txtType)
        Me.Panel2.Controls.Add(Me.txtUnit)
        Me.Panel2.Controls.Add(Me.txtExpired)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDetail)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 736)
        Me.Panel2.TabIndex = 4
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtStock.Location = New System.Drawing.Point(31, 291)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(398, 42)
        Me.txtStock.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.DisplayMember = "ຊາຍ,ຍິງ"
        Me.txtType.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtType.FormattingEnabled = True
        Me.txtType.Location = New System.Drawing.Point(31, 130)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(398, 40)
        Me.txtType.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 55)
        Me.Panel1.TabIndex = 3
        '
        'AddMedicine
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(464, 791)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddMedicine"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtUnit As ComboBox
    Friend WithEvents txtExpired As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents txtType As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
