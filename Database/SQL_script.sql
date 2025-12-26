create table NGUOI_DUNG
(
	Ten varchar(100) primary key,
	Matkhau varchar(100) not null,
	Email varchar(100) not null,
);
create table HANG_HOA
(
	MaHH varchar(500) primary key,
	Ten nvarchar(200) not null,
	Loai nvarchar(100),
	Gia_tien decimal(15,2),
	So_luong int,
	Ngay_nhap_kho datetime default getdate(),
	Ngay_xuat_kho datetime,
	Tinh_trang nvarchar(20),
);
