Public Class Reports
    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        switchPanel(viewEmployee, "ລາຍງານຂໍ້ມູນພະນັກງານ")
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
        switchPanel(viewCustomer, "ລາຍງານຂໍ້ມູນລູກຄ້າ")
    End Sub

    Private Sub btnSup_Click(sender As Object, e As EventArgs) Handles btnSup.Click
        switchPanel(viewSupplier, "ລາຍງານຂໍ້ມູນຜູ້ສະໜອງ")
    End Sub

    Private Sub btnMed_Click(sender As Object, e As EventArgs) Handles btnMed.Click
        switchPanel(viewMedicine, "ລາຍງານຂໍ້ມູນຢາ")
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        switchPanel(viewType, "ລາຍງານຂໍ້ມູນປະເພດຢາ")
    End Sub

    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        switchPanel(viewSale, "ລາຍງານຂໍ້ມູນການຂາຍ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(viewPurchase, "ລາຍງານຂໍ້ມູນການສັ່ງຊື້")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(viewImport, "ລາຍງານຂໍ້ມູນການນຳເຂົ້າ")
    End Sub
End Class