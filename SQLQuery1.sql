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
insert into Soaringlist values('�����ǳ�','��Ʒ�','S1.jpg')
insert into Soaringlist values('��������','����','S2.jpg')
insert into Soaringlist values('���������۾�','������','S3.jpg')
insert into Soaringlist values('����֮������������500��','�ϲ���','S4.jpg')
insert into Soaringlist values('�Ҳ�ϲ��������磬��ֻϲ����','��һ','S5.jpg')
insert into Soaringlist values('�������˵ĺ�կͨ��','�ն���������','S6.jpg')
create table Newbook --�����
(
N_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)
create table Totallist --�ܰ�
(
T_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)

create table Updatebook --���°�
(
U_Id int primary key identity,
B_Name varchar(30) not null,--����
A_Name varchar(20) not null,--������
[image] varchar(100), --�鼮ͼƬ
)


