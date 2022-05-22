Public Class frmPurchase
    Private Sub frmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBindingData(txtSupplier, "supplier", "sup_name", "sup_id")
        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")
    End Sub

    Private Sub txtProID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProID.KeyDown
        If e.KeyCode = Keys.Enter Then
            addCart(txtProID.Text, txtQTY.Value)
        End If
    End Sub

    Public Sub addCart(proID As String, QTy As Integer)
        Dim dt As New DataTable
        dt = loadingData("SELECT * FROM medicine WHERE mdc_id = '" + proID + "'")

        Dim proName As String
        Dim proPrice As Double
        Dim total_price As Double
        Dim check As Boolean

        If dt.Rows.Count <> 0 Then

            proName = dt.Rows(0)(1)
            proPrice = dt.Rows(0)(6)
            total_price = proPrice * QTy


            'MessageBox.Show("ຈຳນວນໃນສະຕ໋ອກຕົວຈິງບໍ່ຊອດຄອງກັບຈຳນວນທີ່ທ່ານປ້ອນ ກະລຸນາລອງໃໝ່ອີກຄັ້ງ!!!")
            'Else
            Dim eRow As Integer
            For i As Integer = 0 To dgvshow.Rows.Count - 1
                If dgvshow.Item(0, i).Value.ToString = proID Then
                    eRow = i
                    check = True
                    Exit For
                Else
                    check = False
                End If
            Next

            If check = True Then
                'MessageBox.Show("ສິນຄ້ານີ້ມີແລ້ວ")

                QTy += dgvshow.Item(3, eRow).Value
                total_price += dgvshow.Item(4, eRow).Value

                
                    dgvshow.Item(3, eRow).Value = QTy
                    dgvshow.Item(4, eRow).Value = total_price


                'MessageBox.Show(QTy.ToString + " " + total_price.ToString)
            Else

                dgvshow.Rows.Add(proID, proName, proPrice, QTy, total_price)



                'dgvshow.Rows.Add(proID, proName, proPrice, QTy, total_price)
            End If

            totalPrice()

        Else
            MessageBox.Show("ລະຫັດສິນຄ້ານີ້ບໍ່ມີໃນລະບົບກະລຸນາລອງໃໝ່", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub totalPrice()
        Dim sum As Double
        For i As Integer = 0 To dgvshow.Rows.Count - 1
            sum += dgvshow.Rows(i).Cells(4).Value
        Next

        txtTotalPrice.Text = sum.ToString("#,##0.00 ກີບ")

    End Sub

    Private Sub btnSeachPro_Click(sender As Object, e As EventArgs) Handles btnSeachPro.Click
        SearchProduct.check = "Purchase"
        SearchProduct.Show()
    End Sub

    Private Sub btnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        If txtProID.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສິນຄ້າ", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            addCart(txtProID.Text, txtQTY.Value)
        End If
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim cindex As Integer = dgvshow.CurrentRow.Index

            'MessageBox.Show(cindex)
            If MessageBox.Show("ທ່ານຕ້ອງການລົບລາຍການນີ້ຫຼືບໍ່?", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgvshow.Rows.Remove(dgvshow.Rows(cindex))
                totalPrice()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvshow.Rows.Count = 0 Then
            MessageBox.Show("ກະລຸນາເລືອກສິນຄ້າທີ່ຕ້ອງການສັ່ງຊື້!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Sql = "INSERT INTO purchase SET emp_id='" + userID + "', sup_id='" + txtSupplier.SelectedValue.ToString + "'"

            'MessageBox.Show(Sql)
            InsertDB(Sql)

            Dim dt As New DataTable
            dt = loadingData("SELECT * FROM purchase ORDER BY pch_id DESC LIMIT 1")

            If dt.Rows.Count <> 0 Then
                Dim pch_id = dt.Rows(0)(0)

                For i As Integer = 0 To dgvshow.Rows.Count - 1
                    Dim mdc_id = dgvshow.Rows(i).Cells(0).Value
                    Dim price = dgvshow.Rows(i).Cells(2).Value
                    Dim qty = dgvshow.Rows(i).Cells(3).Value
                    InsertDB("INSERT INTO purchase_detail SET pch_id='" + pch_id.ToString + "',mdc_id='" + mdc_id.ToString + "',pd_price='" + price.ToString + "',pd_qty='" + qty.ToString + "'")
                    'InsertDB("UPDATE medicine SET mdc_stock = mdc_stock - " + qty + " WHERE mdc_id='" + mdc_id + "'")
                Next




                If MessageBox.Show("ທ່ານຕ້ອງການພິມໃບບິນ ຫຼື ບໍ່?", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'Dim rpt As New ReportDocument
                    Dim report As New rptPurchase
                    'rpt.Load(report)
                    report.SetParameterValue("pch_id", pch_id)

                    frmRptPurchase.crvShow.ReportSource = report
                    frmRptPurchase.crvShow.Refresh()
                    frmRptPurchase.Show()
                End If
                clear()
            End If
        End If
    End Sub

    Sub clear()

        dgvshow.Rows.Clear()
        txtProID.Clear()
        txtQTY.Value = 1
        txtTotalPrice.Text = 0.ToString("#,##0.00 ກີບ")
    End Sub
End Class