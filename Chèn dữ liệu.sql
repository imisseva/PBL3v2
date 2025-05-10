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