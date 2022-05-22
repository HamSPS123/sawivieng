Public Class AddMedicine
    Private Sub AddMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBindingData(txtType, "type", "type_name", "type_id")
        cboBindingData(txtUnit, "unit", "unit_name", "unit_id")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dashboard.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ຢາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStock.Value = 0 Then
            MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນຢາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລາຄາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim sql As String = "INSERT INTO medicine SET mdc_name=@name,type_id=@type,unit_id=@unit,mdc_stock=@stock,expired_date=@date,mdc_price=@price,mdc_detail=@detail"
            Dim val() As Object = {txtName.Text, txtType.SelectedValue, txtUnit.SelectedValue, txtStock.Value, txtExpired.Value, txtPrice.Text, txtDetail.Text}
            Dim pr() As String = {"@name", "@type", "@unit", "@stock", "@date", "@price", "@detail"}
            InsertData(sql, pr, val)
            Medicine.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class