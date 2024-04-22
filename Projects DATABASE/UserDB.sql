create database UserDB
use UserDB
create table Users (
			UserId int primary key identity(1,1),
			UserName varchar(100) not null,
			UserAge int not null
		);

select * from Users

-- add column
alter table Users
add UserDob date not null

-- add constraint
alter table Users
add UNIQUE (UserDob)


-- rename column
exec sp_rename 'Users.UserAge', 'User_Age', 'column'

-- alter colum datatype
alter table Users
alter column User_Age bigint

-- delete colum
alter table Users
drop column UserName

-- 
select * from Users

drop table Users

insert into Users (UserName,UserAge,UserDob) values ('John',30,'2014-05-2');

update Users
set UserName = 'Smith'
where UserId = 2

delete from Users
where UserId = 2

truncate table Users


