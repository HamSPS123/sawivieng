Public Class Management
    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        switchPanel(Employee, "ຈັດການຂໍ້ມູນພະນັກງານ")
    End Sub

    Sub switchPanel(ByVal panel As Form, title As String)
        Dashboard.pnMain.Controls.Clear()
        panel.TopLevel = False
        Dashboard.pnMain.Controls.Add(panel)
        panel.Show()
        panel.Dock = DockStyle.Fill
        Dashboard.lbTitle.Text = title
    End Sub

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        switchPanel(Customer, "ຈັດການຂໍ້ມູນລູກຄ້າ")
    End Sub

    Private Sub btnMed_Click(sender As Object, e As EventArgs) Handles btnMed.Click
        switchPanel(Medicine, "ຈັດການຂໍ້ມູນຢາ")
    End Sub

    Private Sub btnSup_Click(sender As Object, e As EventArgs) Handles btnSup.Click
        switchPanel(Supplier, "ຈັດການຂໍ້ມູນຜູ້ສະໜອງ")
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        switchPanel(Type, "ຈັດການຂໍ້ມູນປະເພດ")
    End Sub

    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        switchPanel(Unit, "ຈັດການຂໍ້ມູນຫົວໜ່ວຍ")
    End Sub
End Class