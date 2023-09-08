create database bstore;
use bstore
go
DROP DATABASE bstore;

-- Create the TheLoaiSach table
CREATE TABLE [dbo].[TheLoaiSach](
	[MaTheLoai] [char](5) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
));

-- Create the Sach table
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](6) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[MaTheLoai] [char](5) NOT NULL,
	[TacGia] [nvarchar](200) NULL,
	[SoLuongTon] [int] NOT NULL,
	[DonGia] [money] NULL,
	[NamXuatBan] [int] NULL,
	[NhaXuatBan] [nvarchar](100) NULL,
	[SoTrang] [int] NULL,
	[MoTa] [nvarchar](1000) NULL,
	[AnhBia] [image] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
),
 CONSTRAINT [FK_Sach_TheLoaiSach] FOREIGN KEY ([MaTheLoai]) REFERENCES [dbo].[TheLoaiSach]([MaTheLoai])
);

-- Create the NhanVien table
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](6) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[ChucVu] [int] NOT NULL,
	[MatKhau] [char](32) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
));

-- Create the KhachHang table
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [char](6) NOT NULL,
	[HoTenKH] [nvarchar](100) NOT NULL,
	[SoDienThoai] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Email] [nvarchar](50) NULL,
	[SoTienNo] [money] NOT NULL,
	[TongTien] [money] NOT NULL,
	[NgayMuaCuoi] [date] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
));

-- Create the HoaDon table
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](6) NOT NULL,
	[MaKhachHang] [char](6) NOT NULL,
	[MaNhanVien] [char](6) NOT NULL,
	[NgayHoaDon] [date] NOT NULL,
	[GiamGia] [money] NOT NULL,
	[TienKhachDaTra] [money] NOT NULL,
	[TienKhachDua] [money] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
),
 CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang]([MaKhachHang]),
 CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
);

-- Create the PhieuThu table
CREATE TABLE [dbo].[PhieuThu](
	[MaPhieuThu] [char](10) NOT NULL,
	[MaKhachHang] [char](6) NOT NULL,
	[MaNhanVien] [char](6) NULL,
	[NgayThu] [date] NOT NULL,
	[SoTienThu] [money] NOT NULL,
	[LyDoThu] [nvarchar](200) NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
),
 CONSTRAINT [FK_PhieuThu_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang]([MaKhachHang]),
 CONSTRAINT [FK_PhieuThu_NhanVien] FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
);

-- Create the PhieuNhapSach table
CREATE TABLE [dbo].[PhieuNhapSach](
	[MaPhieuNhapSach] [char](6) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[MaNhanVien] [char](6) NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapSach] ASC
),
 CONSTRAINT [FK_PhieuNhapSach_NhanVien] FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
);

-- Create the ChiTietPhieuNhapSach table
CREATE TABLE [dbo].[ChiTietPhieuNhapSach](
	[MaChiTietPhieuNhapSach] [char](10) NOT NULL,
	[MaPhieuNhapSach] [char](6) NOT NULL,
	[MaSach] [char](6) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhapSach] ASC
),
 CONSTRAINT [FK_ChiTietPhieuNhapSach_PhieuNhapSach] FOREIGN KEY ([MaPhieuNhapSach]) REFERENCES [dbo].[PhieuNhapSach]([MaPhieuNhapSach]),
 CONSTRAINT [FK_ChiTietPhieuNhapSach_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach]([MaSach])
);

-- Create the ChiTietHoaDon table
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [char](10) NOT NULL,
	[MaHoaDon] [char](6) NOT NULL,
	[MaSach] [char](6) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[DonGiaBan] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
),
 CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon]([MaHoaDon]),
 CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach]([MaSach])
);

-- Create the BaoCaoTon table
CREATE TABLE [dbo].[BaoCaoTon](
	[MaBaoCaoTon] [char](6) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
 CONSTRAINT [PK_BaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
));

-- Create the ChiTietBaoCaoTon table
CREATE TABLE [dbo].[ChiTietBaoCaoTon](
	[MaChiTietBaoCaoTon] [char](10) NOT NULL,
	[MaBaoCaoTon] [char](6) NULL,
	[MaSach] [char](6) NULL,
	[TonDau] [int] NULL,
	[TonCuoi] [int] NULL,
	[PhatSinh] [int] NULL,
 CONSTRAINT [PK_ChiTietBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCaoTon] ASC
),
 CONSTRAINT [FK_ChiTietBaoCaoTon_BaoCaoTon] FOREIGN KEY ([MaBaoCaoTon]) REFERENCES [dbo].[BaoCaoTon]([MaBaoCaoTon]),
 CONSTRAINT [FK_ChiTietBaoCaoTon_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach]([MaSach])
);

-- Create the BaoCaoCongNo table
CREATE TABLE [dbo].[BaoCaoCongNo](
	[MaBaoCaoCongNo] [char](6) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
 CONSTRAINT [PK_BaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoCongNo] ASC
));

-- Create the ChiTietBaoCaoCongNo table
CREATE TABLE [dbo].[ChiTietBaoCaoCongNo](
	[MaChiTietBaoCaoCongNo] [char](10) NOT NULL,
	[MaBaoCaoCongNo] [char](6) NULL,
	[MaKhachHang] [char](6) NULL,
	[NoDau] [money] NULL,
	[NoCuoi] [money] NULL,
	[PhatSinh] [money] NULL,
 CONSTRAINT [PK_ChiTietBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCaoCongNo] ASC
),
 CONSTRAINT [FK_ChiTietBaoCaoCongNo_BaoCaoCongNo] FOREIGN KEY ([MaBaoCaoCongNo]) REFERENCES [dbo].[BaoCaoCongNo]([MaBaoCaoCongNo]),
 CONSTRAINT [FK_ChiTietBaoCaoCongNo_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang]([MaKhachHang])
);

-- Create the ThamSo table
CREATE TABLE [dbo].[ThamSo](
	[MaThamSo] [char](5) NOT NULL,
	[TenThamSo] [varchar](100) NULL,
	[GiaTri] [int] NOT NULL,
 CONSTRAINT [PK_ThamSo] PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
));
