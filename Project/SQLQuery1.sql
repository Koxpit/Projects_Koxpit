CREATE TABLE Пользователь(
Логин NVARCHAR(30) UNIQUE NOT NULL,
Пароль NVARCHAR(30) NOT NULL,
Роль NVARCHAR(15) NOT NULL,
Наименование NVARCHAR(30),
PRIMARY KEY(Логин, Пароль))

CREATE TABLE Заказ(
Номер INT UNIQUE NOT NULL,
Дата DATETIME NOT NULL,
[Этап_выполнения] NVARCHAR(255) CHECK ([Этап_выполнения] IN ('Новый', 'Ожидает', 'Обработка', 'Отклонен', 'К оплате', 'Оплачен', 'Раскрой', 'Производство', 'Готов')) NOT NULL,
Заказчик NVARCHAR(30) FOREIGN KEY REFERENCES Пользователь(Логин),
Менеджер NVARCHAR(30) FOREIGN KEY REFERENCES Пользователь(Логин),
Стоимость DECIMAL NOT NULL,
PRIMARY KEY(Номер, Дата))

CREATE TABLE Изделие(
Артикул NVARCHAR(15) PRIMARY KEY NOT NULL,
Наименование NVARCHAR(30) NOT NULL,
Ширина DECIMAL NOT NULL,
Длина DECIMAL NOT NULL,
Изображение IMAGE,
Комментарий NVARCHAR(50))

CREATE TABLE Заказанные_изделия(
Артикул_изделия NVARCHAR(15) FOREIGN KEY REFERENCES Изделие(Артикул) NOT NULL,
Номер_заказа INT FOREIGN KEY REFERENCES Заказ(Номер) NOT NULL,
Количество INT NOT NULL)

CREATE TABLE Ткань(
Артикул NVARCHAR(15) PRIMARY KEY NOT NULL,
Наименование NVARCHAR(30) NOT NULL,
Рисунок NVARCHAR(20),
Изображение IMAGE,
Состав NVARCHAR(30), 
Ширина DECIMAL NOT NULL,
Длина DECIMAL NOT NULL,
Цена DECIMAL,
Цвет NVARCHAR(15))

CREATE TABLE Фурнитура(
Артикул NVARCHAR(15) PRIMARY KEY NOT NULL,
Наименование NVARCHAR(30) NOT NULL,
Тип NVARCHAR(20) NOT NULL,
Ширина DECIMAL NOT NULL,
Длина DECIMAL,
Вес DECIMAL,
Изображение IMAGE,
Цена DECIMAL NOT NULL)

CREATE TABLE Склад_фурнитуры(
Партия INT PRIMARY KEY NOT NULL,
Артикул_фурнитуры NVARCHAR(15) FOREIGN KEY REFERENCES Фурнитура(Артикул) NOT NULL,
Количество INT NOT NULL)

CREATE TABLE Фурнитура_изделия(
Артикул_фурнитуры NVARCHAR(15) FOREIGN KEY REFERENCES Изделие(Артикул) NOT NULL,
Артикул_изделия NVARCHAR(15) FOREIGN KEY REFERENCES Фурнитура(Артикул) NOT NULL,
Размещение NVARCHAR(30) NOT NULL,
Ширина DECIMAL,
Длина DECIMAL,
Поворот NVARCHAR,
Количество INT NOT NULL)

CREATE TABLE Ткани_изделия(
Артикул_ткани NVARCHAR(15) FOREIGN KEY REFERENCES Ткань(Артикул) NOT NULL, 
Артикул_изделия NVARCHAR(15) FOREIGN KEY REFERENCES Изделие(Артикул) NOT NULL)

CREATE TABLE Склад_ткани(
Рулон CHAR(30) PRIMARY KEY NOT NULL,
Артикул_ткани NVARCHAR(15) FOREIGN KEY REFERENCES Ткань(Артикул) NOT NULL,
Длина DECIMAL NOT NULL)