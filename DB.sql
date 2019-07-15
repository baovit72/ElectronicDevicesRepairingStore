CREATE DATABASE REPAIRINGSTORE
GO
USE REPAIRINGSTORE
GO

CREATE TABLE NHANHIEU
(
	MaNhanHieu int not null identity primary key,
	TenNhanHieu nvarchar(50), 
)
 GO
CREATE TABLE THIETBISUACHUA
(
	MaThietBi integer not null identity primary key,
	TenThietBi nvarchar(50),
	Model varchar(50), 
	MaNhanHieu int references NHANHIEU(MaNhanHieu)
)
GO
CREATE TABLE KHACHHANG
(
	MaKhachHang integer not null identity primary key,
	HoTen nvarchar(50),
	SoDienThoai varchar(50),
	DiaChi nvarchar(50)
)
GO
CREATE TABLE YEUCAUSUACHUA
(
	MaYeuCau integer not null identity primary key,
	MaKH int references KHACHHANG(MaKhachHang) ,
	NgayNhan Date,
	MaMonHang int references THIETBISUACHUA(MaThietBi),
	SoLuong int,
	MoTaTinhTrang nvarchar(300),
	DaSuaChua int ,-- 0 not repaired, 1 repaired
	ChiTiet nvarchar(100)
)

GO
/*CREATE TABLE NHAPTHIETBI
(
	MaNhap int not null identity primary key,
	MaYeuCau int references YEUCAUSUACHUA(MaYeuCau),
	NgayNhap date
)


GO*/
CREATE TABLE NHAPTHIETBI
(
	MaNhap int not null identity primary key,
	MaYeuCau int references YEUCAUSUACHUA(MaYeuCau), 
	TenThietBi nvarchar(50),
	SoLuong int,
	DonGia int
	NgayNhap date,
)
 
GO
CREATE TABLE SUACHUA
(
	MaSuaChua int not null identity primary key,
	MaYeuCau int references YEUCAUSUACHUA(MaYeuCau),
	NgayLap date,
	TienCong int,
	MoTaLoi nvarchar(300)
)


--Lấy thông tin chi tiết yêu cầu
select y.MaYeuCau, TenThietBi,  NgayNhan, TenNhanHieu, Model, HoTen, SoDienThoai, DiaChi, DaSuaChua, SoLuong, MoTaTinhTrang, ChiTiet, TienCong, MoTaLoi
from YEUCAUSUACHUA y
inner join KHACHHANG k
on y.MaKH = k.MaKhachHang
join THIETBISUACHUA t
on y.MaMonHang = t.MaThietBi
join NHANHIEU n
on t.MaNhanHieu = n.MaNhanHieu
left join SUACHUA s
on s.MaYeuCau = y.MaYeuCau


--Lấy danh sách thiết bị được nhập cho yêu cầu nào đó
select * 
from NHAPTHIETBI
where MaYeuCau = 0