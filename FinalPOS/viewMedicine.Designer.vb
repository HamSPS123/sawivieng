<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewMedicine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewMedicine))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvshow = New System.Windows.Forms.DataGridView()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgvshow)
        Me.Panel1.Location = New System.Drawing.Point(29, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 769)
        Me.Panel1.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(875, 34)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 47)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "ພິມລາຍງານ"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cmbSelect)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ເລືອກປະເພດ"
        '
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = False
        Me.dgvshow.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvshow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvshow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvshow.BackgroundColor = System.Drawing.Color.White
        Me.dgvshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Saysettha OT", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvshow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshow.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvshow.EnableHeadersVisualStyles = False
        Me.dgvshow.Location = New System.Drawing.Point(3, 107)
        Me.dgvshow.Name = "dgvshow"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvshow.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvshow.RowHeadersWidth = 51
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Saysettha OT", 10.2!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dgvshow.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvshow.RowTemplate.Height = 24
        Me.dgvshow.Size = New System.Drawing.Size(1018, 659)
        Me.dgvshow.TabIndex = 0
        '
        'cmbSelect
        '
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelect.FormattingEnabled = True
        Me.cmbSelect.Location = New System.Drawing.Point(6, 24)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(274, 35)
        Me.cmbSelect.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(295, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(46, 33)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(347, 24)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(46, 33)
        Me.btnReset.TabIndex = 3
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'viewMedicine
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1086, 793)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewMedicine"
        Me.Text = "viewMedicine"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvshow As DataGridView
    Friend WithEvents cmbSelect As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearch As Button
End Class
