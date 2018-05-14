Imports QLHocSinh_BUS
Imports QlHocSinh_DAL
Imports QLHocSInh_DTO

Public Class frmNhapHS
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim HS As HocSinhDTO
        HS = New HocSinhDTO


        '1. Mapping data from GUI control
        HS.StrHoTen1 = txtHoTen.Text
        HS.StrGioiTinh1 = txtGioiTinh.Text
        HS.StrDiaChi1 = txtDiaChi.Text
        Dim mydate As DateTime
        mydate = DateTime.ParseExact(txtNgaySinh.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
        HS.dtNgaySinh1 = mydate
        HS.StrLop1 = txtLop.Text


        '2. Business .....
        Dim hsbus As HocSinhBUS
        hsbus = New HocSinhBUS
        If (hsbus.isValidName(HS) = False) Then
            MessageBox.Show("Ho Ten khong dung. vui long kiem tra lai")
            txtHoTen.Focus()
            Return
        End If

        If (hsbus.isValidLop(HS) = False) Then
            MessageBox.Show("Lop khong dung. vui long kiem tra lai")
            txtHoTen.Focus()
            Return
        End If

        If (hsbus.isValidYear(HS) = False) Then
            MessageBox.Show("Ngay sinh khong dung. vui long kiem tra lai")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim hsdal As HocSinhDAL
        hsdal = New HocSinhDAL()
        Dim result As Integer
        result = hsdal.insert(HS)
        If (result = 0) Then
            MessageBox.Show("Them NY thanh cong.")
        Else
            MessageBox.Show("Them  that bai. Vui long kiem tra lai DB!!!")
        End If
    End Sub

End Class