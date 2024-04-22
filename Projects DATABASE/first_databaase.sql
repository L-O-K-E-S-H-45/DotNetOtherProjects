create database frst_database
use frst_database   -- select specified database
use master
alter database [frst_database] modify name = [first_database]  -- rename database
drop database [first_database] -- delete database

backup database first_database to disk = 'F:\DotNet\DotNetProjects\Projects DATABASE\bk1.sql' --  to backup database

create table First_Table (
		col1 int primary key,
		col2 varchar(255) not null,
		col3 BIGINT check (col3 >=6000000000 and col3<=9999999999)
		);
--drop table First_Table
select * from First_Table
insert into First_Table values (4,'abc',9345678514);

alter table First_Table
add col4 date
insert into First_Table values (7,'abc',9345678514,'2024-8-3');

