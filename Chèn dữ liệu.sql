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
(2, N'Nguy?n Phuong Anh', N'N?', '2005-11-21', N'Vung T�u', N'ngphganh@gmail.com',  N'15 Nguy?n Thi?n Thu?t, p9, Vung T�u',  N'870169538269',  N'0909161837'),
(3, N'Ho�ng Minh �?c' ,N'Nam', '2005-08-15', N'Vung T�u', N'hminhduc@gmail.com', N'19 �inh Ti�n Ho�ng, p1, Vung T�u', N'0890759605', N'587617300341'),
(7, N'Ho�ng �?i Hi?u', N'Nam', '2005-12-05', N'Vung T�u', N'hdaihieu@gmail.com', N'888 , du?ng 30/4, phu?ng 12, Vung T�u', N'0976021762',  N'357016289339');