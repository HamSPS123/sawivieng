Public Class frmImport
    Private Sub btnSeachPro_Click(sender As Object, e As EventArgs) Handles btnSeachPro.Click
        SearchProduct.check = "Import"
        SearchProduct.Show()
    End Sub

    Public Sub addCart(proID As String, QTy As Integer, Price As Double)
        Dim dt As New DataTable
        dt = loadingData("SELECT * FROM medicine WHERE mdc_id = '" + proID + "'")

        Dim proName As String
        Dim total_price As Double
        Dim check As Boolean

        If txtPrice.Text = "" Then
            Price = 0
        End If

        If dt.Rows.Count <> 0 Then

            If Price = 0 Then
                MessageBox.Show("ກະລຸນາລອງປ້ອນລາຄານຳເຂົ້າ!!!")
            Else
                proName = dt.Rows(0)(1)
                'Price = dt.Rows(0)(6)
                total_price = Price * QTy


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

                    dgvshow.Rows.Add(proID, proName, Price, QTy, total_price)



                    'dgvshow.Rows.Add(proID, proName, proPrice, QTy, total_price)
                End If

                totalPrice()
                txtProID.Clear()
                txtPrice.Clear()
                txtQTY.Value = 1
            End If

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

    Private Sub btnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        addCart(txtProID.Text, txtQTY.Value, Val(txtPrice.Text))
    End Sub

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")
    End Sub

    Private Sub txtProID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProID.KeyDown
        If e.KeyCode = Keys.Enter Then
            addCart(txtProID.Text, txtQTY.Value, Val(txtPrice.Text))

            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            addCart(txtProID.Text, txtQTY.Value, Val(txtPrice.Text))

            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvshow.Rows.Count = 0 Then
            MessageBox.Show("ກະລຸນາເລືອກສິນຄ້າທີ່ຕ້ອງການສັ່ງຊື້!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Sql = "INSERT INTO tb_import SET emp_id='" + userID + "'"

            'MessageBox.Show(Sql)
            InsertDB(Sql)

            Dim dt As New DataTable
            dt = loadingData("SELECT * FROM tb_import ORDER BY imp_id DESC LIMIT 1")

            If dt.Rows.Count <> 0 Then
                Dim imp_id = dt.Rows(0)(0).ToString

                For i As Integer = 0 To dgvshow.Rows.Count - 1
                    Dim mdc_id = dgvshow.Rows(i).Cells(0).Value.ToString
                    Dim price = dgvshow.Rows(i).Cells(2).Value.ToString
                    Dim qty = dgvshow.Rows(i).Cells(3).Value.ToString
                    InsertDB("INSERT INTO import_detail SET imp_id='" + imp_id + "',mdc_id='" + mdc_id + "',imp_prices='" + price + "',imp_qty='" + qty + "'")
                    InsertDB("UPDATE medicine SET mdc_stock = mdc_stock + " + qty + ", mdc_price = '" + price + "' WHERE mdc_id='" + mdc_id + "'")

                Next




                If MessageBox.Show("ທ່ານຕ້ອງການພິມໃບບິນ ຫຼື ບໍ່?", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'Dim rpt As New ReportDocument
                    Dim report As New rptImport
                    'rpt.Load(report)
                    report.SetParameterValue("imp_id", imp_id)

                    frmRptImport.crvshow.ReportSource = report
                    frmRptImport.crvshow.Refresh()
                    frmRptImport.Show()
                End If
                clear()
            End If
        End If
    End Sub

    Sub clear()

        dgvshow.Rows.Clear()
        txtProID.Clear()
        txtQTY.Value = 1
        txtPrice.Clear()
        txtTotalPrice.Text = 0.ToString("#,##0.00 ກີບ")
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
End Class