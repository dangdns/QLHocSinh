Imports QLHocSInh_DTO

Public Class HocSinhBUS
    Public Function isValidName(hs As HocSinhDTO) As Boolean
        If (hs.StrHoTen1.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidYear(hs As HocSinhDTO) As Boolean
        Dim zeroTime As DateTime
        zeroTime = New DateTime(1, 1, 1)
        Dim Datepast As TimeSpan
        Datepast = DateTime.Today - hs.dtNgaySinh1
        Dim Tuoi As Integer
        Tuoi = (zeroTime + Datepast).Year - 1
        If (Tuoi < 15 Or Tuoi > 20) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidLop(hs As HocSinhDTO) As Boolean
        If (hs.StrLop1 Like "?1??" Or hs.StrLop1 Like "?2??" Or hs.StrLop1 Like "?0??") Then

            If (hs.StrLop1 Like "1??1" Or hs.StrLop1 Like "1??2" Or hs.StrLop1 Like "1??3" Or hs.StrLop1 Like "1??4" Or hs.StrLop1 Like "1??5" Or hs.StrLop1 Like "10?6" Or hs.StrLop1 Like "10?7" Or hs.StrLop1 Like "10?8" Or hs.StrLop1 Like "11?6" Or hs.StrLop1 Like "11?7") Then
                Return True
            End If
        End If

        Return False
    End Function
End Class
