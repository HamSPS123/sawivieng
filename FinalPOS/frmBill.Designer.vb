<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.crvshow = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvshow
        '
        Me.crvshow.ActiveViewIndex = -1
        Me.crvshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvshow.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvshow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvshow.Location = New System.Drawing.Point(0, 0)
        Me.crvshow.Name = "crvshow"
        Me.crvshow.Size = New System.Drawing.Size(1010, 796)
        Me.crvshow.TabIndex = 0
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 796)
        Me.Controls.Add(Me.crvshow)
        Me.Name = "frmBill"
        Me.Text = "frmBill"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvshow As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
