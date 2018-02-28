create table SACH
(
	MaSach nvarchar(10) primary key,
	TenSach nvarchar(150),
	TacGia nvarchar(150),
	NgayXuatBan datetime,
	MaNhaXuatBan nvarchar(10),
	HinhAnh image,
	foreign key (MaNhaXuatBan) references NHAXUATBAN(MaNhaXuatBan)
)

create table NHAXUATBAN
(
	MaNhaXuatBan nvarchar(10) primary key,
	TenNhaXuatBan nvarchar(150),
	Sdt nvarchar(15),
	DiaChi nvarchar(150)
)

create table THELOAI
(
	MaLoaiSach nvarchar(10) primary key,
	TenTheLoai nvarchar(150)
)

create table LOAISACH
(
	MaSach nvarchar(10),
	MaLoaiSach nvarchar(10),
	primary key(MaSach,MaLoaiSach),
	foreign key (MaSach) references SACH(MaSach),
	foreign key (MaLoaiSach) references THELOAI(MaLoaiSach)
)

