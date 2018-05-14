Imports System.Data.SqlClient
Imports QLHocSInh_DTO
Imports Utility

Public Class HocSinhDAL
    Public Function insert(hs As HocSinhDTO) As Integer


        Dim query As String = String.Empty
        query &= "INSERT INTO HocSinh (HoTen, GioiTinh, NgaySinh, DiaChi, Lop)"
        query &= "VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @Lop)"

        Using conn As New SqlConnection("Data Source=DESKTOP-Q75A6S2;Initial Catalog=QLHocSinh;Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@HoTen", hs.StrHoTen1)
                    .Parameters.AddWithValue("@GioiTinh", hs.StrGioiTinh1)
                    .Parameters.AddWithValue("@NgaySinh", hs.dtNgaySinh1)
                    .Parameters.AddWithValue("@DiaChi", hs.StrDiaChi1)
                    .Parameters.AddWithValue("@Lop", hs.StrLop1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return 1
                End Try
            End Using
        End Using
        Return 0
    End Function
End Class
