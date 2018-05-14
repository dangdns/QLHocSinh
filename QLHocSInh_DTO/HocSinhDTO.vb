Public Class HocSinhDTO
    Dim strHoTen As String
    Dim dtNgaySinh As Date
    Dim strGioiTinh As String
    Dim strDiaChi As String
    Dim strLop As String

    Public Property StrHoTen1 As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property dtNgaySinh1 As Date
        Get
            Return dtNgaySinh
        End Get
        Set(value As Date)
            dtNgaySinh = value
        End Set
    End Property

    Public Property StrGioiTinh1 As String
        Get
            Return strGioiTinh
        End Get
        Set(value As String)
            strGioiTinh = value
        End Set
    End Property

    Public Property StrDiaChi1 As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property StrLop1 As String
        Get
            Return strLop
        End Get
        Set(value As String)
            strLop = value
        End Set
    End Property
End Class
