CREATE DATABASE QLdiem;
USE QLdiem;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1, 1),
    Role BIT,
    Username VARCHAR(20) NOT NULL,
    Password VARCHAR(20) NOT NULL
);

CREATE TABLE SINHVIEN (
    MaSV VARCHAR(20) PRIMARY KEY,
    TenSV VARCHAR(50),
    GioiTinh VARCHAR(50),
    SDT VARCHAR(15),
    Diem DECIMAL(10, 2)
);

CREATE TABLE MONHOC (
    MaMH INT PRIMARY KEY IDENTITY(1, 1),
    TenMH VARCHAR(50),
    SoTC INT,
    MaTa VARCHAR(50)
);

CREATE TABLE DIEMHP (
    MaMH INT IDENTITY(1,1),FOREIGN KEY (MaMH) REFERENCES MONHOC(MaMH),
    MaSV VARCHAR(20),
    HocKy VARCHAR(10),
    NamHoc VARCHAR(10),
    Diem DECIMAL(10, 2),
    Xeploai VARCHAR(15),
    PRIMARY KEY (MaSV, MaMH, HocKy, NamHoc),
    FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
    FOREIGN KEY (MaMH) REFERENCES MONHOC(MaMH)
);
INSERT INTO Users(Role, Username, Password) 
VALUES (0, 'admin', '123'),
       (1, 'user', '123');

-- Thêm dữ liệu vào bảng SINHVIEN
INSERT INTO SINHVIEN (MaSV, TenSV, GioiTinh, SDT, Diem) 
VALUES ('BH01125', 'Nguyen Van Long', 'Nam', '0123456789', 9),
       ('BH01126', 'Nguyen Thi Lien', 'Nu', '0987654321', 7),
       ('BH01127', 'Tran Van Cao', 'Nam', '0365478912', 5),
	   ('BH01128', 'Nguyen Van Kien', 'LGPT', '0123456789', 9.5),
       ('BH01129', 'Nguyen Thi Phi', 'Nu', '0987654321', 8),
       ('BH01130', 'Tran Van Nhat', 'LGPT', '0365478912', 5);

-- Thêm dữ liệu vào bảng MONHOC
INSERT INTO MONHOC (TenMH, SoTC, MaTa) 
VALUES ('Toan', 15, 'GV100'),
       ('Van', 20, 'GV101'),
       ('Anh', 20, 'GV102'),
	   ('Toan1', 15, 'GV100'),
       ('Van1', 20, 'GV101'),
       ('Anh1', 20, 'GV102'),
	   ('Toan2', 15, 'GV100'),
       ('Van2', 20, 'GV101'),
       ('Anh2', 20, 'GV102');

-- Thêm dữ liệu vào bảng DIEMHP
INSERT INTO DIEMHP (MaSV, HocKy, NamHoc, Diem, Xeploai) 
VALUES ('BH01125', 'HK1', '2023-2024', 9, 'Gioi'),
       ('BH01126', 'HK1', '2023-2024', 7, 'Kha'),
       ('BH01127', 'HK1', '2023-2024', 5, 'Trung binh');
       
     


