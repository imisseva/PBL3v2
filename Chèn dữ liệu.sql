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
(2, N'Nguy?n Phuong Anh', N'N?', '2005-11-21', N'Vung Tàu', N'ngphganh@gmail.com',  N'15 Nguy?n Thi?n Thu?t, p9, Vung Tàu',  N'870169538269',  N'0909161837'),
(3, N'Hoàng Minh Ð?c' ,N'Nam', '2005-08-15', N'Vung Tàu', N'hminhduc@gmail.com', N'19 Ðinh Tiên Hoàng, p1, Vung Tàu', N'0890759605', N'587617300341'),
(7, N'Hoàng Ð?i Hi?u', N'Nam', '2005-12-05', N'Vung Tàu', N'hdaihieu@gmail.com', N'888 , du?ng 30/4, phu?ng 12, Vung Tàu', N'0976021762',  N'357016289339');