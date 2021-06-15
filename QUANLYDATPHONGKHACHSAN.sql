create database QUANLYDATPHONGKHACHSAN
use quanlydatphongkhachsan

create table NGUOIDUNG(TaiKhoan varchar(50) not null primary key,MatKhau varchar(50) not null ,Makhach varchar(5) not null,
TenKhachHang varchar(50) not null, Email varchar(50) not null, SoDienThoai int not null )

create table PHONG(MaPhong varchar(5) not null primary key, LoaiPhong char(20) not null, SoGiuong int not null, DonGia int not null)
insert into PHONG (MaPhong, LoaiPhong, SoGiuong, DonGia)
values ('S9001', 'Suite(SUT)','2', '900'),
('S9002', 'Suite(SUT)','1', '800'),
('S9003', 'Suite(SUT)','1', '800'),
('A8001', 'Deluxe(DLX)','2', '700'),
('A8002', 'Deluxe(DLX)','2', '700'),
('A8003', 'Deluxe(DLX)','1', '600'),
('B7001', 'Superior (SUP)','2', '500'),
('B6001', 'Superior (SUP)','1', '400'),
('B7002', 'Superior (SUP)','1', '400'),
('C5001', 'Standard (STD)','2', '300'),
('C4001', 'Standard (STD)','2', '300'),
('C4002', 'Standard (STD)','1', '200')

create table KhachHang(MaKhach varchar(5) not null primary key, TenKhachHang varchar(50) not null, DiaChi varchar(50) not null,
Email varchar(50) not null, SoDienThoai int not null, GioiTinh bit not null)

create table DONDATPHONG (MaDonDatPhong varchar(5) not null primary key, MaPhong varchar(5) not null, MaKhach varchar(5) not null,
NgayDen date not null,NgayDi date not null, HuyDon bit not null, ThoiGianThue int, TienPhong int)
