create database ManageCoffeeShop
go

use ManageCoffeeShop
go

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo
-- 

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'chua dat ten',
	status nvarchar(100) not null default N'Blank'-- Blank || ! Blank
)
go

create table Account
(
	userName nvarchar(100) primary key,
	displayName nvarchar(100) not null default N'admin_kali',
	password nvarchar(1000) not null default 0,
	type int not null default 0 -- 1: admin , 0: staff
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'chua dat ten',
)
go

create table Food 
(
	id int identity primary key,
	name nvarchar(100) not null default N'chua dat ten',
	idCategory int not null,
	price float not null default 0,

	foreign key (idCategory) references  dbo.FoodCategory(id)
)

create table Bill
(
	id int identity primary key,
	dateCheckIn date not null default getdate(),
	dateCheckOut date,
	idTable int not null,
	status int not null -- 1 = paied, 0 = not yet pay

	foreign key (idTable) references dbo.TableFood(id)
)
go

create table BillInfo 
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go