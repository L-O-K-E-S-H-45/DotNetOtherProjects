create database StudentDB
use StudentDB
create table Students ( student_id int primary key identity(1,1),
						student_name varchar(50) not null,
						student_age int not null
					   )
select * from Students

insert into Students(student_name, student_age) values ('Jhon',21)

select * from Students

update Students
set student_age=30
where student_id=3

delete from Students
where student_name = 'Jhon'



