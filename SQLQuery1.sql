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
go
select * from Soaringlist
go
insert into Soaringlist values('刀与星辰','徐浩峰','S1.jpg')
insert into Soaringlist values('正红旗下','老舍','S2.jpg')
insert into Soaringlist values('带上她的眼睛','刘慈欣','S3.jpg')
insert into Soaringlist values('对立之美·西方艺术500年','严伯钧','S4.jpg')
insert into Soaringlist values('我不喜欢这个世界，我只喜欢你','乔一','S5.jpg')
insert into Soaringlist values('给所有人的黑寨通话','赫尔曼·黑塞','S6.jpg')
<<<<<<< HEAD
go
=======
>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Newbook --新书榜
(
N_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)
<<<<<<< HEAD
insert into Newbook values('刀与星辰1','徐浩峰','S1.jpg')
insert into Newbook values('正红旗下1','老舍','S2.jpg')
insert into Newbook values('带上她的眼睛1','刘慈欣','S3.jpg')
insert into Newbook values('对立之美·西方艺术500年1','严伯钧','S4.jpg')
insert into Newbook values('我不喜欢这个世界，我只喜欢你1','乔一','S5.jpg')
insert into Newbook values('给所有人的黑寨通话1','赫尔曼·黑塞','S6.jpg')
go
=======
>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Totallist --总榜
(
T_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)
<<<<<<< HEAD
insert into Totallist values('刀与星辰2','徐浩峰','S1.jpg')
insert into Totallist values('正红旗下2','老舍','S2.jpg')
insert into Totallist values('带上她的眼睛2','刘慈欣','S3.jpg')
insert into Totallist values('对立之美·西方艺术500年2','严伯钧','S4.jpg')
insert into Totallist values('我不喜欢这个世界，我只喜欢你2','乔一','S5.jpg')
insert into Totallist values('给所有人的黑寨通话2','赫尔曼·黑塞','S6.jpg')
go
=======

>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Updatebook --更新榜
(
U_Id int primary key identity,
B_Name varchar(30) not null,--书名
A_Name varchar(20) not null,--作者名
[image] varchar(100), --书籍图片
)
<<<<<<< HEAD
insert into Updatebook values('刀与星辰3','徐浩峰','S1.jpg')
insert into Updatebook values('正红旗下3','老舍','S2.jpg')
insert into Updatebook values('带上她的眼睛3','刘慈欣','S3.jpg')
insert into Updatebook values('对立之美·西方艺术500年3','严伯钧','S4.jpg')
insert into Updatebook values('我不喜欢这个世界，我只喜欢你3','乔一','S5.jpg')
insert into Updatebook values('给所有人的黑寨通话3','赫尔曼·黑塞','S6.jpg')

select * from Soaringlist
select * from Newbook
select * from Totallist
select * from Updatebook
=======


>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
