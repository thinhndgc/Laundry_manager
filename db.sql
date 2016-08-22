create database LaundryDB
go

use LaundryDB
go

create table Staff(
StaffID int IDENTITY(1,1),
staffName nvarchar(50),
account nvarchar(20),
[password] nvarchar(20),
constraint pk_staff primary key (StaffID)
)
go

create table Customer(
CID int IDENTITY(1,1),
customerName nvarchar(50),
[address] nvarchar(100),
phoneNumber int,
constraint pk_customer primary key (CID)
)
go

create table Services(
SID int IDENTITY(1,1),
serviceName nvarchar(100),
price int,
constraint pk_services primary key (SID)
)
go


create table Bill(
BID int IDENTITY(1,1),
[SID] int,
STID int,
quantity int,
receiveDate date,
returnDate date,
[status] int,
[description] nvarchar(150),
constraint pk_bill primary key (BID),
constraint fk_bill_to_Service foreign key ([SID]) references Services,
constraint fk_bill_to_Staff foreign key (STID) references Staff
)
go

create table BillToCustomer(
CID int,
BID int,
constraint pk_bill_to_customer primary key (CID,BID),
constraint fk_customer foreign key (CID) references Customer,
constraint fk_bill foreign key (BID) references Bill
)
go