create database QUANLYDATPHONGKHACHSAN
use QUANLYDATPHONGKHACHSAN

create table NGUOIDUNG(TaiKhoan varchar(50) not null primary key,MatKhau varchar(50) not null)
insert into NGUOIDUNG(TaiKhoan, MatKhau)
values ('tranhoaiviet','tranhoaiviet'),
('vothitotrinh','vothitotrinh')

create table PHONG(MaPhong varchar(5) not null primary key, MaLoaiPhong varchar(5) not null, TenPhong varchar(10) not null, MoTaPhong nvarchar(1000) not null , TrangThai bit not null)
insert into PHONG (MaPhong, MaLoaiPhong, TenPhong, MoTaPhong, TrangThai)
values ('SS901', 'S1001', 'Phong 901', 'Phòng Suite có khu vực sảnh tiếp khách riêng biệt với hướng nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại bật nhất với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.' ,0),
('SS902', 'S1001', 'Phong 902', 'Phòng Suite có khu vực sảnh tiếp khách riêng biệt với hướng nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại bật nhất với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.',0),
('SS903', 'S1001', 'Phong 903', 'Phòng Suite có khu vực sảnh tiếp khách riêng biệt với hướng nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại bật nhất với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.',0),
('SS904', 'S1001', 'Phong 904', 'Phòng Suite có khu vực sảnh tiếp khách riêng biệt với hướng nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại bật nhất với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.',0),
('AA801', 'A1001', 'Phong 801', 'Phòng Executive có tầm nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('AA802', 'A1001', 'Phong 802', 'Phòng Executive có tầm nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('AA803', 'A1002', 'Phong 803', 'Phòng Executive có tầm nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('AA804', 'A1002', 'Phong 804', 'Phòng Executive có tầm nhìn bao quát toàn cảnh thành phố và bãi biển Đà Nẵng, có ban công sưởi nắng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng với tất cả các quyền lợi kèm theo, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, miễn phí các cuộc gọi địa phương, quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('BB701', 'B1001', 'Phong 701', 'Phòng Deluxe có ban công với tầm nhìn toàn cảnh sông Hàn cũng như các bãi biển Đà Nẵng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('BB702', 'B1001', 'Phong 702', 'Phòng Deluxe có ban công với tầm nhìn toàn cảnh sông Hàn cũng như các bãi biển Đà Nẵng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('BB703', 'B1002', 'Phong 703', 'Phòng Deluxe có ban công với tầm nhìn toàn cảnh sông Hàn cũng như các bãi biển Đà Nẵng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('BB704', 'B1002', 'Phong 704', 'Phòng Deluxe có ban công với tầm nhìn toàn cảnh sông Hàn cũng như các bãi biển Đà Nẵng. Khách cũng có thể sử dụng các dịch vụ tại quầy bar tầng thượng hạng, phòng có trang thiết bị hiện đại với đầy đủ tiện nghi chuẩn khách sạn 5 sao như: internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác.', 0),
('CC601', 'C1001', 'Phong 601', 'Phòng Superior có không gian khiêm tốn nhưng được trang bị với những trang thiết bị hiện đại , tiện nghi chuẩn khách sạn 5 sao như internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác. Khách hàng có cơ hội được thưởng thức toàn cảnh sông Hàn và những bãi biển đẹp.', 0),
('CC602', 'C1001', 'Phong 602', 'Phòng Superior có không gian khiêm tốn nhưng được trang bị với những trang thiết bị hiện đại , tiện nghi chuẩn khách sạn 5 sao như internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác. Khách hàng có cơ hội được thưởng thức toàn cảnh sông Hàn và những bãi biển đẹp.', 0),
('CC603', 'C1002', 'Phong 603', 'Phòng Superior có không gian khiêm tốn nhưng được trang bị với những trang thiết bị hiện đại , tiện nghi chuẩn khách sạn 5 sao như internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác. Khách hàng có cơ hội được thưởng thức toàn cảnh sông Hàn và những bãi biển đẹp.', 0),
('CC604', 'C1002', 'Phong 604', 'Phòng Superior có không gian khiêm tốn nhưng được trang bị với những trang thiết bị hiện đại , tiện nghi chuẩn khách sạn 5 sao như internet miễn phí, TV truyền hình cáp, , quầy bar mini với các loại đồ uống hấp dẫn, phòng tắm rộng rãi với vòi tắm và đầy đủ các tiện nghi khác. Khách hàng có cơ hội được thưởng thức toàn cảnh sông Hàn và những bãi biển đẹp.', 0)

Create table LOAIPHONG(MaLoaiPhong varchar(5) not null primary key, LoaiPhong varchar (30) not null, SoGiuong int not null, GiaPhong int not null )
insert into LOAIPHONG(MaLoaiPhong, LoaiPhong, SoGiuong, GiaPhong)
values('S1001', 'Suite', 1, 900), 
('A1001', 'Executive', 2, 800),
('A1002', 'Executive', 1, 700),
('B1001', 'Deluxe', 2, 600),
('B1002', 'Deluxe', 1, 500),
('C1001', 'Superior', 2, 400),
('C1002', 'Superior', 1, 300)

create table KHACHHANG(MaKhach varchar(5) not null primary key, TenKhachHang nvarchar(100) not null, DiaChi nvarchar(100) not null,
Email varchar(50) not null, SoDienThoai int not null, GioiTinh bit not null)
insert into KHACHHANG(MaKhach, TenKhachhang, DiaChi, Email, SoDienThoai, GioiTinh)
values('10004', 'Tran Hoai Nam', '100 Au Co Da Nang', 'tranhoainam@gmail.com', '0934777143', 1),
('10005', 'Phan Tiep', '54 Phan Lang 9 Da Nang', 'phantiep@gmail.com', '0934938106', 1),
('10006', 'Phan Thi Hien', '495 Au Co Da Nang', 'hienphan@gmail.com', '0934938275', 0),
('10007', 'Pham Long Nhat', '56 Phan Lang 9 Da Nang', 'nhatpham@gmail.com', '0934123456', 1),
('10008', 'Tran Van Phuoc', '56 Ha Huy Tap Da Nang', 'phuocvan@gmail.com', '0934456789', 1),
('10009', 'Tran Van Vinh', '45 Dien Bien Phu Hue', 'vinhtran@gmail.com', '0934987654', 1),
('10010', 'Tran Hoai Viet', '945 Au Co Da Nang', 'hangul309@gmail.com', '0934777106', 1),
('10011', 'Tran Van Tai', '89 Dien Bien Phu Da Nang', 'taivan@gmail.com', '0934569106', 1),
('10012', 'Tran Minh Quan', '90 My An Da Nang', 'vannha@gmail.com', '0787356631', 1),
('10003', 'Nguyen Minh tri', '100 Au Co Da Nang', 'triminh@gmail.com', '0934777143', 1)

create table DONDATPHONG (MaDonDatPhong varchar(10) not null primary key, MaPhong varchar(5) not null, MaKhach varchar(5) not null,
NgayDatPhong date not null, NgayDen date not null, NgayDi date not null, HuyDon bit not null, ThoiGianThue int, TienPhong int, DatCoc int, ConLai int)
insert into DONDATPHONG(MaDonDatPhong, MaPhong, MaKhach, NgayDatPhong, NgayDen, NgayDi, HuyDon)
values('DS00001','SS901','10010', '2021-06-10', '2021-08-30', '2021-09-30',0),
 ('DS00002','SS903','10004', '2020-09-30', '2021-07-30', '2021-08-31',0),
 ('DA00001','AA803','10006', '2020-12-10', '2021-05-10', '2021-05-30',0),
 ('DA00002','AA804','10012', '2020-11-30', '2021-06-30', '2021-07-05',1),
 ('DB00001','BB702','10011', '2020-12-30', '2021-02-15', '2021-03-30',1),
 ('DB00002','BB704','10003', '2020-08-15', '2021-01-30', '2021-03-01',0),
 ('DC00001','CC601','10005', '2020-10-20', '2021-01-01', '2021-01-30',0),
 ('DC00002','CC602','10007', '2020-08-30', '2021-07-31', '2021-09-29',0),
 ('DB00003','BB701','10008', '2020-12-12', '2021-04-20', '2021-05-20',0),
 ('DA00003','AA801','10009', '2020-10-30', '2021-03-30', '2021-04-30',0)

 ALTER TABLE dbo.PHONG 
ADD CONSTRAINT FK_LOAIPHONG1 FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong) ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE dbo.DONDATPHONG 
ADD CONSTRAINT FK_PHONG1 FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE

ALTER TABLE dbo.DONDATPHONG 
ADD CONSTRAINT FK_KHACHHANG1 FOREIGN KEY (MaKhach) REFERENCES dbo.KHACHHANG(MaKhach) ON DELETE CASCADE ON UPDATE CASCADE

--Thoi gian thue--
update DONDATPHONG
set ThoiGianThue = iif(DATEDIFF(day, NgayDi, NgayDen)=0,1,DATEDIFF(day, NgayDen, NgayDi))

--Tien phong--
update DONDATPHONG
set TienPhong = ThoiGianThue * GiaPhong
FROM DONDATPHONG INNER JOIN  PHONG ON 
DONDATPHONG.MaPhong = PHONG.MaPhong 
 INNER JOIN LOAIPHONG ON LOAIPHONG.MaLoaiPhong = PHONG.MaLoaiPhong 
 
 --Tien dat coc--
 update DONDATPHONG
 set DatCoc = TienPhong * 0.3
 
 --Con lai--
 update DONDATPHONG
 set ConLai = TienPhong - DatCoc
 select * from DONDATPHONG