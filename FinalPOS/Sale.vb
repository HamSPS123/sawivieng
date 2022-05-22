Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class Sale
    Private Sub btnSeachPro_Click(sender As Object, e As EventArgs) Handles btnSeachPro.Click
        SearchProduct.Show()
    End Sub

    Dim total As Double = 0
    Dim pay As Double = 0
    Dim change As Double = 0
    Dim discount As Double = 0
    Dim cost As Double = 0

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

                If QTy > dt.Rows(0)(4) Then
                    MessageBox.Show("ຈຳນວນໃນສະຕ໋ອກຕົວຈິງບໍ່ຊອດຄອງກັບຈຳນວນທີ່ທ່ານປ້ອນ ກະລຸນາລອງໃໝ່ອີກຄັ້ງ!!!")
                Else
                    dgvshow.Item(3, eRow).Value = QTy
                    dgvshow.Item(4, eRow).Value = total_price
                End If

                'MessageBox.Show(QTy.ToString + " " + total_price.ToString)
            Else
                If QTy > dt.Rows(0)(4) Then
                    MessageBox.Show("ຈຳນວນໃນສະຕ໋ອກຕົວຈິງບໍ່ຊອດຄອງກັບຈຳນວນທີ່ທ່ານປ້ອນ ກະລຸນາລອງໃໝ່ອີກຄັ້ງ!!!")
                Else
                    dgvshow.Rows.Add(proID, proName, proPrice, QTy, total_price)
                End If


                'dgvshow.Rows.Add(proID, proName, proPrice, QTy, total_price)
            End If

            totalPrice()

        Else
            MessageBox.Show("ລະຫັດສິນຄ້ານີ້ບໍ່ມີໃນລະບົບກະລຸນາລອງໃໝ່", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub FormatBox()
        txtTotalPrice.Text = total.ToString("#,##0.00 ກີບ")
        txtPay.Text = pay.ToString("#,##0.00 ກີບ")
        txtChange.Text = change.ToString("#,##0.00 ກີບ")
        txtDiscount.Text = discount.ToString("#,##0.00 ກີບ")
    End Sub

    Sub totalPrice()
        Dim sum As Double
        For i As Integer = 0 To dgvshow.Rows.Count - 1
            sum += dgvshow.Rows(i).Cells(4).Value
        Next
        total = sum

        'txtTotalPrice.Text = total.ToString("#,##0.00 ກີບ")
        FormatBox()
    End Sub

    Private Sub Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")

        'txtTotalPrice.Text = total_price.ToString("#,##0.00 ກີບ")

        FormatBox()

    End Sub

    Private Sub btnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        If txtProID.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສິນຄ້າ", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            addCart(txtProID.Text, txtQTY.Value)
        End If

        'MessageBox.Show(dgvshow.Rows.Count)
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

    Private Sub txtProID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProID.Text = "" Then
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສິນຄ້າ", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                addCart(txtProID.Text, txtQTY.Value)
            End If

            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtCusID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCusID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCusID.Text = "" Then
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດລູກຄ້າ", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                addCus(txtCusID.Text)
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Public Sub addCus(cusID As String)
        Dim dt As DataTable
        dt = loadingData("SELECT * FROM customer WHERE cus_id = '" + cusID + "'")
        If dt.Rows.Count <> 0 Then
            lbCus.Text = dt.Rows(0)(1).ToString
            lbCus.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
            lbCus.ForeColor = System.Drawing.Color.Green
            Label8.ForeColor = System.Drawing.Color.Green
            lbCus.Visible = True
            Label8.Visible = True
        Else
            MessageBox.Show("ລະຫັດລູກຄ້າບໍ່ຖືກຕ້ອງ ກະລຸນາລອງໃໝ່", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lbCus.Text = "ກະລຸນາລອງໃໝ່"
            lbCus.BackColor = System.Drawing.Color.FromArgb(255, 192, 192)
            lbCus.ForeColor = System.Drawing.Color.Maroon
            Label8.ForeColor = System.Drawing.Color.Maroon
            lbCus.Visible = True
            Label8.Visible = True
        End If
    End Sub

    Private Sub btnSearchCus_Click(sender As Object, e As EventArgs) Handles btnSearchCus.Click
        SearchCustomer.Show()
    End Sub



    Private Sub txtPay_Enter(sender As Object, e As EventArgs) Handles txtPay.Enter
        If pay = 0 Then
            txtPay.Clear()
        Else
            txtPay.Text = pay
        End If
    End Sub

    Private Sub txtDiscount_Enter(sender As Object, e As EventArgs) Handles txtDiscount.Enter
        If discount = 0 Then
            txtDiscount.Clear()
        Else
            txtDiscount.Text = discount
        End If
    End Sub

    Private Sub txtPay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPay.KeyDown
        If e.KeyCode = Keys.Enter Then

            pay = Val(txtPay.Text)

            cost = total - discount
            change = pay - cost

            txtCost.Text = cost.ToString("#,##0.00 ກີບ")

            FormatBox()

            e.Handled = True
            e.SuppressKeyPress = True


        End If
    End Sub

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            discount = Val(txtDiscount.Text)

            cost = total - discount

            change = pay - cost
            txtCost.Text = cost.ToString("#,##0.00 ກີບ")
            FormatBox()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If pay < cost Or pay = 0 Then
            MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນເງິນໃຫ້ຖືກຕ້ອງ!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim Sql = "INSERT INTO sale SET emp_id='" + userID + "', cus_id='" + txtCusID.Text + "', sale_pay='" + pay.ToString + "', sale_discount='" + discount.ToString + "'"

            'MessageBox.Show(Sql)
            InsertDB(Sql)

            Dim dt As New DataTable
            dt = loadingData("SELECT * FROM SALE ORDER BY sale_id DESC LIMIT 1")

            If dt.Rows.Count <> 0 Then
                Dim sale_id = dt.Rows(0)(0)

                For i As Integer = 0 To dgvshow.Rows.Count - 1
                    Dim mdc_id = dgvshow.Rows(i).Cells(0).Value
                    Dim price = dgvshow.Rows(i).Cells(2).Value
                    Dim qty = dgvshow.Rows(i).Cells(3).Value
                    InsertDB("INSERT INTO sale_detail SET sale_id='" + sale_id.ToString + "',mdc_id='" + mdc_id.ToString + "',sd_price='" + price.ToString + "',sd_qty='" + qty.ToString + "'")
                Next


                If MessageBox.Show("ທ່ານຕ້ອງການພິມໃບບິນ ຫຼື ບໍ່?", "ຄຳຖາມ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    'Dim rpt As New ReportDocument
                    Dim report As New rptBill
                    'rpt.Load(report)
                    report.SetParameterValue("sale_id", sale_id)

                    frmBill.crvshow.ReportSource = report
                    frmBill.crvshow.Refresh()
                    frmBill.Show()
                End If
                clear()
            End If
        End If
    End Sub

    Sub clear()
        total = 0
        pay = 0
        change = 0
        discount = 0
        cost = 0
        FormatBox()

        dgvshow.Rows.Clear()
        txtProID.Clear()
        txtQTY.Value = 1
        txtCusID.Clear()
        lbCus.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        searchSale.Show()
    End Sub
End Class