CREATE TABLE ������������(
����� NVARCHAR(30) UNIQUE NOT NULL,
������ NVARCHAR(30) NOT NULL,
���� NVARCHAR(15) NOT NULL,
������������ NVARCHAR(30),
PRIMARY KEY(�����, ������))

CREATE TABLE �����(
����� INT UNIQUE NOT NULL,
���� DATETIME NOT NULL,
[����_����������] NVARCHAR(255) CHECK ([����_����������] IN ('�����', '�������', '���������', '��������', '� ������', '�������', '�������', '������������', '�����')) NOT NULL,
�������� NVARCHAR(30) FOREIGN KEY REFERENCES ������������(�����),
�������� NVARCHAR(30) FOREIGN KEY REFERENCES ������������(�����),
��������� DECIMAL NOT NULL,
PRIMARY KEY(�����, ����))

CREATE TABLE �������(
������� NVARCHAR(15) PRIMARY KEY NOT NULL,
������������ NVARCHAR(30) NOT NULL,
������ DECIMAL NOT NULL,
����� DECIMAL NOT NULL,
����������� IMAGE,
����������� NVARCHAR(50))

CREATE TABLE ����������_�������(
�������_������� NVARCHAR(15) FOREIGN KEY REFERENCES �������(�������) NOT NULL,
�����_������ INT FOREIGN KEY REFERENCES �����(�����) NOT NULL,
���������� INT NOT NULL)

CREATE TABLE �����(
������� NVARCHAR(15) PRIMARY KEY NOT NULL,
������������ NVARCHAR(30) NOT NULL,
������� NVARCHAR(20),
����������� IMAGE,
������ NVARCHAR(30), 
������ DECIMAL NOT NULL,
����� DECIMAL NOT NULL,
���� DECIMAL,
���� NVARCHAR(15))

CREATE TABLE ���������(
������� NVARCHAR(15) PRIMARY KEY NOT NULL,
������������ NVARCHAR(30) NOT NULL,
��� NVARCHAR(20) NOT NULL,
������ DECIMAL NOT NULL,
����� DECIMAL,
��� DECIMAL,
����������� IMAGE,
���� DECIMAL NOT NULL)

CREATE TABLE �����_���������(
������ INT PRIMARY KEY NOT NULL,
�������_��������� NVARCHAR(15) FOREIGN KEY REFERENCES ���������(�������) NOT NULL,
���������� INT NOT NULL)

CREATE TABLE ���������_�������(
�������_��������� NVARCHAR(15) FOREIGN KEY REFERENCES �������(�������) NOT NULL,
�������_������� NVARCHAR(15) FOREIGN KEY REFERENCES ���������(�������) NOT NULL,
���������� NVARCHAR(30) NOT NULL,
������ DECIMAL,
����� DECIMAL,
������� NVARCHAR,
���������� INT NOT NULL)

CREATE TABLE �����_�������(
�������_����� NVARCHAR(15) FOREIGN KEY REFERENCES �����(�������) NOT NULL, 
�������_������� NVARCHAR(15) FOREIGN KEY REFERENCES �������(�������) NOT NULL)

CREATE TABLE �����_�����(
����� CHAR(30) PRIMARY KEY NOT NULL,
�������_����� NVARCHAR(15) FOREIGN KEY REFERENCES �����(�������) NOT NULL,
����� DECIMAL NOT NULL)