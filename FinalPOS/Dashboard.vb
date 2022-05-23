Public Class Dashboard
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("ເຈົ້າຕ້ອງການປິດໂປຣແກຣມບໍ່", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles item4.Click
        switchPanel(frmImport, "ການນຳເຂົ້າຢາ")
    End Sub
    Sub switchPanel(ByVal panel As Form, title As String)
        pnMain.Controls.Clear()
        panel.TopLevel = False
        pnMain.Controls.Add(panel)
        panel.Show()
        panel.Dock = DockStyle.Fill
        lbTitle.Text = title
    End Sub
    Private Sub item1_Click(sender As Object, e As EventArgs) Handles item1.Click
        switchPanel(Management, "ການຈັດການຂໍ້ມູນ")
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        Dim sidebarWidth As Integer

        sidebarWidth = plSidebar.Size.Width

        If sidebarWidth = 273 Then
            plSidebar.Width = 79
            lbLogo.Text = "SP"
        Else
            plSidebar.Width = 273
            lbLogo.Text = "Sawiveing Pharmacy"
        End If
    End Sub

    Private Sub item2_Click(sender As Object, e As EventArgs) Handles item2.Click
        switchPanel(Sale, "ການຂາຍສິນຄ້າ")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userID <> "" And userName <> "" Then
            lbuser.Text = userName
        End If
    End Sub

    Private Sub item3_Click(sender As Object, e As EventArgs) Handles item3.Click
        switchPanel(frmPurchase, "ການສັ່ງຊື້ສິນຄ້າ")
    End Sub
End Class