<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sale))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvshow = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbCus = New System.Windows.Forms.Label()
        Me.btnSearchCus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddCard = New System.Windows.Forms.Button()
        Me.btnSeachPro = New System.Windows.Forms.Button()
        Me.txtQTY = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(59, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1345, 743)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvshow)
        Me.GroupBox4.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(37, 187)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(912, 526)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ຍອດລວມ"
        '
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = False
        Me.dgvshow.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvshow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvshow.BackgroundColor = System.Drawing.Color.White
        Me.dgvshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvshow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvshow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvshow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvshow.EnableHeadersVisualStyles = False
        Me.dgvshow.Location = New System.Drawing.Point(3, 32)
        Me.dgvshow.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvshow.Name = "dgvshow"
        Me.dgvshow.RowHeadersWidth = 51
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvshow.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvshow.RowTemplate.Height = 24
        Me.dgvshow.Size = New System.Drawing.Size(906, 492)
        Me.dgvshow.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.HeaderText = "ລະຫັດ"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "ຊື່ສິນຄ້າ"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "ລາຄາ"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "ຈຳນວນ"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "ລາຄາລວມ"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCost)
        Me.GroupBox3.Controls.Add(Me.txtDiscount)
        Me.GroupBox3.Controls.Add(Me.txtChange)
        Me.GroupBox3.Controls.Add(Me.txtPay)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox3.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(955, 188)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(355, 519)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ຍອດລວມ"
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Location = New System.Drawing.Point(23, 356)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(289, 58)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "ບັນທຶກການຂາຍ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.Location = New System.Drawing.Point(23, 428)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(289, 58)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "ເພີມໃບບິນ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 27)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ເປັນເງິນ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 27)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ສ່ວນຫຼຸດ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ເງິນທອນ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ຈຳນວນເງິນ"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(116, 277)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(196, 37)
        Me.txtCost.TabIndex = 2
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(115, 169)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(196, 37)
        Me.txtDiscount.TabIndex = 2
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(115, 225)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(196, 37)
        Me.txtChange.TabIndex = 2
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(115, 117)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(196, 37)
        Me.txtPay.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ລາຄາລວມ"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(115, 57)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(196, 37)
        Me.txtTotalPrice.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbCus)
        Me.GroupBox2.Controls.Add(Me.btnSearchCus)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCusID)
        Me.GroupBox2.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(773, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(537, 135)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຂໍ້ມູນລູກຄ້າທີ່ເປັນສະມາຊິກ"
        '
        'lbCus
        '
        Me.lbCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbCus.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCus.ForeColor = System.Drawing.Color.Green
        Me.lbCus.Location = New System.Drawing.Point(308, 74)
        Me.lbCus.Name = "lbCus"
        Me.lbCus.Size = New System.Drawing.Size(200, 30)
        Me.lbCus.TabIndex = 4
        Me.lbCus.Text = "Customer"
        Me.lbCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCus.Visible = False
        '
        'btnSearchCus
        '
        Me.btnSearchCus.BackgroundImage = CType(resources.GetObject("btnSearchCus.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchCus.Location = New System.Drawing.Point(231, 74)
        Me.btnSearchCus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchCus.Name = "btnSearchCus"
        Me.btnSearchCus.Size = New System.Drawing.Size(62, 38)
        Me.btnSearchCus.TabIndex = 3
        Me.btnSearchCus.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(308, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ຊື່ລູກຄ້າ"
        Me.Label8.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ລະຫັດລູກຄ້າ"
        '
        'txtCusID
        '
        Me.txtCusID.Location = New System.Drawing.Point(21, 75)
        Me.txtCusID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(204, 37)
        Me.txtCusID.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddCard)
        Me.GroupBox1.Controls.Add(Me.btnSeachPro)
        Me.GroupBox1.Controls.Add(Me.txtQTY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProID)
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(707, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ຂໍ້ມູນສິນຄ້າ"
        '
        'btnAddCard
        '
        Me.btnAddCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddCard.Location = New System.Drawing.Point(520, 34)
        Me.btnAddCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(144, 79)
        Me.btnAddCard.TabIndex = 3
        Me.btnAddCard.Text = "ເພີ່ມລາຍການ"
        Me.btnAddCard.UseVisualStyleBackColor = True
        '
        'btnSeachPro
        '
        Me.btnSeachPro.BackgroundImage = CType(resources.GetObject("btnSeachPro.BackgroundImage"), System.Drawing.Image)
        Me.btnSeachPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSeachPro.Location = New System.Drawing.Point(269, 75)
        Me.btnSeachPro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSeachPro.Name = "btnSeachPro"
        Me.btnSeachPro.Size = New System.Drawing.Size(51, 37)
        Me.btnSeachPro.TabIndex = 3
        Me.btnSeachPro.UseVisualStyleBackColor = True
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(336, 75)
        Me.txtQTY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQTY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(164, 37)
        Me.txtQTY.TabIndex = 2
        Me.txtQTY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ຈຳນວນ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ລະຫັດສິນຄ້າ"
        '
        'txtProID
        '
        Me.txtProID.Location = New System.Drawing.Point(21, 75)
        Me.txtProID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(241, 37)
        Me.txtProID.TabIndex = 0
        '
        'Sale
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1449, 743)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Sale"
        Me.Text = "Sale"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchCus As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCusID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeachPro As Button
    Friend WithEvents txtQTY As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProID As TextBox
    Friend WithEvents btnAddCard As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgvshow As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lbCus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCost As TextBox
End Class
