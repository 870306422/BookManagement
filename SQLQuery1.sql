create database BookManagementDB
GO
use BookManagementDB
go
create table Soaringlist --�����
(
S_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)
go
select * from Soaringlist
go
insert into Soaringlist values('�����ǳ�','��Ʒ�','S1.jpg')
insert into Soaringlist values('��������','����','S2.jpg')
insert into Soaringlist values('���������۾�','������','S3.jpg')
insert into Soaringlist values('����֮������������500��','�ϲ���','S4.jpg')
insert into Soaringlist values('�Ҳ�ϲ��������磬��ֻϲ����','��һ','S5.jpg')
insert into Soaringlist values('�������˵ĺ�կͨ��','�ն���������','S6.jpg')
<<<<<<< HEAD
go
=======
>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Newbook --�����
(
N_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)
<<<<<<< HEAD
insert into Newbook values('�����ǳ�1','��Ʒ�','S1.jpg')
insert into Newbook values('��������1','����','S2.jpg')
insert into Newbook values('���������۾�1','������','S3.jpg')
insert into Newbook values('����֮������������500��1','�ϲ���','S4.jpg')
insert into Newbook values('�Ҳ�ϲ��������磬��ֻϲ����1','��һ','S5.jpg')
insert into Newbook values('�������˵ĺ�կͨ��1','�ն���������','S6.jpg')
go
=======
>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Totallist --�ܰ�
(
T_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)
<<<<<<< HEAD
insert into Totallist values('�����ǳ�2','��Ʒ�','S1.jpg')
insert into Totallist values('��������2','����','S2.jpg')
insert into Totallist values('���������۾�2','������','S3.jpg')
insert into Totallist values('����֮������������500��2','�ϲ���','S4.jpg')
insert into Totallist values('�Ҳ�ϲ��������磬��ֻϲ����2','��һ','S5.jpg')
insert into Totallist values('�������˵ĺ�կͨ��2','�ն���������','S6.jpg')
go
=======

>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
create table Updatebook --���°�
(
U_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)
<<<<<<< HEAD
insert into Updatebook values('�����ǳ�3','��Ʒ�','S1.jpg')
insert into Updatebook values('��������3','����','S2.jpg')
insert into Updatebook values('���������۾�3','������','S3.jpg')
insert into Updatebook values('����֮������������500��3','�ϲ���','S4.jpg')
insert into Updatebook values('�Ҳ�ϲ��������磬��ֻϲ����3','��һ','S5.jpg')
insert into Updatebook values('�������˵ĺ�կͨ��3','�ն���������','S6.jpg')

select * from Soaringlist
select * from Newbook
select * from Totallist
select * from Updatebook
=======


>>>>>>> fc0b02548aa1592a219667e8030bbead58c4f3e1
