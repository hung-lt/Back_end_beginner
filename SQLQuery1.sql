
-- Tao Database
CREATE DATABASE QLNhanSu
GO
USE QLNhanSu
GO

-- Tao bang PhongBan
CREATE TABLE PhongBan
(
	MaPhong VARCHAR(20) PRIMARY KEY,
	TenPhong NVARCHAR(100) NOT NULL,
	DienTHoai VARCHAR(15)
)

-- Tao bang NhanVien
GO
CREATE TABLE NhanVien
(
	MaNV VARCHAR(20) PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	DienThoai NVARCHAR(15),
	DiaChi NVARCHAR(200),
	MaPhong VARCHAR(20) FOREIGN KEY REFERENCES PhongBan(MaPhong)
)

--Them du lieu vao bang PhongBan
USE QLNhanSu;
GO
INSERT INTO PhongBan VALUES('P01',N'Ky thuat','0243286483')