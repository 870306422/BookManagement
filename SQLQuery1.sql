create database BookManagementDB
GO
use BookManagementDB
go
create table Soaringlist --飙升榜
(
S_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)
insert into Soaringlist values('刀与星辰','徐浩峰','S1.jpg')
insert into Soaringlist values('正红旗下','老舍','S2.jpg')
insert into Soaringlist values('带上她的眼睛','刘慈欣','S3.jpg')
insert into Soaringlist values('对立之美·西方艺术500年','严伯钧','S4.jpg')
insert into Soaringlist values('我不喜欢这个世界，我只喜欢你','乔一','S5.jpg')
insert into Soaringlist values('给所有人的黑寨通话','赫尔曼·黑塞','S6.jpg')
create table Newbook --新书榜
(
N_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)
create table Totallist --总榜
(
T_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)

create table Updatebook --更新榜
(
U_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)


