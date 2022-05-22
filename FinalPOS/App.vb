Imports System.IO
Imports MySql.Data.MySqlClient

Module App
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim conStr = "server=localhost;userid=root;password=;database=sawiveing_pharmacy;Convert Zero Datetime=True"

    Public userID As String
    Public userName As String

    Public curDir As String = Directory.GetCurrentDirectory()


    Private Sub checkconn()
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = conStr
            .Open()
        End With
    End Sub

    Friend Function loadingData(sql As String) As DataTable
        checkconn()
        Dim dt As New DataTable

        Try
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            dt.Load(dr)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dt
    End Function

    Friend Sub InsertData(sql As String, para() As String, val() As Object)
        checkconn()
        Try
            cmd = New MySqlCommand(sql, conn)
            For i = 0 To para.Length - 1
                cmd.Parameters.AddWithValue(para(i), val(i))
            Next
            cmd.ExecuteNonQuery()

            MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ", "ຜົນຮັບ", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend Sub UpdateData(sql As String, para() As String, val() As Object)
        checkconn()
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນຫຼືບໍ່", "Question",
                         MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New MySqlCommand(sql, conn)
                For i = 0 To para.Length - 1
                    cmd.Parameters.AddWithValue(para(i), val(i))
                Next
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend Sub DeleteData(tb As String, id As String, val As String)
        checkconn()
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນຫຼືບໍ່", "Question",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New MySqlCommand("delete from " + tb + " where " + id + "=@id", conn)
                cmd.Parameters.AddWithValue("@id", val)
                cmd.ExecuteNonQuery()

                MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend Sub setHeaderText(dgv As DataGridView, strh() As String)
        For i = 0 To strh.Length - 1
            dgv.Columns(i).HeaderText = strh(i)
        Next
    End Sub

    Friend Sub cboBindingData(cbo As ComboBox, tbn As String, cold As String, colVa As String)
        cbo.DataSource = loadingData("select * from " + tbn)
        cbo.DisplayMember = cold
        cbo.ValueMember = colVa
    End Sub

    Friend Sub AddButtonToGrid(btn As DataGridViewButtonColumn, dgv As DataGridView, header As String, name As String, text As String)

        btn.HeaderText = header
        btn.Name = name
        btn.Text = text
        btn.FlatStyle = FlatStyle.Popup
        If header = "ແກ້ໄຂ" Then
            btn.CellTemplate.Style.BackColor = System.Drawing.Color.FromArgb(255, 193, 7)
        Else
            btn.CellTemplate.Style.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        End If

        btn.CellTemplate.Style.ForeColor = System.Drawing.Color.White
        btn.Width = 65


        btn.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btn)
    End Sub

    Friend Sub InsertDB(sql As String)
        checkconn()
        Try
            cmd = New MySqlCommand(sql, conn)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
