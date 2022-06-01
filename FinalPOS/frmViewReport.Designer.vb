<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReport
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
        Me.crvShow = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvShow
        '
        Me.crvShow.ActiveViewIndex = -1
        Me.crvShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvShow.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvShow.Location = New System.Drawing.Point(0, 0)
        Me.crvShow.Name = "crvShow"
        Me.crvShow.Size = New System.Drawing.Size(1089, 766)
        Me.crvShow.TabIndex = 0
        '
        'frmViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 766)
        Me.Controls.Add(Me.crvShow)
        Me.Name = "frmViewReport"
        Me.Text = "frmViewReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvShow As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
