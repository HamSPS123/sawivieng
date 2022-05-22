Public Class EditCard

    Public proID As String
    Public QTY As Integer
    Public proPrice As Double
    Public total As Double
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProID.Text = proID
        txtQTY.Value = QTY
        txtPrice.Text = proPrice.ToString("#,##0.## ກີບ")
        txtTotalPrice.Text = total.ToString("#,##0.## ກີບ")
    End Sub

    Private Sub txtQTY_ValueChanged(sender As Object, e As EventArgs) Handles txtQTY.ValueChanged
        QTY = txtQTY.Value
        total = QTY * proPrice
        txtTotalPrice.Text = total.ToString("#,##0.## ກີບ")
    End Sub
End Class