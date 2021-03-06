/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLHocSinh')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNY') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLHocSinh]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLHocSinh]
GO

USE [QLHocSinh]
GO

/****** Object:  Table [dbo].[HocSinh]    Script Date: 4/19/2018 7:02:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HocSinh](
	[HoTen] [nchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[NgaySinh] [datetime2](7) NULL,
	[DiaChi] [nchar](50) NULL,
	[Lop] [nchar](10) NULL
) ON [PRIMARY]

GO
