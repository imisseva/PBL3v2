USE BusManagement
INSERT INTO Account (username, password, role)
VALUES 
(N'admin', N'123456', 1);


INSERT INTO account (username, password, role)
VALUES 
(N'ST0001', N'12345678', 0),
(N'ST0002', N'12345678', 0);

DELETE FROM Account WHERE username = 'ST0003';

DELETE FROM Staff;

SELECT * FROM Staff; 
SELECT * FROM account;

INSERT INTO account (username, password, role)
VALUES
(N'ST0003', N'12345678', 0);

INSERT INTO Staff (ID_account, Name, Gender, DOB, NoiSinh, email, home_address, CCCD, phone) VALUES
(2, N'Nguyễn Phương Anh', N'Nữ', '2005-11-21', N'Vũng Tàu', N'ngphganh@gmail.com',  N'15 Nguyễn Thiện Thuật, p9, Vũng Tàu',  N'870169538269',  N'0909161837'),
(3, N'Hoàng Minh Ðức' ,N'Nam', '2005-08-15', N'Vũng Tàu', N'hminhduc@gmail.com', N'19 Ðinh Tiên Hoàng, p1, Vũng Tàu', N'0890759605', N'587617300341'),
(7, N'Hoàng Ðại Hiếu', N'Nam', '2005-12-05', N'Vũng Tàu', N'hdaihieu@gmail.com', N'888 ,đường 30/4, phuờng 12, Vũng Tàu', N'0976021762',  N'357016289339');


INSERT INTO Bus (ID_bus, Quantity, Status) VALUES 
(N'B1', 34, 1),
(N'B2', 34, 1),
(N'B3', 22, 1),
(N'B4', 22, 1);

INSERT INTO SEAT(ID_seat, ID_bus, seat_number, type) VALUES
-- B1: 35 giường nằm
(N'S001', N'B1', 1, N'giường nằm'), (N'S002', N'B1', 2, N'giường nằm'), (N'S003', N'B1', 3, N'giường nằm'),
(N'S004', N'B1', 4, N'giường nằm'), (N'S005', N'B1', 5, N'giường nằm'), (N'S006', N'B1', 6, N'giường nằm'),
(N'S007', N'B1', 7, N'giường nằm'), (N'S008', N'B1', 8, N'giường nằm'), (N'S009', N'B1', 9, N'giường nằm'),
(N'S010', N'B1', 10, N'giường nằm'), (N'S011', N'B1', 11, N'giường nằm'), (N'S012', N'B1', 12, N'giường nằm'),
(N'S013', N'B1', 13, N'giường nằm'), (N'S014', N'B1', 14, N'giường nằm'), (N'S015', N'B1', 15, N'giường nằm'),
(N'S016', N'B1', 16, N'giường nằm'), (N'S017', N'B1', 17, N'giường nằm'), (N'S018', N'B1', 18, N'giường nằm'),
(N'S019', N'B1', 19, N'giường nằm'), (N'S020', N'B1', 20, N'giường nằm'), (N'S021', N'B1', 21, N'giường nằm'),
(N'S022', N'B1', 22, N'giường nằm'), (N'S023', N'B1', 23, N'giường nằm'), (N'S024', N'B1', 24, N'giường nằm'),
(N'S025', N'B1', 25, N'giường nằm'), (N'S026', N'B1', 26, N'giường nằm'), (N'S027', N'B1', 27, N'giường nằm'),
(N'S028', N'B1', 28, N'giường nằm'), (N'S029', N'B1', 29, N'giường nằm'), (N'S030', N'B1', 30, N'giường nằm'),
(N'S031', N'B1', 31, N'giường nằm'), (N'S032', N'B1', 32, N'giường nằm'), (N'S033', N'B1', 33, N'giường nằm'),
(N'S034', N'B1', 34, N'giường nằm'), 

-- B2: 35 giường nằm
(N'S036', N'B2', 1, N'giường nằm'), (N'S037', N'B2', 2, N'giường nằm'), (N'S038', N'B2', 3, N'giường nằm'),
(N'S039', N'B2', 4, N'giường nằm'), (N'S040', N'B2', 5, N'giường nằm'), (N'S041', N'B2', 6, N'giường nằm'),
(N'S042', N'B2', 7, N'giường nằm'), (N'S043', N'B2', 8, N'giường nằm'), (N'S044', N'B2', 9, N'giường nằm'),
(N'S045', N'B2', 10, N'giường nằm'), (N'S046', N'B2', 11, N'giường nằm'), (N'S047', N'B2', 12, N'giường nằm'),
(N'S048', N'B2', 13, N'giường nằm'), (N'S049', N'B2', 14, N'giường nằm'), (N'S050', N'B2', 15, N'giường nằm'),
(N'S051', N'B2', 16, N'giường nằm'), (N'S052', N'B2', 17, N'giường nằm'), (N'S053', N'B2', 18, N'giường nằm'),
(N'S054', N'B2', 19, N'giường nằm'), (N'S055', N'B2', 20, N'giường nằm'), (N'S056', N'B2', 21, N'giường nằm'),
(N'S057', N'B2', 22, N'giường nằm'), (N'S058', N'B2', 23, N'giường nằm'), (N'S059', N'B2', 24, N'giường nằm'),
(N'S060', N'B2', 25, N'giường nằm'), (N'S061', N'B2', 26, N'giường nằm'), (N'S062', N'B2', 27, N'giường nằm'),
(N'S063', N'B2', 28, N'giường nằm'), (N'S064', N'B2', 29, N'giường nằm'), (N'S065', N'B2', 30, N'giường nằm'),
(N'S066', N'B2', 31, N'giường nằm'), (N'S067', N'B2', 32, N'giường nằm'), (N'S068', N'B2', 33, N'giường nằm'),
(N'S069', N'B2', 34, N'giường nằm'), 

-- B3: 22 giường đôi
(N'S071', N'B3', 1, N'giường đôi'), (N'S072', N'B3', 2, N'giường đôi'), (N'S073', N'B3', 3, N'giường đôi'),
(N'S074', N'B3', 4, N'giường đôi'), (N'S075', N'B3', 5, N'giường đôi'), (N'S076', N'B3', 6, N'giường đôi'),
(N'S077', N'B3', 7, N'giường đôi'), (N'S078', N'B3', 8, N'giường đôi'), (N'S079', N'B3', 9, N'giường đôi'),
(N'S080', N'B3', 10, N'giường đôi'), (N'S081', N'B3', 11, N'giường đôi'), (N'S082', N'B3', 12, N'giường đôi'),
(N'S083', N'B3', 13, N'giường đôi'), (N'S084', N'B3', 14, N'giường đôi'), (N'S085', N'B3', 15, N'giường đôi'),
(N'S086', N'B3', 16, N'giường đôi'), (N'S087', N'B3', 17, N'giường đôi'), (N'S088', N'B3', 18, N'giường đôi'),
(N'S089', N'B3', 19, N'giường đôi'), (N'S090', N'B3', 20, N'giường đôi'), (N'S091', N'B3', 21, N'giường đôi'),
(N'S092', N'B3', 22, N'giường đôi'),

-- B4: 22 giường đôi
(N'S093', N'B4', 1, N'giường đôi'), (N'S094', N'B4', 2, N'giường đôi'), (N'S095', N'B4', 3, N'giường đôi'),
(N'S096', N'B4', 4, N'giường đôi'), (N'S097', N'B4', 5, N'giường đôi'), (N'S098', N'B4', 6, N'giường đôi'),
(N'S099', N'B4', 7, N'giường đôi'), (N'S100', N'B4', 8, N'giường đôi'), (N'S101', N'B4', 9, N'giường đôi'),
(N'S102', N'B4', 10, N'giường đôi'), (N'S103', N'B4', 11, N'giường đôi'), (N'S104', N'B4', 12, N'giường đôi'),
(N'S105', N'B4', 13, N'giường đôi'), (N'S106', N'B4', 14, N'giường đôi'), (N'S107', N'B4', 15, N'giường đôi'),
(N'S108', N'B4', 16, N'giường đôi'), (N'S109', N'B4', 17, N'giường đôi'), (N'S110', N'B4', 18, N'giường đôi'),
(N'S111', N'B4', 19, N'giường đôi'), (N'S112', N'B4', 20, N'giường đôi'), (N'S113', N'B4', 21, N'giường đôi'),
(N'S114', N'B4', 22, N'giường đôi');

INSERT INTO Station (ID_station, Name_station, location)
VALUES
(1, N'Bến xe nước ngầm', N'Số 1 Ngọc Hồi, Hoàng Liệt, Hoàng Mai, Tp. Hà Nội'),
(2, N'Trạm Thu Phí Cầu Bến Thuỷ 2',N'QL1A, Hưng Nguyên,TP. Nghệ An'),
(3, N'Ngã ba bến xe Hà Tĩnh', N'13 Võ Liêm Sơn, Bắc Hà, Tp. Hà Tĩnh'),
(4, N'Quầy 22A Bến xe Đà Nẵng', N'75 Thanh Tịnh, Quận Liên Chiểu, TP. Đà Nẵng'),
(5, N'Bến xe Quy Nhơn', N'Đường Võ Liệu - Cửa Hàng Xăng Dầu Phương Linh 3,TP. Quy Nhơn'),
(6, N'Văn phòng Đà Lạt', N'94 Mai Anh Đào, Phường 8, TP. Đà Lạt');

INSERT INTO Bus_Location_History 
( ID_bus, ID_Station, arrive_time)
VALUES 
( N'B1', N'1', '2025-05-12 00:00:00'),
( N'B2', N'4', '2025-05-12 00:00:00'),
( N'B3', N'4', '2025-05-12 00:00:00'),
( N'B4', N'6', '2025-05-12 00:00:00');

INSERT INTO Route(ID_route,ID_Station_start,ID_Station_end,distance,time)
VALUES
(N'HN_DN',N'1',N'4',770,'12:50'),
(N'HN_NA',N'1',N'2',280,'04:40'),
(N'HN_HT',N'1',N'3',358,'06:00'),
(N'DN_HT',N'4',N'3',412,'07:00'),
(N'DN_NA',N'4',N'2',490,'08:20'),
(N'DN_HN',N'4',N'1',770,'12:50'),
(N'DN_DL',N'4',N'6',680,'11:30'),
(N'DN_QN',N'4',N'5',330,'05:30'),
(N'DL_QN',N'6',N'5',350,'06:00'),
(N'DL_DN',N'6',N'4',680,'11:30');

INSERT INTO Route_SubRoute(ID_route_parent,ID_route_child,StopOrder)
VALUES
(N'HN_DN',N'HN_NA',1),
(N'HN_DN',N'HN_HT',2),
(N'DN_HN',N'DN_HT',1),
(N'DN_HN',N'DN_NA',2),
(N'DN_DL',N'DN_QN',1),
(N'DL_DN',N'DL_QN',1);

SELECT COUNT(*) FROM Staff;

INSERT INTO Staff (ID_account, Name, Gender, DOB, NoiSinh, email, home_address, CCCD, phone) VALUES
(2, N'Nguyễn Phương Anh', N'Nữ', '2005-11-21', N'Vũng Tàu', N'ngphganh@gmail.com',  N'15 Nguyễn Thiện Thuật, p9, Vũng Tàu',  N'870169538269',  N'0909161837'),
(3, N'Hoàng Minh Ðức' ,N'Nam', '2005-08-15', N'Vũng Tàu', N'hminhduc@gmail.com', N'19 Ðinh Tiên Hoàng, p1, Vũng Tàu', N'0890759605', N'587617300341'),
(8, N'Hoàng Ðại Hiếu', N'Nam', '2005-12-05', N'Vũng Tàu', N'hdaihieu@gmail.com', N'888 ,đường 30/4, phuờng 12, Vũng Tàu', N'0976021762',  N'357016289339');