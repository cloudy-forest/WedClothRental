create database boutique4
go 
use boutique4
go


--tạo dữ liệu cho login
create table admin(
	adminID varchar(15) primary key,
	adminName varchar(15),
	adminPassword varchar(20),
	adminEmail varchar(50)
)

create table staff(
	staffID varchar(15) primary key,
	staffName varchar(15),
	staffPassword varchar(20),
	staffEmail varchar(50)
)

create table staffChiTiet(
	maStaffChiTiet varchar(15) primary key,
	staffID varchar(15),
	foreign key(staffID) references staff(staffID),
	hoTen nvarchar(100),
	soDienThoai varchar(12),
	email varchar(50),
	diaChi nvarchar(80)
)
select * from admin
select * from staff
select * from staffChiTiet


insert into admin values ('AD001', 'admin', '12345', '@123')

insert into staff values ('ST001', 'staff', '9876', '@987')


--tạo dữ liệu cho sản phẩm 
create table loaiSanPham(
	maLoaiSP varchar(50) primary key,
	tenLoaiSP nvarchar(50)
)

create table sanPham(
	maSanPham varchar(50) primary key,
	tenSanPham nvarchar(50),
	giaThue decimal(18, 2),
	trangThai nvarchar(30),
	soLuong int,
	maLoaiSP varchar(50),
	ngayThem DATE DEFAULT GETDATE(),
	foreign key(maLoaiSP) references loaiSanPham(maLoaiSP)
)

create table Sp(
	--maSanPham varchar(15) primary key,
	tenSanPham nvarchar(50),
	loaiSanPham nvarchar(30),
	mota nvarchar(30),
	giaThue decimal(18, 2)
	--trangThai nvarchar(30),
	--soLuong int,
	--maLoaiSP varchar(15),
	--ngayThem DATE DEFAULT GETDATE(),
	--foreign key(maLoaiSP) references loaiSanPham(maLoaiSP)
)
select * from sanPham
insert into loaiSanPham values
('DM001', N'Váy cưới'),
('DM002', N'Vest')

--tạo bảng để lưu trữ sản phẩm đã xóa
create table sanPhamXoa(
	maSanPham varchar(15),
	tenSanPham nvarchar(50),
	giaThue decimal(18, 2),
	maLoaiSP varchar(15),
	ngayXoa date default getdate(),
	primary key(maSanPham, ngayXoa),
)

select * from sanPham
delete from sanPhamXoa
delete from loaiSanPham
create table khachHang(
	maKhachHang varchar(20) primary key,
	tenKhachHang nvarchar(60),
	emailKhachHang varchar(30),
	soDienThoai varchar(12),
	diaChi nvarchar(70)
)

insert into khachHang values (
	'KH001', 'Jenny', 'jenny@gmail.com', '0123456789', N'123 đường A phường B TP C'
)

create table khachHangXoa(
	maKhachHang varchar(20),
	tenKhachHang nvarchar(60),
	email varchar(30),
	soDienThoai varchar(12),
	diaChi nvarchar(70),
	ngayXoa date default getdate(),
	primary key (maKhachHang, ngayXoa),
)
--chỉ cần tổ hợp khóa chính(maKhachHang, ngayXoa) là giá trị duy nhất thì không lỗi
select * from khachHang
select * from khachHangXoa
delete from khachHangXoa
create table donThue(
	maDonThue varchar(20) primary key,
	maKhachHang varchar(20),
	foreign key(maKhachHang) references khachHang(maKhachHang),
	ngayDat date default getdate(),
	ngayNhan date not null,
	ngayTraDuKien date not null,
	ngayTraThucTe date,
	tienCoc decimal(18, 2) default 0,
	tongTien decimal(18, 2) default 0, --tính từ tổng các thành tiền trong chi tiết đơn thuê
	trangThai nvarchar(50) not null check (trangThai in (N'Đang xử lý', N'Đã xác nhận', N'Đã nhận', N'Đã trả', N'Hoàn thành', N'Hủy')),
	ghiChu nvarchar(600),
	ngayTao datetime default getdate(),
	constraint check_ngayTraDuKien check(ngayTraDuKien >= ngayNhan)
)

insert into donThue(maDonThue, maKhachHang, ngayNhan, ngayTraDuKien, ngayTraThucTe, tienCoc, tongTien, trangThai, ghiChu) values
('DT001', 'KH001', '2025-05-15', '2025-06-15', '2025-06-15', 15000000, 30000000, N'Đang xử lý', '')

insert into donThue(maDonThue, maKhachHang, ngayNhan, ngayTraDuKien, ngayTraThucTe, tienCoc, tongTien, trangThai, ghiChu) values
('DT002', 'KH001', '2025-05-15', '2025-06-15', '2025-06-15', 15000000, 30000000, N'Hoàn thành', '')

select * from donThue
select * from chiTietDonThue
select * from khachHang
delete from donThue
create table chiTietDonThue(
	maChiTietDonThue varchar(20) primary key,
	maDonThue varchar(20),
	maSanPham varchar(50),
	soLuong int not null check (soLuong > 0),
	giaThue decimal(18, 2) not null,
	soNgayThue int not null check (soNgayThue > 0),
	thanhTien as (giaThue * soLuong * soNgayThue) persisted,
	ghiChu nvarchar(600),
	foreign key(maDonThue) references donThue(maDonThue),
	foreign key(maSanPham) references sanPham(maSanPham)
)

insert into chiTietDonThue(maChiTietDonThue, maDonThue, maSanPham, soLuong, giaThue, soNgayThue, ghiChu) values 
('CTDT01', 'DT001', 'SP009', 2, 20000, 3, ''),
('CTDT01', 'DT001', 'SP003', 1, 10000, 5, '')

select * from chiTietDonThue
delete from chiTietDonThue 
drop table chiTietDonThue
go
CREATE TRIGGER trg_UpdateTongTien
ON chiTietDonThue
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE d
    SET d.tongTien = ISNULL((SELECT SUM(thanhTien) 
                            FROM chiTietDonThue c 
                            WHERE c.maDonThue = d.maDonThue), 0)
    FROM donThue d
    WHERE d.maDonThue IN (
        SELECT maDonThue FROM inserted
        UNION
        SELECT maDonThue FROM deleted
    )
END



-- Thêm đơn thuê
INSERT INTO donThue(maDonThue, maKhachHang, ngayNhan, ngayTraDuKien, trangThai) 
VALUES ('DT001', 'KH001', '2023-01-01', '2023-01-10', N'Hoàn thành')

-- Thêm chi tiết đơn thuê (trigger sẽ tự chạy)
INSERT INTO chiTietDonThue(maChiTietDonThue, maDonThue, maSanPham, soLuong, giaThue, soNgayThue)
VALUES ('CTDT001', 'DT001', 'SP010', 2, 100000, 5),
       ('CTDT002', 'DT001', 'SP011', 1, 150000, 3)



SELECT kh.tenKhachHang, kh.soDienThoai, kh.diaChi,
                                           dt.ngayDat, dt.ngayNhan, dt.ngayTraThucTe, dt.tongTien,
                                          ctdt.soLuong, ctdt.giaThue, ctdt.soNgayThue,
                                          sp.tenSanPham 
                                   FROM khachHang kh INNER JOIN donThue dt ON kh.maKhachHang = dt.maKhachHang 
                                                      INNER JOIN chiTietDonThue ctdt ON dt.maDonThue = ctdt.maDonThue 
                                                      INNER JOIN sanPham sp ON ctdt.maSanPham = sp.maSanPham 
                                   WHERE dt.trangThai = N'Hoàn thành'