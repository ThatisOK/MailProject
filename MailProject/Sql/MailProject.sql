create database MailProject;
use MailProject;
create table userInfo(
id int AUTO_INCREMENT primary key,
userName varchar(20) not null,
sex char(2) not null,
userPassword varchar(20),
eMail varchar(30) not null
);
show tables;
select * from userInfo;
insert into userInfo(userName,sex,userPassword,eMail) values('张三','男','123456','0000@qq.com');
insert into userInfo(userName,sex,userPassword,eMail) values('李四','男','123456lisi','1111@126.com');
delete from userinfo where id > 4;